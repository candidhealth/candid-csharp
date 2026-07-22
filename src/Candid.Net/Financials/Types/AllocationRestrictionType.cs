using global::Candid.Net.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace Candid.Net.Financials;

[JsonConverter(typeof(AllocationRestrictionType.AllocationRestrictionTypeSerializer))]
[Serializable]
public readonly record struct AllocationRestrictionType : IStringEnum
{
    public static readonly AllocationRestrictionType BillingProviderNpi = new(
        Values.BillingProviderNpi
    );

    public static readonly AllocationRestrictionType ServiceFacilityId = new(
        Values.ServiceFacilityId
    );

    public AllocationRestrictionType(string value)
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
    public static AllocationRestrictionType FromCustom(string value)
    {
        return new AllocationRestrictionType(value);
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

    public static bool operator ==(AllocationRestrictionType value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(AllocationRestrictionType value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(AllocationRestrictionType value) => value.Value;

    public static explicit operator AllocationRestrictionType(string value) => new(value);

    internal class AllocationRestrictionTypeSerializer : JsonConverter<AllocationRestrictionType>
    {
        public override AllocationRestrictionType Read(
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
            return new AllocationRestrictionType(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            AllocationRestrictionType value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override AllocationRestrictionType ReadAsPropertyName(
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
            return new AllocationRestrictionType(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            AllocationRestrictionType value,
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
        public const string BillingProviderNpi = "billing_provider_npi";

        public const string ServiceFacilityId = "service_facility_id";
    }
}
