using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using VOLKSWAGEN.Core.Entities;

namespace VOLKSWAGEN.Core.Interfaces
{
    public interface IVehicleLookUp
    {
        Task<VehicleRegistration> GetVehicleData(string vehicleLicense, ConfigSettings settings, ResponseConfig responseConfig);
    }
}
