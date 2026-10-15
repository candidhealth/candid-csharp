using global::Candid.Net.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace Candid.Net.ExternalConsolidatedRemit.V1;

[JsonConverter(typeof(PaymentBundleAllocationMethod.PaymentBundleAllocationMethodSerializer))]
[Serializable]
public readonly record struct PaymentBundleAllocationMethod : IStringEnum
{
    public static readonly PaymentBundleAllocationMethod AutoAllocatedOrganization = new(
        Values.AutoAllocatedOrganization
    );

    public static readonly PaymentBundleAllocationMethod UserAllocatedServiceLine = new(
        Values.UserAllocatedServiceLine
    );

    public static readonly PaymentBundleAllocationMethod UserAllocatedClearing = new(
        Values.UserAllocatedClearing
    );

    public static readonly PaymentBundleAllocationMethod UserAllocatedExternal = new(
        Values.UserAllocatedExternal
    );

    public PaymentBundleAllocationMethod(string value)
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
    public static PaymentBundleAllocationMethod FromCustom(string value)
    {
        return new PaymentBundleAllocationMethod(value);
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

    public static bool operator ==(PaymentBundleAllocationMethod value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(PaymentBundleAllocationMethod value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(PaymentBundleAllocationMethod value) => value.Value;

    public static explicit operator PaymentBundleAllocationMethod(string value) => new(value);

    internal class PaymentBundleAllocationMethodSerializer
        : JsonConverter<PaymentBundleAllocationMethod>
    {
        public override PaymentBundleAllocationMethod Read(
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
            return new PaymentBundleAllocationMethod(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            PaymentBundleAllocationMethod value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override PaymentBundleAllocationMethod ReadAsPropertyName(
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
            return new PaymentBundleAllocationMethod(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            PaymentBundleAllocationMethod value,
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
        public const string AutoAllocatedOrganization = "auto_allocated_organization";

        public const string UserAllocatedServiceLine = "user_allocated_service_line";

        public const string UserAllocatedClearing = "user_allocated_clearing";

        public const string UserAllocatedExternal = "user_allocated_external";
    }
}
