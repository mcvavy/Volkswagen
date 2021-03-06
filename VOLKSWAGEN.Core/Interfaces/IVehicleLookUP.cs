﻿using System.Threading.Tasks;
using VOLKSWAGEN.Core.Entities;

namespace VOLKSWAGEN.Core.Interfaces
{
    public interface IVehicleLookUp
    {
        Task<VehicleData> GetVehicleDataAsync(string vehicleLicense);
    }
}
