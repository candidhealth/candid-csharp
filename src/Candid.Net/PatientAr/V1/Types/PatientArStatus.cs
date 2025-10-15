using System.Text.Json.Serialization;
using Candid.Net.Core;

namespace Candid.Net.PatientAr.V1;

[JsonConverter(typeof(StringEnumSerializer<PatientArStatus>))]
[Serializable]
public readonly record struct PatientArStatus : IStringEnum
{
    public static readonly PatientArStatus Invoiceable = new(Values.Invoiceable);

    public static readonly PatientArStatus NonInvoiceable = new(Values.NonInvoiceable);

    public PatientArStatus(string value)
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
    public static PatientArStatus FromCustom(string value)
    {
        return new PatientArStatus(value);
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

    public static bool operator ==(PatientArStatus value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(PatientArStatus value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(PatientArStatus value) => value.Value;

    public static explicit operator PatientArStatus(string value) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string Invoiceable = "invoiceable";

        public const string NonInvoiceable = "non_invoiceable";
    }
}
