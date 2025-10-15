using System.Text.Json.Serialization;
using Candid.Net.Core;

namespace Candid.Net.WriteOffs.V1;

[JsonConverter(typeof(StringEnumSerializer<WriteOffSortField>))]
[Serializable]
public readonly record struct WriteOffSortField : IStringEnum
{
    public static readonly WriteOffSortField AmountCents = new(Values.AmountCents);

    public static readonly WriteOffSortField WriteOffTimestamp = new(Values.WriteOffTimestamp);

    public static readonly WriteOffSortField WriteOffNote = new(Values.WriteOffNote);

    public WriteOffSortField(string value)
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
    public static WriteOffSortField FromCustom(string value)
    {
        return new WriteOffSortField(value);
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

    public static bool operator ==(WriteOffSortField value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(WriteOffSortField value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(WriteOffSortField value) => value.Value;

    public static explicit operator WriteOffSortField(string value) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string AmountCents = "amount_cents";

        public const string WriteOffTimestamp = "write_off_timestamp";

        public const string WriteOffNote = "write_off_note";
    }
}
