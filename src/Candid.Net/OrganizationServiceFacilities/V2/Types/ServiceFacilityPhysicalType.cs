using System.Text.Json.Serialization;
using Candid.Net.Core;

namespace Candid.Net.OrganizationServiceFacilities.V2;

[JsonConverter(typeof(StringEnumSerializer<ServiceFacilityPhysicalType>))]
[Serializable]
public readonly record struct ServiceFacilityPhysicalType : IStringEnum
{
    /// <summary>
    /// A collection of buildings or other locations such as a site or a campus.
    /// </summary>
    public static readonly ServiceFacilityPhysicalType Site = new(Values.Site);

    /// <summary>
    /// Any Building or structure. This may contain rooms, corridors, wings, etc. It might not have walls, or a roof, but is considered a defined/allocated space.
    /// </summary>
    public static readonly ServiceFacilityPhysicalType Building = new(Values.Building);

    /// <summary>
    /// A Wing within a Building, this often contains levels, rooms and corridors.
    /// </summary>
    public static readonly ServiceFacilityPhysicalType Wing = new(Values.Wing);

    /// <summary>
    /// A Ward is a section of a medical facility that may contain rooms and other types of location.
    /// </summary>
    public static readonly ServiceFacilityPhysicalType Ward = new(Values.Ward);

    /// <summary>
    /// A Level in a multi-level Building/Structure.
    /// </summary>
    public static readonly ServiceFacilityPhysicalType Level = new(Values.Level);

    /// <summary>
    /// A Corridor within a Building.
    /// </summary>
    public static readonly ServiceFacilityPhysicalType Corridor = new(Values.Corridor);

    /// <summary>
    /// A space that is allocated as a room, it may have walls/roof etc., but does not require these.
    /// </summary>
    public static readonly ServiceFacilityPhysicalType Room = new(Values.Room);

    /// <summary>
    /// A space that is allocated for sleeping/laying on etc. typically within a building, section of a building or within a room.
    /// </summary>
    public static readonly ServiceFacilityPhysicalType Bed = new(Values.Bed);

    /// <summary>
    /// A means of transportation.
    /// </summary>
    public static readonly ServiceFacilityPhysicalType Vehicle = new(Values.Vehicle);

    /// <summary>
    /// A residential dwelling. Usually used to reference a location that a person/patient may reside.
    /// </summary>
    public static readonly ServiceFacilityPhysicalType House = new(Values.House);

    /// <summary>
    /// A container that can store goods, equipment, medications or other items.
    /// </summary>
    public static readonly ServiceFacilityPhysicalType Cabinet = new(Values.Cabinet);

    /// <summary>
    /// A defined path to travel between 2 points that has a known name.
    /// </summary>
    public static readonly ServiceFacilityPhysicalType Road = new(Values.Road);

    /// <summary>
    /// A defined physical boundary of something, such as a flood risk zone, region, postcode.
    /// </summary>
    public static readonly ServiceFacilityPhysicalType Area = new(Values.Area);

    /// <summary>
    /// A wide scope that covers a conceptual domain, such as a Nation (Country wide community or Federal Government - e.g.  Ministry of Health), Province or State (community or Government), Business (throughout the enterprise), Nation with a business  scope of an agency (e.g. CDC, FDA etc.) or a Business segment (UK Pharmacy), not just an physical boundary.
    /// </summary>
    public static readonly ServiceFacilityPhysicalType Jurisdiction = new(Values.Jurisdiction);

    public ServiceFacilityPhysicalType(string value)
    {
        Value = value;
    }

    /// <summary>
    /// The string value of the enum.
    /// </summary>
    public string Value { get; }

    /// <summary>
    /// Create a string enum with the given value.
    /// </summary>
    public static ServiceFacilityPhysicalType FromCustom(string value)
    {
        return new ServiceFacilityPhysicalType(value);
    }

    public bool Equals(string? other)
    {
        return Value.Equals(other);
    }

    /// <summary>
    /// Returns the string value of the enum.
    /// </summary>
    public override string ToString()
    {
        return Value;
    }

    public static bool operator ==(ServiceFacilityPhysicalType value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(ServiceFacilityPhysicalType value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(ServiceFacilityPhysicalType value) => value.Value;

    public static explicit operator ServiceFacilityPhysicalType(string value) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        /// <summary>
        /// A collection of buildings or other locations such as a site or a campus.
        /// </summary>
        public const string Site = "si";

        /// <summary>
        /// Any Building or structure. This may contain rooms, corridors, wings, etc. It might not have walls, or a roof, but is considered a defined/allocated space.
        /// </summary>
        public const string Building = "bu";

        /// <summary>
        /// A Wing within a Building, this often contains levels, rooms and corridors.
        /// </summary>
        public const string Wing = "wi";

        /// <summary>
        /// A Ward is a section of a medical facility that may contain rooms and other types of location.
        /// </summary>
        public const string Ward = "wa";

        /// <summary>
        /// A Level in a multi-level Building/Structure.
        /// </summary>
        public const string Level = "lvl";

        /// <summary>
        /// A Corridor within a Building.
        /// </summary>
        public const string Corridor = "co";

        /// <summary>
        /// A space that is allocated as a room, it may have walls/roof etc., but does not require these.
        /// </summary>
        public const string Room = "ro";

        /// <summary>
        /// A space that is allocated for sleeping/laying on etc. typically within a building, section of a building or within a room.
        /// </summary>
        public const string Bed = "bd";

        /// <summary>
        /// A means of transportation.
        /// </summary>
        public const string Vehicle = "ve";

        /// <summary>
        /// A residential dwelling. Usually used to reference a location that a person/patient may reside.
        /// </summary>
        public const string House = "ho";

        /// <summary>
        /// A container that can store goods, equipment, medications or other items.
        /// </summary>
        public const string Cabinet = "ca";

        /// <summary>
        /// A defined path to travel between 2 points that has a known name.
        /// </summary>
        public const string Road = "rd";

        /// <summary>
        /// A defined physical boundary of something, such as a flood risk zone, region, postcode.
        /// </summary>
        public const string Area = "area";

        /// <summary>
        /// A wide scope that covers a conceptual domain, such as a Nation (Country wide community or Federal Government - e.g.  Ministry of Health), Province or State (community or Government), Business (throughout the enterprise), Nation with a business  scope of an agency (e.g. CDC, FDA etc.) or a Business segment (UK Pharmacy), not just an physical boundary.
        /// </summary>
        public const string Jurisdiction = "jdn";
    }
}
