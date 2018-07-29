using System;
using System.Collections.Generic;
using System.Text;

namespace VOLKSWAGEN.Core.Entities
{
    public class VehicleRegistration
    {
        public string FuelType { get; set; }
        public bool Scrapped { get; set; }
        public string EngineNumber { get; set; }
        public object WheelPlan { get; set; }
        public bool Exported { get; set; }
        public int GrossWeight { get; set; }
        public object CertificateOfDestructionIssued { get; set; }
        public string MvrisMakeCode { get; set; }
        public int Co2Emissions { get; set; }
        public string MakeModel { get; set; }
        public string DtpModelCode { get; set; }
        public int SeatingCapacity { get; set; }
        public string MvrisModelCode { get; set; }
        public string DoorPlan { get; set; }
        public string Model { get; set; }
        public string VinLast5 { get; set; }
        public string Transmission { get; set; }
        public string Vin { get; set; }
        public string Colour { get; set; }
        public object VinConfirmationFlag { get; set; }
        public string YearOfManufacture { get; set; }
        public string TransmissionCode { get; set; }
        public int GearCount { get; set; }
        public string DoorPlanLiteral { get; set; }
        public object PreviousVrmGb { get; set; }
        public DateTime DateFirstRegistered { get; set; }
        public DateTime DateExported { get; set; }
        public string EngineCapacity { get; set; }
        public string DtpMakeCode { get; set; }
        public object PreviousVrmNi { get; set; }
        public string VehicleClass { get; set; }
        public bool Imported { get; set; }
        public bool VehicleUsedBeforeFirstRegistration { get; set; }
        public string YearMonthFirstRegistered { get; set; }
        public int MaxPermissibleMass { get; set; }
        public string TransmissionType { get; set; }
        public object AbiBrokerNetCode { get; set; }
        public bool ImportNonEu { get; set; }
        public string Make { get; set; }
        public string Vrm { get; set; }
        public DateTime DateOfLastUpdate { get; set; }
        public object DateScrapped { get; set; }
        public DateTime DateFirstRegisteredUk { get; set; }
    }
}
