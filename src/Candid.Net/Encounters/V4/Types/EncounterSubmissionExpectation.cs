using System.Text.Json.Serialization;
using Candid.Net.Core;

namespace Candid.Net.Encounters.V4;

[JsonConverter(typeof(StringEnumSerializer<EncounterSubmissionExpectation>))]
[Serializable]
public readonly record struct EncounterSubmissionExpectation : IStringEnum
{
    /// <summary>
    /// Treat this encounter as a potential professional claim submission and validate it as such.
    /// </summary>
    public static readonly EncounterSubmissionExpectation TargetProfessional = new(
        Values.TargetProfessional
    );

    /// <summary>
    /// Treat this encounter as a potential institutional claim submission and validate it as such.
    /// </summary>
    public static readonly EncounterSubmissionExpectation TargetInstitutional = new(
        Values.TargetInstitutional
    );

    public EncounterSubmissionExpectation(string value)
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
    public static EncounterSubmissionExpectation FromCustom(string value)
    {
        return new EncounterSubmissionExpectation(value);
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

    public static bool operator ==(EncounterSubmissionExpectation value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(EncounterSubmissionExpectation value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(EncounterSubmissionExpectation value) => value.Value;

    public static explicit operator EncounterSubmissionExpectation(string value) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        /// <summary>
        /// Treat this encounter as a potential professional claim submission and validate it as such.
        /// </summary>
        public const string TargetProfessional = "TARGET_PROFESSIONAL";

        /// <summary>
        /// Treat this encounter as a potential institutional claim submission and validate it as such.
        /// </summary>
        public const string TargetInstitutional = "TARGET_INSTITUTIONAL";
    }
}
