using System.Text.Json.Serialization;
using Candid.Net.Core;

namespace Candid.Net.OrganizationServiceFacilities.V2;

[JsonConverter(typeof(StringEnumSerializer<ServiceFacilityOperationalStatus>))]
[Serializable]
public readonly record struct ServiceFacilityOperationalStatus : IStringEnum
{
    /// <summary>
    /// The location is not operational and is closed.
    /// </summary>
    public static readonly ServiceFacilityOperationalStatus Closed = new(Values.Closed);

    /// <summary>
    /// The location is currently undergoing cleaning or maintenance.
    /// </summary>
    public static readonly ServiceFacilityOperationalStatus Housekeeping = new(Values.Housekeeping);

    /// <summary>
    /// The location is quarantined or isolated for special cases.
    /// </summary>
    public static readonly ServiceFacilityOperationalStatus Isolated = new(Values.Isolated);

    /// <summary>
    /// The location has been identified as contaminated and is not currently usable.
    /// </summary>
    public static readonly ServiceFacilityOperationalStatus Contaminated = new(Values.Contaminated);

    /// <summary>
    /// The location is currently in use or occupied.
    /// </summary>
    public static readonly ServiceFacilityOperationalStatus Occupied = new(Values.Occupied);

    /// <summary>
    /// The location is operational but currently empty or not in use.
    /// </summary>
    public static readonly ServiceFacilityOperationalStatus Unoccupied = new(Values.Unoccupied);

    public ServiceFacilityOperationalStatus(string value)
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
    public static ServiceFacilityOperationalStatus FromCustom(string value)
    {
        return new ServiceFacilityOperationalStatus(value);
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

    public static bool operator ==(ServiceFacilityOperationalStatus value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(ServiceFacilityOperationalStatus value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(ServiceFacilityOperationalStatus value) => value.Value;

    public static explicit operator ServiceFacilityOperationalStatus(string value) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        /// <summary>
        /// The location is not operational and is closed.
        /// </summary>
        public const string Closed = "C";

        /// <summary>
        /// The location is currently undergoing cleaning or maintenance.
        /// </summary>
        public const string Housekeeping = "H";

        /// <summary>
        /// The location is quarantined or isolated for special cases.
        /// </summary>
        public const string Isolated = "I";

        /// <summary>
        /// The location has been identified as contaminated and is not currently usable.
        /// </summary>
        public const string Contaminated = "K";

        /// <summary>
        /// The location is currently in use or occupied.
        /// </summary>
        public const string Occupied = "O";

        /// <summary>
        /// The location is operational but currently empty or not in use.
        /// </summary>
        public const string Unoccupied = "U";
    }
}
