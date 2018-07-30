using System;
using VOLKSWAGEN.Core.Entities;

namespace VOLKSWAGEN.Core.DTOs
{
    public class VehicleRegistrationDto
    {
        public string FuelType { get; set; }
        public string MakeModel { get; set; }
        public string Model { get; set; }
        public string Transmission { get; set; }
        public string Colour { get; set; }
        public DateTime? DateFirstRegistered { get; set; } = null;
        public string VehicleClass { get; set; }
        public string TransmissionType { get; set; }
        public string Make { get; set; }
        public string Vrm { get; set; }
        public DateTime? DateFirstRegisteredUk { get; set; } = null;
        public double Co2Emissions { get; set; }
        public string EngineCapacity { get; set; }
        public string YearOfManufacture { get; set; }
        public LookupResponse Response { get; set; }
    }
}
