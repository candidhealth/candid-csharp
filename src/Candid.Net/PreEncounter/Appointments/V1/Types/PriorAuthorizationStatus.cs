using global::Candid.Net.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace Candid.Net.PreEncounter.Appointments.V1;

[JsonConverter(typeof(PriorAuthorizationStatus.PriorAuthorizationStatusSerializer))]
[Serializable]
public readonly record struct PriorAuthorizationStatus : IStringEnum
{
    public static readonly PriorAuthorizationStatus NotRequired = new(Values.NotRequired);

    public static readonly PriorAuthorizationStatus Required = new(Values.Required);

    public static readonly PriorAuthorizationStatus Pending = new(Values.Pending);

    public static readonly PriorAuthorizationStatus Approved = new(Values.Approved);

    public static readonly PriorAuthorizationStatus PartiallyApproved = new(
        Values.PartiallyApproved
    );

    public static readonly PriorAuthorizationStatus Denied = new(Values.Denied);

    public static readonly PriorAuthorizationStatus Expired = new(Values.Expired);

    public PriorAuthorizationStatus(string value)
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
    public static PriorAuthorizationStatus FromCustom(string value)
    {
        return new PriorAuthorizationStatus(value);
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

    public static bool operator ==(PriorAuthorizationStatus value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(PriorAuthorizationStatus value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(PriorAuthorizationStatus value) => value.Value;

    public static explicit operator PriorAuthorizationStatus(string value) => new(value);

    internal class PriorAuthorizationStatusSerializer : JsonConverter<PriorAuthorizationStatus>
    {
        public override PriorAuthorizationStatus Read(
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
            return new PriorAuthorizationStatus(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            PriorAuthorizationStatus value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override PriorAuthorizationStatus ReadAsPropertyName(
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
            return new PriorAuthorizationStatus(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            PriorAuthorizationStatus value,
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
        public const string NotRequired = "NOT_REQUIRED";

        public const string Required = "REQUIRED";

        public const string Pending = "PENDING";

        public const string Approved = "APPROVED";

        public const string PartiallyApproved = "PARTIALLY_APPROVED";

        public const string Denied = "DENIED";

        public const string Expired = "EXPIRED";
    }
}
