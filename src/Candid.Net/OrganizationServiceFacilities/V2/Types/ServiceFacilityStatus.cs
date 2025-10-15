using System.Text.Json.Serialization;
using Candid.Net.Core;

namespace Candid.Net.OrganizationServiceFacilities.V2;

[JsonConverter(typeof(StringEnumSerializer<ServiceFacilityStatus>))]
[Serializable]
public readonly record struct ServiceFacilityStatus : IStringEnum
{
    /// <summary>
    /// The location is operational.
    /// </summary>
    public static readonly ServiceFacilityStatus Active = new(Values.Active);

    /// <summary>
    /// The location is no longer used.
    /// </summary>
    public static readonly ServiceFacilityStatus Inactive = new(Values.Inactive);

    /// <summary>
    /// TThe location is temporarily closed.
    /// </summary>
    public static readonly ServiceFacilityStatus Suspended = new(Values.Suspended);

    public ServiceFacilityStatus(string value)
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
    public static ServiceFacilityStatus FromCustom(string value)
    {
        return new ServiceFacilityStatus(value);
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

    public static bool operator ==(ServiceFacilityStatus value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(ServiceFacilityStatus value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(ServiceFacilityStatus value) => value.Value;

    public static explicit operator ServiceFacilityStatus(string value) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        /// <summary>
        /// The location is operational.
        /// </summary>
        public const string Active = "active";

        /// <summary>
        /// The location is no longer used.
        /// </summary>
        public const string Inactive = "inactive";

        /// <summary>
        /// TThe location is temporarily closed.
        /// </summary>
        public const string Suspended = "suspended";
    }
}
