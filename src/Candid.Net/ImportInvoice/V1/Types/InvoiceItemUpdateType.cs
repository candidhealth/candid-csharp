using System.Text.Json;
using System.Text.Json.Serialization;
using global::Candid.Net.Core;

namespace Candid.Net.ImportInvoice.V1;

[JsonConverter(typeof(InvoiceItemUpdateType.InvoiceItemUpdateTypeSerializer))]
[Serializable]
public readonly record struct InvoiceItemUpdateType : IStringEnum
{
    public static readonly InvoiceItemUpdateType Append = new(Values.Append);

    public static readonly InvoiceItemUpdateType Overwrite = new(Values.Overwrite);

    public InvoiceItemUpdateType(string value)
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
    public static InvoiceItemUpdateType FromCustom(string value)
    {
        return new InvoiceItemUpdateType(value);
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

    public static bool operator ==(InvoiceItemUpdateType value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(InvoiceItemUpdateType value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(InvoiceItemUpdateType value) => value.Value;

    public static explicit operator InvoiceItemUpdateType(string value) => new(value);

    internal class InvoiceItemUpdateTypeSerializer : JsonConverter<InvoiceItemUpdateType>
    {
        public override InvoiceItemUpdateType Read(
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
            return new InvoiceItemUpdateType(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            InvoiceItemUpdateType value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override InvoiceItemUpdateType ReadAsPropertyName(
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
            return new InvoiceItemUpdateType(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            InvoiceItemUpdateType value,
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
        public const string Append = "APPEND";

        public const string Overwrite = "OVERWRITE";
    }
}
