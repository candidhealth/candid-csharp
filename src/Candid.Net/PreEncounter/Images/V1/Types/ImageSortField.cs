using System.Text.Json.Serialization;
using Candid.Net.Core;

namespace Candid.Net.PreEncounter.Images.V1;

[JsonConverter(typeof(StringEnumSerializer<ImageSortField>))]
[Serializable]
public readonly record struct ImageSortField : IStringEnum
{
    public static readonly ImageSortField UpdatedAt = new(Values.UpdatedAt);

    public static readonly ImageSortField FileName = new(Values.FileName);

    public static readonly ImageSortField DisplayName = new(Values.DisplayName);

    public static readonly ImageSortField FileType = new(Values.FileType);

    public static readonly ImageSortField Status = new(Values.Status);

    public ImageSortField(string value)
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
    public static ImageSortField FromCustom(string value)
    {
        return new ImageSortField(value);
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

    public static bool operator ==(ImageSortField value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(ImageSortField value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(ImageSortField value) => value.Value;

    public static explicit operator ImageSortField(string value) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string UpdatedAt = "updatedAt";

        public const string FileName = "fileName";

        public const string DisplayName = "displayName";

        public const string FileType = "fileType";

        public const string Status = "status";
    }
}
