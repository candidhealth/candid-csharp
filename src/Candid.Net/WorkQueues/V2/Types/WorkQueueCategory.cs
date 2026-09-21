using global::Candid.Net.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace Candid.Net.WorkQueues.V2;

[JsonConverter(typeof(WorkQueueCategory.WorkQueueCategorySerializer))]
[Serializable]
public readonly record struct WorkQueueCategory : IStringEnum
{
    public static readonly WorkQueueCategory PreSubmission = new(Values.PreSubmission);

    public static readonly WorkQueueCategory Rejections = new(Values.Rejections);

    public static readonly WorkQueueCategory Denials = new(Values.Denials);

    public static readonly WorkQueueCategory OtherPostSubmission = new(Values.OtherPostSubmission);

    public static readonly WorkQueueCategory StaleClaims = new(Values.StaleClaims);

    public static readonly WorkQueueCategory Custom = new(Values.Custom);

    public static readonly WorkQueueCategory Coding = new(Values.Coding);

    public static readonly WorkQueueCategory ChargeIngestion = new(Values.ChargeIngestion);

    public WorkQueueCategory(string value)
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
    public static WorkQueueCategory FromCustom(string value)
    {
        return new WorkQueueCategory(value);
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

    public static bool operator ==(WorkQueueCategory value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(WorkQueueCategory value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(WorkQueueCategory value) => value.Value;

    public static explicit operator WorkQueueCategory(string value) => new(value);

    internal class WorkQueueCategorySerializer : JsonConverter<WorkQueueCategory>
    {
        public override WorkQueueCategory Read(
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
            return new WorkQueueCategory(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            WorkQueueCategory value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override WorkQueueCategory ReadAsPropertyName(
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
            return new WorkQueueCategory(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            WorkQueueCategory value,
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
        public const string PreSubmission = "Pre-Submission";

        public const string Rejections = "Rejections";

        public const string Denials = "Denials";

        public const string OtherPostSubmission = "Other Post-Submission";

        public const string StaleClaims = "Stale Claims";

        public const string Custom = "Custom";

        public const string Coding = "Coding";

        public const string ChargeIngestion = "Charge Ingestion";
    }
}
