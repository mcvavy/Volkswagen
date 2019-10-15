using System;
using System.Collections.Generic;
using System.Text;

namespace VOLKSWAGEN.Core.Entities
{
    public class VehicleData
    {
        public BillingAccount BillingAccount { get; set; }
        public Request Request { get; set; }
        public Response Response { get; set; }
    }
    public class ExtraInformation
    {
    }

    public class BillingAccount
    {
        public string AccountType { get; set; }
        public double? AccountBalance { get; set; }
        public double? TransactionCost { get; set; }
        public ExtraInformation ExtraInformation { get; set; }
    }

    public class DataKeys
    {
        public string Vrm { get; set; }
    }

    public class Request
    {
        public string RequestGuid { get; set; }
        public string PackageId { get; set; }
        public int? PackageVersion { get; set; }
        public int? ResponseVersion { get; set; }
        public DataKeys DataKeys { get; set; }
    }

    public class Lookup
    {
        public string StatusCode { get; set; }
        public string StatusMessage { get; set; }
        public List<object> AdviceTextList { get; set; }
    }

    public class StatusInformation
    {
        public Lookup Lookup { get; set; }
    }

    public class Engine
    {
        public string CylinderArrangement { get; set; }
        public double? Bore { get; set; }
        public string ValveGear { get; set; }
        public int? ValvesPerCylinder { get; set; }
        public string PrimaryFuelFlag { get; set; }
        public string Aspiration { get; set; }
        public string Description { get; set; }
        public string Make { get; set; }
        public double? Stroke { get; set; }
        public int? NumberOfCylinders { get; set; }
        public string Location { get; set; }
    }

    public class General
    {
        public Engine Engine { get; set; }
        public string EuroStatus { get; set; }
        public object DataVersionNumber { get; set; }
        public string TypeApprovalCategory { get; set; }
        public string DrivingAxle { get; set; }
        public string PowerDelivery { get; set; }
    }

    public class ExtraUrban
    {
        public double? Lkm { get; set; }
        public double? Mpg { get; set; }
    }

    public class Combined
    {
        public double? Lkm { get; set; }
        public double? Mpg { get; set; }
    }

    public class UrbanCold
    {
        public double? Lkm { get; set; }
        public double? Mpg { get; set; }
    }

    public class Consumption
    {
        public ExtraUrban ExtraUrban { get; set; }
        public Combined Combined { get; set; }
        public UrbanCold UrbanCold { get; set; }
    }

    public class Acceleration
    {
        public object Mph { get; set; }
        public object Kph { get; set; }
    }

    public class Power
    {
        public double? Kw { get; set; }
        public double? Bhp { get; set; }
        public double? Rpm { get; set; }
    }

    public class Torque
    {
        public double? Rpm { get; set; }
        public double? FtLb { get; set; }
        public double? Nm { get; set; }
    }

    public class MaxSpeed
    {
        public double? Kph { get; set; }
        public double? Mph { get; set; }
    }

    public class Performance
    {
        public Acceleration Acceleration { get; set; }
        public Power Power { get; set; }
        public object DataVersionNumber { get; set; }
        public Torque Torque { get; set; }
        public MaxSpeed MaxSpeed { get; set; }
        public object Co2 { get; set; }
    }

    public class Dimensions
    {
        public object PayloadVolume { get; set; }
        public string RigidArtic { get; set; }
        public double? CarLength { get; set; }
        public object DataVersionNumber { get; set; }
        public double? Width { get; set; }
        public double? Height { get; set; }
        public object GrossTrainWeight { get; set; }
        public object WheelBase { get; set; }
        public object GrossCombinedWeight { get; set; }
        public int? NumberOfAxles { get; set; }
        public object PayloadWeight { get; set; }
        public double? KerbWeight { get; set; }
        public object UnladenWeight { get; set; }
        public int? NumberOfSeats { get; set; }
        public object LoadLength { get; set; }
        public string BodyShape { get; set; }
        public double? GrossVehicleWeight { get; set; }
    }

    public class TechnicalDetails
    {
        public General General { get; set; }
        public Consumption Consumption { get; set; }
        public Performance Performance { get; set; }
        public Dimensions Dimensions { get; set; }
    }

    public class SmmtDetails
    {
        public string BodyStyle { get; set; }
        public string CabType { get; set; }
        public double? NominalEngineCapacity { get; set; }
        public string CountryOfOrigin { get; set; }
        public string DriveType { get; set; }
        public string VisibilityDate { get; set; }
        public string MarketSectorCode { get; set; }
        public string FuelType { get; set; }
        public string Transmission { get; set; }
        public string EngineCapacity { get; set; }
        public object TerminateDate { get; set; }
        public string SysSetupDate { get; set; }
        public string Series { get; set; }
        public string Marque { get; set; }
        public string ModelVariant { get; set; }
        public int? NumberOfDoors { get; set; }
        public object DataVersionNumber { get; set; }
        public int? NumberOfGears { get; set; }
        public string MarqueCode { get; set; }
        public string ModelCode { get; set; }
        public string Range { get; set; }
    }

    public class FirstYear
    {
        public object TwelveMonth { get; set; }
        public object SixMonth { get; set; }
    }

    public class YearTwoToSix
    {
        public object SixMonth { get; set; }
        public object TwelveMonth { get; set; }
    }

    public class PremiumVehicle
    {
        public YearTwoToSix YearTwoToSix { get; set; }
    }

    public class Standard
    {
        public double? SixMonth { get; set; }
        public double? TwelveMonth { get; set; }
    }

    public class VedRate
    {
        public FirstYear FirstYear { get; set; }
        public PremiumVehicle PremiumVehicle { get; set; }
        public Standard Standard { get; set; }
    }

    public class MotVed
    {
        public double? VedCo2Emissions { get; set; }
        public object MotDue { get; set; }
        public string VedCo2Band { get; set; }
        public VedRate VedRate { get; set; }
        public string VedBand { get; set; }
        public object VehicleStatus { get; set; }
        public object Message { get; set; }
        public object TaxDue { get; set; }
    }

    public class VehicleStatus
    {
        public MotVed MotVed { get; set; }
    }

    public class VehicleRegistration
    {
        public string FuelType { get; set; }
        public bool Scrapped { get; set; }
        public string EngineNumber { get; set; }
        public object WheelPlan { get; set; }
        public bool Exported { get; set; }
        public double? GrossWeight { get; set; }
        public object CertificateOfDestructionIssued { get; set; }
        public string MvrisMakeCode { get; set; }
        public double? Co2Emissions { get; set; }
        public string MakeModel { get; set; }
        public string DtpModelCode { get; set; }
        public int? SeatingCapacity { get; set; }
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
        public int? GearCount { get; set; }
        public string DoorPlanLiteral { get; set; }
        public object PreviousVrmGb { get; set; }
        public DateTime? DateFirstRegistered { get; set; }
        public object DateExported { get; set; }
        public string EngineCapacity { get; set; }
        public string DtpMakeCode { get; set; }
        public object PreviousVrmNi { get; set; }
        public string VehicleClass { get; set; }
        public bool Imported { get; set; }
        public bool VehicleUsedBeforeFirstRegistration { get; set; }
        public string YearMonthFirstRegistered { get; set; }
        public double? MaxPermissibleMass { get; set; }
        public string TransmissionType { get; set; }
        public object AbiBrokerNetCode { get; set; }
        public bool ImportNonEu { get; set; }
        public string Make { get; set; }
        public string Vrm { get; set; }
        public DateTime? DateOfLastUpdate { get; set; }
        public object DateScrapped { get; set; }
        public DateTime? DateFirstRegisteredUk { get; set; }
    }

    public class KeeperChangesList
    {
        public DateTime? DateOfTransaction { get; set; }
        public int? NumberOfPreviousKeepers { get; set; }
        public DateTime? DateOfLastKeeperChange { get; set; }
    }

    public class V5CCertificateList
    {
        public DateTime? CertificateDate { get; set; }
    }

    public class VehicleHistory
    {
        public object ColourChangeCount { get; set; }
        public List<KeeperChangesList> KeeperChangesList { get; set; }
        public List<V5CCertificateList> V5CCertificateList { get; set; }
        public int? NumberOfPreviousKeepers { get; set; }
        public object PlateChangeList { get; set; }
        public int? V5CCertificateCount { get; set; }
        public object VicList { get; set; }
        public object ColourChangeList { get; set; }
        public int? VicCount { get; set; }
        public int? KeeperChangesCount { get; set; }
        public int? PlateChangeCount { get; set; }
    }

    public class Mvris
    {
        public string MakeCode { get; set; }
        public string ModelCode { get; set; }
    }

    public class Smmt
    {
        public string Trim { get; set; }
        public string Range { get; set; }
        public Mvris Mvris { get; set; }
        public string Make { get; set; }
    }

    public class Dvla
    {
        public string Make { get; set; }
        public string MakeCode { get; set; }
        public string Model { get; set; }
        public string ModelCode { get; set; }
    }

    public class ClassificationDetails
    {
        public Smmt Smmt { get; set; }
        public Dvla Dvla { get; set; }
    }

    public class DataItems
    {
        public TechnicalDetails TechnicalDetails { get; set; }
        public SmmtDetails SmmtDetails { get; set; }
        public VehicleStatus VehicleStatus { get; set; }
        public VehicleRegistration VehicleRegistration { get; set; }
        public VehicleHistory VehicleHistory { get; set; }
        public ClassificationDetails ClassificationDetails { get; set; }
    }

    public class Response
    {
        public string StatusCode { get; set; }
        public string StatusMessage { get; set; }
        public StatusInformation StatusInformation { get; set; }
        public DataItems DataItems { get; set; }
    }
}
