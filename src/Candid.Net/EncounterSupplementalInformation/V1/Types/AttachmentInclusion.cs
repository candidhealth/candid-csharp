using System.Text.Json.Serialization;
using Candid.Net.Core;

namespace Candid.Net.EncounterSupplementalInformation.V1;

[JsonConverter(typeof(StringEnumSerializer<AttachmentInclusion>))]
[Serializable]
public readonly record struct AttachmentInclusion : IStringEnum
{
    public static readonly AttachmentInclusion NotIncluded = new(Values.NotIncluded);

    public static readonly AttachmentInclusion IncludedOnNextSubmission = new(
        Values.IncludedOnNextSubmission
    );

    public static readonly AttachmentInclusion IncludedOnAllSubmissions = new(
        Values.IncludedOnAllSubmissions
    );

    public AttachmentInclusion(string value)
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
    public static AttachmentInclusion FromCustom(string value)
    {
        return new AttachmentInclusion(value);
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

    public static bool operator ==(AttachmentInclusion value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(AttachmentInclusion value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(AttachmentInclusion value) => value.Value;

    public static explicit operator AttachmentInclusion(string value) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string NotIncluded = "not_included";

        public const string IncludedOnNextSubmission = "included_on_next_submission";

        public const string IncludedOnAllSubmissions = "included_on_all_submissions";
    }
}
