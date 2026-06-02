using System.Text.Json.Serialization;
using Candid.Net.Core;

namespace Candid.Net.BillingNotes.V2;

[JsonConverter(typeof(StringEnumSerializer<BillingNoteType>))]
[Serializable]
public readonly record struct BillingNoteType : IStringEnum
{
    public static readonly BillingNoteType Manual = new(Values.Manual);

    public static readonly BillingNoteType System = new(Values.System);

    public static readonly BillingNoteType QueueAdded = new(Values.QueueAdded);

    public static readonly BillingNoteType QueueMoved = new(Values.QueueMoved);

    public static readonly BillingNoteType TaskCreated = new(Values.TaskCreated);

    public BillingNoteType(string value)
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
    public static BillingNoteType FromCustom(string value)
    {
        return new BillingNoteType(value);
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

    public static bool operator ==(BillingNoteType value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(BillingNoteType value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(BillingNoteType value) => value.Value;

    public static explicit operator BillingNoteType(string value) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string Manual = "manual";

        public const string System = "system";

        public const string QueueAdded = "queue_added";

        public const string QueueMoved = "queue_moved";

        public const string TaskCreated = "task_created";
    }
}
