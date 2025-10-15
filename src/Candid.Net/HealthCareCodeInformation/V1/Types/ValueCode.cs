using System.Text.Json.Serialization;
using Candid.Net.Core;

namespace Candid.Net.HealthCareCodeInformation.V1;

[JsonConverter(typeof(StringEnumSerializer<ValueCode>))]
[Serializable]
public readonly record struct ValueCode : IStringEnum
{
    /// <summary>
    /// Most Common Semi-private Rate
    /// To provide for the recording of hospital’s most common semi-private rate.
    /// </summary>
    public static readonly ValueCode C01Money = new(Values.C01Money);

    /// <summary>
    /// Hospital has no Semi-private Rooms
    /// Entering this code requires $0.00 amount.
    /// </summary>
    public static readonly ValueCode C02Money = new(Values.C02Money);

    /// <summary>
    /// Professional Component Charges which are Combined Billed
    /// Code indicates the amount shown is the sum of technical and professional charges, which are combined billed. Medicare uses this information in internal processes and in the CMS notice of utilization sent to the patient to explain that Part B coinsurance applies to the professional component.
    /// </summary>
    public static readonly ValueCode C04Money = new(Values.C04Money);

    /// <summary>
    /// Professional Component Included in Charges and also Billed Separate to Carrier
    /// Amount shown is the combined billed charges (technical and professional); however the provider is submitting a separate professional bill to the health plan. For use on Medicare or TRICARE bills and all Medicaid bills if state specifies need for this information.
    /// </summary>
    public static readonly ValueCode C05Money = new(Values.C05Money);

    /// <summary>
    /// Blood Deductible
    /// Total cash blood deductible. If appropriate, enter Medicare Part A or Part B blood deductible amount. (To report other than the blood deductible, that is to report the program deductible, see Value Codes (FL39-FL41) A1, B1, and C1.)
    /// </summary>
    public static readonly ValueCode C06Money = new(Values.C06Money);

    /// <summary>
    /// Life Time Reserve Amount in the First Calendar Year
    /// Lifetime reserve amount charged in the year of admission. Note: For Medicare, use this code only for Part A bills. For Part B Coinsurance use Value Codes (FL39-41) A2, B2, and C2).
    /// </summary>
    public static readonly ValueCode C08Money = new(Values.C08Money);

    /// <summary>
    /// Coinsurance Amount in the First Calendar Year
    /// Coinsurance amounts, charged in the year of admission.
    /// </summary>
    public static readonly ValueCode C09Money = new(Values.C09Money);

    /// <summary>
    /// Lifetime Reserve Amount in the Second Calendar Year
    /// Lifetime reserve amount charged in the year of discharge where the bill spans two calendar years.
    /// </summary>
    public static readonly ValueCode C10Money = new(Values.C10Money);

    /// <summary>
    /// Coinsurance Amount in the Second Calendar Year
    /// Coinsurance amount charged in the year of discharge where the inpatient bill spans two calendar years.
    /// </summary>
    public static readonly ValueCode C11Money = new(Values.C11Money);

    /// <summary>
    /// Working Aged Beneficiary/Spouse with Employer Group Health Plan
    /// Amount shown reflects that portion of a payment from a higher priority employer group health insurance made on behalf of an aged beneficiary. For Medicare purposes the provider is billing Medicare as the secondary, payer (based on MSP development) for covered services on this bill.
    /// </summary>
    public static readonly ValueCode C12Money = new(Values.C12Money);

    /// <summary>
    /// ESRD Beneficiary in a Medicare Coordination Period with an Employer Group Health Plan
    /// Amount shown is that portion of a payment from a higher priority employer group health insurance payment made on behalf of an ESRD beneficiary that the provider is applying to Medicare covered services on this bill.
    /// </summary>
    public static readonly ValueCode C13Money = new(Values.C13Money);

    /// <summary>
    /// No-Fault, Including Auto/Other
    /// Amount shown is that portion from a higher priority no-fault insurance, including auto/other made on behalf of the patient or insured. For Medicare beneficiaries, the provider should apply this amount to the Medicare covered services on this bill.
    /// </summary>
    public static readonly ValueCode C14Money = new(Values.C14Money);

    /// <summary>
    /// Worker’s Compensation
    /// Amount shown is that portion of a payment from a higher priority worker’s compensation insurance made on behalf of the patient or insured. For Medicare beneficiaries the provider should apply this amount to Medicare covered services on this bill.
    /// </summary>
    public static readonly ValueCode C15Money = new(Values.C15Money);

    /// <summary>
    /// PHS, or Other Federal Agency
    /// Amount shown is that portion of a payment from a higher priority Public Health Service or the Federal Agency made on behalf of a Medicare beneficiary that the provider is applying to Medicare covered services on this bill.
    /// </summary>
    public static readonly ValueCode C16Money = new(Values.C16Money);

    /// <summary>
    /// Catastrophic
    /// Catastrophic Medicaid-eligibility and coverage requirements determined at the state level.
    /// </summary>
    public static readonly ValueCode C21Money = new(Values.C21Money);

    /// <summary>
    /// Surplus Income
    /// Surplus (or excess) income as designated by Medicaid eligibility requirements determined at the state level.
    /// </summary>
    public static readonly ValueCode C22Money = new(Values.C22Money);

    /// <summary>
    /// Recurring Monthly Income
    /// Monthly income as designated by Medicaid-eligibility requirements determined at the state level.
    /// </summary>
    public static readonly ValueCode C23Money = new(Values.C23Money);

    /// <summary>
    /// Medicaid Rate Code
    /// Code indicating the payment or reimbursement rate designated by Medicaid at the state level.
    /// </summary>
    public static readonly ValueCode C24Num = new(Values.C24Num);

    /// <summary>
    /// Offset to the Patient-Payment Amount - Prescription Drugs
    /// Prescription drugs paid for out of a long-term care facility resident/patient’s funds in the billing period submitted (Statement Covers Period).
    /// </summary>
    public static readonly ValueCode C25Money = new(Values.C25Money);

    /// <summary>
    /// Offset to the Patient-Payment Amount - Hearing and Ear Services
    /// Hearing and ear services paid for out of a long-term care facility resident/patient’s funds in the billing period submitted (Statement Covers Period).
    /// </summary>
    public static readonly ValueCode C26Money = new(Values.C26Money);

    /// <summary>
    /// Offset to the Patient-Payment Amount - Vision and Eye Services
    /// Vision and eye services paid for out of a long-term care facility resident/patient’s funds in the billing period submitted (Statement Covers Period).
    /// </summary>
    public static readonly ValueCode C27Money = new(Values.C27Money);

    /// <summary>
    /// Offset to the Patient-Payment Amount - Dental Services
    /// Dental services paid for out of a long-term care facility resident/patient’s funds in the billing period submitted (Statement Covers Period).
    /// </summary>
    public static readonly ValueCode C28Money = new(Values.C28Money);

    /// <summary>
    /// Offset to the Patient-Payment Amount - Chiropractic Services
    /// Chiropractic services paid for out of a long-term care facility resident/patient’s funds in the billing period submitted (Statement Covers Period).
    /// </summary>
    public static readonly ValueCode C29Money = new(Values.C29Money);

    /// <summary>
    /// Preadmission Testing
    /// This code reflects charges for preadmission outpatient diagnostic services in preparation for a previously scheduled admission.
    /// </summary>
    public static readonly ValueCode C30Money = new(Values.C30Money);

    /// <summary>
    /// Patient Liability Amount
    /// Approved amount to charge the beneficiary for non-covered accommodations, diagnostic procedures or treatments.
    /// </summary>
    public static readonly ValueCode C31Money = new(Values.C31Money);

    /// <summary>
    /// Multiple Patient Ambulance Transport
    /// When more than one patient is transported in a single ambulance trip, report the total number of patients transported.
    /// </summary>
    public static readonly ValueCode C32Num = new(Values.C32Num);

    /// <summary>
    /// Offset to the Patient-Payment Amount - Podiatric Services
    /// Podiatric services paid for out of a long-term care facility resident/patient’s funds in the billing period submitted (Statement Covers Period).
    /// </summary>
    public static readonly ValueCode C33Money = new(Values.C33Money);

    /// <summary>
    /// Offset to the Patient-Payment Amount - Other Medical Services
    /// Other medical services paid for out of a long-term care facility resident/patient’s funds in the billing period submitted (Statement Covers Period).
    /// </summary>
    public static readonly ValueCode C34Money = new(Values.C34Money);

    /// <summary>
    /// Offset to the Patient-Payment Amount - Health Insurance Premiums
    /// Health insurance premiums paid for out of long-term care facility resident/patient’s funds in the billing period submitted (Statement Covers Period).
    /// </summary>
    public static readonly ValueCode C35Money = new(Values.C35Money);

    /// <summary>
    /// Units of Blood Furnished
    /// The total number of units of whole blood or packed red cells furnished to the patient, regardless of whether the hospital charges for blood or not.
    /// </summary>
    public static readonly ValueCode C37Num = new(Values.C37Num);

    /// <summary>
    /// Blood Deductible Units
    /// The number of unreplaced deductible units of packed red cells furnished for which the patient is responsible. If all deductible units furnished have been replaced, no entry is made.
    /// </summary>
    public static readonly ValueCode C38Num = new(Values.C38Num);

    /// <summary>
    /// Units of Blood Replaced
    /// The total number of units of whole blood or packed red cells furnished to the patient that have been replaced by or on behalf of the patient.
    /// </summary>
    public static readonly ValueCode C39Num = new(Values.C39Num);

    /// <summary>
    /// New Coverage not Implemented by HMO (for inpatient service only)
    /// Amount shown is for inpatient charges covered by the HMO. (Use this code when the bill includes inpatient charges for newly covered services that are not paid by the HMO.) Note: Condition Codes 04 and 78 should also be reported.
    /// </summary>
    public static readonly ValueCode C40Money = new(Values.C40Money);

    /// <summary>
    /// Black Lung
    /// Code indicates the amount shown is that portion of a higher priority Black Lung (federal program) payment made on behalf of a Medicare beneficiary. Note: The reporting of zero indicates the provider is claiming a conditional payment because there has been a substantial delay in payment from the Black Lung Program.
    /// </summary>
    public static readonly ValueCode C41Money = new(Values.C41Money);

    /// <summary>
    /// VA or PACE
    /// Code indicates the amount shown is that portion of a higher priority VA or PACE payment made on behalf of a Medicare beneficiary and that you are applying to Medicare as secondary payer for covered Medicare services on this claim.
    /// </summary>
    public static readonly ValueCode C42Money = new(Values.C42Money);

    /// <summary>
    /// Disabled Beneficiary Under Age 65 with LGHP
    /// Code indicates the amount shown is that portion of a higher priority LGHP payment made on behalf of a disabled beneficiary that you are applying to covered Medicare charges on this bill.
    /// </summary>
    public static readonly ValueCode C43Money = new(Values.C43Money);

    /// <summary>
    /// Amount Provider Agreed to Accept from Primary Payer when this Amount is less than Charges but Higher than Payment Received
    /// Report the amount the provider was obligated to accept from a primary payer when the amount is less than charges but higher than or equal to the payment received. Secondary payment may be due. Note: The following value codes report the actual amounts paid: 12- 16, 41-43, and 47. Value Code 44 should always be equal to, or, greater than the amounts indicated in the value codes indicated immediately above.
    /// </summary>
    public static readonly ValueCode C44Money = new(Values.C44Money);

    /// <summary>
    /// Accident Hour
    /// The hour when the accident occurred that necessitated medical treatment. 00 12:00 - 12:59 (Midnight), 13 01:00 - 01:59, 01 01:00 - 01:59, 14 02:00 - 02:59, 02 02:00 - 02:59, 15 03:00 - 03:59, 03 03:00 - 03:59, 16 04:00 - 04:59, 04 04:00 - 04:59, 17 05:00 - 05:59, 05 05:00 - 05:59, 18 06:00 - 06:59, 06 06:00 - 06:59, 19 07:00 - 07:59, 07 07:00 - 07:59, 20 08:00 - 08:59, 08 08:00 - 08:59, 21 09:00 - 09:59, 09 09:00 - 09:59, 22 10:00 - 10:59, 10 10:00 - 10:59, 23 11:00 - 11:59, 11 11:00 - 11:59, 99 Unknown, 12 12:00 - 12:59 (Noon)
    /// </summary>
    public static readonly ValueCode C45Num = new(Values.C45Num);

    /// <summary>
    /// Number of Grace Days
    /// Follows the QIO determination. This is the number of days determined by the QIO (medical necessity reviewer) as necessary to arrange for the patient’s post-discharge care.
    /// </summary>
    public static readonly ValueCode C46Num = new(Values.C46Num);

    /// <summary>
    /// Any Liability Insurance
    /// Amount shown is that portion from a higher priority liability insurance made on behalf of a Medicare beneficiary that the provider is applying to Medicare covered services on this bill. Enter zero in the amount field if you are claiming a conditional payment.
    /// </summary>
    public static readonly ValueCode C47Money = new(Values.C47Money);

    /// <summary>
    /// Hemoglobin Reading
    /// The most recent hemoglobin reading taken before the start of this billing period. For patients just starting, use the most recent value prior to the onset if treatment. The reading is a 3-byte numeric element (XX.X). Results exceeding 3-position numeric elements (e.g., 10.50) are reported as 10.5.
    /// </summary>
    public static readonly ValueCode C48Num = new(Values.C48Num);

    /// <summary>
    /// Hematocrit Reading
    /// The most recent hematocrit reading taken before the start of this billing period. For patients just starting, use the most recent value prior to the onset if treatment. The reading is a 3-byte numeric element (XX.X). Results exceeding 3-position numeric elements (e.g., l0.50) are reported as 10.5.
    /// </summary>
    public static readonly ValueCode C49Num = new(Values.C49Num);

    /// <summary>
    /// Physical Therapy Visits
    /// Report the number of physical therapy visits provided from the onset of treatment from this billing provider through this billing period.
    /// </summary>
    public static readonly ValueCode C50Num = new(Values.C50Num);

    /// <summary>
    /// Occupational Therapy Visits
    /// Report the number of occupational therapy visits provided from the onset of treatment from this billing provider) through this billing period.
    /// </summary>
    public static readonly ValueCode C51Num = new(Values.C51Num);

    /// <summary>
    /// Speech Therapy Visits
    /// Report the number of speech therapy visits provided from the onset of treatment by this billing provider through this period.
    /// </summary>
    public static readonly ValueCode C52Num = new(Values.C52Num);

    /// <summary>
    /// Cardiac Rehab Visits
    /// The number of cardiac rehabilitation visits from the onset of treatment from the billing provider through this billing period.
    /// </summary>
    public static readonly ValueCode C53Num = new(Values.C53Num);

    /// <summary>
    /// Newborn Birth Weight in Grams
    /// Actual birth weight or weight at time of admission for an extramural birth. Required on all claims with Priority (Type) of Admission of 4 and on other claims as required by state law.
    /// </summary>
    public static readonly ValueCode C54Num = new(Values.C54Num);

    /// <summary>
    /// Eligibility Threshold for Charity Care
    /// The amount at which a health care facility determines the eligibility threshold for charity care.
    /// </summary>
    public static readonly ValueCode C55Money = new(Values.C55Money);

    /// <summary>
    /// Skilled Nurse - Home Visit Hours (HHA only)
    /// The number of home visit hours of skilled nursing provided during the billing period. Count only hours spent in the home.  Exclude travel time. Report in whole hours, rounded to the nearest whole hour.
    /// </summary>
    public static readonly ValueCode C56Num = new(Values.C56Num);

    /// <summary>
    /// Home Health Aide - Home Visit Hours (HHA only)
    /// The number of hours of home health aide services provided during the billing period.  Count only hours spent in the home. Exclude travel time. Report in whole hours, rounded to the nearest whole hour.
    /// </summary>
    public static readonly ValueCode C57Num = new(Values.C57Num);

    /// <summary>
    /// Arterial Blood Gas (P02)
    /// Arterial blood gas value at beginning of each reporting period for oxygen therapy. This value or the value in Value Code 59 will be required on the initial bill for oxygen therapy and on the fourth month’s bill.  Report two digits rounded to the nearest whole number. Example: A value of 56.5 should be reported as 57.
    /// </summary>
    public static readonly ValueCode C58Num = new(Values.C58Num);

    /// <summary>
    /// Oxygen Saturation Oximetry
    /// Oxygen percent saturation at the beginning of each reporting period for oxygen therapy. This value or the value in Value Code 58 will be required on the initial bill for oxygen therapy and on the fourth month’s bill.  Report two digits rounded to the nearest whole percent. Example: 93.5 percent should be reported as 0.94. A value of 100 percent would be reported as 1.
    /// </summary>
    public static readonly ValueCode C59Num = new(Values.C59Num);

    /// <summary>
    /// HHA Branch MSA
    /// MSA in which HHA branch is located (Report MSA when branch location is different than the HHA’s.
    /// </summary>
    public static readonly ValueCode C60Num = new(Values.C60Num);

    /// <summary>
    /// Place of Residence where Service is Furnished (HHA and Hospice)
    /// MSA or Core Based Statistical Area (CBSA) number (or rural state code) of the place of residence where the home health or hospice service is delivered.
    /// </summary>
    public static readonly ValueCode C61Num = new(Values.C61Num);

    /// <summary>
    /// Medicaid Spend Down Amount
    /// The dollar amount that was used to meet the recipient’s spend down liability for this claim.
    /// </summary>
    public static readonly ValueCode C66Money = new(Values.C66Money);

    /// <summary>
    /// Peritoneal Dialysis
    /// The number of hours of peritoneal dialysis provided during the billing period.  Count only the hours spent in the home. Exclude travel time. Report in whole hours, rounded to the nearest whole hour.
    /// </summary>
    public static readonly ValueCode C67Num = new(Values.C67Num);

    /// <summary>
    /// EPO-Drug
    /// Number of units of EPO administered and/or supplied relating to the billing period. Report amount in whole units.
    /// </summary>
    public static readonly ValueCode C68Num = new(Values.C68Num);

    /// <summary>
    /// State Charity Care Percent
    /// Code indicates the percentage of charity care eligibility for the patient.  For example, a rate of 10.5% is shown as: 0 . 1 0 5
    /// </summary>
    public static readonly ValueCode C69Num = new(Values.C69Num);

    /// <summary>
    /// Covered Days
    /// The number of days covered by the primary payer as qualified by the payer.
    /// </summary>
    public static readonly ValueCode C80Num = new(Values.C80Num);

    /// <summary>
    /// Non-covered Days
    /// Days of care not covered by the primary payer.
    /// </summary>
    public static readonly ValueCode C81Num = new(Values.C81Num);

    /// <summary>
    /// Co-insurance Days
    /// The inpatient Medicare days occurring after the 60th day and before the 91st day or inpatient SNF/Swing Bed days occurring after the 20th and before the 101st day in a single spell of illness.
    /// </summary>
    public static readonly ValueCode C82Num = new(Values.C82Num);

    /// <summary>
    /// Lifetime Reserve Days
    /// Under Medicare, each beneficiary has a lifetime reserve of 60 additional days of inpatient hospital services after using 90 days of inpatient hospital services during a spell of illness.
    /// </summary>
    public static readonly ValueCode C83Num = new(Values.C83Num);

    /// <summary>
    /// Shorter Duration Hemodialysis
    /// The number of sessions per week as specified in the patient’s plan of care for hemodialysis that is shorter in duration (Revenue Code 0826) than conventional sessions (reported under Revenue Code 0821).
    /// </summary>
    public static readonly ValueCode C84Num = new(Values.C84Num);

    /// <summary>
    /// County where Service is Rendered (Effective 1/1/19)
    /// Report the Federal Information Processing Standards (FIPS) state and county codes when required by law or regulation with no space between the state code and the county code.
    /// </summary>
    public static readonly ValueCode C85Num = new(Values.C85Num);

    /// <summary>
    /// Gene Therapy Invoice Cost (Effective 4/1/20)
    /// Invoice/acquisition cost of modified biologics. For use with Revenue Category 0892.
    /// </summary>
    public static readonly ValueCode C87Money = new(Values.C87Money);

    /// <summary>
    /// Allogeneic Stem Cell Transplant – Total All-inclusive Donor Charges (Effective 7/1/20)
    /// Report on the recipient’s stem cell transplant claim the total of all donor charges, including charges billed on separately submitted claims.
    /// </summary>
    public static readonly ValueCode C89Money = new(Values.C89Money);

    /// <summary>
    /// Cell Therapy Invoice Cost (Effective 4/1/20)
    /// Invoice/acquisition cost of modified biologics. For use with Revenue Category 0891.
    /// </summary>
    public static readonly ValueCode C90Money = new(Values.C90Money);

    /// <summary>
    /// Charges for Kidney Acquisition (Effective 10/1/21)
    /// Used by providers to identify charges for kidney acquisitions when mandated by state or federal law or regulation.
    /// </summary>
    public static readonly ValueCode C91Money = new(Values.C91Money);

    /// <summary>
    /// Special ZIP Code Reporting
    /// Five digit ZIP Code of the location from which the beneficiary is initially placed on board the ambulance.
    /// </summary>
    public static readonly ValueCode Ca0Num = new(Values.Ca0Num);

    /// <summary>
    /// Deductible Payer A
    /// The amount assumed by the provider to be applied to the patient’s policy/program deductible amount involving the indicated payer. (Note: Report Medicare blood deductibles under Value Code 6.)
    /// </summary>
    public static readonly ValueCode Ca1Money = new(Values.Ca1Money);

    /// <summary>
    /// Coinsurance Payer A
    /// The amount assumed by the provider to be applied toward the patient’s coinsurance amount involving the indicated payer. (Note: For Medicare, use this code only for reporting Part B coinsurance amounts. For Part A coinsurance amounts use Value Codes 8-11.)
    /// </summary>
    public static readonly ValueCode Ca2Money = new(Values.Ca2Money);

    /// <summary>
    /// Estimated Responsibility Payer A
    /// The amount estimated by the provider to be paid by the indicated payer; it is not the actual payment.
    /// </summary>
    public static readonly ValueCode Ca3Money = new(Values.Ca3Money);

    /// <summary>
    /// Covered Self-administrable Drugs - Emergency
    /// The covered charge amount for self-administrable drugs administered to the patient in an emergency situation (e.g., diabetic coma). For use with Revenue Code 0637.
    /// </summary>
    public static readonly ValueCode Ca4Money = new(Values.Ca4Money);

    /// <summary>
    /// Covered Self-administrable Drugs - not Self-administrable in the Form and Situation Furnished to Patient
    /// The amount included in covered charges for self-administrable drugs administered to the patient because the drug was not self-administrable in the form and situation in which it was furnished to the patient. For use with Revenue Code 0637.
    /// </summary>
    public static readonly ValueCode Ca5Money = new(Values.Ca5Money);

    /// <summary>
    /// Covered Self-administrable Drugs - Diagnostic Study and Other
    /// The amount included in covered charges for self-administrable drugs administered to the patient because the drug was necessary for diagnostic study or other reason (e.g., the drug is specifically covered by the payer).
    /// </summary>
    public static readonly ValueCode Ca6Money = new(Values.Ca6Money);

    /// <summary>
    /// Co-payment Payer A
    /// The amount assumed by the provider to be applied toward the patient’s co-payment amount involving the indicated payer.
    /// </summary>
    public static readonly ValueCode Ca7Money = new(Values.Ca7Money);

    /// <summary>
    /// Patient Weight
    /// Weight of patient in kilograms. Report this data only when the health plan has a predefined change in reimbursement that is affected by weight. For newborns, use Value Code 54
    /// </summary>
    public static readonly ValueCode Ca8Num = new(Values.Ca8Num);

    /// <summary>
    /// Patient Height
    /// Height of patient in centimeters. Report this data only when the health plan has a predefined change in reimbursement that is affected by height.
    /// </summary>
    public static readonly ValueCode Ca9Num = new(Values.Ca9Num);

    /// <summary>
    /// Regulatory Surcharges, Assessments, Allowances or Health Care Related Taxes Payer A
    /// The amount of regulatory surcharges, assessments, allowances or health care related taxes pertaining to the indicated payer.
    /// </summary>
    public static readonly ValueCode CaaMoney = new(Values.CaaMoney);

    /// <summary>
    /// Other Assessments or Allowances (e.g., Medical Education) Payer A
    /// The amount of other assessments or allowances (e.g., medical education) pertaining to the indicated payer.
    /// </summary>
    public static readonly ValueCode CabMoney = new(Values.CabMoney);

    /// <summary>
    /// Deductible Payer B
    /// The amount assumed by the provider to be applied to the patient’s policy/program deductible amount involving the indicated payer. (Note: Medicare blood deductibles should be reported under Value Code 6.)
    /// </summary>
    public static readonly ValueCode Cb1Money = new(Values.Cb1Money);

    /// <summary>
    /// Coinsurance Payer B
    /// The amount assumed by the provider to be applied toward the patient’s coinsurance amount involving the indicated payer. For Part A coinsurance amounts use Value Codes 8-11.)
    /// </summary>
    public static readonly ValueCode Cb2Money = new(Values.Cb2Money);

    /// <summary>
    /// Estimated Responsibility Payer B
    /// The amount estimated by the provider to be paid by the indicated payer; it is not the actual payment.
    /// </summary>
    public static readonly ValueCode Cb3Money = new(Values.Cb3Money);

    /// <summary>
    /// Co-payment Payer B
    /// The amount assumed by the provider to be applied toward the patient’s co-payment amount involving the indicated payer.
    /// </summary>
    public static readonly ValueCode Cb7Money = new(Values.Cb7Money);

    /// <summary>
    /// Regulatory Surcharges, Assessments, Allowances or Health Care Related Taxes Payer B
    /// The amount of regulatory surcharges, assessments, allowances or health care related taxes pertaining to the indicated payer.
    /// </summary>
    public static readonly ValueCode CbaMoney = new(Values.CbaMoney);

    /// <summary>
    /// Other Assessments or Allowances (e.g., Medical Education) Payer B
    /// The amount of other assessments or allowances (e.g., medical education) pertaining to the indicated payer.
    /// </summary>
    public static readonly ValueCode CbbMoney = new(Values.CbbMoney);

    /// <summary>
    /// Deductible Payer C
    /// The amount assumed by the provider to be applied to the patient’s policy/program deductible amount involving the indicated payer. (Note: Medicare blood deductibles should be reported under Value Code 6.)
    /// </summary>
    public static readonly ValueCode Cc1Money = new(Values.Cc1Money);

    /// <summary>
    /// Coinsurance Payer C
    /// The amount assumed by the provider to be applied toward the patient’s coinsurance amount involving the indicated payer. For Part A coinsurance amounts use Value Codes 8-11.)
    /// </summary>
    public static readonly ValueCode Cc2Money = new(Values.Cc2Money);

    /// <summary>
    /// Estimated Responsibility Payer C
    /// The amount estimated by the provider to be paid by the indicated payer; it is not the actual payment.
    /// </summary>
    public static readonly ValueCode Cc3Money = new(Values.Cc3Money);

    /// <summary>
    /// Co-payment Payer C
    /// The amount assumed by the provider to be applied toward the patient’s co-payment amount involving the indicated payer.
    /// </summary>
    public static readonly ValueCode Cc7Money = new(Values.Cc7Money);

    /// <summary>
    /// Regulatory Surcharges, Assessments, Allowances or Health Care Related Taxes Payer C
    /// The amount of regulatory surcharges, assessments, allowances or health care related taxes pertaining to the indicated payer.
    /// </summary>
    public static readonly ValueCode CcaMoney = new(Values.CcaMoney);

    /// <summary>
    /// Other Assessments or Allowances (e.g., Medical Education) Payer C
    /// The amount of other assessments or allowances (e.g., medical education) pertaining to the indicated payer.
    /// </summary>
    public static readonly ValueCode CcbMoney = new(Values.CcbMoney);

    /// <summary>
    /// Patient Estimated Responsibility
    /// The amount estimated by the provider to be paid by the indicated patient.
    /// </summary>
    public static readonly ValueCode Cd3Money = new(Values.Cd3Money);

    /// <summary>
    /// Clinical Trial Number Assigned by NLM/NIH
    /// 8-digit, numeric National Library of Medicine/ National Institutes of Health assigned clinical trial number.
    /// </summary>
    public static readonly ValueCode Cd4Num = new(Values.Cd4Num);

    /// <summary>
    /// Last Kt/V Reading (Effective 7/1/10)
    /// Result of last Kt/V reading. For in-center hemodialysis patients, this is the last reading taken during the billing period. For peritoneal dialysis patients (and home hemodialysis patients), this may be before the current billing period but should be within 4 months of the date of service.
    /// </summary>
    public static readonly ValueCode Cd5Num = new(Values.Cd5Num);

    /// <summary>
    /// Total Number of Minutes of Dialysis Provided During the Billing Period. (Effective 1/1/21)
    /// The machine reported number of minutes (rounded to the nearest whole minute) of dialysis treatment time.  The total count includes only the minutes spent dialyzing. The duration begins when the treatment starts and ends when the treatment is complete. The units reported must exceed 1.  For Medicare ESRD claims. See Medicare manual for further instructions on the use of this code along with other related UB codes.
    /// </summary>
    public static readonly ValueCode Cd6Num = new(Values.Cd6Num);

    /// <summary>
    /// Patient Paid Amount
    /// The amount the provider has received from the patient toward payment of this bill. (Effective 7/1/08)
    /// </summary>
    public static readonly ValueCode CfcMoney = new(Values.CfcMoney);

    /// <summary>
    /// Credit Received from the Manufacturer for a Medical Device
    /// The amount the provider has received from a medical device manufacturer as credit for a medical device. (Effective 7/1/15)
    /// </summary>
    public static readonly ValueCode CfdMoney = new(Values.CfdMoney);

    /// <summary>
    /// Facility where Inpatient Hospice Service is Delivered
    /// MSA or Core Based Statistical Area (CBSA) number (or rural state code) of the facility where inpatient hospice service is delivered.
    /// </summary>
    public static readonly ValueCode Cg8Num = new(Values.Cg8Num);

    /// <summary>
    /// Heart Rate (Effective 7/1/19)
    /// FOR PUBLIC HEALTH DATAREPORTING ONLY when required by state or federal law or regulations. Code indicates patient heart rate in beats per minute taken upon arrival for treatment.
    /// </summary>
    public static readonly ValueCode Cp1Num = new(Values.Cp1Num);

    /// <summary>
    /// Blood Pressure – Systolic (Effective 7/1/19)
    /// FOR PUBLIC HEALTH DATA REPORTING ONLY when required by state or federal law or regulations. Code indicates patient systolic blood pressure in mg/dl, taken upon arrival for treatment.
    /// </summary>
    public static readonly ValueCode Cp2Num = new(Values.Cp2Num);

    /// <summary>
    /// Blood Pressure – Diastolic (Effective 7/1/19)
    /// FOR PUBLIC HEALTH DATAREPORTING ONLY when required by state or federal law or regulations. Code indicates patient diastolic blood pressure in mg/dl, taken upon arrival for treatment.
    /// </summary>
    public static readonly ValueCode Cp3Num = new(Values.Cp3Num);

    /// <summary>
    /// Part A Demonstration Payment
    /// This is the portion of the payment designated as reimbursement for Part A services under the demonstration/model.
    /// </summary>
    public static readonly ValueCode Cy1Money = new(Values.Cy1Money);

    /// <summary>
    /// Part B Demonstration Payment
    /// This is the portion of the payment designated as reimbursement for Part B services under the demonstration/model. No deductible or coinsurance has been applied.
    /// </summary>
    public static readonly ValueCode Cy2Money = new(Values.Cy2Money);

    /// <summary>
    /// Part B Coinsurance
    /// This is the amount of Part B coinsurance applied by the A/B MAC to this demonstration/model claim.
    /// </summary>
    public static readonly ValueCode Cy3Money = new(Values.Cy3Money);

    /// <summary>
    /// Conventional Provider Payment
    /// This is the amount Medicare would have reimbursed the provider for Part A services if there had been no demonstration/model.
    /// </summary>
    public static readonly ValueCode Cy4Money = new(Values.Cy4Money);

    /// <summary>
    /// Part B Deductible (Effective 4/1/13)
    /// This is the amount of Part B deductible applied by the A/B MAC to this demonstration/model claim.
    /// </summary>
    public static readonly ValueCode Cy5Money = new(Values.Cy5Money);

    public ValueCode(string value)
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
    public static ValueCode FromCustom(string value)
    {
        return new ValueCode(value);
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

    public static bool operator ==(ValueCode value1, string value2) => value1.Value.Equals(value2);

    public static bool operator !=(ValueCode value1, string value2) => !value1.Value.Equals(value2);

    public static explicit operator string(ValueCode value) => value.Value;

    public static explicit operator ValueCode(string value) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        /// <summary>
        /// Most Common Semi-private Rate
        /// To provide for the recording of hospital’s most common semi-private rate.
        /// </summary>
        public const string C01Money = "01";

        /// <summary>
        /// Hospital has no Semi-private Rooms
        /// Entering this code requires $0.00 amount.
        /// </summary>
        public const string C02Money = "02";

        /// <summary>
        /// Professional Component Charges which are Combined Billed
        /// Code indicates the amount shown is the sum of technical and professional charges, which are combined billed. Medicare uses this information in internal processes and in the CMS notice of utilization sent to the patient to explain that Part B coinsurance applies to the professional component.
        /// </summary>
        public const string C04Money = "04";

        /// <summary>
        /// Professional Component Included in Charges and also Billed Separate to Carrier
        /// Amount shown is the combined billed charges (technical and professional); however the provider is submitting a separate professional bill to the health plan. For use on Medicare or TRICARE bills and all Medicaid bills if state specifies need for this information.
        /// </summary>
        public const string C05Money = "05";

        /// <summary>
        /// Blood Deductible
        /// Total cash blood deductible. If appropriate, enter Medicare Part A or Part B blood deductible amount. (To report other than the blood deductible, that is to report the program deductible, see Value Codes (FL39-FL41) A1, B1, and C1.)
        /// </summary>
        public const string C06Money = "06";

        /// <summary>
        /// Life Time Reserve Amount in the First Calendar Year
        /// Lifetime reserve amount charged in the year of admission. Note: For Medicare, use this code only for Part A bills. For Part B Coinsurance use Value Codes (FL39-41) A2, B2, and C2).
        /// </summary>
        public const string C08Money = "08";

        /// <summary>
        /// Coinsurance Amount in the First Calendar Year
        /// Coinsurance amounts, charged in the year of admission.
        /// </summary>
        public const string C09Money = "09";

        /// <summary>
        /// Lifetime Reserve Amount in the Second Calendar Year
        /// Lifetime reserve amount charged in the year of discharge where the bill spans two calendar years.
        /// </summary>
        public const string C10Money = "10";

        /// <summary>
        /// Coinsurance Amount in the Second Calendar Year
        /// Coinsurance amount charged in the year of discharge where the inpatient bill spans two calendar years.
        /// </summary>
        public const string C11Money = "11";

        /// <summary>
        /// Working Aged Beneficiary/Spouse with Employer Group Health Plan
        /// Amount shown reflects that portion of a payment from a higher priority employer group health insurance made on behalf of an aged beneficiary. For Medicare purposes the provider is billing Medicare as the secondary, payer (based on MSP development) for covered services on this bill.
        /// </summary>
        public const string C12Money = "12";

        /// <summary>
        /// ESRD Beneficiary in a Medicare Coordination Period with an Employer Group Health Plan
        /// Amount shown is that portion of a payment from a higher priority employer group health insurance payment made on behalf of an ESRD beneficiary that the provider is applying to Medicare covered services on this bill.
        /// </summary>
        public const string C13Money = "13";

        /// <summary>
        /// No-Fault, Including Auto/Other
        /// Amount shown is that portion from a higher priority no-fault insurance, including auto/other made on behalf of the patient or insured. For Medicare beneficiaries, the provider should apply this amount to the Medicare covered services on this bill.
        /// </summary>
        public const string C14Money = "14";

        /// <summary>
        /// Worker’s Compensation
        /// Amount shown is that portion of a payment from a higher priority worker’s compensation insurance made on behalf of the patient or insured. For Medicare beneficiaries the provider should apply this amount to Medicare covered services on this bill.
        /// </summary>
        public const string C15Money = "15";

        /// <summary>
        /// PHS, or Other Federal Agency
        /// Amount shown is that portion of a payment from a higher priority Public Health Service or the Federal Agency made on behalf of a Medicare beneficiary that the provider is applying to Medicare covered services on this bill.
        /// </summary>
        public const string C16Money = "16";

        /// <summary>
        /// Catastrophic
        /// Catastrophic Medicaid-eligibility and coverage requirements determined at the state level.
        /// </summary>
        public const string C21Money = "21";

        /// <summary>
        /// Surplus Income
        /// Surplus (or excess) income as designated by Medicaid eligibility requirements determined at the state level.
        /// </summary>
        public const string C22Money = "22";

        /// <summary>
        /// Recurring Monthly Income
        /// Monthly income as designated by Medicaid-eligibility requirements determined at the state level.
        /// </summary>
        public const string C23Money = "23";

        /// <summary>
        /// Medicaid Rate Code
        /// Code indicating the payment or reimbursement rate designated by Medicaid at the state level.
        /// </summary>
        public const string C24Num = "24";

        /// <summary>
        /// Offset to the Patient-Payment Amount - Prescription Drugs
        /// Prescription drugs paid for out of a long-term care facility resident/patient’s funds in the billing period submitted (Statement Covers Period).
        /// </summary>
        public const string C25Money = "25";

        /// <summary>
        /// Offset to the Patient-Payment Amount - Hearing and Ear Services
        /// Hearing and ear services paid for out of a long-term care facility resident/patient’s funds in the billing period submitted (Statement Covers Period).
        /// </summary>
        public const string C26Money = "26";

        /// <summary>
        /// Offset to the Patient-Payment Amount - Vision and Eye Services
        /// Vision and eye services paid for out of a long-term care facility resident/patient’s funds in the billing period submitted (Statement Covers Period).
        /// </summary>
        public const string C27Money = "27";

        /// <summary>
        /// Offset to the Patient-Payment Amount - Dental Services
        /// Dental services paid for out of a long-term care facility resident/patient’s funds in the billing period submitted (Statement Covers Period).
        /// </summary>
        public const string C28Money = "28";

        /// <summary>
        /// Offset to the Patient-Payment Amount - Chiropractic Services
        /// Chiropractic services paid for out of a long-term care facility resident/patient’s funds in the billing period submitted (Statement Covers Period).
        /// </summary>
        public const string C29Money = "29";

        /// <summary>
        /// Preadmission Testing
        /// This code reflects charges for preadmission outpatient diagnostic services in preparation for a previously scheduled admission.
        /// </summary>
        public const string C30Money = "30";

        /// <summary>
        /// Patient Liability Amount
        /// Approved amount to charge the beneficiary for non-covered accommodations, diagnostic procedures or treatments.
        /// </summary>
        public const string C31Money = "31";

        /// <summary>
        /// Multiple Patient Ambulance Transport
        /// When more than one patient is transported in a single ambulance trip, report the total number of patients transported.
        /// </summary>
        public const string C32Num = "32";

        /// <summary>
        /// Offset to the Patient-Payment Amount - Podiatric Services
        /// Podiatric services paid for out of a long-term care facility resident/patient’s funds in the billing period submitted (Statement Covers Period).
        /// </summary>
        public const string C33Money = "33";

        /// <summary>
        /// Offset to the Patient-Payment Amount - Other Medical Services
        /// Other medical services paid for out of a long-term care facility resident/patient’s funds in the billing period submitted (Statement Covers Period).
        /// </summary>
        public const string C34Money = "34";

        /// <summary>
        /// Offset to the Patient-Payment Amount - Health Insurance Premiums
        /// Health insurance premiums paid for out of long-term care facility resident/patient’s funds in the billing period submitted (Statement Covers Period).
        /// </summary>
        public const string C35Money = "35";

        /// <summary>
        /// Units of Blood Furnished
        /// The total number of units of whole blood or packed red cells furnished to the patient, regardless of whether the hospital charges for blood or not.
        /// </summary>
        public const string C37Num = "37";

        /// <summary>
        /// Blood Deductible Units
        /// The number of unreplaced deductible units of packed red cells furnished for which the patient is responsible. If all deductible units furnished have been replaced, no entry is made.
        /// </summary>
        public const string C38Num = "38";

        /// <summary>
        /// Units of Blood Replaced
        /// The total number of units of whole blood or packed red cells furnished to the patient that have been replaced by or on behalf of the patient.
        /// </summary>
        public const string C39Num = "39";

        /// <summary>
        /// New Coverage not Implemented by HMO (for inpatient service only)
        /// Amount shown is for inpatient charges covered by the HMO. (Use this code when the bill includes inpatient charges for newly covered services that are not paid by the HMO.) Note: Condition Codes 04 and 78 should also be reported.
        /// </summary>
        public const string C40Money = "40";

        /// <summary>
        /// Black Lung
        /// Code indicates the amount shown is that portion of a higher priority Black Lung (federal program) payment made on behalf of a Medicare beneficiary. Note: The reporting of zero indicates the provider is claiming a conditional payment because there has been a substantial delay in payment from the Black Lung Program.
        /// </summary>
        public const string C41Money = "41";

        /// <summary>
        /// VA or PACE
        /// Code indicates the amount shown is that portion of a higher priority VA or PACE payment made on behalf of a Medicare beneficiary and that you are applying to Medicare as secondary payer for covered Medicare services on this claim.
        /// </summary>
        public const string C42Money = "42";

        /// <summary>
        /// Disabled Beneficiary Under Age 65 with LGHP
        /// Code indicates the amount shown is that portion of a higher priority LGHP payment made on behalf of a disabled beneficiary that you are applying to covered Medicare charges on this bill.
        /// </summary>
        public const string C43Money = "43";

        /// <summary>
        /// Amount Provider Agreed to Accept from Primary Payer when this Amount is less than Charges but Higher than Payment Received
        /// Report the amount the provider was obligated to accept from a primary payer when the amount is less than charges but higher than or equal to the payment received. Secondary payment may be due. Note: The following value codes report the actual amounts paid: 12- 16, 41-43, and 47. Value Code 44 should always be equal to, or, greater than the amounts indicated in the value codes indicated immediately above.
        /// </summary>
        public const string C44Money = "44";

        /// <summary>
        /// Accident Hour
        /// The hour when the accident occurred that necessitated medical treatment. 00 12:00 - 12:59 (Midnight), 13 01:00 - 01:59, 01 01:00 - 01:59, 14 02:00 - 02:59, 02 02:00 - 02:59, 15 03:00 - 03:59, 03 03:00 - 03:59, 16 04:00 - 04:59, 04 04:00 - 04:59, 17 05:00 - 05:59, 05 05:00 - 05:59, 18 06:00 - 06:59, 06 06:00 - 06:59, 19 07:00 - 07:59, 07 07:00 - 07:59, 20 08:00 - 08:59, 08 08:00 - 08:59, 21 09:00 - 09:59, 09 09:00 - 09:59, 22 10:00 - 10:59, 10 10:00 - 10:59, 23 11:00 - 11:59, 11 11:00 - 11:59, 99 Unknown, 12 12:00 - 12:59 (Noon)
        /// </summary>
        public const string C45Num = "45";

        /// <summary>
        /// Number of Grace Days
        /// Follows the QIO determination. This is the number of days determined by the QIO (medical necessity reviewer) as necessary to arrange for the patient’s post-discharge care.
        /// </summary>
        public const string C46Num = "46";

        /// <summary>
        /// Any Liability Insurance
        /// Amount shown is that portion from a higher priority liability insurance made on behalf of a Medicare beneficiary that the provider is applying to Medicare covered services on this bill. Enter zero in the amount field if you are claiming a conditional payment.
        /// </summary>
        public const string C47Money = "47";

        /// <summary>
        /// Hemoglobin Reading
        /// The most recent hemoglobin reading taken before the start of this billing period. For patients just starting, use the most recent value prior to the onset if treatment. The reading is a 3-byte numeric element (XX.X). Results exceeding 3-position numeric elements (e.g., 10.50) are reported as 10.5.
        /// </summary>
        public const string C48Num = "48";

        /// <summary>
        /// Hematocrit Reading
        /// The most recent hematocrit reading taken before the start of this billing period. For patients just starting, use the most recent value prior to the onset if treatment. The reading is a 3-byte numeric element (XX.X). Results exceeding 3-position numeric elements (e.g., l0.50) are reported as 10.5.
        /// </summary>
        public const string C49Num = "49";

        /// <summary>
        /// Physical Therapy Visits
        /// Report the number of physical therapy visits provided from the onset of treatment from this billing provider through this billing period.
        /// </summary>
        public const string C50Num = "50";

        /// <summary>
        /// Occupational Therapy Visits
        /// Report the number of occupational therapy visits provided from the onset of treatment from this billing provider) through this billing period.
        /// </summary>
        public const string C51Num = "51";

        /// <summary>
        /// Speech Therapy Visits
        /// Report the number of speech therapy visits provided from the onset of treatment by this billing provider through this period.
        /// </summary>
        public const string C52Num = "52";

        /// <summary>
        /// Cardiac Rehab Visits
        /// The number of cardiac rehabilitation visits from the onset of treatment from the billing provider through this billing period.
        /// </summary>
        public const string C53Num = "53";

        /// <summary>
        /// Newborn Birth Weight in Grams
        /// Actual birth weight or weight at time of admission for an extramural birth. Required on all claims with Priority (Type) of Admission of 4 and on other claims as required by state law.
        /// </summary>
        public const string C54Num = "54";

        /// <summary>
        /// Eligibility Threshold for Charity Care
        /// The amount at which a health care facility determines the eligibility threshold for charity care.
        /// </summary>
        public const string C55Money = "55";

        /// <summary>
        /// Skilled Nurse - Home Visit Hours (HHA only)
        /// The number of home visit hours of skilled nursing provided during the billing period. Count only hours spent in the home.  Exclude travel time. Report in whole hours, rounded to the nearest whole hour.
        /// </summary>
        public const string C56Num = "56";

        /// <summary>
        /// Home Health Aide - Home Visit Hours (HHA only)
        /// The number of hours of home health aide services provided during the billing period.  Count only hours spent in the home. Exclude travel time. Report in whole hours, rounded to the nearest whole hour.
        /// </summary>
        public const string C57Num = "57";

        /// <summary>
        /// Arterial Blood Gas (P02)
        /// Arterial blood gas value at beginning of each reporting period for oxygen therapy. This value or the value in Value Code 59 will be required on the initial bill for oxygen therapy and on the fourth month’s bill.  Report two digits rounded to the nearest whole number. Example: A value of 56.5 should be reported as 57.
        /// </summary>
        public const string C58Num = "58";

        /// <summary>
        /// Oxygen Saturation Oximetry
        /// Oxygen percent saturation at the beginning of each reporting period for oxygen therapy. This value or the value in Value Code 58 will be required on the initial bill for oxygen therapy and on the fourth month’s bill.  Report two digits rounded to the nearest whole percent. Example: 93.5 percent should be reported as 0.94. A value of 100 percent would be reported as 1.
        /// </summary>
        public const string C59Num = "59";

        /// <summary>
        /// HHA Branch MSA
        /// MSA in which HHA branch is located (Report MSA when branch location is different than the HHA’s.
        /// </summary>
        public const string C60Num = "60";

        /// <summary>
        /// Place of Residence where Service is Furnished (HHA and Hospice)
        /// MSA or Core Based Statistical Area (CBSA) number (or rural state code) of the place of residence where the home health or hospice service is delivered.
        /// </summary>
        public const string C61Num = "61";

        /// <summary>
        /// Medicaid Spend Down Amount
        /// The dollar amount that was used to meet the recipient’s spend down liability for this claim.
        /// </summary>
        public const string C66Money = "66";

        /// <summary>
        /// Peritoneal Dialysis
        /// The number of hours of peritoneal dialysis provided during the billing period.  Count only the hours spent in the home. Exclude travel time. Report in whole hours, rounded to the nearest whole hour.
        /// </summary>
        public const string C67Num = "67";

        /// <summary>
        /// EPO-Drug
        /// Number of units of EPO administered and/or supplied relating to the billing period. Report amount in whole units.
        /// </summary>
        public const string C68Num = "68";

        /// <summary>
        /// State Charity Care Percent
        /// Code indicates the percentage of charity care eligibility for the patient.  For example, a rate of 10.5% is shown as: 0 . 1 0 5
        /// </summary>
        public const string C69Num = "69";

        /// <summary>
        /// Covered Days
        /// The number of days covered by the primary payer as qualified by the payer.
        /// </summary>
        public const string C80Num = "80";

        /// <summary>
        /// Non-covered Days
        /// Days of care not covered by the primary payer.
        /// </summary>
        public const string C81Num = "81";

        /// <summary>
        /// Co-insurance Days
        /// The inpatient Medicare days occurring after the 60th day and before the 91st day or inpatient SNF/Swing Bed days occurring after the 20th and before the 101st day in a single spell of illness.
        /// </summary>
        public const string C82Num = "82";

        /// <summary>
        /// Lifetime Reserve Days
        /// Under Medicare, each beneficiary has a lifetime reserve of 60 additional days of inpatient hospital services after using 90 days of inpatient hospital services during a spell of illness.
        /// </summary>
        public const string C83Num = "83";

        /// <summary>
        /// Shorter Duration Hemodialysis
        /// The number of sessions per week as specified in the patient’s plan of care for hemodialysis that is shorter in duration (Revenue Code 0826) than conventional sessions (reported under Revenue Code 0821).
        /// </summary>
        public const string C84Num = "84";

        /// <summary>
        /// County where Service is Rendered (Effective 1/1/19)
        /// Report the Federal Information Processing Standards (FIPS) state and county codes when required by law or regulation with no space between the state code and the county code.
        /// </summary>
        public const string C85Num = "85";

        /// <summary>
        /// Gene Therapy Invoice Cost (Effective 4/1/20)
        /// Invoice/acquisition cost of modified biologics. For use with Revenue Category 0892.
        /// </summary>
        public const string C87Money = "87";

        /// <summary>
        /// Allogeneic Stem Cell Transplant – Total All-inclusive Donor Charges (Effective 7/1/20)
        /// Report on the recipient’s stem cell transplant claim the total of all donor charges, including charges billed on separately submitted claims.
        /// </summary>
        public const string C89Money = "89";

        /// <summary>
        /// Cell Therapy Invoice Cost (Effective 4/1/20)
        /// Invoice/acquisition cost of modified biologics. For use with Revenue Category 0891.
        /// </summary>
        public const string C90Money = "90";

        /// <summary>
        /// Charges for Kidney Acquisition (Effective 10/1/21)
        /// Used by providers to identify charges for kidney acquisitions when mandated by state or federal law or regulation.
        /// </summary>
        public const string C91Money = "91";

        /// <summary>
        /// Special ZIP Code Reporting
        /// Five digit ZIP Code of the location from which the beneficiary is initially placed on board the ambulance.
        /// </summary>
        public const string Ca0Num = "A0";

        /// <summary>
        /// Deductible Payer A
        /// The amount assumed by the provider to be applied to the patient’s policy/program deductible amount involving the indicated payer. (Note: Report Medicare blood deductibles under Value Code 6.)
        /// </summary>
        public const string Ca1Money = "A1";

        /// <summary>
        /// Coinsurance Payer A
        /// The amount assumed by the provider to be applied toward the patient’s coinsurance amount involving the indicated payer. (Note: For Medicare, use this code only for reporting Part B coinsurance amounts. For Part A coinsurance amounts use Value Codes 8-11.)
        /// </summary>
        public const string Ca2Money = "A2";

        /// <summary>
        /// Estimated Responsibility Payer A
        /// The amount estimated by the provider to be paid by the indicated payer; it is not the actual payment.
        /// </summary>
        public const string Ca3Money = "A3";

        /// <summary>
        /// Covered Self-administrable Drugs - Emergency
        /// The covered charge amount for self-administrable drugs administered to the patient in an emergency situation (e.g., diabetic coma). For use with Revenue Code 0637.
        /// </summary>
        public const string Ca4Money = "A4";

        /// <summary>
        /// Covered Self-administrable Drugs - not Self-administrable in the Form and Situation Furnished to Patient
        /// The amount included in covered charges for self-administrable drugs administered to the patient because the drug was not self-administrable in the form and situation in which it was furnished to the patient. For use with Revenue Code 0637.
        /// </summary>
        public const string Ca5Money = "A5";

        /// <summary>
        /// Covered Self-administrable Drugs - Diagnostic Study and Other
        /// The amount included in covered charges for self-administrable drugs administered to the patient because the drug was necessary for diagnostic study or other reason (e.g., the drug is specifically covered by the payer).
        /// </summary>
        public const string Ca6Money = "A6";

        /// <summary>
        /// Co-payment Payer A
        /// The amount assumed by the provider to be applied toward the patient’s co-payment amount involving the indicated payer.
        /// </summary>
        public const string Ca7Money = "A7";

        /// <summary>
        /// Patient Weight
        /// Weight of patient in kilograms. Report this data only when the health plan has a predefined change in reimbursement that is affected by weight. For newborns, use Value Code 54
        /// </summary>
        public const string Ca8Num = "A8";

        /// <summary>
        /// Patient Height
        /// Height of patient in centimeters. Report this data only when the health plan has a predefined change in reimbursement that is affected by height.
        /// </summary>
        public const string Ca9Num = "A9";

        /// <summary>
        /// Regulatory Surcharges, Assessments, Allowances or Health Care Related Taxes Payer A
        /// The amount of regulatory surcharges, assessments, allowances or health care related taxes pertaining to the indicated payer.
        /// </summary>
        public const string CaaMoney = "AA";

        /// <summary>
        /// Other Assessments or Allowances (e.g., Medical Education) Payer A
        /// The amount of other assessments or allowances (e.g., medical education) pertaining to the indicated payer.
        /// </summary>
        public const string CabMoney = "AB";

        /// <summary>
        /// Deductible Payer B
        /// The amount assumed by the provider to be applied to the patient’s policy/program deductible amount involving the indicated payer. (Note: Medicare blood deductibles should be reported under Value Code 6.)
        /// </summary>
        public const string Cb1Money = "B1";

        /// <summary>
        /// Coinsurance Payer B
        /// The amount assumed by the provider to be applied toward the patient’s coinsurance amount involving the indicated payer. For Part A coinsurance amounts use Value Codes 8-11.)
        /// </summary>
        public const string Cb2Money = "B2";

        /// <summary>
        /// Estimated Responsibility Payer B
        /// The amount estimated by the provider to be paid by the indicated payer; it is not the actual payment.
        /// </summary>
        public const string Cb3Money = "B3";

        /// <summary>
        /// Co-payment Payer B
        /// The amount assumed by the provider to be applied toward the patient’s co-payment amount involving the indicated payer.
        /// </summary>
        public const string Cb7Money = "B7";

        /// <summary>
        /// Regulatory Surcharges, Assessments, Allowances or Health Care Related Taxes Payer B
        /// The amount of regulatory surcharges, assessments, allowances or health care related taxes pertaining to the indicated payer.
        /// </summary>
        public const string CbaMoney = "BA";

        /// <summary>
        /// Other Assessments or Allowances (e.g., Medical Education) Payer B
        /// The amount of other assessments or allowances (e.g., medical education) pertaining to the indicated payer.
        /// </summary>
        public const string CbbMoney = "BB";

        /// <summary>
        /// Deductible Payer C
        /// The amount assumed by the provider to be applied to the patient’s policy/program deductible amount involving the indicated payer. (Note: Medicare blood deductibles should be reported under Value Code 6.)
        /// </summary>
        public const string Cc1Money = "C1";

        /// <summary>
        /// Coinsurance Payer C
        /// The amount assumed by the provider to be applied toward the patient’s coinsurance amount involving the indicated payer. For Part A coinsurance amounts use Value Codes 8-11.)
        /// </summary>
        public const string Cc2Money = "C2";

        /// <summary>
        /// Estimated Responsibility Payer C
        /// The amount estimated by the provider to be paid by the indicated payer; it is not the actual payment.
        /// </summary>
        public const string Cc3Money = "C3";

        /// <summary>
        /// Co-payment Payer C
        /// The amount assumed by the provider to be applied toward the patient’s co-payment amount involving the indicated payer.
        /// </summary>
        public const string Cc7Money = "C7";

        /// <summary>
        /// Regulatory Surcharges, Assessments, Allowances or Health Care Related Taxes Payer C
        /// The amount of regulatory surcharges, assessments, allowances or health care related taxes pertaining to the indicated payer.
        /// </summary>
        public const string CcaMoney = "CA";

        /// <summary>
        /// Other Assessments or Allowances (e.g., Medical Education) Payer C
        /// The amount of other assessments or allowances (e.g., medical education) pertaining to the indicated payer.
        /// </summary>
        public const string CcbMoney = "CB";

        /// <summary>
        /// Patient Estimated Responsibility
        /// The amount estimated by the provider to be paid by the indicated patient.
        /// </summary>
        public const string Cd3Money = "D3";

        /// <summary>
        /// Clinical Trial Number Assigned by NLM/NIH
        /// 8-digit, numeric National Library of Medicine/ National Institutes of Health assigned clinical trial number.
        /// </summary>
        public const string Cd4Num = "D4";

        /// <summary>
        /// Last Kt/V Reading (Effective 7/1/10)
        /// Result of last Kt/V reading. For in-center hemodialysis patients, this is the last reading taken during the billing period. For peritoneal dialysis patients (and home hemodialysis patients), this may be before the current billing period but should be within 4 months of the date of service.
        /// </summary>
        public const string Cd5Num = "D5";

        /// <summary>
        /// Total Number of Minutes of Dialysis Provided During the Billing Period. (Effective 1/1/21)
        /// The machine reported number of minutes (rounded to the nearest whole minute) of dialysis treatment time.  The total count includes only the minutes spent dialyzing. The duration begins when the treatment starts and ends when the treatment is complete. The units reported must exceed 1.  For Medicare ESRD claims. See Medicare manual for further instructions on the use of this code along with other related UB codes.
        /// </summary>
        public const string Cd6Num = "D6";

        /// <summary>
        /// Patient Paid Amount
        /// The amount the provider has received from the patient toward payment of this bill. (Effective 7/1/08)
        /// </summary>
        public const string CfcMoney = "FC";

        /// <summary>
        /// Credit Received from the Manufacturer for a Medical Device
        /// The amount the provider has received from a medical device manufacturer as credit for a medical device. (Effective 7/1/15)
        /// </summary>
        public const string CfdMoney = "FD";

        /// <summary>
        /// Facility where Inpatient Hospice Service is Delivered
        /// MSA or Core Based Statistical Area (CBSA) number (or rural state code) of the facility where inpatient hospice service is delivered.
        /// </summary>
        public const string Cg8Num = "G8";

        /// <summary>
        /// Heart Rate (Effective 7/1/19)
        /// FOR PUBLIC HEALTH DATAREPORTING ONLY when required by state or federal law or regulations. Code indicates patient heart rate in beats per minute taken upon arrival for treatment.
        /// </summary>
        public const string Cp1Num = "P1";

        /// <summary>
        /// Blood Pressure – Systolic (Effective 7/1/19)
        /// FOR PUBLIC HEALTH DATA REPORTING ONLY when required by state or federal law or regulations. Code indicates patient systolic blood pressure in mg/dl, taken upon arrival for treatment.
        /// </summary>
        public const string Cp2Num = "P2";

        /// <summary>
        /// Blood Pressure – Diastolic (Effective 7/1/19)
        /// FOR PUBLIC HEALTH DATAREPORTING ONLY when required by state or federal law or regulations. Code indicates patient diastolic blood pressure in mg/dl, taken upon arrival for treatment.
        /// </summary>
        public const string Cp3Num = "P3";

        /// <summary>
        /// Part A Demonstration Payment
        /// This is the portion of the payment designated as reimbursement for Part A services under the demonstration/model.
        /// </summary>
        public const string Cy1Money = "Y1";

        /// <summary>
        /// Part B Demonstration Payment
        /// This is the portion of the payment designated as reimbursement for Part B services under the demonstration/model. No deductible or coinsurance has been applied.
        /// </summary>
        public const string Cy2Money = "Y2";

        /// <summary>
        /// Part B Coinsurance
        /// This is the amount of Part B coinsurance applied by the A/B MAC to this demonstration/model claim.
        /// </summary>
        public const string Cy3Money = "Y3";

        /// <summary>
        /// Conventional Provider Payment
        /// This is the amount Medicare would have reimbursed the provider for Part A services if there had been no demonstration/model.
        /// </summary>
        public const string Cy4Money = "Y4";

        /// <summary>
        /// Part B Deductible (Effective 4/1/13)
        /// This is the amount of Part B deductible applied by the A/B MAC to this demonstration/model claim.
        /// </summary>
        public const string Cy5Money = "Y5";
    }
}
