using System.Text.Json.Serialization;
using Candid.Net.Core;

namespace Candid.Net.Tasks.V3;

[JsonConverter(typeof(StringEnumSerializer<TaskActionType>))]
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
