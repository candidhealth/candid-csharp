using System.Text.Json;
using System.Text.Json.Serialization;
using global::Candid.Net.Core;

namespace Candid.Net.PayerPlanGroups.V1;

[JsonConverter(typeof(PayerPlanGroupSortField.PayerPlanGroupSortFieldSerializer))]
[Serializable]
public readonly record struct PayerPlanGroupSortField : IStringEnum
{
    public static readonly PayerPlanGroupSortField PlanGroupName = new(Values.PlanGroupName);

    public static readonly PayerPlanGroupSortField PlanType = new(Values.PlanType);

    public static readonly PayerPlanGroupSortField CreatedAt = new(Values.CreatedAt);

    public PayerPlanGroupSortField(string value)
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
    public static PayerPlanGroupSortField FromCustom(string value)
    {
        return new PayerPlanGroupSortField(value);
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

    public static bool operator ==(PayerPlanGroupSortField value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(PayerPlanGroupSortField value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(PayerPlanGroupSortField value) => value.Value;

    public static explicit operator PayerPlanGroupSortField(string value) => new(value);

    internal class PayerPlanGroupSortFieldSerializer : JsonConverter<PayerPlanGroupSortField>
    {
        public override PayerPlanGroupSortField Read(
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
            return new PayerPlanGroupSortField(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            PayerPlanGroupSortField value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override PayerPlanGroupSortField ReadAsPropertyName(
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
            return new PayerPlanGroupSortField(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            PayerPlanGroupSortField value,
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
        public const string PlanGroupName = "plan_group_name";

        public const string PlanType = "plan_type";

        public const string CreatedAt = "created_at";
    }
}
