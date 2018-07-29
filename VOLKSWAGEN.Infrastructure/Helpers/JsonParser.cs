using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json.Linq;
using VOLKSWAGEN.Core.Interfaces;

namespace VOLKSWAGEN.Infrastructure.Helpers
{
    public class JsonParser : IJsonParser<JObject>
    {
        public JObject Parse(string data)
        {
            return JObject.Parse(data);
        }
    }
}
