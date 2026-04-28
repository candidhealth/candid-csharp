using System.Text.Json.Serialization;
using Candid.Net.Core;

namespace Candid.Net.PreEncounter.Patients.V1;

[JsonConverter(typeof(StringEnumSerializer<AdvancedDirective>))]
[Serializable]
public readonly record struct AdvancedDirective : IStringEnum
{
    public static readonly AdvancedDirective None = new(Values.None);

    public static readonly AdvancedDirective DurablePowerOfAttorney = new(
        Values.DurablePowerOfAttorney
    );

    public static readonly AdvancedDirective LivingWill = new(Values.LivingWill);

    public static readonly AdvancedDirective DoNotResuscitate = new(Values.DoNotResuscitate);

    public static readonly AdvancedDirective StandardPrecautions = new(Values.StandardPrecautions);

    public static readonly AdvancedDirective FallRisk = new(Values.FallRisk);

    public AdvancedDirective(string value)
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
    public static AdvancedDirective FromCustom(string value)
    {
        return new AdvancedDirective(value);
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

    public static bool operator ==(AdvancedDirective value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(AdvancedDirective value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(AdvancedDirective value) => value.Value;

    public static explicit operator AdvancedDirective(string value) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string None = "NONE";

        public const string DurablePowerOfAttorney = "DURABLE_POWER_OF_ATTORNEY";

        public const string LivingWill = "LIVING_WILL";

        public const string DoNotResuscitate = "DO_NOT_RESUSCITATE";

        public const string StandardPrecautions = "STANDARD_PRECAUTIONS";

        public const string FallRisk = "FALL_RISK";
    }
}
