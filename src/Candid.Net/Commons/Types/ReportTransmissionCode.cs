using System.Text.Json.Serialization;
using Candid.Net.Core;

namespace Candid.Net.Commons;

[JsonConverter(typeof(StringEnumSerializer<ReportTransmissionCode>))]
[Serializable]
public readonly record struct ReportTransmissionCode : IStringEnum
{
    /// <summary>
    /// By Mail
    /// </summary>
    public static readonly ReportTransmissionCode Cbm = new(Values.Cbm);

    /// <summary>
    /// Electronically Only
    /// </summary>
    public static readonly ReportTransmissionCode Cel = new(Values.Cel);

    /// <summary>
    /// By Fax
    /// </summary>
    public static readonly ReportTransmissionCode Cfx = new(Values.Cfx);

    public ReportTransmissionCode(string value)
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
    public static ReportTransmissionCode FromCustom(string value)
    {
        return new ReportTransmissionCode(value);
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

    public static bool operator ==(ReportTransmissionCode value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(ReportTransmissionCode value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(ReportTransmissionCode value) => value.Value;

    public static explicit operator ReportTransmissionCode(string value) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        /// <summary>
        /// By Mail
        /// </summary>
        public const string Cbm = "BM";

        /// <summary>
        /// Electronically Only
        /// </summary>
        public const string Cel = "EL";

        /// <summary>
        /// By Fax
        /// </summary>
        public const string Cfx = "FX";
    }
}
