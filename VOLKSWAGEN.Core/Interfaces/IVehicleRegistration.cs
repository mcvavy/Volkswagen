using System;
using VOLKSWAGEN.Core.Entities;

namespace VOLKSWAGEN.Core.Interfaces
{
    public interface IVehicleRegistration
    {
        string FuelType { get; set; }
        bool Scrapped { get; set; }
        string EngineNumber { get; set; }
        object WheelPlan { get; set; }
        bool Exported { get; set; }
        double GrossWeight { get; set; }
        object CertificateOfDestructionIssued { get; set; }
        string MvrisMakeCode { get; set; }
        double Co2Emissions { get; set; }
        string MakeModel { get; set; }
        string DtpModelCode { get; set; }
        int? SeatingCapacity { get; set; }
        string MvrisModelCode { get; set; }
        string DoorPlan { get; set; }
        string Model { get; set; }
        string VinLast5 { get; set; }
        string Transmission { get; set; }
        string Vin { get; set; }
        string Colour { get; set; }
        object VinConfirmationFlag { get; set; }
        string YearOfManufacture { get; set; }
        string TransmissionCode { get; set; }
        int GearCount { get; set; }
        string DoorPlanLiteral { get; set; }
        object PreviousVrmGb { get; set; }
        DateTime? DateFirstRegistered { get; set; }
        DateTime? DateExported { get; set; }
        string EngineCapacity { get; set; }
        string DtpMakeCode { get; set; }
        object PreviousVrmNi { get; set; }
        string VehicleClass { get; set; }
        bool Imported { get; set; }
        bool VehicleUsedBeforeFirstRegistration { get; set; }
        string YearMonthFirstRegistered { get; set; }
        double MaxPermissibleMass { get; set; }
        string TransmissionType { get; set; }
        object AbiBrokerNetCode { get; set; }
        bool ImportNonEu { get; set; }
        string Make { get; set; }
        string Vrm { get; set; }
        DateTime? DateOfLastUpdate { get; set; }
        object DateScrapped { get; set; }
        DateTime? DateFirstRegisteredUk { get; set; }
        LookupResponse Response { get; set; }
    }
}