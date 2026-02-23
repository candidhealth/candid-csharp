using System.Text.Json.Serialization;
using Candid.Net.Core;

namespace Candid.Net.PreEncounter.EligibilityChecks.V1;

[JsonConverter(typeof(StringEnumSerializer<VoteValue>))]
[Serializable]
public readonly record struct VoteValue : IStringEnum
{
    public static readonly VoteValue Upvote = new(Values.Upvote);

    public static readonly VoteValue Downvote = new(Values.Downvote);

    public VoteValue(string value)
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
    public static VoteValue FromCustom(string value)
    {
        return new VoteValue(value);
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

    public static bool operator ==(VoteValue value1, string value2) => value1.Value.Equals(value2);

    public static bool operator !=(VoteValue value1, string value2) => !value1.Value.Equals(value2);

    public static explicit operator string(VoteValue value) => value.Value;

    public static explicit operator VoteValue(string value) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string Upvote = "UPVOTE";

        public const string Downvote = "DOWNVOTE";
    }
}
