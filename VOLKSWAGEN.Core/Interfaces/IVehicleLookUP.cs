using System.Threading.Tasks;
using VOLKSWAGEN.Core.Entities;

namespace VOLKSWAGEN.Core.Interfaces
{
    public interface IVehicleLookUp
    {
        Task<IVehicleRegistration> GetVehicleDataAsync(string vehicleLicense);
    }
}
