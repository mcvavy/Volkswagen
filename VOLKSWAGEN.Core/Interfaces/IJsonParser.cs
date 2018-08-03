using System;
using System.Collections.Generic;
using System.Text;

namespace VOLKSWAGEN.Core.Interfaces
{
    public interface IJsonParser<T> where T : new()
    {
        T Parse(string data) ;
    }
}
