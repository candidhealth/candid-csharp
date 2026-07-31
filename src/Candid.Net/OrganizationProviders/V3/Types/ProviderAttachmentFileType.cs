using global::Candid.Net.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace Candid.Net.OrganizationProviders.V3;

[JsonConverter(typeof(ProviderAttachmentFileType.ProviderAttachmentFileTypeSerializer))]
[Serializable]
public readonly record struct ProviderAttachmentFileType : IStringEnum
{
    public static readonly ProviderAttachmentFileType W9 = new(Values.W9);

    public static readonly ProviderAttachmentFileType PecosRecord = new(Values.PecosRecord);

    public static readonly ProviderAttachmentFileType BankLetterOrVoidedCheck = new(
        Values.BankLetterOrVoidedCheck
    );

    public ProviderAttachmentFileType(string value)
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
    public static ProviderAttachmentFileType FromCustom(string value)
    {
        return new ProviderAttachmentFileType(value);
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

    public static bool operator ==(ProviderAttachmentFileType value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(ProviderAttachmentFileType value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(ProviderAttachmentFileType value) => value.Value;

    public static explicit operator ProviderAttachmentFileType(string value) => new(value);

    internal class ProviderAttachmentFileTypeSerializer : JsonConverter<ProviderAttachmentFileType>
    {
        public override ProviderAttachmentFileType Read(
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
            return new ProviderAttachmentFileType(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            ProviderAttachmentFileType value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override ProviderAttachmentFileType ReadAsPropertyName(
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
            return new ProviderAttachmentFileType(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            ProviderAttachmentFileType value,
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
        public const string W9 = "W9";

        public const string PecosRecord = "PECOS_RECORD";

        public const string BankLetterOrVoidedCheck = "BANK_LETTER_OR_VOIDED_CHECK";
    }
}
