using System.Text.Json.Serialization;
using Candid.Net.Core;

namespace Candid.Net.ClinicalTrials.V1;

[JsonConverter(typeof(StringEnumSerializer<ClinicalTrialPhase>))]
[Serializable]
public readonly record struct ClinicalTrialPhase : IStringEnum
{
    public static readonly ClinicalTrialPhase PhaseOne = new(Values.PhaseOne);

    public static readonly ClinicalTrialPhase PhaseTwo = new(Values.PhaseTwo);

    public static readonly ClinicalTrialPhase PhaseThree = new(Values.PhaseThree);

    public ClinicalTrialPhase(string value)
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
    public static ClinicalTrialPhase FromCustom(string value)
    {
        return new ClinicalTrialPhase(value);
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

    public static bool operator ==(ClinicalTrialPhase value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(ClinicalTrialPhase value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(ClinicalTrialPhase value) => value.Value;

    public static explicit operator ClinicalTrialPhase(string value) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string PhaseOne = "Phase 1";

        public const string PhaseTwo = "Phase 2";

        public const string PhaseThree = "Phase 3";
    }
}
