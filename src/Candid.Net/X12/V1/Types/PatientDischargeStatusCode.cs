using System.Text.Json.Serialization;
using Candid.Net.Core;

namespace Candid.Net.X12.V1;

[JsonConverter(typeof(StringEnumSerializer<PatientDischargeStatusCode>))]
[Serializable]
public readonly record struct PatientDischargeStatusCode : IStringEnum
{
    /// <summary>
    /// DISCHARGED TO HOME OR SELF CARE (ROUTINE DISCHARGE)
    /// </summary>
    public static readonly PatientDischargeStatusCode C01 = new(Values.C01);

    /// <summary>
    /// DISCHARGED/TRANSFERRED TO A SHORT-TERM GENERAL HOSPITAL FOR INPATIENT CARE
    /// </summary>
    public static readonly PatientDischargeStatusCode C02 = new(Values.C02);

    /// <summary>
    /// DISCHARGED/TRANSFERRED TO SKILLED NURSING FACILITY (SNF) WITH MEDICARE CERTIFICATION IN ANTICIPATION OF SKILLED CARE
    /// </summary>
    public static readonly PatientDischargeStatusCode C03 = new(Values.C03);

    /// <summary>
    /// DISCHARGED/TRANSFERRED TO A FACILITY THAT PROVIDES CUSTODIAL OR SUPPORTIVE CARE
    /// </summary>
    public static readonly PatientDischargeStatusCode C04 = new(Values.C04);

    /// <summary>
    /// DISCHARGED/TRANSFERRED TO A DESIGNATED CANCER CENTER OR CHILDREN'S HOSPITAL
    /// </summary>
    public static readonly PatientDischargeStatusCode C05 = new(Values.C05);

    /// <summary>
    /// DISCHARGED/TRANSFERRED TO HOME UNDER CARE OF AN ORGANIZED HOME HEALTH SERVICE ORGANIZATION IN ANTICIPATION OF COVERED SKILLED CARE
    /// </summary>
    public static readonly PatientDischargeStatusCode C06 = new(Values.C06);

    /// <summary>
    /// LEFT AGAINST MEDICAL ADVICE OR DISCONTINUED CARE
    /// </summary>
    public static readonly PatientDischargeStatusCode C07 = new(Values.C07);

    /// <summary>
    /// ADMITTED AS AN INPATIENT TO THIS HOSPITAL
    /// </summary>
    public static readonly PatientDischargeStatusCode C09 = new(Values.C09);

    /// <summary>
    /// EXPIRED(A)
    /// </summary>
    public static readonly PatientDischargeStatusCode C20 = new(Values.C20);

    /// <summary>
    /// DISCHARGED/TRANSFERRED TO COURT/LAW ENFORCEMENT
    /// </summary>
    public static readonly PatientDischargeStatusCode C21 = new(Values.C21);

    /// <summary>
    /// STILL PATIENT
    /// </summary>
    public static readonly PatientDischargeStatusCode C30 = new(Values.C30);

    /// <summary>
    /// EXPIRED AT HOME(A)
    /// </summary>
    public static readonly PatientDischargeStatusCode C40 = new(Values.C40);

    /// <summary>
    /// EXPIRED IN A MEDICAL FACILITY A) (E.G. HOSPITAL, SNF, ICF, OR FREE STANDING HOSPICE)
    /// </summary>
    public static readonly PatientDischargeStatusCode C41 = new(Values.C41);

    /// <summary>
    /// EXPIRED - PLACE UNKNOWN A)
    /// </summary>
    public static readonly PatientDischargeStatusCode C42 = new(Values.C42);

    /// <summary>
    /// DISCHARGED/TRANSFERRED TO A FEDERAL HEALTH CARE FACILITY
    /// </summary>
    public static readonly PatientDischargeStatusCode C43 = new(Values.C43);

    /// <summary>
    /// HOSPICE - HOME
    /// </summary>
    public static readonly PatientDischargeStatusCode C50 = new(Values.C50);

    /// <summary>
    /// HOSPICE - MEDICAL FACILITY (CERTIFIED) PROVIDING HOSPICE LEVEL OF CARE
    /// </summary>
    public static readonly PatientDischargeStatusCode C51 = new(Values.C51);

    /// <summary>
    /// DISCHARGED/TRANSFERRED TO A HOSPITAL-BASED MEDICARE APPROVED SWING BED
    /// </summary>
    public static readonly PatientDischargeStatusCode C61 = new(Values.C61);

    /// <summary>
    /// DISCHARGED/TRANSFERRED TO AN INPATIENT REHABILITATION FACILITY (IRF) INCLUDING REHABILITATION DISTINCT PART UNITS OF A HOSPITAL
    /// </summary>
    public static readonly PatientDischargeStatusCode C62 = new(Values.C62);

    /// <summary>
    /// DISCHARGED/TRANSFERRED TO A MEDICARE CERTIFIED LONG TERM CARE HOSPITAL (LTCH)
    /// </summary>
    public static readonly PatientDischargeStatusCode C63 = new(Values.C63);

    /// <summary>
    /// DISCHARGED/TRANSFERRED TO A NURSING FACILITY CERTIFIED UNDER MEDICAID BUT NOT CERTIFIED UNDER MEDICARE
    /// </summary>
    public static readonly PatientDischargeStatusCode C64 = new(Values.C64);

    /// <summary>
    /// DISCHARGED/TRANSFERRED TO A PSYCHIATRIC HOSPITAL OR PSYCHIATRIC DISTINCT PART UNIT OF A HOSPITAL
    /// </summary>
    public static readonly PatientDischargeStatusCode C65 = new(Values.C65);

    /// <summary>
    /// DISCHARGED/TRANSFERRED TO A CRITICAL ACCESS HOSPITAL (CAH)
    /// </summary>
    public static readonly PatientDischargeStatusCode C66 = new(Values.C66);

    /// <summary>
    /// DISCHARGED/TRANSFERRED TO A DESIGNATED DISASTER ALTERNATE CARE SITE (EFFECTIVE 10/1/13)
    /// </summary>
    public static readonly PatientDischargeStatusCode C69 = new(Values.C69);

    /// <summary>
    /// DISCHARGED/TRANSFERRED TO ANOTHER TYPE OF HEALTH CARE INSTITUTION NOT DEFINED ELSEWHERE IN THIS CODE LIST
    /// </summary>
    public static readonly PatientDischargeStatusCode C70 = new(Values.C70);

    /// <summary>
    /// DISCHARGED TO HOME OR SELF CARE WITH A PLANNED ACUTE CARE HOSPITAL INPATIENT READMISSION (EFFECTIVE 10/1/13)
    /// </summary>
    public static readonly PatientDischargeStatusCode C81 = new(Values.C81);

    /// <summary>
    /// DISCHARGED/TRANSFERRED TO A SHORT TERM GENERAL HOSPITAL FOR INPATIENT CARE WITH A PLANNED ACUTE CARE HOSPITAL INPATIENT READMISSION (EFFECTIVE 10/1/13)
    /// </summary>
    public static readonly PatientDischargeStatusCode C82 = new(Values.C82);

    /// <summary>
    /// DISCHARGED/TRANSFERRED TO A SKILLED NURSING FACILITY (SNF) WITH MEDICARE CERTIFICATION WITH A PLANNED ACUTE CARE HOSPITAL INPATIENT READMISSION (EFFECTIVE 10/1/13)
    /// </summary>
    public static readonly PatientDischargeStatusCode C83 = new(Values.C83);

    /// <summary>
    /// DISCHARGED/TRANSFERRED TO A FACILITY THAT PROVIDES CUSTODIAL OR SUPPORTIVE CARE WITH A PLANNED ACUTE CARE HOSPITAL INPATIENT READMISSION (EFFECTIVE 10/1/13)
    /// </summary>
    public static readonly PatientDischargeStatusCode C84 = new(Values.C84);

    /// <summary>
    /// DISCHARGED/TRANSFERRED TO A DESIGNATED CANCER CENTER OR CHILDREN'S HOSPITAL WITH A PLANNED ACUTE CARE HOSPITAL INPATIENT READMISSION (EFFECTIVE 10/1/13)
    /// </summary>
    public static readonly PatientDischargeStatusCode C85 = new(Values.C85);

    /// <summary>
    /// DISCHARGED/TRANSFERRED TO HOME UNDER CARE OF ORGANIZED HOME HEALTH SERVICE ORGANIZATION IN ANTICIPATION OF COVERED SKILLED CARE WITH A PLANNED ACUTE CARE HOSPITAL INPATIENT READMISSION (EFFECTIVE 10/1/13)
    /// </summary>
    public static readonly PatientDischargeStatusCode C86 = new(Values.C86);

    /// <summary>
    /// DISCHARGED/TRANSFERRED TO COURT/LAW ENFORCEMENT WITH A PLANNED ACUTE CARE HOSPITAL INPATIENT READMISSION (EFFECTIVE 10/1/13)
    /// </summary>
    public static readonly PatientDischargeStatusCode C87 = new(Values.C87);

    /// <summary>
    /// DISCHARGED/TRANSFERRED TO A FEDERAL HEALTH CARE FACILITY WITH A PLANNED ACUTE CARE HOSPITAL INPATIENT READMISSION (EFFECTIVE 10/1/13)
    /// </summary>
    public static readonly PatientDischargeStatusCode C88 = new(Values.C88);

    /// <summary>
    /// DISCHARGED/TRANSFERRED TO A HOSPITAL-BASED MEDICARE APPROVED SWING BED WITH A PLANNED ACUTE CARE HOSPITAL INPATIENT READMISSION (EFFECTIVE 10/1/13)
    /// </summary>
    public static readonly PatientDischargeStatusCode C89 = new(Values.C89);

    /// <summary>
    /// DISCHARGED/TRANSFERRED TO AN INPATIENT REHABILITATION FACILITY (IRF) INCLUDING REHABILITATION DISTINCT PART UNITS OF A HOSPITAL WITH A PLANNED ACUTE CARE HOSPITAL INPATIENT READMISSION (EFFECTIVE 10/1/13)
    /// </summary>
    public static readonly PatientDischargeStatusCode C90 = new(Values.C90);

    /// <summary>
    /// DISCHARGED/TRANSFERRED TO A MEDICARE CERTIFIED LONG TERM CARE HOSPITAL (LTCH) WITH A PLANNED ACUTE CARE HOSPITAL INPATIENT READMISSION (EFFECTIVE 10/1/13)
    /// </summary>
    public static readonly PatientDischargeStatusCode C91 = new(Values.C91);

    /// <summary>
    /// DISCHARGED/TRANSFERRED TO A NURSING FACILITY CERTIFIED UNDER MEDICAID BUT NOT CERTIFIED UNDER MEDICARE WITH A PLANNED ACUTE CARE HOSPITAL INPATIENT READMISSION (EFFECTIVE 10/1/13)
    /// </summary>
    public static readonly PatientDischargeStatusCode C92 = new(Values.C92);

    /// <summary>
    /// DISCHARGED/TRANSFERRED TO A PSYCHIATRIC HOSPITAL OR PSYCHIATRIC DISTINCT PART UNIT OF A HOSPITAL WITH A PLANNED ACUTE CARE HOSPITAL INPATIENT READMISSION (EFFECTIVE 10/1/13)
    /// </summary>
    public static readonly PatientDischargeStatusCode C93 = new(Values.C93);

    /// <summary>
    /// DISCHARGED/TRANSFERRED TO A CRITICAL ACCESS HOSPITAL (CAH) WITH A PLANNED ACUTE CARE HOSPITAL INPATIENT READMISSION (EFFECTIVE 10/1/13)
    /// </summary>
    public static readonly PatientDischargeStatusCode C94 = new(Values.C94);

    /// <summary>
    /// DISCHARGED/TRANSFERRED TO ANOTHER TYPE OF HEALTH CARE INSTITUTION NOT DEFINED ELSEWHERE IN THIS CODE LIST WITH A PLANNED ACUTE CARE HOSPITAL INPATIENT READMISSION (EFFECTIVE 10/1/13)
    /// </summary>
    public static readonly PatientDischargeStatusCode C95 = new(Values.C95);

    public PatientDischargeStatusCode(string value)
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
    public static PatientDischargeStatusCode FromCustom(string value)
    {
        return new PatientDischargeStatusCode(value);
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

    public static bool operator ==(PatientDischargeStatusCode value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(PatientDischargeStatusCode value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(PatientDischargeStatusCode value) => value.Value;

    public static explicit operator PatientDischargeStatusCode(string value) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        /// <summary>
        /// DISCHARGED TO HOME OR SELF CARE (ROUTINE DISCHARGE)
        /// </summary>
        public const string C01 = "01";

        /// <summary>
        /// DISCHARGED/TRANSFERRED TO A SHORT-TERM GENERAL HOSPITAL FOR INPATIENT CARE
        /// </summary>
        public const string C02 = "02";

        /// <summary>
        /// DISCHARGED/TRANSFERRED TO SKILLED NURSING FACILITY (SNF) WITH MEDICARE CERTIFICATION IN ANTICIPATION OF SKILLED CARE
        /// </summary>
        public const string C03 = "03";

        /// <summary>
        /// DISCHARGED/TRANSFERRED TO A FACILITY THAT PROVIDES CUSTODIAL OR SUPPORTIVE CARE
        /// </summary>
        public const string C04 = "04";

        /// <summary>
        /// DISCHARGED/TRANSFERRED TO A DESIGNATED CANCER CENTER OR CHILDREN'S HOSPITAL
        /// </summary>
        public const string C05 = "05";

        /// <summary>
        /// DISCHARGED/TRANSFERRED TO HOME UNDER CARE OF AN ORGANIZED HOME HEALTH SERVICE ORGANIZATION IN ANTICIPATION OF COVERED SKILLED CARE
        /// </summary>
        public const string C06 = "06";

        /// <summary>
        /// LEFT AGAINST MEDICAL ADVICE OR DISCONTINUED CARE
        /// </summary>
        public const string C07 = "07";

        /// <summary>
        /// ADMITTED AS AN INPATIENT TO THIS HOSPITAL
        /// </summary>
        public const string C09 = "09";

        /// <summary>
        /// EXPIRED(A)
        /// </summary>
        public const string C20 = "20";

        /// <summary>
        /// DISCHARGED/TRANSFERRED TO COURT/LAW ENFORCEMENT
        /// </summary>
        public const string C21 = "21";

        /// <summary>
        /// STILL PATIENT
        /// </summary>
        public const string C30 = "30";

        /// <summary>
        /// EXPIRED AT HOME(A)
        /// </summary>
        public const string C40 = "40";

        /// <summary>
        /// EXPIRED IN A MEDICAL FACILITY A) (E.G. HOSPITAL, SNF, ICF, OR FREE STANDING HOSPICE)
        /// </summary>
        public const string C41 = "41";

        /// <summary>
        /// EXPIRED - PLACE UNKNOWN A)
        /// </summary>
        public const string C42 = "42";

        /// <summary>
        /// DISCHARGED/TRANSFERRED TO A FEDERAL HEALTH CARE FACILITY
        /// </summary>
        public const string C43 = "43";

        /// <summary>
        /// HOSPICE - HOME
        /// </summary>
        public const string C50 = "50";

        /// <summary>
        /// HOSPICE - MEDICAL FACILITY (CERTIFIED) PROVIDING HOSPICE LEVEL OF CARE
        /// </summary>
        public const string C51 = "51";

        /// <summary>
        /// DISCHARGED/TRANSFERRED TO A HOSPITAL-BASED MEDICARE APPROVED SWING BED
        /// </summary>
        public const string C61 = "61";

        /// <summary>
        /// DISCHARGED/TRANSFERRED TO AN INPATIENT REHABILITATION FACILITY (IRF) INCLUDING REHABILITATION DISTINCT PART UNITS OF A HOSPITAL
        /// </summary>
        public const string C62 = "62";

        /// <summary>
        /// DISCHARGED/TRANSFERRED TO A MEDICARE CERTIFIED LONG TERM CARE HOSPITAL (LTCH)
        /// </summary>
        public const string C63 = "63";

        /// <summary>
        /// DISCHARGED/TRANSFERRED TO A NURSING FACILITY CERTIFIED UNDER MEDICAID BUT NOT CERTIFIED UNDER MEDICARE
        /// </summary>
        public const string C64 = "64";

        /// <summary>
        /// DISCHARGED/TRANSFERRED TO A PSYCHIATRIC HOSPITAL OR PSYCHIATRIC DISTINCT PART UNIT OF A HOSPITAL
        /// </summary>
        public const string C65 = "65";

        /// <summary>
        /// DISCHARGED/TRANSFERRED TO A CRITICAL ACCESS HOSPITAL (CAH)
        /// </summary>
        public const string C66 = "66";

        /// <summary>
        /// DISCHARGED/TRANSFERRED TO A DESIGNATED DISASTER ALTERNATE CARE SITE (EFFECTIVE 10/1/13)
        /// </summary>
        public const string C69 = "69";

        /// <summary>
        /// DISCHARGED/TRANSFERRED TO ANOTHER TYPE OF HEALTH CARE INSTITUTION NOT DEFINED ELSEWHERE IN THIS CODE LIST
        /// </summary>
        public const string C70 = "70";

        /// <summary>
        /// DISCHARGED TO HOME OR SELF CARE WITH A PLANNED ACUTE CARE HOSPITAL INPATIENT READMISSION (EFFECTIVE 10/1/13)
        /// </summary>
        public const string C81 = "81";

        /// <summary>
        /// DISCHARGED/TRANSFERRED TO A SHORT TERM GENERAL HOSPITAL FOR INPATIENT CARE WITH A PLANNED ACUTE CARE HOSPITAL INPATIENT READMISSION (EFFECTIVE 10/1/13)
        /// </summary>
        public const string C82 = "82";

        /// <summary>
        /// DISCHARGED/TRANSFERRED TO A SKILLED NURSING FACILITY (SNF) WITH MEDICARE CERTIFICATION WITH A PLANNED ACUTE CARE HOSPITAL INPATIENT READMISSION (EFFECTIVE 10/1/13)
        /// </summary>
        public const string C83 = "83";

        /// <summary>
        /// DISCHARGED/TRANSFERRED TO A FACILITY THAT PROVIDES CUSTODIAL OR SUPPORTIVE CARE WITH A PLANNED ACUTE CARE HOSPITAL INPATIENT READMISSION (EFFECTIVE 10/1/13)
        /// </summary>
        public const string C84 = "84";

        /// <summary>
        /// DISCHARGED/TRANSFERRED TO A DESIGNATED CANCER CENTER OR CHILDREN'S HOSPITAL WITH A PLANNED ACUTE CARE HOSPITAL INPATIENT READMISSION (EFFECTIVE 10/1/13)
        /// </summary>
        public const string C85 = "85";

        /// <summary>
        /// DISCHARGED/TRANSFERRED TO HOME UNDER CARE OF ORGANIZED HOME HEALTH SERVICE ORGANIZATION IN ANTICIPATION OF COVERED SKILLED CARE WITH A PLANNED ACUTE CARE HOSPITAL INPATIENT READMISSION (EFFECTIVE 10/1/13)
        /// </summary>
        public const string C86 = "86";

        /// <summary>
        /// DISCHARGED/TRANSFERRED TO COURT/LAW ENFORCEMENT WITH A PLANNED ACUTE CARE HOSPITAL INPATIENT READMISSION (EFFECTIVE 10/1/13)
        /// </summary>
        public const string C87 = "87";

        /// <summary>
        /// DISCHARGED/TRANSFERRED TO A FEDERAL HEALTH CARE FACILITY WITH A PLANNED ACUTE CARE HOSPITAL INPATIENT READMISSION (EFFECTIVE 10/1/13)
        /// </summary>
        public const string C88 = "88";

        /// <summary>
        /// DISCHARGED/TRANSFERRED TO A HOSPITAL-BASED MEDICARE APPROVED SWING BED WITH A PLANNED ACUTE CARE HOSPITAL INPATIENT READMISSION (EFFECTIVE 10/1/13)
        /// </summary>
        public const string C89 = "89";

        /// <summary>
        /// DISCHARGED/TRANSFERRED TO AN INPATIENT REHABILITATION FACILITY (IRF) INCLUDING REHABILITATION DISTINCT PART UNITS OF A HOSPITAL WITH A PLANNED ACUTE CARE HOSPITAL INPATIENT READMISSION (EFFECTIVE 10/1/13)
        /// </summary>
        public const string C90 = "90";

        /// <summary>
        /// DISCHARGED/TRANSFERRED TO A MEDICARE CERTIFIED LONG TERM CARE HOSPITAL (LTCH) WITH A PLANNED ACUTE CARE HOSPITAL INPATIENT READMISSION (EFFECTIVE 10/1/13)
        /// </summary>
        public const string C91 = "91";

        /// <summary>
        /// DISCHARGED/TRANSFERRED TO A NURSING FACILITY CERTIFIED UNDER MEDICAID BUT NOT CERTIFIED UNDER MEDICARE WITH A PLANNED ACUTE CARE HOSPITAL INPATIENT READMISSION (EFFECTIVE 10/1/13)
        /// </summary>
        public const string C92 = "92";

        /// <summary>
        /// DISCHARGED/TRANSFERRED TO A PSYCHIATRIC HOSPITAL OR PSYCHIATRIC DISTINCT PART UNIT OF A HOSPITAL WITH A PLANNED ACUTE CARE HOSPITAL INPATIENT READMISSION (EFFECTIVE 10/1/13)
        /// </summary>
        public const string C93 = "93";

        /// <summary>
        /// DISCHARGED/TRANSFERRED TO A CRITICAL ACCESS HOSPITAL (CAH) WITH A PLANNED ACUTE CARE HOSPITAL INPATIENT READMISSION (EFFECTIVE 10/1/13)
        /// </summary>
        public const string C94 = "94";

        /// <summary>
        /// DISCHARGED/TRANSFERRED TO ANOTHER TYPE OF HEALTH CARE INSTITUTION NOT DEFINED ELSEWHERE IN THIS CODE LIST WITH A PLANNED ACUTE CARE HOSPITAL INPATIENT READMISSION (EFFECTIVE 10/1/13)
        /// </summary>
        public const string C95 = "95";
    }
}
