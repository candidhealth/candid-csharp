using System.Text.Json;
using System.Text.Json.Serialization;
using global::Candid.Net.Core;

namespace Candid.Net.ClinicalTrials.V1;

[JsonConverter(typeof(ClinicalTrialPhase.ClinicalTrialPhaseSerializer))]
[Serializable]
public readonly record struct ClinicalTrialPhase : IStringEnum
{
    public static readonly ClinicalTrialPhase PhaseOne = new(Values.PhaseOne);

    public static readonly ClinicalTrialPhase PhaseTwo = new(Values.PhaseTwo);

    public static readonly ClinicalTrialPhase PhaseThree = new(Values.PhaseThree);

    public ClinicalTrialPhase(string value)
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
    public static ClinicalTrialPhase FromCustom(string value)
    {
        return new ClinicalTrialPhase(value);
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

    public static bool operator ==(ClinicalTrialPhase value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(ClinicalTrialPhase value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(ClinicalTrialPhase value) => value.Value;

    public static explicit operator ClinicalTrialPhase(string value) => new(value);

    internal class ClinicalTrialPhaseSerializer : JsonConverter<ClinicalTrialPhase>
    {
        public override ClinicalTrialPhase Read(
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
            return new ClinicalTrialPhase(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            ClinicalTrialPhase value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override ClinicalTrialPhase ReadAsPropertyName(
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
            return new ClinicalTrialPhase(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            ClinicalTrialPhase value,
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
        public const string PhaseOne = "Phase 1";

        public const string PhaseTwo = "Phase 2";

        public const string PhaseThree = "Phase 3";
    }
}
