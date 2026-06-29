using global::Candid.Net.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace Candid.Net.PreEncounter.Patients.V1;

[JsonConverter(typeof(AdvancedDirective.AdvancedDirectiveSerializer))]
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

    internal class AdvancedDirectiveSerializer : JsonConverter<AdvancedDirective>
    {
        public override AdvancedDirective Read(
            ref Utf8JsonReader reader,
            Type typeToConvert,
            JsonSerializerOptions options
        )
        {
            var stringValue =
                reader.GetString()
                ?? throw new global::System.Exception(
                    "The JSON value could not be read as a string."
                );
            return new AdvancedDirective(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            AdvancedDirective value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override AdvancedDirective ReadAsPropertyName(
            ref Utf8JsonReader reader,
            Type typeToConvert,
            JsonSerializerOptions options
        )
        {
            var stringValue =
                reader.GetString()
                ?? throw new global::System.Exception(
                    "The JSON property name could not be read as a string."
                );
            return new AdvancedDirective(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            AdvancedDirective value,
            JsonSerializerOptions options
        )
        {
            writer.WritePropertyName(value.Value);
        }
    }

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
