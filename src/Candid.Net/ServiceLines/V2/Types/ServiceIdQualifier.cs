using System.Text.Json.Serialization;
using Candid.Net.Core;

namespace Candid.Net.ServiceLines.V2;

[JsonConverter(typeof(StringEnumSerializer<ServiceIdQualifier>))]
[Serializable]
public readonly record struct ServiceIdQualifier : IStringEnum
{
    /// <summary>
    /// EAN/UCC - 13
    /// </summary>
    public static readonly ServiceIdQualifier EanUcc13 = new(Values.EanUcc13);

    /// <summary>
    /// EAN/UCC - 8
    /// </summary>
    public static readonly ServiceIdQualifier EanUcc8 = new(Values.EanUcc8);

    /// <summary>
    /// HIBC (Health Care Industry Bar Code) Supplier Labeling Standard Primary Data Message
    /// </summary>
    public static readonly ServiceIdQualifier Hibc = new(Values.Hibc);

    /// <summary>
    /// National Drug Code in 5-4-2 Format
    /// </summary>
    public static readonly ServiceIdQualifier Ndc542Format = new(Values.Ndc542Format);

    /// <summary>
    /// Customer Order Number
    /// </summary>
    public static readonly ServiceIdQualifier CustomerOrderNumber = new(Values.CustomerOrderNumber);

    /// <summary>
    /// GTIN 14-digit Data Structure
    /// </summary>
    public static readonly ServiceIdQualifier Gtin = new(Values.Gtin);

    /// <summary>
    /// UCC - 12
    /// </summary>
    public static readonly ServiceIdQualifier Ucc12 = new(Values.Ucc12);

    public ServiceIdQualifier(string value)
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
    public static ServiceIdQualifier FromCustom(string value)
    {
        return new ServiceIdQualifier(value);
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

    public static bool operator ==(ServiceIdQualifier value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(ServiceIdQualifier value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(ServiceIdQualifier value) => value.Value;

    public static explicit operator ServiceIdQualifier(string value) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        /// <summary>
        /// EAN/UCC - 13
        /// </summary>
        public const string EanUcc13 = "EN";

        /// <summary>
        /// EAN/UCC - 8
        /// </summary>
        public const string EanUcc8 = "EO";

        /// <summary>
        /// HIBC (Health Care Industry Bar Code) Supplier Labeling Standard Primary Data Message
        /// </summary>
        public const string Hibc = "HI";

        /// <summary>
        /// National Drug Code in 5-4-2 Format
        /// </summary>
        public const string Ndc542Format = "N4";

        /// <summary>
        /// Customer Order Number
        /// </summary>
        public const string CustomerOrderNumber = "ON";

        /// <summary>
        /// GTIN 14-digit Data Structure
        /// </summary>
        public const string Gtin = "UK";

        /// <summary>
        /// UCC - 12
        /// </summary>
        public const string Ucc12 = "UP";
    }
}
