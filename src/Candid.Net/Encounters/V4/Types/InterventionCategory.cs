using System.Text.Json;
using System.Text.Json.Serialization;
using global::Candid.Net.Core;

namespace Candid.Net.Encounters.V4;

[JsonConverter(typeof(InterventionCategory.InterventionCategorySerializer))]
[Serializable]
public readonly record struct InterventionCategory : IStringEnum
{
    public static readonly InterventionCategory Allopathic = new(Values.Allopathic);

    public static readonly InterventionCategory Naturopathic = new(Values.Naturopathic);

    public static readonly InterventionCategory Tests = new(Values.Tests);

    public static readonly InterventionCategory Lifestyle = new(Values.Lifestyle);

    public InterventionCategory(string value)
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
    public static InterventionCategory FromCustom(string value)
    {
        return new InterventionCategory(value);
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

    public static bool operator ==(InterventionCategory value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(InterventionCategory value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(InterventionCategory value) => value.Value;

    public static explicit operator InterventionCategory(string value) => new(value);

    internal class InterventionCategorySerializer : JsonConverter<InterventionCategory>
    {
        public override InterventionCategory Read(
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
            return new InterventionCategory(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            InterventionCategory value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override InterventionCategory ReadAsPropertyName(
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
            return new InterventionCategory(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            InterventionCategory value,
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
        public const string Allopathic = "allopathic";

        public const string Naturopathic = "naturopathic";

        public const string Tests = "tests";

        public const string Lifestyle = "lifestyle";
    }
}
