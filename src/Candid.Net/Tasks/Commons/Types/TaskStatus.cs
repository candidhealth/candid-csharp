using System.Text.Json.Serialization;
using Candid.Net.Core;

namespace Candid.Net.Tasks.Commons;

[JsonConverter(typeof(StringEnumSerializer<TaskStatus>))]
[Serializable]
public readonly record struct TaskStatus : IStringEnum
{
    public static readonly TaskStatus Finished = new(Values.Finished);

    public static readonly TaskStatus AddressedByProviderGroup = new(
        Values.AddressedByProviderGroup
    );

    public static readonly TaskStatus SentToProviderGroup = new(Values.SentToProviderGroup);

    public static readonly TaskStatus OpenTask = new(Values.OpenTask);

    public static readonly TaskStatus Blocked = new(Values.Blocked);

    public static readonly TaskStatus WaitingForReview = new(Values.WaitingForReview);

    public static readonly TaskStatus InProgress = new(Values.InProgress);

    public TaskStatus(string value)
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
    public static TaskStatus FromCustom(string value)
    {
        return new TaskStatus(value);
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

    public static bool operator ==(TaskStatus value1, string value2) => value1.Value.Equals(value2);

    public static bool operator !=(TaskStatus value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(TaskStatus value) => value.Value;

    public static explicit operator TaskStatus(string value) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string Finished = "finished";

        public const string AddressedByProviderGroup = "addressed_by_provider_group";

        public const string SentToProviderGroup = "sent_to_provider_group";

        public const string OpenTask = "open";

        public const string Blocked = "blocked";

        public const string WaitingForReview = "waiting_for_review";

        public const string InProgress = "in_progress";
    }
}
