using System.Text.Json;
using System.Text.Json.Serialization;
using global::Candid.Net.Core;

namespace Candid.Net.Tasks.V3;

[JsonConverter(typeof(TaskActionType.TaskActionTypeSerializer))]
[Serializable]
public readonly record struct TaskActionType : IStringEnum
{
    public static readonly TaskActionType CloseTask = new(Values.CloseTask);

    public static readonly TaskActionType CloseTaskAndReprocess = new(Values.CloseTaskAndReprocess);

    public TaskActionType(string value)
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
    public static TaskActionType FromCustom(string value)
    {
        return new TaskActionType(value);
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

    public static bool operator ==(TaskActionType value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(TaskActionType value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(TaskActionType value) => value.Value;

    public static explicit operator TaskActionType(string value) => new(value);

    internal class TaskActionTypeSerializer : JsonConverter<TaskActionType>
    {
        public override TaskActionType Read(
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
            return new TaskActionType(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            TaskActionType value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override TaskActionType ReadAsPropertyName(
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
            return new TaskActionType(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            TaskActionType value,
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
        public const string CloseTask = "close_task";

        public const string CloseTaskAndReprocess = "close_task_and_reprocess";
    }
}
