using System.Text.Json;
using System.Text.Json.Serialization;
using global::Candid.Net.Core;

namespace Candid.Net.Encounters.V4;

[JsonConverter(typeof(BillableStatusType.BillableStatusTypeSerializer))]
[Serializable]
public readonly record struct BillableStatusType : IStringEnum
{
    public static readonly BillableStatusType Billable = new(Values.Billable);

    public static readonly BillableStatusType NotBillable = new(Values.NotBillable);

    public BillableStatusType(string value)
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
    public static BillableStatusType FromCustom(string value)
    {
        return new BillableStatusType(value);
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

    public static bool operator ==(BillableStatusType value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(BillableStatusType value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(BillableStatusType value) => value.Value;

    public static explicit operator BillableStatusType(string value) => new(value);

    internal class BillableStatusTypeSerializer : JsonConverter<BillableStatusType>
    {
        public override BillableStatusType Read(
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
            return new BillableStatusType(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            BillableStatusType value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override BillableStatusType ReadAsPropertyName(
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
            return new BillableStatusType(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            BillableStatusType value,
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
        public const string Billable = "BILLABLE";

        public const string NotBillable = "NOT_BILLABLE";
    }
}
