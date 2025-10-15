using System.Text.Json.Serialization;
using Candid.Net.Core;

namespace Candid.Net.PreEncounter.Coverages.V1;

[JsonConverter(typeof(StringEnumSerializer<BenefitType>))]
[Serializable]
public readonly record struct BenefitType : IStringEnum
{
    public static readonly BenefitType Deductible = new(Values.Deductible);

    public static readonly BenefitType DeductibleContract = new(Values.DeductibleContract);

    public static readonly BenefitType DeductibleRemaining = new(Values.DeductibleRemaining);

    public static readonly BenefitType DeductibleYearToDate = new(Values.DeductibleYearToDate);

    public static readonly BenefitType OopMax = new(Values.OopMax);

    public static readonly BenefitType OopMaxContract = new(Values.OopMaxContract);

    public static readonly BenefitType OopMaxRemaining = new(Values.OopMaxRemaining);

    public static readonly BenefitType OopMaxYearToDate = new(Values.OopMaxYearToDate);

    public static readonly BenefitType Copay = new(Values.Copay);

    public static readonly BenefitType Coinsurance = new(Values.Coinsurance);

    public BenefitType(string value)
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
    public static BenefitType FromCustom(string value)
    {
        return new BenefitType(value);
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

    public static bool operator ==(BenefitType value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(BenefitType value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(BenefitType value) => value.Value;

    public static explicit operator BenefitType(string value) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string Deductible = "DEDUCTIBLE";

        public const string DeductibleContract = "DEDUCTIBLE_CONTRACT";

        public const string DeductibleRemaining = "DEDUCTIBLE_REMAINING";

        public const string DeductibleYearToDate = "DEDUCTIBLE_YEAR_TO_DATE";

        public const string OopMax = "OOP_MAX";

        public const string OopMaxContract = "OOP_MAX_CONTRACT";

        public const string OopMaxRemaining = "OOP_MAX_REMAINING";

        public const string OopMaxYearToDate = "OOP_MAX_YEAR_TO_DATE";

        public const string Copay = "COPAY";

        public const string Coinsurance = "COINSURANCE";
    }
}
