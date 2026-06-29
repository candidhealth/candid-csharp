using global::Candid.Net.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace Candid.Net.PreEncounter.EligibilityChecks.V1;

[JsonConverter(typeof(InsuranceDiscoveryGender.InsuranceDiscoveryGenderSerializer))]
[Serializable]
public readonly record struct InsuranceDiscoveryGender : IStringEnum
{
    public static readonly InsuranceDiscoveryGender M = new(Values.M);

    public static readonly InsuranceDiscoveryGender F = new(Values.F);

    public InsuranceDiscoveryGender(string value)
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
    public static InsuranceDiscoveryGender FromCustom(string value)
    {
        return new InsuranceDiscoveryGender(value);
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

    public static bool operator ==(InsuranceDiscoveryGender value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(InsuranceDiscoveryGender value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(InsuranceDiscoveryGender value) => value.Value;

    public static explicit operator InsuranceDiscoveryGender(string value) => new(value);

    internal class InsuranceDiscoveryGenderSerializer : JsonConverter<InsuranceDiscoveryGender>
    {
        public override InsuranceDiscoveryGender Read(
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
            return new InsuranceDiscoveryGender(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            InsuranceDiscoveryGender value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override InsuranceDiscoveryGender ReadAsPropertyName(
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
            return new InsuranceDiscoveryGender(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            InsuranceDiscoveryGender value,
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
        public const string M = "M";

        public const string F = "F";
    }
}
