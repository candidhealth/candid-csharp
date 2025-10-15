using System.Text.Json.Serialization;
using Candid.Net.Core;

namespace Candid.Net.OrganizationServiceFacilities.V2;

[JsonConverter(typeof(StringEnumSerializer<ServiceFacilityMode>))]
[Serializable]
public readonly record struct ServiceFacilityMode : IStringEnum
{
    /// <summary>
    /// The Location resource represents a specific instance of a location (e.g. Operating Theatre 1A).
    /// </summary>
    public static readonly ServiceFacilityMode Instance = new(Values.Instance);

    /// <summary>
    /// The Location represents a class of locations (e.g. Any Operating Theatre) although this class of locations could be constrained within a specific boundary (such as organization, or parent location, address etc.).
    /// </summary>
    public static readonly ServiceFacilityMode Kind = new(Values.Kind);

    public ServiceFacilityMode(string value)
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
    public static ServiceFacilityMode FromCustom(string value)
    {
        return new ServiceFacilityMode(value);
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

    public static bool operator ==(ServiceFacilityMode value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(ServiceFacilityMode value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(ServiceFacilityMode value) => value.Value;

    public static explicit operator ServiceFacilityMode(string value) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        /// <summary>
        /// The Location resource represents a specific instance of a location (e.g. Operating Theatre 1A).
        /// </summary>
        public const string Instance = "instance";

        /// <summary>
        /// The Location represents a class of locations (e.g. Any Operating Theatre) although this class of locations could be constrained within a specific boundary (such as organization, or parent location, address etc.).
        /// </summary>
        public const string Kind = "kind";
    }
}
