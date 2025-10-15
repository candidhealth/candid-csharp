using System.Text.Json.Serialization;
using Candid.Net.Core;

namespace Candid.Net.HealthCareCodeInformation.V1;

[JsonConverter(typeof(StringEnumSerializer<OccurrenceSpanCode>))]
[Serializable]
public readonly record struct OccurrenceSpanCode : IStringEnum
{
    /// <summary>
    /// QUALIFYING STAY DATES FOR SNF USE ONLY
    /// </summary>
    public static readonly OccurrenceSpanCode C70 = new(Values.C70);

    /// <summary>
    /// PRIOR STAY DATES
    /// </summary>
    public static readonly OccurrenceSpanCode C71 = new(Values.C71);

    /// <summary>
    /// FIRST/LAST VISIT DATES
    /// </summary>
    public static readonly OccurrenceSpanCode C72 = new(Values.C72);

    /// <summary>
    /// BENEFIT ELIGIBILITY PERIOD
    /// </summary>
    public static readonly OccurrenceSpanCode C73 = new(Values.C73);

    /// <summary>
    /// NON-COVERED LEVEL OF CARE/LEAVE OF ABSENCE DATES
    /// </summary>
    public static readonly OccurrenceSpanCode C74 = new(Values.C74);

    /// <summary>
    /// SNF LEVEL OF CARE DATES
    /// </summary>
    public static readonly OccurrenceSpanCode C75 = new(Values.C75);

    /// <summary>
    /// PATIENT LIABILITY
    /// </summary>
    public static readonly OccurrenceSpanCode C76 = new(Values.C76);

    /// <summary>
    /// PROVIDER LIABILITY PERIOD
    /// </summary>
    public static readonly OccurrenceSpanCode C77 = new(Values.C77);

    /// <summary>
    /// SNF PROIR STAY DATES
    /// </summary>
    public static readonly OccurrenceSpanCode C78 = new(Values.C78);

    /// <summary>
    /// PRIOR SAME-SNF STAY DATES FOR PAYMENT BAN PRUPOSES
    /// </summary>
    public static readonly OccurrenceSpanCode C80 = new(Values.C80);

    /// <summary>
    /// ANTEPARTUM DAYS AT REDUCED LEVEL OF CARE
    /// </summary>
    public static readonly OccurrenceSpanCode C81 = new(Values.C81);

    /// <summary>
    /// HOSPITAL AT HOME CARE DATES
    /// </summary>
    public static readonly OccurrenceSpanCode C82 = new(Values.C82);

    /// <summary>
    /// QIO/UR APPROVED STAY DATES - The first and last days that were approved where not all of the stay was approved. (Use when Condition Code C3 is used in Form Locators 18-28.)
    /// </summary>
    public static readonly OccurrenceSpanCode Cm0 = new(Values.Cm0);

    /// <summary>
    /// PROVIDER LIABILITY - NO UTILIZATION - Code indicates the from/through dates of a period of noncovered care that is denied due to lack of medical necessity or as custodial care for which the provider is liable. The beneficiary is not charged with utilization. The provider may not collect Part A or Part B deductible or coinsurance from the beneficiary.
    /// </summary>
    public static readonly OccurrenceSpanCode Cm1 = new(Values.Cm1);

    /// <summary>
    /// INPATIENT RESPITE DATES - The from/through dates of a period of inpatient respite care.
    /// </summary>
    public static readonly OccurrenceSpanCode Cm2 = new(Values.Cm2);

    /// <summary>
    /// ICF LEVEL OF CARE - The from/through dates of a period of intermediate level of care during an inpatient hospital stay.
    /// </summary>
    public static readonly OccurrenceSpanCode Cm3 = new(Values.Cm3);

    /// <summary>
    /// RESIDENTIAL LEVEL OF CARE - The from/through dates of a period of residential level of care during an inpatient hospital stay.
    /// </summary>
    public static readonly OccurrenceSpanCode Cm4 = new(Values.Cm4);

    public OccurrenceSpanCode(string value)
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
    public static OccurrenceSpanCode FromCustom(string value)
    {
        return new OccurrenceSpanCode(value);
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

    public static bool operator ==(OccurrenceSpanCode value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(OccurrenceSpanCode value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(OccurrenceSpanCode value) => value.Value;

    public static explicit operator OccurrenceSpanCode(string value) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        /// <summary>
        /// QUALIFYING STAY DATES FOR SNF USE ONLY
        /// </summary>
        public const string C70 = "70";

        /// <summary>
        /// PRIOR STAY DATES
        /// </summary>
        public const string C71 = "71";

        /// <summary>
        /// FIRST/LAST VISIT DATES
        /// </summary>
        public const string C72 = "72";

        /// <summary>
        /// BENEFIT ELIGIBILITY PERIOD
        /// </summary>
        public const string C73 = "73";

        /// <summary>
        /// NON-COVERED LEVEL OF CARE/LEAVE OF ABSENCE DATES
        /// </summary>
        public const string C74 = "74";

        /// <summary>
        /// SNF LEVEL OF CARE DATES
        /// </summary>
        public const string C75 = "75";

        /// <summary>
        /// PATIENT LIABILITY
        /// </summary>
        public const string C76 = "76";

        /// <summary>
        /// PROVIDER LIABILITY PERIOD
        /// </summary>
        public const string C77 = "77";

        /// <summary>
        /// SNF PROIR STAY DATES
        /// </summary>
        public const string C78 = "78";

        /// <summary>
        /// PRIOR SAME-SNF STAY DATES FOR PAYMENT BAN PRUPOSES
        /// </summary>
        public const string C80 = "80";

        /// <summary>
        /// ANTEPARTUM DAYS AT REDUCED LEVEL OF CARE
        /// </summary>
        public const string C81 = "81";

        /// <summary>
        /// HOSPITAL AT HOME CARE DATES
        /// </summary>
        public const string C82 = "82";

        /// <summary>
        /// QIO/UR APPROVED STAY DATES - The first and last days that were approved where not all of the stay was approved. (Use when Condition Code C3 is used in Form Locators 18-28.)
        /// </summary>
        public const string Cm0 = "M0";

        /// <summary>
        /// PROVIDER LIABILITY - NO UTILIZATION - Code indicates the from/through dates of a period of noncovered care that is denied due to lack of medical necessity or as custodial care for which the provider is liable. The beneficiary is not charged with utilization. The provider may not collect Part A or Part B deductible or coinsurance from the beneficiary.
        /// </summary>
        public const string Cm1 = "M1";

        /// <summary>
        /// INPATIENT RESPITE DATES - The from/through dates of a period of inpatient respite care.
        /// </summary>
        public const string Cm2 = "M2";

        /// <summary>
        /// ICF LEVEL OF CARE - The from/through dates of a period of intermediate level of care during an inpatient hospital stay.
        /// </summary>
        public const string Cm3 = "M3";

        /// <summary>
        /// RESIDENTIAL LEVEL OF CARE - The from/through dates of a period of residential level of care during an inpatient hospital stay.
        /// </summary>
        public const string Cm4 = "M4";
    }
}
