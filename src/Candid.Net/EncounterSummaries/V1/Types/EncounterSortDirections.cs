using global::Candid.Net.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace Candid.Net.EncounterSummaries.V1;

[JsonConverter(typeof(EncounterSortDirections.EncounterSortDirectionsSerializer))]
[Serializable]
public readonly record struct EncounterSortDirections : IStringEnum
{
    public static readonly EncounterSortDirections Descending = new(Values.Descending);

    public static readonly EncounterSortDirections Ascending = new(Values.Ascending);

    public EncounterSortDirections(string value)
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
    public static EncounterSortDirections FromCustom(string value)
    {
        return new EncounterSortDirections(value);
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

    public static bool operator ==(EncounterSortDirections value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(EncounterSortDirections value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(EncounterSortDirections value) => value.Value;

    public static explicit operator EncounterSortDirections(string value) => new(value);

    internal class EncounterSortDirectionsSerializer : JsonConverter<EncounterSortDirections>
    {
        public override EncounterSortDirections Read(
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
            return new EncounterSortDirections(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            EncounterSortDirections value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override EncounterSortDirections ReadAsPropertyName(
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
            return new EncounterSortDirections(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            EncounterSortDirections value,
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
        public const string Descending = "desc";

        public const string Ascending = "asc";
    }
}
