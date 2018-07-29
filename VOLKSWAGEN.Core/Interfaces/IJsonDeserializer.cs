using System;
using System.Collections.Generic;
using System.Text;

namespace VOLKSWAGEN.Core.Interfaces
{
    public interface IJsonDeserializer
    {
        T Deserialize<T, T2>(T2 data) where T : class where T2 : class;
    }
}
