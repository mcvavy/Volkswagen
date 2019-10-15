using Newtonsoft.Json;
using VOLKSWAGEN.Core.Interfaces;

namespace VOLKSWAGEN.Infrastructure.Helpers
{
    public class JsonDeserializer : IJsonDeserializer
    {
        public T Deserialize<T>(string data) where T : class
        {
            return JsonConvert.DeserializeObject<T>(data);
        }
    }
}
