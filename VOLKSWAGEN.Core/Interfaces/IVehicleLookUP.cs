using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using VOLKSWAGEN.Core.Entities;

namespace VOLKSWAGEN.Core.Interfaces
{
    public interface IVehicleLookUp<T> where T : new()
    {
        Task<VehicleRegistration> GetVehicleData(string vehicleLicense);
    }
}
