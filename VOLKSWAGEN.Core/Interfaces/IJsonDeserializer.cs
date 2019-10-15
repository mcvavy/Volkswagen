using System;
using System.Collections.Generic;
using System.Text;

namespace VOLKSWAGEN.Core.Interfaces
{
    public interface IJsonDeserializer
    {
        T Deserialize<T>(string data) where T : class;
    }
}
