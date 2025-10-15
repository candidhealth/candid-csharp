using System.Text.Json.Serialization;
using Candid.Net.Core;

namespace Candid.Net.Encounters.V4;

[JsonConverter(typeof(StringEnumSerializer<EncounterSortOptions>))]
[Serializable]
public readonly record struct EncounterSortOptions : IStringEnum
{
    public static readonly EncounterSortOptions CreatedAtAsc = new(Values.CreatedAtAsc);

    public static readonly EncounterSortOptions CreatedAtDesc = new(Values.CreatedAtDesc);

    public static readonly EncounterSortOptions DateOfServiceAsc = new(Values.DateOfServiceAsc);

    public static readonly EncounterSortOptions DateOfServiceDesc = new(Values.DateOfServiceDesc);

    public EncounterSortOptions(string value)
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
    public static EncounterSortOptions FromCustom(string value)
    {
        return new EncounterSortOptions(value);
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

    public static bool operator ==(EncounterSortOptions value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(EncounterSortOptions value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(EncounterSortOptions value) => value.Value;

    public static explicit operator EncounterSortOptions(string value) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string CreatedAtAsc = "created_at:asc";

        public const string CreatedAtDesc = "created_at:desc";

        public const string DateOfServiceAsc = "date_of_service:asc";

        public const string DateOfServiceDesc = "date_of_service:desc";
    }
}
