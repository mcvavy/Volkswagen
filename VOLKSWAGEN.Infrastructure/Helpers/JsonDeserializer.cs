using Newtonsoft.Json;
using VOLKSWAGEN.Core.Interfaces;

namespace VOLKSWAGEN.Infrastructure.Helpers
{
    public class JsonDeserializer : IJsonDeserializer
    {
        public T Deserialize<T, T2>(T2 data) 
            where T : class 
            where T2 : class
        {
            return JsonConvert.DeserializeObject<T>(data.ToString());
        }
    }
}
