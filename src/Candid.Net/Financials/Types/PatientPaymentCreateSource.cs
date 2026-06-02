using System.Text.Json.Serialization;
using Candid.Net.Core;

namespace Candid.Net.Financials;

[JsonConverter(typeof(StringEnumSerializer<PatientPaymentCreateSource>))]
[Serializable]
public readonly record struct PatientPaymentCreateSource : IStringEnum
{
    public static readonly PatientPaymentCreateSource ManualEntry = new(Values.ManualEntry);

    public static readonly PatientPaymentCreateSource Phreesia = new(Values.Phreesia);

    public static readonly PatientPaymentCreateSource SherpaHealth = new(Values.SherpaHealth);

    public PatientPaymentCreateSource(string value)
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
    public static PatientPaymentCreateSource FromCustom(string value)
    {
        return new PatientPaymentCreateSource(value);
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

    public static bool operator ==(PatientPaymentCreateSource value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(PatientPaymentCreateSource value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(PatientPaymentCreateSource value) => value.Value;

    public static explicit operator PatientPaymentCreateSource(string value) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string ManualEntry = "MANUAL_ENTRY";

        public const string Phreesia = "PHREESIA";

        public const string SherpaHealth = "SHERPA_HEALTH";
    }
}
