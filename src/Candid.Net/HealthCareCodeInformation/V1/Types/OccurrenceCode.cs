using System.Text.Json.Serialization;
using Candid.Net.Core;

namespace Candid.Net.HealthCareCodeInformation.V1;

[JsonConverter(typeof(StringEnumSerializer<OccurrenceCode>))]
[Serializable]
public readonly record struct OccurrenceCode : IStringEnum
{
    /// <summary>
    /// Accident/Medical Coverage Code indicating accident-related injury for which there is medical payment coverage. Provide the date of accident/injury.
    /// </summary>
    public static readonly OccurrenceCode C01 = new(Values.C01);

    /// <summary>
    /// No Fault Insurance Involved - Including Auto Accident/Other Code indicating the date of an accident including auto or other where state has applicable no fault liability laws (i.e., legal basis for settlement without admission of proof of guilt).
    /// </summary>
    public static readonly OccurrenceCode C02 = new(Values.C02);

    /// <summary>
    /// Accident/Tort Liability Code indicating the date of an accident resulting from a third party’s action that may involve a civil court process in an attempt to require payment by the third party, other than no fault liability.
    /// </summary>
    public static readonly OccurrenceCode C03 = new(Values.C03);

    /// <summary>
    /// Accident/Employment Related Code indicating the date of an accident allegedly relating to the patient’s employment.
    /// </summary>
    public static readonly OccurrenceCode C04 = new(Values.C04);

    /// <summary>
    /// Accident/No Medical or Liability Coverage Code indicating accident related injury for which there is no medical payment or third-party liability coverage. Provide the date of accident/ injury.
    /// </summary>
    public static readonly OccurrenceCode C05 = new(Values.C05);

    /// <summary>
    /// Crime Victim Code indicating the date on which a medical condition resulted from alleged criminal action committed by one or more parties.
    /// </summary>
    public static readonly OccurrenceCode C06 = new(Values.C06);

    /// <summary>
    /// Start of Infertility Treatment Cycle Code indicating the date of start of infertility treatment cycle.
    /// </summary>
    public static readonly OccurrenceCode C09 = new(Values.C09);

    /// <summary>
    /// Last Menstrual Period Code indicating the date of the last menstrual period; ONLY applies when patient is being treated for maternity related condition.
    /// </summary>
    public static readonly OccurrenceCode C10 = new(Values.C10);

    /// <summary>
    /// Onset of Symptoms/Illness Code indicating the date the patient first became aware of symptoms/illness.
    /// </summary>
    public static readonly OccurrenceCode C11 = new(Values.C11);

    /// <summary>
    /// Date of Onset for a Chronically Dependent Individual (HHA Claims Only.) Code denotes date the patient/beneficiary becomes a Chronically Dependent Individual (CDI). This is the first month of the 3-month period immediately before eligibility under respite care benefit.
    /// </summary>
    public static readonly OccurrenceCode C12 = new(Values.C12);

    /// <summary>
    /// Date of Last Therapy Code denotes last day of therapy services (e.g., physical therapy, occupational therapy, speech therapy).
    /// </summary>
    public static readonly OccurrenceCode C16 = new(Values.C16);

    /// <summary>
    /// Date Outpatient Occupational Therapy Plan Established or Last Reviewed Code denotes date an occupational therapy plan was established or last reviewed.
    /// </summary>
    public static readonly OccurrenceCode C17 = new(Values.C17);

    /// <summary>
    /// Date of Retirement - Patient/ Beneficiary The date of retirement for the patient/ beneficiary.
    /// </summary>
    public static readonly OccurrenceCode C18 = new(Values.C18);

    /// <summary>
    /// Date of Retirement - Spouse Code denotes the retirement date for the patient’s spouse.
    /// </summary>
    public static readonly OccurrenceCode C19 = new(Values.C19);

    /// <summary>
    /// Date Guarantee of Payment Began Code indicates date on which the provider began claiming Medicare payment under the guarantee of payment provision (see Medicare manual for special Medicare instructions).
    /// </summary>
    public static readonly OccurrenceCode C20 = new(Values.C20);

    /// <summary>
    /// Date UR Notice Received Code indicating the date of receipt by the provider of the UR Committee’s finding that the admission or future stay was not medically necessary.
    /// </summary>
    public static readonly OccurrenceCode C21 = new(Values.C21);

    /// <summary>
    /// Date Active Care Ended Code indicates the date covered level of care ended in a SNF or general hospital, or date on which active care ended in a psychiatric or tuberculosis hospital, or date on which patient was released on a trial basis from a residential facility. Code not required when Condition Code 21 is used.
    /// </summary>
    public static readonly OccurrenceCode C22 = new(Values.C22);

    /// <summary>
    /// Date Insurance Denied Code indicating the date the denial of coverage was received by the health care facility from any insurer.
    /// </summary>
    public static readonly OccurrenceCode C24 = new(Values.C24);

    /// <summary>
    /// Date Benefits Terminated by Primary Payer Code indicating the date on which coverage (including Worker’s Compensation benefits or no-fault coverage) is no longer available to the patient.
    /// </summary>
    public static readonly OccurrenceCode C25 = new(Values.C25);

    /// <summary>
    /// Date SNF Bed Became Available Code indicating the date on which a SNF bed became available to hospital inpatient who requires only SNF level care.
    /// </summary>
    public static readonly OccurrenceCode C26 = new(Values.C26);

    /// <summary>
    /// Date of Hospice Certification or Recertification Code indicating the date of certification or recertification of the hospice benefit period.
    /// </summary>
    public static readonly OccurrenceCode C27 = new(Values.C27);

    /// <summary>
    /// Date Comprehensive Outpatient Rehabilitation Plan Established or Last Reviewed Code indicating the date a comprehensive outpatient rehabilitation plan was established or last reviewed.
    /// </summary>
    public static readonly OccurrenceCode C28 = new(Values.C28);

    /// <summary>
    /// Date Outpatient Physical Therapy Plan Established or Last Reviewed Code indicating the date a physical therapy plan established or last reviewed.
    /// </summary>
    public static readonly OccurrenceCode C29 = new(Values.C29);

    /// <summary>
    /// Date Outpatient Speech Pathology Plan Established or Last Reviewed Code indicating the date a speech pathology plan was established or last reviewed.
    /// </summary>
    public static readonly OccurrenceCode C30 = new(Values.C30);

    /// <summary>
    /// Date Beneficiary Notified of Intent to Bill (Accommodations) The date of notice provided by the hospital to the patient that inpatient care is no longer required.
    /// </summary>
    public static readonly OccurrenceCode C31 = new(Values.C31);

    /// <summary>
    /// Date Beneficiary Notified of Intent to Bill (Procedures or Treatments) The date of notice provided to the beneficiary that requested care (diagnostic procedures or treatments) may not be reasonable or necessary.
    /// </summary>
    public static readonly OccurrenceCode C32 = new(Values.C32);

    /// <summary>
    /// First Day of the Coordination Period for ESRD Beneficiaries Covered by EGHP Code indicates the first day of coordination for benefits that are secondary to benefits payable under an employer’s group health plan. Required only for ESRD beneficiaries.
    /// </summary>
    public static readonly OccurrenceCode C33 = new(Values.C33);

    /// <summary>
    /// Date of Election of Extended Care Facilities Code indicates the date the guest elected to receive extended care services (used by Religious Non-Medical only).
    /// </summary>
    public static readonly OccurrenceCode C34 = new(Values.C34);

    /// <summary>
    /// Date Treatment Started for Physical Therapy Code indicates the initial date services by the billing provider for physical therapy began.
    /// </summary>
    public static readonly OccurrenceCode C35 = new(Values.C35);

    /// <summary>
    /// Date of Inpatient Hospital Discharge for Covered Transplant Patient Code indicates the date of discharge for inpatient hospital stay in which the patient received a covered transplant procedure when the hospital is billing for immunosuppressive drugs. Note: When the patient received both a covered and a non-covered transplant, the covered transplant predominates.
    /// </summary>
    public static readonly OccurrenceCode C36 = new(Values.C36);

    /// <summary>
    /// Date of Inpatient Hospital Discharge for Non-covered Transplant Patient Code indicates the date of discharge for the inpatient hospital stay in which the patient received a non-covered transplant procedure when the hospital is billing for immunosuppressive drugs.
    /// </summary>
    public static readonly OccurrenceCode C37 = new(Values.C37);

    /// <summary>
    /// Date Treatment Started for Home IV Therapy Date the patient was first treated at home for IV therapy. (Home IV providers - Bill Type 085x.)
    /// </summary>
    public static readonly OccurrenceCode C38 = new(Values.C38);

    /// <summary>
    /// Date Discharged on a Continuous Course of IV Therapy Date the patient was discharged from the hospital on continuous course of IV therapy. (Home IV providers - Bill Type 085x.)
    /// </summary>
    public static readonly OccurrenceCode C39 = new(Values.C39);

    /// <summary>
    /// SCHEDULED DATE OF ADMISSION - The scheduled date the patient will be admitted as an inpatient to the hospital. (This code may only be used on an outpatient claim.)
    /// </summary>
    public static readonly OccurrenceCode C40 = new(Values.C40);

    /// <summary>
    /// DATE OF FIRST TEST PRE-ADMISSION TESTING - The date on which the first outpatient diagnostic test was performed as part of a PAT program. This code may only be used if a date of admission was scheduled before the administration of the test(s).
    /// </summary>
    public static readonly OccurrenceCode C41 = new(Values.C41);

    /// <summary>
    /// DATE OF DISCHARGE - Use only when "Through" date in Form Locator 06 (Statement Covers Period) is not the actual discharge date and the frequency code in Form Locator 04 is that of a final bill. For final bill for hospice care, enter the date the Medicare beneficiary terminated his election of hospice care.
    /// </summary>
    public static readonly OccurrenceCode C42 = new(Values.C42);

    /// <summary>
    /// SCHEDULED DATE OF CANCELED SURGERY - The date for which outpatient surgery was scheduled.
    /// </summary>
    public static readonly OccurrenceCode C43 = new(Values.C43);

    /// <summary>
    /// DATE TREATMENT STARTED OCCUPATIONAL THERAPY - The date services were initiated by the billing provider for occupational therapy.
    /// </summary>
    public static readonly OccurrenceCode C44 = new(Values.C44);

    /// <summary>
    /// DATE TREATMENT STARTED FOR SPEECH THERAPY - The date services were initiated by the billing provider for speech therapy.
    /// </summary>
    public static readonly OccurrenceCode C45 = new(Values.C45);

    /// <summary>
    /// DATE TREATMENT STARTED FOR CARDIAC REHABILITATION - The date services were initiated by the billing provider for cardiac rehabilitation.
    /// </summary>
    public static readonly OccurrenceCode C46 = new(Values.C46);

    /// <summary>
    /// DATE COST OUTLIER STATUS BEGINS - Code indicates that this is the first day after the day the Cost Outlier threshold is reached. For Medicare purposes, a beneficiary must have regular, coinsurance and/or lifetime reserve days available beginning on this date to allow coverage of additional daily charges for the purpose of making a cost outlier payment.
    /// </summary>
    public static readonly OccurrenceCode C47 = new(Values.C47);

    /// <summary>
    /// ASSESSMENT DATE (EFFECTIVE 1/1/11) - Code indicating an assessment date as defined by the assessment instrument applicable to this provider type (e.g., Minimum Data Set (MDS) for skilled nursing).
    /// </summary>
    public static readonly OccurrenceCode C50 = new(Values.C50);

    /// <summary>
    /// DATE OF LAST KT/V READING (EFFECTIVE 7/1/10) - For in-center hemodialysis patients, this is the date of the last reading taken during the billing period. For peritoneal dialysis patients (and home hemodialysis patients), this date may be before the current billing period but should be within 4 months of the date of service.
    /// </summary>
    public static readonly OccurrenceCode C51 = new(Values.C51);

    /// <summary>
    /// MEDICAL CERTIFICATION/RECERTIFICATION DATE (EFFECTIVE 1/1/11) - The date of the most recent non-hospice medical certification or recertification of the patient. Use Occurrence Code 27 for Date of Hospice Certification or Recertification.
    /// </summary>
    public static readonly OccurrenceCode C52 = new(Values.C52);

    /// <summary>
    /// PHYSICIAN FOLLOW-UP DATE (EFFECTIVE 1/1/11) - Last date of a physician follow-up with the patient.
    /// </summary>
    public static readonly OccurrenceCode C54 = new(Values.C54);

    /// <summary>
    /// DATE OF DEATH (EFFECTIVE 10/1/12) - Report this code when patient discharge status codes 20 (expired), 40 (expired at home), 41 (expired in a medical facility), or 42 (expired - place unknown) are used.
    /// </summary>
    public static readonly OccurrenceCode C55 = new(Values.C55);

    /// <summary>
    /// ORIGINAL HOSPICE ELECTION OR REVOCATION DATE (EFFECTIVE 1/1/18) - Used when the hospice is submitting a correction to the election date reported on a previous 08xA Type of Bill or the revocation date on a previous 08xB Type of Bill. The hospice reports the correct dates in FL06 - Statement Covers Period (From-Through) and the original date in this occurrence code.
    /// </summary>
    public static readonly OccurrenceCode C56 = new(Values.C56);

    /// <summary>
    /// HOSPITAL DISCHARGE DATE (HHA ONLY) (EFFECTIVE 1/1/2020) - The Through date of a hospital stay that ended within 14 days prior to the From date of this HHA claim.
    /// </summary>
    public static readonly OccurrenceCode C61 = new(Values.C61);

    /// <summary>
    /// OTHER INSTITUTIONAL DISCHARGE DATE (HHA ONLY) (EFFECTIVE 1/1/2020) - The Through date of a skilled nursing facility (SNF), inpatient rehabilitation facility (IRF), long term care hospital (LTCH), or inpatient psychiatric facility (IPF) stay that ended within 14 days prior to this HHA admission.
    /// </summary>
    public static readonly OccurrenceCode C62 = new(Values.C62);

    /// <summary>
    /// BIRTH DATE - INSURED A - The birth date of the individual in whose name the insurance is carried.
    /// </summary>
    public static readonly OccurrenceCode Ca1 = new(Values.Ca1);

    /// <summary>
    /// EFFECTIVE DATE - INSURED A POLICY - A code indicating the first date insurance is in force.
    /// </summary>
    public static readonly OccurrenceCode Ca2 = new(Values.Ca2);

    /// <summary>
    /// BENEFITS EXHAUSTED - PAYER A - Code indicating the last date for which benefits are available and after which no payment can be made by Payer A.
    /// </summary>
    public static readonly OccurrenceCode Ca3 = new(Values.Ca3);

    /// <summary>
    /// SPLIT BILL DATE - Date patient became eligible due to medically needy spend down (sometimes referred to as "Split Bill Date").
    /// </summary>
    public static readonly OccurrenceCode Ca4 = new(Values.Ca4);

    /// <summary>
    /// BIRTH DATE INSURED B - The birth date of the individual in whose name the insurance is carried.
    /// </summary>
    public static readonly OccurrenceCode Cb1 = new(Values.Cb1);

    /// <summary>
    /// EFFECTIVE DATE - INSURED B POLICY - A code indicating the first date insurance is in force.
    /// </summary>
    public static readonly OccurrenceCode Cb2 = new(Values.Cb2);

    /// <summary>
    /// BENEFITS EXHAUSTED - PAYER B - Code indicating the last date for which benefits are available and after which no payment can be made by Payer B.
    /// </summary>
    public static readonly OccurrenceCode Cb3 = new(Values.Cb3);

    /// <summary>
    /// BIRTH DATE INSURED C - The birth date of the individual in whose name the insurance is carried.
    /// </summary>
    public static readonly OccurrenceCode Cc1 = new(Values.Cc1);

    /// <summary>
    /// EFFECTIVE DATE - INSURED C POLICY - A code indicating the first date insurance is in force.
    /// </summary>
    public static readonly OccurrenceCode Cc2 = new(Values.Cc2);

    /// <summary>
    /// BENEFITS EXHAUSTED - PAYER C - Code indicating the last date for which benefits are available and after which no payment can be made by Payer C.
    /// </summary>
    public static readonly OccurrenceCode Cc3 = new(Values.Cc3);

    public OccurrenceCode(string value)
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
    public static OccurrenceCode FromCustom(string value)
    {
        return new OccurrenceCode(value);
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

    public static bool operator ==(OccurrenceCode value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(OccurrenceCode value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(OccurrenceCode value) => value.Value;

    public static explicit operator OccurrenceCode(string value) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        /// <summary>
        /// Accident/Medical Coverage Code indicating accident-related injury for which there is medical payment coverage. Provide the date of accident/injury.
        /// </summary>
        public const string C01 = "01";

        /// <summary>
        /// No Fault Insurance Involved - Including Auto Accident/Other Code indicating the date of an accident including auto or other where state has applicable no fault liability laws (i.e., legal basis for settlement without admission of proof of guilt).
        /// </summary>
        public const string C02 = "02";

        /// <summary>
        /// Accident/Tort Liability Code indicating the date of an accident resulting from a third party’s action that may involve a civil court process in an attempt to require payment by the third party, other than no fault liability.
        /// </summary>
        public const string C03 = "03";

        /// <summary>
        /// Accident/Employment Related Code indicating the date of an accident allegedly relating to the patient’s employment.
        /// </summary>
        public const string C04 = "04";

        /// <summary>
        /// Accident/No Medical or Liability Coverage Code indicating accident related injury for which there is no medical payment or third-party liability coverage. Provide the date of accident/ injury.
        /// </summary>
        public const string C05 = "05";

        /// <summary>
        /// Crime Victim Code indicating the date on which a medical condition resulted from alleged criminal action committed by one or more parties.
        /// </summary>
        public const string C06 = "06";

        /// <summary>
        /// Start of Infertility Treatment Cycle Code indicating the date of start of infertility treatment cycle.
        /// </summary>
        public const string C09 = "09";

        /// <summary>
        /// Last Menstrual Period Code indicating the date of the last menstrual period; ONLY applies when patient is being treated for maternity related condition.
        /// </summary>
        public const string C10 = "10";

        /// <summary>
        /// Onset of Symptoms/Illness Code indicating the date the patient first became aware of symptoms/illness.
        /// </summary>
        public const string C11 = "11";

        /// <summary>
        /// Date of Onset for a Chronically Dependent Individual (HHA Claims Only.) Code denotes date the patient/beneficiary becomes a Chronically Dependent Individual (CDI). This is the first month of the 3-month period immediately before eligibility under respite care benefit.
        /// </summary>
        public const string C12 = "12";

        /// <summary>
        /// Date of Last Therapy Code denotes last day of therapy services (e.g., physical therapy, occupational therapy, speech therapy).
        /// </summary>
        public const string C16 = "16";

        /// <summary>
        /// Date Outpatient Occupational Therapy Plan Established or Last Reviewed Code denotes date an occupational therapy plan was established or last reviewed.
        /// </summary>
        public const string C17 = "17";

        /// <summary>
        /// Date of Retirement - Patient/ Beneficiary The date of retirement for the patient/ beneficiary.
        /// </summary>
        public const string C18 = "18";

        /// <summary>
        /// Date of Retirement - Spouse Code denotes the retirement date for the patient’s spouse.
        /// </summary>
        public const string C19 = "19";

        /// <summary>
        /// Date Guarantee of Payment Began Code indicates date on which the provider began claiming Medicare payment under the guarantee of payment provision (see Medicare manual for special Medicare instructions).
        /// </summary>
        public const string C20 = "20";

        /// <summary>
        /// Date UR Notice Received Code indicating the date of receipt by the provider of the UR Committee’s finding that the admission or future stay was not medically necessary.
        /// </summary>
        public const string C21 = "21";

        /// <summary>
        /// Date Active Care Ended Code indicates the date covered level of care ended in a SNF or general hospital, or date on which active care ended in a psychiatric or tuberculosis hospital, or date on which patient was released on a trial basis from a residential facility. Code not required when Condition Code 21 is used.
        /// </summary>
        public const string C22 = "22";

        /// <summary>
        /// Date Insurance Denied Code indicating the date the denial of coverage was received by the health care facility from any insurer.
        /// </summary>
        public const string C24 = "24";

        /// <summary>
        /// Date Benefits Terminated by Primary Payer Code indicating the date on which coverage (including Worker’s Compensation benefits or no-fault coverage) is no longer available to the patient.
        /// </summary>
        public const string C25 = "25";

        /// <summary>
        /// Date SNF Bed Became Available Code indicating the date on which a SNF bed became available to hospital inpatient who requires only SNF level care.
        /// </summary>
        public const string C26 = "26";

        /// <summary>
        /// Date of Hospice Certification or Recertification Code indicating the date of certification or recertification of the hospice benefit period.
        /// </summary>
        public const string C27 = "27";

        /// <summary>
        /// Date Comprehensive Outpatient Rehabilitation Plan Established or Last Reviewed Code indicating the date a comprehensive outpatient rehabilitation plan was established or last reviewed.
        /// </summary>
        public const string C28 = "28";

        /// <summary>
        /// Date Outpatient Physical Therapy Plan Established or Last Reviewed Code indicating the date a physical therapy plan established or last reviewed.
        /// </summary>
        public const string C29 = "29";

        /// <summary>
        /// Date Outpatient Speech Pathology Plan Established or Last Reviewed Code indicating the date a speech pathology plan was established or last reviewed.
        /// </summary>
        public const string C30 = "30";

        /// <summary>
        /// Date Beneficiary Notified of Intent to Bill (Accommodations) The date of notice provided by the hospital to the patient that inpatient care is no longer required.
        /// </summary>
        public const string C31 = "31";

        /// <summary>
        /// Date Beneficiary Notified of Intent to Bill (Procedures or Treatments) The date of notice provided to the beneficiary that requested care (diagnostic procedures or treatments) may not be reasonable or necessary.
        /// </summary>
        public const string C32 = "32";

        /// <summary>
        /// First Day of the Coordination Period for ESRD Beneficiaries Covered by EGHP Code indicates the first day of coordination for benefits that are secondary to benefits payable under an employer’s group health plan. Required only for ESRD beneficiaries.
        /// </summary>
        public const string C33 = "33";

        /// <summary>
        /// Date of Election of Extended Care Facilities Code indicates the date the guest elected to receive extended care services (used by Religious Non-Medical only).
        /// </summary>
        public const string C34 = "34";

        /// <summary>
        /// Date Treatment Started for Physical Therapy Code indicates the initial date services by the billing provider for physical therapy began.
        /// </summary>
        public const string C35 = "35";

        /// <summary>
        /// Date of Inpatient Hospital Discharge for Covered Transplant Patient Code indicates the date of discharge for inpatient hospital stay in which the patient received a covered transplant procedure when the hospital is billing for immunosuppressive drugs. Note: When the patient received both a covered and a non-covered transplant, the covered transplant predominates.
        /// </summary>
        public const string C36 = "36";

        /// <summary>
        /// Date of Inpatient Hospital Discharge for Non-covered Transplant Patient Code indicates the date of discharge for the inpatient hospital stay in which the patient received a non-covered transplant procedure when the hospital is billing for immunosuppressive drugs.
        /// </summary>
        public const string C37 = "37";

        /// <summary>
        /// Date Treatment Started for Home IV Therapy Date the patient was first treated at home for IV therapy. (Home IV providers - Bill Type 085x.)
        /// </summary>
        public const string C38 = "38";

        /// <summary>
        /// Date Discharged on a Continuous Course of IV Therapy Date the patient was discharged from the hospital on continuous course of IV therapy. (Home IV providers - Bill Type 085x.)
        /// </summary>
        public const string C39 = "39";

        /// <summary>
        /// SCHEDULED DATE OF ADMISSION - The scheduled date the patient will be admitted as an inpatient to the hospital. (This code may only be used on an outpatient claim.)
        /// </summary>
        public const string C40 = "40";

        /// <summary>
        /// DATE OF FIRST TEST PRE-ADMISSION TESTING - The date on which the first outpatient diagnostic test was performed as part of a PAT program. This code may only be used if a date of admission was scheduled before the administration of the test(s).
        /// </summary>
        public const string C41 = "41";

        /// <summary>
        /// DATE OF DISCHARGE - Use only when "Through" date in Form Locator 06 (Statement Covers Period) is not the actual discharge date and the frequency code in Form Locator 04 is that of a final bill. For final bill for hospice care, enter the date the Medicare beneficiary terminated his election of hospice care.
        /// </summary>
        public const string C42 = "42";

        /// <summary>
        /// SCHEDULED DATE OF CANCELED SURGERY - The date for which outpatient surgery was scheduled.
        /// </summary>
        public const string C43 = "43";

        /// <summary>
        /// DATE TREATMENT STARTED OCCUPATIONAL THERAPY - The date services were initiated by the billing provider for occupational therapy.
        /// </summary>
        public const string C44 = "44";

        /// <summary>
        /// DATE TREATMENT STARTED FOR SPEECH THERAPY - The date services were initiated by the billing provider for speech therapy.
        /// </summary>
        public const string C45 = "45";

        /// <summary>
        /// DATE TREATMENT STARTED FOR CARDIAC REHABILITATION - The date services were initiated by the billing provider for cardiac rehabilitation.
        /// </summary>
        public const string C46 = "46";

        /// <summary>
        /// DATE COST OUTLIER STATUS BEGINS - Code indicates that this is the first day after the day the Cost Outlier threshold is reached. For Medicare purposes, a beneficiary must have regular, coinsurance and/or lifetime reserve days available beginning on this date to allow coverage of additional daily charges for the purpose of making a cost outlier payment.
        /// </summary>
        public const string C47 = "47";

        /// <summary>
        /// ASSESSMENT DATE (EFFECTIVE 1/1/11) - Code indicating an assessment date as defined by the assessment instrument applicable to this provider type (e.g., Minimum Data Set (MDS) for skilled nursing).
        /// </summary>
        public const string C50 = "50";

        /// <summary>
        /// DATE OF LAST KT/V READING (EFFECTIVE 7/1/10) - For in-center hemodialysis patients, this is the date of the last reading taken during the billing period. For peritoneal dialysis patients (and home hemodialysis patients), this date may be before the current billing period but should be within 4 months of the date of service.
        /// </summary>
        public const string C51 = "51";

        /// <summary>
        /// MEDICAL CERTIFICATION/RECERTIFICATION DATE (EFFECTIVE 1/1/11) - The date of the most recent non-hospice medical certification or recertification of the patient. Use Occurrence Code 27 for Date of Hospice Certification or Recertification.
        /// </summary>
        public const string C52 = "52";

        /// <summary>
        /// PHYSICIAN FOLLOW-UP DATE (EFFECTIVE 1/1/11) - Last date of a physician follow-up with the patient.
        /// </summary>
        public const string C54 = "54";

        /// <summary>
        /// DATE OF DEATH (EFFECTIVE 10/1/12) - Report this code when patient discharge status codes 20 (expired), 40 (expired at home), 41 (expired in a medical facility), or 42 (expired - place unknown) are used.
        /// </summary>
        public const string C55 = "55";

        /// <summary>
        /// ORIGINAL HOSPICE ELECTION OR REVOCATION DATE (EFFECTIVE 1/1/18) - Used when the hospice is submitting a correction to the election date reported on a previous 08xA Type of Bill or the revocation date on a previous 08xB Type of Bill. The hospice reports the correct dates in FL06 - Statement Covers Period (From-Through) and the original date in this occurrence code.
        /// </summary>
        public const string C56 = "56";

        /// <summary>
        /// HOSPITAL DISCHARGE DATE (HHA ONLY) (EFFECTIVE 1/1/2020) - The Through date of a hospital stay that ended within 14 days prior to the From date of this HHA claim.
        /// </summary>
        public const string C61 = "61";

        /// <summary>
        /// OTHER INSTITUTIONAL DISCHARGE DATE (HHA ONLY) (EFFECTIVE 1/1/2020) - The Through date of a skilled nursing facility (SNF), inpatient rehabilitation facility (IRF), long term care hospital (LTCH), or inpatient psychiatric facility (IPF) stay that ended within 14 days prior to this HHA admission.
        /// </summary>
        public const string C62 = "62";

        /// <summary>
        /// BIRTH DATE - INSURED A - The birth date of the individual in whose name the insurance is carried.
        /// </summary>
        public const string Ca1 = "A1";

        /// <summary>
        /// EFFECTIVE DATE - INSURED A POLICY - A code indicating the first date insurance is in force.
        /// </summary>
        public const string Ca2 = "A2";

        /// <summary>
        /// BENEFITS EXHAUSTED - PAYER A - Code indicating the last date for which benefits are available and after which no payment can be made by Payer A.
        /// </summary>
        public const string Ca3 = "A3";

        /// <summary>
        /// SPLIT BILL DATE - Date patient became eligible due to medically needy spend down (sometimes referred to as "Split Bill Date").
        /// </summary>
        public const string Ca4 = "A4";

        /// <summary>
        /// BIRTH DATE INSURED B - The birth date of the individual in whose name the insurance is carried.
        /// </summary>
        public const string Cb1 = "B1";

        /// <summary>
        /// EFFECTIVE DATE - INSURED B POLICY - A code indicating the first date insurance is in force.
        /// </summary>
        public const string Cb2 = "B2";

        /// <summary>
        /// BENEFITS EXHAUSTED - PAYER B - Code indicating the last date for which benefits are available and after which no payment can be made by Payer B.
        /// </summary>
        public const string Cb3 = "B3";

        /// <summary>
        /// BIRTH DATE INSURED C - The birth date of the individual in whose name the insurance is carried.
        /// </summary>
        public const string Cc1 = "C1";

        /// <summary>
        /// EFFECTIVE DATE - INSURED C POLICY - A code indicating the first date insurance is in force.
        /// </summary>
        public const string Cc2 = "C2";

        /// <summary>
        /// BENEFITS EXHAUSTED - PAYER C - Code indicating the last date for which benefits are available and after which no payment can be made by Payer C.
        /// </summary>
        public const string Cc3 = "C3";
    }
}
