using System.Text.Json.Serialization;
using Candid.Net.Core;

namespace Candid.Net.Tags;

[JsonConverter(typeof(StringEnumSerializer<TagColorEnum>))]
[Serializable]
public readonly record struct TagColorEnum : IStringEnum
{
    public static readonly TagColorEnum Black = new(Values.Black);

    public static readonly TagColorEnum White = new(Values.White);

    public static readonly TagColorEnum Gray = new(Values.Gray);

    public static readonly TagColorEnum Red = new(Values.Red);

    public static readonly TagColorEnum Yellow = new(Values.Yellow);

    public static readonly TagColorEnum Green = new(Values.Green);

    public static readonly TagColorEnum Blue = new(Values.Blue);

    public static readonly TagColorEnum Indigo = new(Values.Indigo);

    public static readonly TagColorEnum Purple = new(Values.Purple);

    public static readonly TagColorEnum Pink = new(Values.Pink);

    public TagColorEnum(string value)
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
    public static TagColorEnum FromCustom(string value)
    {
        return new TagColorEnum(value);
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

    public static bool operator ==(TagColorEnum value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(TagColorEnum value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(TagColorEnum value) => value.Value;

    public static explicit operator TagColorEnum(string value) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string Black = "black";

        public const string White = "white";

        public const string Gray = "gray";

        public const string Red = "red";

        public const string Yellow = "yellow";

        public const string Green = "green";

        public const string Blue = "blue";

        public const string Indigo = "indigo";

        public const string Purple = "purple";

        public const string Pink = "pink";
    }
}
