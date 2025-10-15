using System.Text.Json.Serialization;
using Candid.Net.Core;

namespace Candid.Net.X12.V1;

[JsonConverter(typeof(StringEnumSerializer<TypeOfBillFrequencyCode>))]
[Serializable]
public readonly record struct TypeOfBillFrequencyCode : IStringEnum
{
    /// <summary>
    /// NON-PAYMENT/ZERO CLAIM - Use this code when the bill is submitted to a payer for informational purposes, the provider does not anticipate payment to result from submitting the bill; but needs to inform the payer of the non-reimbursable periods of confinement or termination of care.
    /// </summary>
    public static readonly TypeOfBillFrequencyCode C0 = new(Values.C0);

    /// <summary>
    /// ADMIT THROUGH DISCHARGE CLAIM (A) - Use this code when billing for a confined treatment or inpatient period. This will include bills representing a total confinement or course of treatment, and bills that represent an entire benefit period of the primary third party payer. Note: Use Occurrence Code 42 to indicate the date of discharge when the "Through" date in Form Locator 06 (Statement Covers Period) is not the actual discharge date and the frequency code in Form Locator 04 is that of a final bill, i.e., 1, 4, and 7 (when the replacement is for a prior final claim).
    /// </summary>
    public static readonly TypeOfBillFrequencyCode C1 = new(Values.C1);

    /// <summary>
    /// INTERIM - FIRST CLAIM - This code is to be used for the first of a series of bills to the same third party payer for the same confinement or course of treatment.
    /// </summary>
    public static readonly TypeOfBillFrequencyCode C2 = new(Values.C2);

    /// <summary>
    /// INTERIM - CONTINUING CLAIM (B) - This code is to be used when a bill for the same confinement or course of treatment has previously been submitted and it is expected that further bills for the same confinement or course of treatment will be submitted.
    /// </summary>
    public static readonly TypeOfBillFrequencyCode C3 = new(Values.C3);

    /// <summary>
    /// INTERIM LAST CLAIM (B) - Use this code for the last of a series of bills, for which payment is expected, to the same third party payer for the same confinement or course of treatment. Note: Do not use this code in lieu of a code for Late Charges or Non-Payment/Zero Claims.
    /// </summary>
    public static readonly TypeOfBillFrequencyCode C4 = new(Values.C4);

    /// <summary>
    /// LATE CHARGE(S) ONLY - Use this code for submitting charges to the payer, which were received by the provider after the Admit Through Discharge, or the Last Interim Claim has been submitted. Note: This code is not intended to be used in lieu of a Replacement Claim.
    /// </summary>
    public static readonly TypeOfBillFrequencyCode C5 = new(Values.C5);

    /// <summary>
    /// REPLACEMENT OF PRIOR CLAIM (A) - This code is used when a specific bill has been issued for a specific Provider, Patient, Payer, Insured and "Statement Covers Period" and it needs to be restated in its entirety, except for the same identity information. In using this code, the payer is to operate on the principle to void the original bill, and that the information present on this bill represents a complete replacement of the previously issued bill. However, this code is not intended to be used in lieu of a Late Charge(s) Only claim.
    /// </summary>
    public static readonly TypeOfBillFrequencyCode C7 = new(Values.C7);

    /// <summary>
    /// VOID/CANCEL OF PRIOR CLAIM (A) - This code reflects the elimination in its entirety of a previously submitted bill for a specific Provider, Patient, Payer, Insured and "Statement Covers Period." The provider may wish to follow a Void Bill with a bill containing the correct information when a Payer is unable to process a Replacement to a Prior Claim. The appropriate Frequency Code must be used when submitting the new bill.
    /// </summary>
    public static readonly TypeOfBillFrequencyCode C8 = new(Values.C8);

    /// <summary>
    /// FINAL CLAIM FOR A HOME HEALTH PPS EPISODE (EFFECTIVE FOR SERVICE DATES PRIOR TO 12/1/21 TO BE DISCONTINUED 1/1/22) FINAL CLAIM FOR A HOME HEALTH PPS PERIOD (EFFECTIVE 1/1/22) - This code indicates the HH bill should be processed as a debit or credit adjustment to the initial home health PPS bill. This code is specific to home health and does not replace Frequency Codes 7 or 8. For claims with service dates on or after January 1, 2023, the HH bill is processed as an original claim, not an adjustment of an initial bill. This code indicates a HH original bill to be processed following the submission of an HH PPS Notice of Admission (NOA-TOB 32A).
    /// </summary>
    public static readonly TypeOfBillFrequencyCode C9 = new(Values.C9);

    /// <summary>
    /// ADMISSION/ELECTION NOTICE - This code is used when a hospice, home health agency, CMS Coordinated Care Demonstration entity, Centers of Excellence Demonstration entity, Provider Partnerships Demonstration entity or Religious Non-medical Health Care Institution is submitting the UB-04 as an admission or election notice.
    /// </summary>
    public static readonly TypeOfBillFrequencyCode Ca = new(Values.Ca);

    /// <summary>
    /// TERMINATION/REVOCATION NOTICE - This code is used when the UB-04 is used as a Termination/Revocation of a hospice, Medicare Coordinated Care Demonstration, Centers of Excellence Demonstration, Provider Partnerships Demonstration or Religious Non-Medical Care Institution election.
    /// </summary>
    public static readonly TypeOfBillFrequencyCode Cb = new(Values.Cb);

    /// <summary>
    /// HOSPICE CHANGE OF PROVIDER NOTICE - Use when the UB-04 is used as a Notice of Change to the hospice provider.
    /// </summary>
    public static readonly TypeOfBillFrequencyCode Cc = new(Values.Cc);

    /// <summary>
    /// CANCELLATION OF ELECTION NOTICE - This code is used when the UB-04 is used as a Notice of a Void/Cancel of a hospice, home health agency, CMS Coordinated Care Demonstration entity, Centers of Excellence Demonstration entity, Provider Partnerships Demonstration entity or Religious Non-medical Health Care Institution election.
    /// </summary>
    public static readonly TypeOfBillFrequencyCode Cd = new(Values.Cd);

    /// <summary>
    /// HOSPICE CHANGE OF OWNERSHIP - This code is used to indicate a Notice of Change in Ownership for the hospice.
    /// </summary>
    public static readonly TypeOfBillFrequencyCode Ce = new(Values.Ce);

    /// <summary>
    /// BENEFICIARY INITIATED ADJUSTMENT CLAIM - For intermediary use only, use to identify adjustments initiated by the beneficiary.
    /// </summary>
    public static readonly TypeOfBillFrequencyCode Cf = new(Values.Cf);

    /// <summary>
    /// CWF INITIATED ADJUSTMENT CLAIM - For intermediary use only, to identify adjustments initiated by CWF.
    /// </summary>
    public static readonly TypeOfBillFrequencyCode Cg = new(Values.Cg);

    /// <summary>
    /// CMS INITIATED ADJUSTMENT - For intermediary use only, to identify adjustments initiated by CMS.
    /// </summary>
    public static readonly TypeOfBillFrequencyCode Ch = new(Values.Ch);

    /// <summary>
    /// INTERMEDIARY ADJUSTMENT CLAIM (OTHER THAN QIO OR PROVIDER) - For intermediary use only, to identify adjustments initiated by the intermediary.
    /// </summary>
    public static readonly TypeOfBillFrequencyCode Ci = new(Values.Ci);

    /// <summary>
    /// INITIATED ADJUSTMENT CLAIM - OTHER - For intermediary use only, to identify adjustments initiated by other entities.
    /// </summary>
    public static readonly TypeOfBillFrequencyCode Cj = new(Values.Cj);

    /// <summary>
    /// OIG INITIATED ADJUSTMENT CLAIM - For intermediary use only, to identify adjustments initiated by OIG.
    /// </summary>
    public static readonly TypeOfBillFrequencyCode Ck = new(Values.Ck);

    /// <summary>
    /// MSP INITIATED ADJUSTMENT CLAIM - For intermediary use only, to identify adjustments initiated by MSP. Note: MSP takes precedence over other adjustment sources.
    /// </summary>
    public static readonly TypeOfBillFrequencyCode Cm = new(Values.Cm);

    /// <summary>
    /// NONPAYMENT/ZERO CLAIMS - This code is used when you do not anticipate payment from the payer for the bill, but you are informing the payer about a period of non-payable confinement or termination of care. The "Through" date of this bill (FL 06) is the discharge date for this confinement. Medicare requires "nonpayment" bills only to extend the spell-of-illness in inpatient cases. Other nonpayment bills are not needed and may be returned.
    /// </summary>
    public static readonly TypeOfBillFrequencyCode CoFreq = new(Values.CoFreq);

    /// <summary>
    /// QIO ADJUSTMENT CLAIM - For intermediary use only, to identify an adjustment initiated because of a QIO review.
    /// </summary>
    public static readonly TypeOfBillFrequencyCode Cp = new(Values.Cp);

    /// <summary>
    /// CLAIM SUBMITTED FOR RECONSIDERATION/REOPENING OUTSIDE OF TIMELY LIMITS (EFFECTIVE JANUARY 1, 2016) - This code is used to identify claims submitted for reconsideration that fall outside of the payer's timely filing limits.
    /// </summary>
    public static readonly TypeOfBillFrequencyCode Cq = new(Values.Cq);

    /// <summary>
    /// VOID/CANCEL A PRIOR ABBREVIATED ENCOUNTER SUBMISSION - This code is used by a Medicare Advantage contractor or other plan required to submit encounter data that indicates that this encounter data submission is an exact duplicate of an incorrect previous encounter data submission using the abbreviated UB-04 format. A code "Y" (Replacement of Prior Abbreviated Encounter Submission) is also submitted by the plan showing corrected information.
    /// </summary>
    public static readonly TypeOfBillFrequencyCode Cx = new(Values.Cx);

    /// <summary>
    /// REPLACEMENT OF PRIOR ABBREVIATED ENCOUNTER SUBMISSION - This code is used by a Medicare Advantage contractor or other plan required to submit encounter data when it wants to correct a previous encounter submission using the abbreviated UB-04 format. This is the code applied to the corrected or new encounter.
    /// </summary>
    public static readonly TypeOfBillFrequencyCode CyFreq = new(Values.CyFreq);

    /// <summary>
    /// NEW ABBREVIATED ENCOUNTER SUBMISSION - This code is used by a Medicare Advantage contractor or other plan required to submit encounter data to indicate it is submitting new encounter data using the abbreviated UB-04 format. It is applicable for both inpatient and outpatient services.
    /// </summary>
    public static readonly TypeOfBillFrequencyCode CzFreq = new(Values.CzFreq);

    public TypeOfBillFrequencyCode(string value)
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
    public static TypeOfBillFrequencyCode FromCustom(string value)
    {
        return new TypeOfBillFrequencyCode(value);
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

    public static bool operator ==(TypeOfBillFrequencyCode value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(TypeOfBillFrequencyCode value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(TypeOfBillFrequencyCode value) => value.Value;

    public static explicit operator TypeOfBillFrequencyCode(string value) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        /// <summary>
        /// NON-PAYMENT/ZERO CLAIM - Use this code when the bill is submitted to a payer for informational purposes, the provider does not anticipate payment to result from submitting the bill; but needs to inform the payer of the non-reimbursable periods of confinement or termination of care.
        /// </summary>
        public const string C0 = "0";

        /// <summary>
        /// ADMIT THROUGH DISCHARGE CLAIM (A) - Use this code when billing for a confined treatment or inpatient period. This will include bills representing a total confinement or course of treatment, and bills that represent an entire benefit period of the primary third party payer. Note: Use Occurrence Code 42 to indicate the date of discharge when the "Through" date in Form Locator 06 (Statement Covers Period) is not the actual discharge date and the frequency code in Form Locator 04 is that of a final bill, i.e., 1, 4, and 7 (when the replacement is for a prior final claim).
        /// </summary>
        public const string C1 = "1";

        /// <summary>
        /// INTERIM - FIRST CLAIM - This code is to be used for the first of a series of bills to the same third party payer for the same confinement or course of treatment.
        /// </summary>
        public const string C2 = "2";

        /// <summary>
        /// INTERIM - CONTINUING CLAIM (B) - This code is to be used when a bill for the same confinement or course of treatment has previously been submitted and it is expected that further bills for the same confinement or course of treatment will be submitted.
        /// </summary>
        public const string C3 = "3";

        /// <summary>
        /// INTERIM LAST CLAIM (B) - Use this code for the last of a series of bills, for which payment is expected, to the same third party payer for the same confinement or course of treatment. Note: Do not use this code in lieu of a code for Late Charges or Non-Payment/Zero Claims.
        /// </summary>
        public const string C4 = "4";

        /// <summary>
        /// LATE CHARGE(S) ONLY - Use this code for submitting charges to the payer, which were received by the provider after the Admit Through Discharge, or the Last Interim Claim has been submitted. Note: This code is not intended to be used in lieu of a Replacement Claim.
        /// </summary>
        public const string C5 = "5";

        /// <summary>
        /// REPLACEMENT OF PRIOR CLAIM (A) - This code is used when a specific bill has been issued for a specific Provider, Patient, Payer, Insured and "Statement Covers Period" and it needs to be restated in its entirety, except for the same identity information. In using this code, the payer is to operate on the principle to void the original bill, and that the information present on this bill represents a complete replacement of the previously issued bill. However, this code is not intended to be used in lieu of a Late Charge(s) Only claim.
        /// </summary>
        public const string C7 = "7";

        /// <summary>
        /// VOID/CANCEL OF PRIOR CLAIM (A) - This code reflects the elimination in its entirety of a previously submitted bill for a specific Provider, Patient, Payer, Insured and "Statement Covers Period." The provider may wish to follow a Void Bill with a bill containing the correct information when a Payer is unable to process a Replacement to a Prior Claim. The appropriate Frequency Code must be used when submitting the new bill.
        /// </summary>
        public const string C8 = "8";

        /// <summary>
        /// FINAL CLAIM FOR A HOME HEALTH PPS EPISODE (EFFECTIVE FOR SERVICE DATES PRIOR TO 12/1/21 TO BE DISCONTINUED 1/1/22) FINAL CLAIM FOR A HOME HEALTH PPS PERIOD (EFFECTIVE 1/1/22) - This code indicates the HH bill should be processed as a debit or credit adjustment to the initial home health PPS bill. This code is specific to home health and does not replace Frequency Codes 7 or 8. For claims with service dates on or after January 1, 2023, the HH bill is processed as an original claim, not an adjustment of an initial bill. This code indicates a HH original bill to be processed following the submission of an HH PPS Notice of Admission (NOA-TOB 32A).
        /// </summary>
        public const string C9 = "9";

        /// <summary>
        /// ADMISSION/ELECTION NOTICE - This code is used when a hospice, home health agency, CMS Coordinated Care Demonstration entity, Centers of Excellence Demonstration entity, Provider Partnerships Demonstration entity or Religious Non-medical Health Care Institution is submitting the UB-04 as an admission or election notice.
        /// </summary>
        public const string Ca = "A";

        /// <summary>
        /// TERMINATION/REVOCATION NOTICE - This code is used when the UB-04 is used as a Termination/Revocation of a hospice, Medicare Coordinated Care Demonstration, Centers of Excellence Demonstration, Provider Partnerships Demonstration or Religious Non-Medical Care Institution election.
        /// </summary>
        public const string Cb = "B";

        /// <summary>
        /// HOSPICE CHANGE OF PROVIDER NOTICE - Use when the UB-04 is used as a Notice of Change to the hospice provider.
        /// </summary>
        public const string Cc = "C";

        /// <summary>
        /// CANCELLATION OF ELECTION NOTICE - This code is used when the UB-04 is used as a Notice of a Void/Cancel of a hospice, home health agency, CMS Coordinated Care Demonstration entity, Centers of Excellence Demonstration entity, Provider Partnerships Demonstration entity or Religious Non-medical Health Care Institution election.
        /// </summary>
        public const string Cd = "D";

        /// <summary>
        /// HOSPICE CHANGE OF OWNERSHIP - This code is used to indicate a Notice of Change in Ownership for the hospice.
        /// </summary>
        public const string Ce = "E";

        /// <summary>
        /// BENEFICIARY INITIATED ADJUSTMENT CLAIM - For intermediary use only, use to identify adjustments initiated by the beneficiary.
        /// </summary>
        public const string Cf = "F";

        /// <summary>
        /// CWF INITIATED ADJUSTMENT CLAIM - For intermediary use only, to identify adjustments initiated by CWF.
        /// </summary>
        public const string Cg = "G";

        /// <summary>
        /// CMS INITIATED ADJUSTMENT - For intermediary use only, to identify adjustments initiated by CMS.
        /// </summary>
        public const string Ch = "H";

        /// <summary>
        /// INTERMEDIARY ADJUSTMENT CLAIM (OTHER THAN QIO OR PROVIDER) - For intermediary use only, to identify adjustments initiated by the intermediary.
        /// </summary>
        public const string Ci = "I";

        /// <summary>
        /// INITIATED ADJUSTMENT CLAIM - OTHER - For intermediary use only, to identify adjustments initiated by other entities.
        /// </summary>
        public const string Cj = "J";

        /// <summary>
        /// OIG INITIATED ADJUSTMENT CLAIM - For intermediary use only, to identify adjustments initiated by OIG.
        /// </summary>
        public const string Ck = "K";

        /// <summary>
        /// MSP INITIATED ADJUSTMENT CLAIM - For intermediary use only, to identify adjustments initiated by MSP. Note: MSP takes precedence over other adjustment sources.
        /// </summary>
        public const string Cm = "M";

        /// <summary>
        /// NONPAYMENT/ZERO CLAIMS - This code is used when you do not anticipate payment from the payer for the bill, but you are informing the payer about a period of non-payable confinement or termination of care. The "Through" date of this bill (FL 06) is the discharge date for this confinement. Medicare requires "nonpayment" bills only to extend the spell-of-illness in inpatient cases. Other nonpayment bills are not needed and may be returned.
        /// </summary>
        public const string CoFreq = "O";

        /// <summary>
        /// QIO ADJUSTMENT CLAIM - For intermediary use only, to identify an adjustment initiated because of a QIO review.
        /// </summary>
        public const string Cp = "P";

        /// <summary>
        /// CLAIM SUBMITTED FOR RECONSIDERATION/REOPENING OUTSIDE OF TIMELY LIMITS (EFFECTIVE JANUARY 1, 2016) - This code is used to identify claims submitted for reconsideration that fall outside of the payer's timely filing limits.
        /// </summary>
        public const string Cq = "Q";

        /// <summary>
        /// VOID/CANCEL A PRIOR ABBREVIATED ENCOUNTER SUBMISSION - This code is used by a Medicare Advantage contractor or other plan required to submit encounter data that indicates that this encounter data submission is an exact duplicate of an incorrect previous encounter data submission using the abbreviated UB-04 format. A code "Y" (Replacement of Prior Abbreviated Encounter Submission) is also submitted by the plan showing corrected information.
        /// </summary>
        public const string Cx = "X";

        /// <summary>
        /// REPLACEMENT OF PRIOR ABBREVIATED ENCOUNTER SUBMISSION - This code is used by a Medicare Advantage contractor or other plan required to submit encounter data when it wants to correct a previous encounter submission using the abbreviated UB-04 format. This is the code applied to the corrected or new encounter.
        /// </summary>
        public const string CyFreq = "Y";

        /// <summary>
        /// NEW ABBREVIATED ENCOUNTER SUBMISSION - This code is used by a Medicare Advantage contractor or other plan required to submit encounter data to indicate it is submitting new encounter data using the abbreviated UB-04 format. It is applicable for both inpatient and outpatient services.
        /// </summary>
        public const string CzFreq = "Z";
    }
}
