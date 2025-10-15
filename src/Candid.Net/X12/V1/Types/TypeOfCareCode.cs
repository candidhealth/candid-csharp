using System.Text.Json.Serialization;
using Candid.Net.Core;

namespace Candid.Net.X12.V1;

[JsonConverter(typeof(StringEnumSerializer<TypeOfCareCode>))]
[Serializable]
public readonly record struct TypeOfCareCode : IStringEnum
{
    /// <summary>
    /// Except Clinics & Special Facilities - Inpatient Part A; Clinics Only - Rural Health Center (RHC); Special Facilities Only - Hospice (non-hospital based)
    /// </summary>
    public static readonly TypeOfCareCode C1 = new(Values.C1);

    /// <summary>
    /// Except Clinics & Special Facilities - Inpatient (Part B) (includes Home Health Agency (HHA) visits under a Part B plan of treatment); Clinics Only - Hospital based or Independent Renal Dialysis Center; Special Facilities Only - Hospice (hospital based)
    /// </summary>
    public static readonly TypeOfCareCode C2 = new(Values.C2);

    /// <summary>
    /// Except Clinics & Special Facilities - Outpatient (includes HHA visits under a Part A plan of treatment and use of HHA DME under a Part A plan of treatment); Special Facilities Only - ASC Services to Hospital Outpatients
    /// </summary>
    public static readonly TypeOfCareCode C3 = new(Values.C3);

    /// <summary>
    /// Except Clinics & Special Facilities - Other (Part B) (includes HHA medical and other health services not under a plan of treatment, SNF diagnostic clinical laboratory services for 'nonpatients,' and referenced diagnostic services); Clinics Only - Other Rehabilitation Facility (ORF); Special Facilities Only - Free Standing Birthing Center
    /// </summary>
    public static readonly TypeOfCareCode C4 = new(Values.C4);

    /// <summary>
    /// Except Clinics & Special Facilities - Intermediate Care - Level I; Clinics Only - Comprehensive Outpatient Rehabilitation Facility (CORF); Special Facilities Only - CAH
    /// </summary>
    public static readonly TypeOfCareCode C5 = new(Values.C5);

    /// <summary>
    /// Except Clinics & Special Facilities - Intermediate Care - Level II; Clinics Only - Community Mental Health Center (CMHC); Special Facilities Only - Residential Facility (not used for Medicare)
    /// </summary>
    public static readonly TypeOfCareCode C6 = new(Values.C6);

    /// <summary>
    /// Except Clinics & Special Facilities - Subacute Inpatient (Revenue Code 019X required) Eight Swing Beds (used to indicate billing for SNF level of care in a hospital with an approved swing bed agreement.); Clinics Only - Free-standing Provider-based Federally Qualified Health Center (FQHC); Special Facilities Only - Reserved for National Assignment
    /// </summary>
    public static readonly TypeOfCareCode C7 = new(Values.C7);

    /// <summary>
    /// Except Clinics & Special Facilities - NA; Clinics Only - Reserved for National Assignment; Special Facilities Only - Reserved for National Assignment
    /// </summary>
    public static readonly TypeOfCareCode C8 = new(Values.C8);

    /// <summary>
    /// Except Clinics & Special Facilities - Reserved for National Assignment; Clinics Only - Other; Special Facilities Only - Other
    /// </summary>
    public static readonly TypeOfCareCode C9 = new(Values.C9);

    public TypeOfCareCode(string value)
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
    public static TypeOfCareCode FromCustom(string value)
    {
        return new TypeOfCareCode(value);
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

    public static bool operator ==(TypeOfCareCode value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(TypeOfCareCode value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(TypeOfCareCode value) => value.Value;

    public static explicit operator TypeOfCareCode(string value) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        /// <summary>
        /// Except Clinics & Special Facilities - Inpatient Part A; Clinics Only - Rural Health Center (RHC); Special Facilities Only - Hospice (non-hospital based)
        /// </summary>
        public const string C1 = "1";

        /// <summary>
        /// Except Clinics & Special Facilities - Inpatient (Part B) (includes Home Health Agency (HHA) visits under a Part B plan of treatment); Clinics Only - Hospital based or Independent Renal Dialysis Center; Special Facilities Only - Hospice (hospital based)
        /// </summary>
        public const string C2 = "2";

        /// <summary>
        /// Except Clinics & Special Facilities - Outpatient (includes HHA visits under a Part A plan of treatment and use of HHA DME under a Part A plan of treatment); Special Facilities Only - ASC Services to Hospital Outpatients
        /// </summary>
        public const string C3 = "3";

        /// <summary>
        /// Except Clinics & Special Facilities - Other (Part B) (includes HHA medical and other health services not under a plan of treatment, SNF diagnostic clinical laboratory services for 'nonpatients,' and referenced diagnostic services); Clinics Only - Other Rehabilitation Facility (ORF); Special Facilities Only - Free Standing Birthing Center
        /// </summary>
        public const string C4 = "4";

        /// <summary>
        /// Except Clinics & Special Facilities - Intermediate Care - Level I; Clinics Only - Comprehensive Outpatient Rehabilitation Facility (CORF); Special Facilities Only - CAH
        /// </summary>
        public const string C5 = "5";

        /// <summary>
        /// Except Clinics & Special Facilities - Intermediate Care - Level II; Clinics Only - Community Mental Health Center (CMHC); Special Facilities Only - Residential Facility (not used for Medicare)
        /// </summary>
        public const string C6 = "6";

        /// <summary>
        /// Except Clinics & Special Facilities - Subacute Inpatient (Revenue Code 019X required) Eight Swing Beds (used to indicate billing for SNF level of care in a hospital with an approved swing bed agreement.); Clinics Only - Free-standing Provider-based Federally Qualified Health Center (FQHC); Special Facilities Only - Reserved for National Assignment
        /// </summary>
        public const string C7 = "7";

        /// <summary>
        /// Except Clinics & Special Facilities - NA; Clinics Only - Reserved for National Assignment; Special Facilities Only - Reserved for National Assignment
        /// </summary>
        public const string C8 = "8";

        /// <summary>
        /// Except Clinics & Special Facilities - Reserved for National Assignment; Clinics Only - Other; Special Facilities Only - Other
        /// </summary>
        public const string C9 = "9";
    }
}
