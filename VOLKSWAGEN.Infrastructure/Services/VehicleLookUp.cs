using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Microsoft.Extensions.Options;
using Newtonsoft.Json.Linq;
using VOLKSWAGEN.Core.Entities;
using VOLKSWAGEN.Core.Interfaces;

namespace VOLKSWAGEN.Infrastructure.Services
{
    public class VehicleLookUp : IVehicleLookUp
    {
        private VehicleRegistration _vehicleRegistration;
        private readonly IJsonParser<JObject> _jsonParser;
        private readonly IJsonDeserializer _jsonDeserializer;
        private readonly ConfigSettings _settings;
        private readonly ResponseConfig _responseConfig;
        private readonly HttpClient _client;

        public VehicleLookUp(
            HttpClient client, 
            VehicleRegistration vehicleRegistration,
            IJsonParser<JObject> jsonParser,
            IJsonDeserializer jsonDeserializer,
            IOptions<ConfigSettings> settings,
            IOptions<ResponseConfig> responseConfig
            )
        {
            _client = client;
            _vehicleRegistration = vehicleRegistration;
            _jsonParser = jsonParser;
            _jsonDeserializer = jsonDeserializer;
            _settings = settings.Value;
            _responseConfig = responseConfig.Value;

            ConfigureHttpClient(_client);
        }

        public async Task<VehicleRegistration> GetVehicleData(string vehicleLicense)
        {
            var lookupUrl = new Uri(_client.BaseAddress, String.Format(_settings.QueryUrl, _settings.Apikey, vehicleLicense));


            try
            {

                var vehicleDataLookUp = await _client.GetAsync(lookupUrl);

                if (vehicleDataLookUp.IsSuccessStatusCode)
                {
                    var vehicleLookupResponseString = await vehicleDataLookUp.Content.ReadAsStringAsync();

                    var vehicleDataJsonData = _jsonParser.Parse(vehicleLookupResponseString);

                    var lookupStatus = vehicleDataJsonData[_responseConfig.Response];

                    _vehicleRegistration.Response = _jsonDeserializer.Deserialize<LookupResponse, JToken>(lookupStatus);

                    if (_vehicleRegistration.Response.StatusCode == _responseConfig.Success)
                    {
                        var vehicleRegistrationExtract = vehicleDataJsonData[_responseConfig.Response][_responseConfig.DataItems][
                            _responseConfig.VehicleRegistration];

                        return _jsonDeserializer.Deserialize<VehicleRegistration, JToken>(vehicleRegistrationExtract);
                    }
                }

            }
            catch (Exception ex)
            {
                var errorMsg = ex.InnerException.Message;
            }

            return _vehicleRegistration;

        }

        #region HttpClient Configuration

        private void ConfigureHttpClient(HttpClient client)
        {
            client.BaseAddress = new Uri(_settings.BaseUrl);
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            client.DefaultRequestHeaders.TryAddWithoutValidation("Accept", "text/html,application/xhtml+xml,application/xml");
            client.DefaultRequestHeaders.TryAddWithoutValidation("User-Agent",
                "Mozilla/5.0 (Windows NT 6.2; WOW64; rv:19.0) Gecko/20100101 Firefox/19.0");
            client.DefaultRequestHeaders.TryAddWithoutValidation("Accept-Charset", "ISO-8859-1");
        }

        #endregion
    }
}
