using System.Text.Json.Serialization;
using Candid.Net.Core;

namespace Candid.Net.EncounterAttachments.V1;

[JsonConverter(typeof(StringEnumSerializer<EncounterAttachmentType>))]
[Serializable]
public readonly record struct EncounterAttachmentType : IStringEnum
{
    public static readonly EncounterAttachmentType Documentation = new(Values.Documentation);

    public static readonly EncounterAttachmentType Eob = new(Values.Eob);

    public static readonly EncounterAttachmentType Other = new(Values.Other);

    public EncounterAttachmentType(string value)
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
    public static EncounterAttachmentType FromCustom(string value)
    {
        return new EncounterAttachmentType(value);
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

    public static bool operator ==(EncounterAttachmentType value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(EncounterAttachmentType value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(EncounterAttachmentType value) => value.Value;

    public static explicit operator EncounterAttachmentType(string value) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string Documentation = "DOCUMENTATION";

        public const string Eob = "EOB";

        public const string Other = "OTHER";
    }
}
