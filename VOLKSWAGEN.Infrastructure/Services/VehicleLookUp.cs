using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Microsoft.Extensions.Options;
using VOLKSWAGEN.Core.Entities;
using VOLKSWAGEN.Core.Interfaces;

namespace VOLKSWAGEN.Infrastructure.Services
{
    public class VehicleLookUp : IVehicleLookUp
    {
        private readonly IJsonDeserializer _jsonDeserializer;
        private readonly ConfigSettings _settings;
        private readonly HttpClient _client;

        public VehicleLookUp(
            HttpClient client,
            IJsonDeserializer jsonDeserializer,
            IOptions<ConfigSettings> settings
            )
        {
            _client = client;
            _jsonDeserializer = jsonDeserializer;
            _settings = settings.Value;
            ConfigureHttpClient(_client);
        }

        public async Task<VehicleData> GetVehicleDataAsync(string vehicleLicense)
        {
            using (var vehicleDataLookUp = await _client.GetAsync(String.Format(_settings.FullUrl, _settings.Apikey, vehicleLicense)))
            {

                return (vehicleDataLookUp.IsSuccessStatusCode) ?
                    _jsonDeserializer.Deserialize<VehicleData>(await vehicleDataLookUp.Content.ReadAsStringAsync()) : null;
            }

        }

        #region Private Methods

        private void ConfigureHttpClient(HttpClient client)
        {
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
