using System.Text.Json.Serialization;
using Candid.Net.Core;

namespace Candid.Net.Encounters.V4;

[JsonConverter(typeof(StringEnumSerializer<ServiceAuthorizationExceptionCode>))]
[Serializable]
public readonly record struct ServiceAuthorizationExceptionCode : IStringEnum
{
    /// <summary>
    /// Immediate/Urgent Care
    /// </summary>
    public static readonly ServiceAuthorizationExceptionCode C1 = new(Values.C1);

    /// <summary>
    /// Services Rendered in a Retroactive Period
    /// </summary>
    public static readonly ServiceAuthorizationExceptionCode C2 = new(Values.C2);

    /// <summary>
    /// Emergency Care
    /// </summary>
    public static readonly ServiceAuthorizationExceptionCode C3 = new(Values.C3);

    /// <summary>
    /// Client has Temporary Medicaid
    /// </summary>
    public static readonly ServiceAuthorizationExceptionCode C4 = new(Values.C4);

    /// <summary>
    /// Request from County for Second Opinion to Determine if Recipient Can Work
    /// </summary>
    public static readonly ServiceAuthorizationExceptionCode C5 = new(Values.C5);

    /// <summary>
    /// Request for Override Pending
    /// </summary>
    public static readonly ServiceAuthorizationExceptionCode C6 = new(Values.C6);

    /// <summary>
    /// Special Handling
    /// </summary>
    public static readonly ServiceAuthorizationExceptionCode C7 = new(Values.C7);

    public ServiceAuthorizationExceptionCode(string value)
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
    public static ServiceAuthorizationExceptionCode FromCustom(string value)
    {
        return new ServiceAuthorizationExceptionCode(value);
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

    public static bool operator ==(ServiceAuthorizationExceptionCode value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(ServiceAuthorizationExceptionCode value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(ServiceAuthorizationExceptionCode value) => value.Value;

    public static explicit operator ServiceAuthorizationExceptionCode(string value) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        /// <summary>
        /// Immediate/Urgent Care
        /// </summary>
        public const string C1 = "1";

        /// <summary>
        /// Services Rendered in a Retroactive Period
        /// </summary>
        public const string C2 = "2";

        /// <summary>
        /// Emergency Care
        /// </summary>
        public const string C3 = "3";

        /// <summary>
        /// Client has Temporary Medicaid
        /// </summary>
        public const string C4 = "4";

        /// <summary>
        /// Request from County for Second Opinion to Determine if Recipient Can Work
        /// </summary>
        public const string C5 = "5";

        /// <summary>
        /// Request for Override Pending
        /// </summary>
        public const string C6 = "6";

        /// <summary>
        /// Special Handling
        /// </summary>
        public const string C7 = "7";
    }
}
