using System.Text.Json.Serialization;
using Candid.Net.Core;

namespace Candid.Net.PreEncounter.Images.V1;

[JsonConverter(typeof(StringEnumSerializer<ImageStatus>))]
[Serializable]
public readonly record struct ImageStatus : IStringEnum
{
    public static readonly ImageStatus Pending = new(Values.Pending);

    public static readonly ImageStatus Uploaded = new(Values.Uploaded);

    public static readonly ImageStatus Failed = new(Values.Failed);

    public ImageStatus(string value)
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
    public static ImageStatus FromCustom(string value)
    {
        return new ImageStatus(value);
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

    public static bool operator ==(ImageStatus value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(ImageStatus value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(ImageStatus value) => value.Value;

    public static explicit operator ImageStatus(string value) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string Pending = "PENDING";

        public const string Uploaded = "UPLOADED";

        public const string Failed = "FAILED";
    }
}
