using System.Text.Json.Serialization;
using Candid.Net.Core;

namespace Candid.Net.HealthCareCodeInformation.V1;

[JsonConverter(typeof(StringEnumSerializer<ConditionCode>))]
[Serializable]
public readonly record struct ConditionCode : IStringEnum
{
    /// <summary>
    /// MILITARY SERVICE RELATED - Medical condition incurred during military service.
    /// </summary>
    public static readonly ConditionCode C01 = new(Values.C01);

    /// <summary>
    /// CONDITION IS EMPLOYMENT RELATED - Patient alleges that medical condition is due to environment/events resulting from employment.
    /// </summary>
    public static readonly ConditionCode C02 = new(Values.C02);

    /// <summary>
    /// PATIENT COVERED BY INSURANCE NOT REFLECTED HERE - Indicates that patient/patient representative has stated that coverage may exist beyond that reflected on this bill.
    /// </summary>
    public static readonly ConditionCode C03 = new(Values.C03);

    /// <summary>
    /// INFORMATION ONLY BILL - Indicates submission of bill is for informational purposes only. Examples would include a bill submitted as a utilization report, or a bill for a beneficiary who enrolled in a risk-based managed care plan and the hospital expects to receive payment from the plan.
    /// </summary>
    public static readonly ConditionCode C04 = new(Values.C04);

    /// <summary>
    /// LIEN HAS BEEN FILED - Provider has filed legal claim for recovery of funds potentially due a patient resulting from legal action initiated by or on behalf of the patient.
    /// </summary>
    public static readonly ConditionCode C05 = new(Values.C05);

    /// <summary>
    /// ESRD PATIENT IN FIRST 30 MONTHS OF ENTITLEMENT COVERED BY EMPLOYER GROUP HEALTH INSURANCE - Code indicates Medicare as the secondary insurer because the patient also is covered through an employer group health insurance during his first 30 months of End Stage Renal Disease (ESRD) entitlement.
    /// </summary>
    public static readonly ConditionCode C06 = new(Values.C06);

    /// <summary>
    /// TREATMENT OF NON-TERMINAL CONDITION FOR HOSPICE PATIENT - Code indicates the patient is a hospice enrollee, but the provider is not treating his terminal condition and is therefore, requesting regular Medicare reimbursement.
    /// </summary>
    public static readonly ConditionCode C07 = new(Values.C07);

    /// <summary>
    /// BENEFICIARY WOULD NOT PROVIDE INFORMATION CONCERNING OTHER INSURANCE COVERAGE - Enter this code if the beneficiary would not provide information concerning other insurance coverage.
    /// </summary>
    public static readonly ConditionCode C08 = new(Values.C08);

    /// <summary>
    /// NEITHER PATIENT NOR SPOUSE IS EMPLOYED - Indicates that in response to development questions, the patient and spouse (if the patient is married) have denied any employment.
    /// </summary>
    public static readonly ConditionCode C09 = new(Values.C09);

    /// <summary>
    /// PATIENT AND/OR SPOUSE IS EMPLOYED BUT NO EGHP EXISTS - Code indicates that in response to development questions, the patient and/or spouse have indicated that one is or both are employed but have no group health insurance from an EGHP or other employer sponsored or provided health insurance that covers the patient.
    /// </summary>
    public static readonly ConditionCode C10 = new(Values.C10);

    /// <summary>
    /// DISABLED BENEFICIARY BUT NO LGHP - Code indicates that in response to development questions, the disabled beneficiary and/or family members have indicated that one is or more are employed but have no group health insurance from an LGHP or other employer sponsored or provided health insurance that covers the patient.
    /// </summary>
    public static readonly ConditionCode C11 = new(Values.C11);

    /// <summary>
    /// PATIENT IS HOMELESS - The patient is homeless.
    /// </summary>
    public static readonly ConditionCode C17 = new(Values.C17);

    /// <summary>
    /// MAIDEN NAME RETAINED - A dependent spouse entitled to benefits who does not use her husband's last name.
    /// </summary>
    public static readonly ConditionCode C18 = new(Values.C18);

    /// <summary>
    /// CHILD RETAINS MOTHER'S NAME - A patient who is a dependent child entitled to benefits and does not have its father's last name.
    /// </summary>
    public static readonly ConditionCode C19 = new(Values.C19);

    /// <summary>
    /// BENEFICIARY REQUESTED BILLING - Provider realizes services are non-covered level of care or excluded, but beneficiary requests determination by payer. (Currently limited to home health and inpatient SNF claims.)
    /// </summary>
    public static readonly ConditionCode C20 = new(Values.C20);

    /// <summary>
    /// BILLING FOR DENIAL NOTICE - Provider realizes services are non-covered level of care or excluded, but requests notice from Medicare or other payer.
    /// </summary>
    public static readonly ConditionCode C21 = new(Values.C21);

    /// <summary>
    /// PATIENT ON MULTIPLE DRUG REGIMEN - A patient who is receiving multiple intravenous drugs while on home IV therapy.
    /// </summary>
    public static readonly ConditionCode C22 = new(Values.C22);

    /// <summary>
    /// HOME CARE GIVER AVAILABLE - The patient has a caregiver available to assist him or her during self-administration of an intravenous drug.
    /// </summary>
    public static readonly ConditionCode C23 = new(Values.C23);

    /// <summary>
    /// HOME IV PATIENT ALSO RECEIVING HHA SERVICES - The patient is under the care of Home Health Agency while receiving home IV drug therapy services.
    /// </summary>
    public static readonly ConditionCode C24 = new(Values.C24);

    /// <summary>
    /// PATIENT IS NON-U.S. RESIDENT - The patient is not a resident of the United States.
    /// </summary>
    public static readonly ConditionCode C25 = new(Values.C25);

    /// <summary>
    /// VA ELIGIBLE PATIENT CHOOSES TO RECEIVE SERVICES IN A MEDICARE CERTIFIED FACILITY - Indicates that the patient is a VA eligible patient and chooses to receive services in a Medicare certified provider instead of a VA facility.
    /// </summary>
    public static readonly ConditionCode C26 = new(Values.C26);

    /// <summary>
    /// PATIENT REFERRED TO A SOLE COMMUNITY HOSPITAL FOR A DIAGNOSTIC LABORATORY TEST - To be reported by Sole Community hospitals only. Report this code to indicate the patient was referred for a diagnostic laboratory test. Do not report this code when a specimen only is referred.
    /// </summary>
    public static readonly ConditionCode C27 = new(Values.C27);

    /// <summary>
    /// PATIENT AND/OR SPOUSE’S EGHP IS SECONDARY TO MEDICARE - Code indicates that in response to development questions, the patient and/or spouse have indicated that one is or both are employed and that there is group health insurance from an EGHP or other employer sponsored or provided health insurance that covers the patient but that either: (1) the EGHP is a single employer plan and the employer has fewer than 20 full and part-time employees; or, (2) the EGHP is a multi or multiple employer plan that elects to pay secondary to Medicare for employees and spouses aged 65 and older for those participating employers who have fewer than 20 employees.
    /// </summary>
    public static readonly ConditionCode C28 = new(Values.C28);

    /// <summary>
    /// DISABLED BENEFICIARY AND/OR FAMILY MEMBER’S LGHP IS SECONDARY TO MEDICARE - Code indicates that in response to development questions, the patient and/or family member(s) have indicated that one is or more are employed. There also is group health insurance coverage from a LGHP or other employer sponsored or provided health insurance that covers the patient. Generally, (1) the LGHP is a single employer plan and that the employer has fewer than 100 full and part-time employees; or, (2), the LGHP is a multiple employer plan and that all employers participating in the plan have fewer than 100 full and part-time employees.
    /// </summary>
    public static readonly ConditionCode C29 = new(Values.C29);

    /// <summary>
    /// QUALIFYING CLINICAL TRIALS - Non-research services provided to patients enrolled in a Qualified Clinical Trial.
    /// </summary>
    public static readonly ConditionCode C30 = new(Values.C30);

    /// <summary>
    /// PATIENT IS STUDENT (FULL TIME - DAY) - Patient declares that he or she is enrolled as a full time day student.
    /// </summary>
    public static readonly ConditionCode C31 = new(Values.C31);

    /// <summary>
    /// PATIENT IS STUDENT (COOPERATIVE/ WORK STUDY PROGRAM) - Self-explanatory.
    /// </summary>
    public static readonly ConditionCode C32 = new(Values.C32);

    /// <summary>
    /// PATIENT IS STUDENT (FULL TIME - NIGHT) - Patient declares that he or she is enrolled as a full time night student.
    /// </summary>
    public static readonly ConditionCode C33 = new(Values.C33);

    /// <summary>
    /// PATIENT IS STUDENT (PART TIME) - Patient declares that he or she is enrolled as a part time student.
    /// </summary>
    public static readonly ConditionCode C34 = new(Values.C34);

    /// <summary>
    /// PACE ELIGIBLE PATIENT DISENROLLS DURING AN INPATIENT ADMISSION - Indicates that the patient is a PACE eligible patient that has disenrolled from PACE during an inpatient admission.
    /// </summary>
    public static readonly ConditionCode C35 = new(Values.C35);

    /// <summary>
    /// GENERAL CARE PATIENT IN A SPECIAL UNIT - Patient temporarily placed in special care unit bed because no general care beds available.
    /// </summary>
    public static readonly ConditionCode C36 = new(Values.C36);

    /// <summary>
    /// WARD ACCOMMODATION AT PATIENT REQUEST - Patient assigned to ward accommodations at patient’s request.
    /// </summary>
    public static readonly ConditionCode C37 = new(Values.C37);

    /// <summary>
    /// SEMI-PRIVATE ROOM NOT AVAILABLE - Indicates that either private or ward accommodations were assigned because semi- private accommodations were not available.
    /// </summary>
    public static readonly ConditionCode C38 = new(Values.C38);

    /// <summary>
    /// PRIVATE ROOM MEDICALLY NECESSARY - Patient needs a private room for medical requirements.
    /// </summary>
    public static readonly ConditionCode C39 = new(Values.C39);

    /// <summary>
    /// SAME DAY TRANSFER - Patient transferred to another facility before midnight on the day of admission.
    /// </summary>
    public static readonly ConditionCode C40 = new(Values.C40);

    /// <summary>
    /// PARTIAL HOSPITALIZATION - Indicates claim is for partial hospitalization services.
    /// </summary>
    public static readonly ConditionCode C41 = new(Values.C41);

    /// <summary>
    /// CONTINUING CARE NOT RELATED TO INPATIENT HOSPITALIZATION - Continuing care not related to the condition or diagnosis for which the individual received inpatient hospital services.
    /// </summary>
    public static readonly ConditionCode C42 = new(Values.C42);

    /// <summary>
    /// CONTINUING CARE NOT PROVIDED WITHIN PRESCRIBED POST-DISCHARGE WINDOW - Continuing care related to the inpatient admission but the prescribed care was not provided within the post-discharge window.
    /// </summary>
    public static readonly ConditionCode C43 = new(Values.C43);

    /// <summary>
    /// INPATIENT ADMISSION CHANGED TO OUTPATIENT - For use on outpatient claims only, when the physician ordered inpatient services, but upon internal utilization review performed before the claim was originally submitted, the hospital determined that the services did not meet its inpatient criteria. (Note: For Medicare, the change in patient status from inpatient to outpatient is made prior to discharge or release, while the beneficiary is still a patient of the hospital.)
    /// </summary>
    public static readonly ConditionCode C44 = new(Values.C44);

    /// <summary>
    /// GENDER INCONGRUENCE - Characterized by a marked and persistent incongruence between an individual's experienced gender and the sex at birth.
    /// </summary>
    public static readonly ConditionCode C45 = new(Values.C45);

    /// <summary>
    /// NON-AVAILABILITY STATEMENT ON FILE - A non-availability statement must be issued for each TRICARE claim for non-emergency inpatient care when the TRICARE beneficiary resides within the catchment’s area (usually a 40-mile radius) of a Uniformed Services Hospital.
    /// </summary>
    public static readonly ConditionCode C46 = new(Values.C46);

    /// <summary>
    /// TRANSFER FROM ANOTHER HOME HEALTH AGENCY (EFFECTIVE 7/1/10) - The patient was admitted to this home health agency as a transfer from another home health agency.
    /// </summary>
    public static readonly ConditionCode C47 = new(Values.C47);

    /// <summary>
    /// PSYCHIATRIC RESIDENTIAL TREATMENT CENTERS FOR CHILDREN AND ADOLESCENTS (RTCS) - Code to identify claims submitted by a “TRICARE - authorized” psychiatric Residential Treatment Center (RTC) for Children and Adolescents.
    /// </summary>
    public static readonly ConditionCode C48 = new(Values.C48);

    /// <summary>
    /// PRODUCT REPLACEMENT WITHIN PRODUCT LIFECYCLE (EFFECTIVE 1/1/15) - Replacement of a product earlier than the anticipated lifecycle.
    /// </summary>
    public static readonly ConditionCode C49 = new(Values.C49);

    /// <summary>
    /// PRODUCT REPLACEMENT FOR KNOWN RECALL OF A PRODUCT - Manufacturer or FDA has identified the product for recall and therefore replacement.
    /// </summary>
    public static readonly ConditionCode C50 = new(Values.C50);

    /// <summary>
    /// ATTESTATION OF UNRELATED OUTPATIENT NONDIAGNOSTIC SERVICES (EFFECTIVE 4/1/11) - The hospital attests that the outpatient nondiagnostic service provided within 3 calendars days (1 calendar day for non-subsection (d) hospitals) prior to the admission is not related to the admission to the inpatient stay. For use on outpatient claims only.
    /// </summary>
    public static readonly ConditionCode C51 = new(Values.C51);

    /// <summary>
    /// OUT OF HOSPICE SERVICE AREA (EFFECTIVE 7/1/12) - Code used when the patient is discharged for moving out of the hospice service area, including patients admitted to a hospital without contractual arrangements with the hospice.
    /// </summary>
    public static readonly ConditionCode C52 = new(Values.C52);

    /// <summary>
    /// INITIAL PLACEMENT OF A MEDICAL DEVICE PROVIDED AS PART OF A CLINICAL TRIAL OR A FREE SAMPLE. (EFFECTIVE 7/1/15) - Code is for outpatient claims that have received a device credit upon initial medical device placement in a clinical trial or a free sample.
    /// </summary>
    public static readonly ConditionCode C53 = new(Values.C53);

    /// <summary>
    /// NO SKILLED HOME HEALTH VISITS IN BILLING PERIOD. POLICY EXCEPTION DOCUMENTED AT THE HOME HEALTH AGENCY (EFFECTIVE 7/1/16) - Report when the Home Health claim is submitted without any skilled visits due to a circumstance that is allowed by the payer and indicate that the policy exception is documented at the Home Health Agency.
    /// </summary>
    public static readonly ConditionCode C54 = new(Values.C54);

    /// <summary>
    /// SNF BED NOT AVAILABLE - Code indicates the patient’s SNF admission was delayed more than 30 days after hospital discharge because a SNF bed was not available.
    /// </summary>
    public static readonly ConditionCode C55 = new(Values.C55);

    /// <summary>
    /// MEDICAL APPROPRIATENESS - Code indicates the patient’s SNF admission was delayed more than 30 days after hospital discharge because his condition made it inappropriate to begin active care within that period.
    /// </summary>
    public static readonly ConditionCode C56 = new(Values.C56);

    /// <summary>
    /// SNF READMISSION - Code indicates the patient was previously receiving Medicare covered SNF care within 30 days of this readmission.
    /// </summary>
    public static readonly ConditionCode C57 = new(Values.C57);

    /// <summary>
    /// TERMINATED MEDICARE ADVANTAGE ENROLLEE - Code indicates that patient is a terminated enrollee in a Medicare Advantage plan whose three-day inpatient hospital stay was waived.
    /// </summary>
    public static readonly ConditionCode C58 = new(Values.C58);

    /// <summary>
    /// NON-PRIMARY ESRD FACILITY - Code indicates that ESRD beneficiary received non- scheduled or emergency dialysis services at a facility other than his/her primary ESRD dialysis facility.
    /// </summary>
    public static readonly ConditionCode C59 = new(Values.C59);

    /// <summary>
    /// DAY OUTLIER - A hospital being paid under a prospective payment system is reporting this stay as a day outlier.
    /// </summary>
    public static readonly ConditionCode C60 = new(Values.C60);

    /// <summary>
    /// COST OUTLIER - A hospital being paid under a prospective payment system is requesting additional payment for this stay as a cost outlier.
    /// </summary>
    public static readonly ConditionCode C61 = new(Values.C61);

    /// <summary>
    /// PROVIDER DOES NOT WISH COST OUTLIER PAYMENT - A hospital paid under a prospective payment system is NOT requesting additional payment for this stay as a cost outlier.
    /// </summary>
    public static readonly ConditionCode C66 = new(Values.C66);

    /// <summary>
    /// BENEFICIARY ELECTS NOT TO USE LIFE TIME RESERVE (LTR) DAYS - Indicates beneficiary elects not to use LTR days.
    /// </summary>
    public static readonly ConditionCode C67 = new(Values.C67);

    /// <summary>
    /// BENEFICIARY ELECTS TO USE LIFE TIME RESERVE (LTR) DAYS - Indicates beneficiary has elected to use LTR days when charges are less than LTR co-insurance amounts.
    /// </summary>
    public static readonly ConditionCode C68 = new(Values.C68);

    /// <summary>
    /// IME/DGME/N&AH PAYMENT ONLY - Code indicates a request for a supplemental payment for IME/DGME/N&AH (Indirect Medical Education/Graduate Medical Education/ Nursing and Allied Health).
    /// </summary>
    public static readonly ConditionCode C69 = new(Values.C69);

    /// <summary>
    /// SELF-ADMINISTERED ANEMIA MANAGEMENT DRUG - Code indicates the billing is for a home dialysis patient who self administers an anemia management drug, such as erythropoietin alpha (EPO) or darbepoetin alpha.
    /// </summary>
    public static readonly ConditionCode C70 = new(Values.C70);

    /// <summary>
    /// FULL CARE IN UNIT - Code indicates the billing is for a patient who received staff-assisted dialysis services in a hospital or renal dialysis facility.
    /// </summary>
    public static readonly ConditionCode C71 = new(Values.C71);

    /// <summary>
    /// SELF CARE IN UNIT - Code indicates the billing is for a patient who managed his own dialysis services without staff assistance in a hospital or renal dialysis facility.
    /// </summary>
    public static readonly ConditionCode C72 = new(Values.C72);

    /// <summary>
    /// ESRD SELF CARE TRAINING - Code indicates the billing is for special dialysis services training when a patient or caregiver is learning to perform dialysis.
    /// </summary>
    public static readonly ConditionCode C73 = new(Values.C73);

    /// <summary>
    /// HOME - Code indicates the billing is for a patient who received dialysis services at home, but where code 75 below does not apply.
    /// </summary>
    public static readonly ConditionCode C74 = new(Values.C74);

    /// <summary>
    /// HOME - 100 PERCENT REIMBURSEMENT - Code indicates the billing is for a patient who received dialysis services at home, using a dialysis machine that was purchased by Medicare under the 100 percent program.
    /// </summary>
    public static readonly ConditionCode C75 = new(Values.C75);

    /// <summary>
    /// BACK-UP IN FACILITY DIALYSIS - Code indicates the billing is for a home dialysis patient who received back-up dialysis in a facility.
    /// </summary>
    public static readonly ConditionCode C76 = new(Values.C76);

    /// <summary>
    /// PROVIDER ACCEPTS OR IS OBLIGATED/REQUIRED DUE TO A CONTRACTUAL ARRANGEMENT OR LAW TO ACCEPT PAYMENT BY A PRIMARY PAYER AS PAYMENT IN FULL. - Code indicates you have accepted or are
    /// obligated/required due to a contractual
    /// arrangement or law to accept payment as
    /// payment in full. Therefore, no payment is due.
    /// </summary>
    public static readonly ConditionCode C77 = new(Values.C77);

    /// <summary>
    /// NEW COVERAGE NOT IMPLEMENTED BY MANAGED CARE PLAN - Billing is for a newly covered service for which
    /// the managed care plan/HMO does not pay. (Note:
    /// For outpatient bills Condition Code 04 should be
    /// omitted).
    /// </summary>
    public static readonly ConditionCode C78 = new(Values.C78);

    /// <summary>
    /// CORF SERVICES PROVIDED OFFSITE - Enter this code to indicate that physical therapy,
    /// occupational therapy, or speech pathology ser-
    /// vices were provided offsite.
    /// </summary>
    public static readonly ConditionCode C79 = new(Values.C79);

    /// <summary>
    /// HOME DIALYSIS - NURSING FACILITY - Home dialysis furnished in a SNF or nursing facility.
    /// </summary>
    public static readonly ConditionCode C80 = new(Values.C80);

    /// <summary>
    /// C-SECTIONS/INDUCTIONS &lt; 39 WEEKS - MEDICAL NECESSITY - C-sections or inductions performed at less than 39 weeks gestation for medical necessity.
    /// </summary>
    public static readonly ConditionCode C81 = new(Values.C81);

    /// <summary>
    /// C-SECTIONS/INDUCTIONS &lt; 39 WEEKS - ELECTIVE - C-sections or inductions performed at less than 39 weeks gestation electively.
    /// </summary>
    public static readonly ConditionCode C82 = new(Values.C82);

    /// <summary>
    /// C-SECTIONS/INDUCTIONS 39 WEEKS OR GREATER - C-sections or inductions performed at 39 weeks gestation or greater.
    /// </summary>
    public static readonly ConditionCode C83 = new(Values.C83);

    /// <summary>
    /// DIALYSIS FOR ACUTE KIDNEY INJURY (AKI) (EFFECTIVE 1/1/17) - Dialysis facilities (Type of Bill 072x) enter this code to indicate that the billing is for a patient with AKI. (Not to be used for patients with End Stage Renal Disease)
    /// </summary>
    public static readonly ConditionCode C84 = new(Values.C84);

    /// <summary>
    /// DELAYED RECERTIFICATION OF HOSPICE TERMINAL ILLNESS (EFFECTIVE 1/1/17) - Used when hospice recertification is untimely.
    /// </summary>
    public static readonly ConditionCode C85 = new(Values.C85);

    /// <summary>
    /// ADDITIONAL HEMODIALYSIS TREATMENTS WITH MEDICAL JUSTIFICATION (ORIGINAL EFFECTIVE DATE DELAYED. NEW EFFECTIVE DATE TBD*) - Enter this code to indicate that the billing is for a patient receiving hemodialysis who exhibits a medical condition that necessitates hemodialysis at a frequency greater than the patient’s plan of care and all treatments on the claim are reasonable and necessary.
    /// </summary>
    public static readonly ConditionCode C86 = new(Values.C86);

    /// <summary>
    /// ESRD SELF CARE RETRAINING (EFFECTIVE 7/1/17) - Code indicates the billing is for special dialysis services retraining where the patient or caregiver has previously completed dialysis training.
    /// </summary>
    public static readonly ConditionCode C87 = new(Values.C87);

    /// <summary>
    /// ALLOGENEIC STEM CELL TRANSPLANT RELATED DONOR CHARGES (EFFECTIVE 7/1/20) - Claim submitted is solely for separately billed charges for evaluating related stem cell transplant donor candidates prior to the actual transplant claim.
    /// </summary>
    public static readonly ConditionCode C88 = new(Values.C88);

    /// <summary>
    /// OPIOID TREATMENT PROGRAM (EFFECTIVE 1/1/21) - Indicates claim is for opioid treatment program services.
    /// </summary>
    public static readonly ConditionCode C89 = new(Values.C89);

    /// <summary>
    /// EXPANDED ACCESS APPROVAL (EFFECTIVE 2/1/21) - Service provided as part of an Expanded Access approval.
    /// </summary>
    public static readonly ConditionCode C90 = new(Values.C90);

    /// <summary>
    /// EMERGENCY USE AUTHORIZATION (EFFECTIVE 2/1/21) - Service provided as part of an Emergency Use Authorization.
    /// </summary>
    public static readonly ConditionCode C91 = new(Values.C91);

    /// <summary>
    /// INTENSIVE OUTPATIENT PROGRAM (IOP) (EFFECTIVE FOR SERVICES FURNISHED ON OR AFTER 1/1/2024) - Code indicates claim is for Intensive Outpatient Services
    /// </summary>
    public static readonly ConditionCode C92 = new(Values.C92);

    /// <summary>
    /// TRICARE EXTERNAL PARTNERSHIP PROGRAM - This code identifies TRICARE claims submitted under the External Partnership Program.
    /// </summary>
    public static readonly ConditionCode Ca0 = new(Values.Ca0);

    /// <summary>
    /// BIRTH DATE - INSURED A - The birth date of the individual in whose name the insurance is carried.
    /// </summary>
    public static readonly ConditionCode Ca1 = new(Values.Ca1);

    /// <summary>
    /// PHYSICALLY HANDICAPPED CHILDREN’S PROGRAM - Services provided under this program receive special funding through Title VII of the Social Security Act or the TRICARE program for the Handicapped.
    /// </summary>
    public static readonly ConditionCode Ca2 = new(Values.Ca2);

    /// <summary>
    /// SPECIAL FEDERAL FUNDING - This code has been designed for uniform use as defined by state law.
    /// </summary>
    public static readonly ConditionCode Ca3 = new(Values.Ca3);

    /// <summary>
    /// FAMILY PLANNING - This code has been designed for uniform use as defined by state law.
    /// </summary>
    public static readonly ConditionCode Ca4 = new(Values.Ca4);

    /// <summary>
    /// DISABILITY - This code has been designed for uniform use as defined by state law.
    /// </summary>
    public static readonly ConditionCode Ca5 = new(Values.Ca5);

    /// <summary>
    /// VACCINES/MEDICARE 100% PAYMENT - This code identifies that pneumococcal pneumonia and influenza vaccine services are reimbursed under special Medicare program provisions and Medicare deductible and coinsurance requirements do not apply.
    /// </summary>
    public static readonly ConditionCode Ca6 = new(Values.Ca6);

    /// <summary>
    /// HOSPITAL SERVICES PROVIDED IN A MOBILE FACILITY OR WITH PORTABLE UNITS (EFFECTIVE 4/1/20). - Code indicates that hospital services were provided in a mobile facility or with portable units.
    /// </summary>
    public static readonly ConditionCode Ca7 = new(Values.Ca7);

    /// <summary>
    /// SECOND OPINION SURGERY - Services requested to support second opinion on surgery.
    /// </summary>
    public static readonly ConditionCode Ca9 = new(Values.Ca9);

    /// <summary>
    /// ABORTION PERFORMED DUE TO RAPE - Code indicates abortion performed due to a rape.
    /// </summary>
    public static readonly ConditionCode Caa = new(Values.Caa);

    /// <summary>
    /// ABORTION PERFORMED DUE TO INCEST - Code indicates abortion performed due to an incident of incest.
    /// </summary>
    public static readonly ConditionCode Cab = new(Values.Cab);

    /// <summary>
    /// ABORTION PERFORMED DUE TO SERIOUS FETAL GENETIC DEFECT, DEFORMITY, OR ABNORMALITY - Code indicates abortion performed due to a genetic defect, a deformity, or abnormality to the fetus.
    /// </summary>
    public static readonly ConditionCode Cac = new(Values.Cac);

    /// <summary>
    /// ABORTION PERFORMED DUE TO A LIFE ENDANGERING PHYSICAL CONDITION - Abortion performed due to a life endangering physical condition caused by, or, arising from or exacerbated by the pregnancy itself.
    /// </summary>
    public static readonly ConditionCode Cad = new(Values.Cad);

    /// <summary>
    /// ABORTION PERFORMED DUE TO PHYSICAL HEALTH OF MOTHER THAT IS NOT LIFE ENDANGERING - Abortion performed due to physical health of mother that is not life endangering.
    /// </summary>
    public static readonly ConditionCode Cae = new(Values.Cae);

    /// <summary>
    /// ABORTION PERFORMED DUE TO EMOTIONAL/PSYCHOLOGICAL HEALTH OF THE MOTHER - Abortion performed due to emotional psychological health of the mother.
    /// </summary>
    public static readonly ConditionCode Caf = new(Values.Caf);

    /// <summary>
    /// ABORTION PERFORMED DUE TO SOCIAL OR ECONOMIC REASONS - Abortion performed due to social or economic reasons.
    /// </summary>
    public static readonly ConditionCode Cag = new(Values.Cag);

    /// <summary>
    /// ELECTIVE ABORTION - Elective abortion.
    /// </summary>
    public static readonly ConditionCode Cah = new(Values.Cah);

    /// <summary>
    /// STERILIZATION - Sterilization.
    /// </summary>
    public static readonly ConditionCode Cai = new(Values.Cai);

    /// <summary>
    /// PAYER RESPONSIBLE FOR CO-PAYMENT - Payer responsible for co-payment.
    /// </summary>
    public static readonly ConditionCode Caj = new(Values.Caj);

    /// <summary>
    /// AIR AMBULANCE REQUIRED - For ambulance claims. Air ambulance required; time needed to transport poses a threat.
    /// </summary>
    public static readonly ConditionCode Cak = new(Values.Cak);

    /// <summary>
    /// SPECIALIZED TREATMENT/BED UNAVAILABLE - ALTERNATE FACILITY TRANSPORT - For ambulance claims. Specialized treatment bed unavailable. Transport to alternate facility.
    /// </summary>
    public static readonly ConditionCode Cal = new(Values.Cal);

    /// <summary>
    /// NON-EMERGENCY MEDICALLY NECESSARY STRETCHER TRANSPORT REQUIRED - For ambulance claims. Non-emergency medically necessary stretcher transport required.
    /// </summary>
    public static readonly ConditionCode Cam = new(Values.Cam);

    /// <summary>
    /// PREADMISSION SCREENING NOT REQUIRED - Person meets the criteria for an exemption from preadmission screening.
    /// </summary>
    public static readonly ConditionCode Can = new(Values.Can);

    /// <summary>
    /// MEDICARE COORDINATED CARE DEMONSTRATION CLAIM - Patient is participant in the Medicare Coordinated Care Demonstration.
    /// </summary>
    public static readonly ConditionCode Cb0 = new(Values.Cb0);

    /// <summary>
    /// BENEFICIARY IS INELIGIBLE FOR DEMONSTRATION PROGRAM - Beneficiary is ineligible for demonstration program.
    /// </summary>
    public static readonly ConditionCode Cb1 = new(Values.Cb1);

    /// <summary>
    /// CRITICAL ACCESS HOSPITAL AMBULANCE ATTESTATION - Attestation by Critical Access Hospital that it meets the criteria for exemption from the ambulance fee schedule.
    /// </summary>
    public static readonly ConditionCode Cb2 = new(Values.Cb2);

    /// <summary>
    /// PREGNANCY INDICATOR - Indicates patient is pregnant. Required when mandated by law; determination of pregnancy completed in compliance with applicable law.
    /// </summary>
    public static readonly ConditionCode Cb3 = new(Values.Cb3);

    /// <summary>
    /// ADMISSION UNRELATED TO DISCHARGE ON SAME DAY - Report code when a patient is discharged/transferred from an acute care PPS hospital on the same day for symptoms unrelated to and/or not for evaluation and management of, the prior stay’s medical condition.
    /// </summary>
    public static readonly ConditionCode Cb4 = new(Values.Cb4);

    /// <summary>
    /// GULF OIL SPILL OF 2010 (EFFECTIVE 4/20/10) - This code identifies claims where the provision of all services on the claim are related, in whole or in part, to an illness, injury, or condition that was caused by or exacerbated by the effects, direct or indirect, of the 2010 oil spill in the Gulf of Mexico and/or circumstances related to such spill, including but not limited to subsequent clean-up activities.
    /// </summary>
    public static readonly ConditionCode Cbp = new(Values.Cbp);

    /// <summary>
    /// APPROVED AS BILLED - The services provided for this billing period have been reviewed by the QIO or intermediary, as appropriate, and are fully approved including any day or cost outlier.
    /// </summary>
    public static readonly ConditionCode Cc1 = new(Values.Cc1);

    /// <summary>
    /// AUTOMATIC APPROVAL AS BILLED BASED ON FOCUSED REVIEW - This should include only categories of cases that the QIO has determined it need not review under a focused review program. (No longer used for Medicare.)
    /// </summary>
    public static readonly ConditionCode Cc2 = new(Values.Cc2);

    /// <summary>
    /// PARTIAL APPROVAL - The services provided for this billing period have been reviewed by the QIO or intermediary, as appropriate, and some portion has been denied (days, or services).
    /// </summary>
    public static readonly ConditionCode Cc3 = new(Values.Cc3);

    /// <summary>
    /// ADMISSION/SERVICES DENIED - This should only be used to indicate that all of the services were denied by the QIO.
    /// </summary>
    public static readonly ConditionCode Cc4 = new(Values.Cc4);

    /// <summary>
    /// POST PAYMENT REVIEW APPLICABLE - This should be used indicated that the QIO review will take place after payment.
    /// </summary>
    public static readonly ConditionCode Cc5 = new(Values.Cc5);

    /// <summary>
    /// ADMISSION PREAUTHORIZATION - The QIO authorized this admission/service but has not reviewed the services provided.
    /// </summary>
    public static readonly ConditionCode Cc6 = new(Values.Cc6);

    /// <summary>
    /// EXTENDED AUTHORIZATION - The QIO has authorized these services for an extended length of time but has not reviewed the services provided.
    /// </summary>
    public static readonly ConditionCode Cc7 = new(Values.Cc7);

    /// <summary>
    /// CHANGES TO SERVICE DATES - Changes to service dates.
    /// </summary>
    public static readonly ConditionCode Cd0 = new(Values.Cd0);

    /// <summary>
    /// CHANGES TO CHARGES - Changes to charges.
    /// </summary>
    public static readonly ConditionCode Cd1 = new(Values.Cd1);

    /// <summary>
    /// CHANGES IN REVENUE CODES/HCPCS/HIPPS RATE CODES - Report this claim change reason code on a replacement claim (Bill Type Frequency Code 7) to reflect a change in Revenue Codes (FL42) HCPCS/HIPPS Rate Codes (FL44).
    /// </summary>
    public static readonly ConditionCode Cd2 = new(Values.Cd2);

    /// <summary>
    /// SECOND OR SUBSEQUENT INTERIM PPS BILL - Second or subsequent Interim PPS bill.
    /// </summary>
    public static readonly ConditionCode Cd3 = new(Values.Cd3);

    /// <summary>
    /// CHANGE IN CLINICAL CODES (ICD) FOR DIAGNOSIS AND/OR PROCEDURE CODES - Report this claim change reason code on a replacement claim (Bill Type Frequency Code 7) to reflect a change in diagnosis (FL67) and procedure codes (FL74).
    /// </summary>
    public static readonly ConditionCode Cd4 = new(Values.Cd4);

    /// <summary>
    /// CANCEL TO CORRECT INSURED’S ID OR PROVIDER ID - Cancel only to correct insured’s ID or provider identification number.
    /// </summary>
    public static readonly ConditionCode Cd5 = new(Values.Cd5);

    /// <summary>
    /// CANCEL ONLY TO REPAY A DUPLICATE OR OIG OVERPAYMENT - Cancel only to repay a duplicate payment or OIG overpayment. (Includes cancellation of an
    /// outpatient bill containing services required to be included on the inpatient bill.)
    /// </summary>
    public static readonly ConditionCode Cd6 = new(Values.Cd6);

    /// <summary>
    /// CHANGE TO MAKE MEDICARE THE SECONDARY PAYER - Change to make Medicare the secondary payer.
    /// </summary>
    public static readonly ConditionCode Cd7 = new(Values.Cd7);

    /// <summary>
    /// CHANGE TO MAKE MEDICARE THE PRIMARY PAYER - Change to make Medicare the primary payer.
    /// </summary>
    public static readonly ConditionCode Cd8 = new(Values.Cd8);

    /// <summary>
    /// ANY OTHER CHANGE - Any other change.
    /// </summary>
    public static readonly ConditionCode Cd9 = new(Values.Cd9);

    /// <summary>
    /// DISASTER RELATED - Used to identify claims that are or may be impacted by specific payer/health plan policies related to a national or regional disaster.
    /// </summary>
    public static readonly ConditionCode CdRa = new(Values.CdRa);

    /// <summary>
    /// CHANGE IN PATIENT STATUS - Change in patient status.
    /// </summary>
    public static readonly ConditionCode Ce0 = new(Values.Ce0);

    /// <summary>
    /// DISTINCT MEDICAL VISIT - Report this code when multiple medical visits occurred on the same day in the same revenue center but the visits were distinct and constituted independent visits. An example of such a situation would be a beneficiary going to the emergency room twice on the same day, in the morning for a broken arm and later for chest pain.
    /// </summary>
    public static readonly ConditionCode Cg0 = new(Values.Cg0);

    /// <summary>
    /// DELAYED FILING; STATEMENT OF INTENT SUBMITTED - Code indicates submission of “Statement of Intent” within the qualifying period to specifically identify the existence of another third party liability situation.
    /// </summary>
    public static readonly ConditionCode Ch0 = new(Values.Ch0);

    /// <summary>
    /// DISCHARGE BY A HOSPICE PROVIDER FOR CAUSE (EFFECTIVE 1/1/09) - Discharge by a hospice provider for cause.
    /// </summary>
    public static readonly ConditionCode Ch2 = new(Values.Ch2);

    /// <summary>
    /// REOCCURRENCE OF GI BLEED COMORBID CATEGORY (EFFECTIVE 1/1/11) - Code indicates a reoccurrence of GI bleed comorbid category limited for use in conjunction with ESRD PPS and applicable to 072x types of bill only.
    /// </summary>
    public static readonly ConditionCode Ch3 = new(Values.Ch3);

    /// <summary>
    /// REOCCURRENCE OF PNEUMONIA COMORBID CATEGORY (EFFECTIVE 1/1/11) - Code indicates a reoccurrence of pneumonia comorbid category limited for use in conjunction with ESRD PPS and applicable to 072x types of bill only.
    /// </summary>
    public static readonly ConditionCode Ch4 = new(Values.Ch4);

    /// <summary>
    /// REOCCURRENCE OF PERICARDITIS COMORBID CATEGORY (EFFECTIVE 1/1/11) - Code indicates a reoccurrence of pericarditis comorbid category limited for use in conjunction with ESRD PPS and applicable to 072x types of bill only.
    /// </summary>
    public static readonly ConditionCode Ch5 = new(Values.Ch5);

    /// <summary>
    /// DO NOT RESUSCITATE ORDER (DNR) - FOR PUBLIC HEALTH DATA REPORTING ONLY when required by state or federal law or regulations. Code indicates that a DNR order was written at the time of or within the first 24 hours of the patient’s admission to the hospital and is clearly documented in the patient’s medical record.
    /// </summary>
    public static readonly ConditionCode Cp1 = new(Values.Cp1);

    /// <summary>
    /// DIRECT INPATIENT ADMISSION FROM EMERGENCY ROOM (EFFECTIVE 7/1/10) - FOR PUBLIC HEALTH DATA REPORTING ONLY when required by state or federal law or regulations. Code indicates that patient was admitted directly from this facility’s Emergency Room/Department.
    /// </summary>
    public static readonly ConditionCode Cp7 = new(Values.Cp7);

    /// <summary>
    /// REQUEST FOR REOPENING REASON CODE - MATHEMATICAL OR COMPUTATIONAL MISTAKES (EFFECTIVE 1/1/16) - Mathematical or computational mistakes.
    /// </summary>
    public static readonly ConditionCode Cr1 = new(Values.Cr1);

    /// <summary>
    /// REQUEST FOR REOPENING REASON CODE - INACCURATE DATA ENTRY (EFFECTIVE 1/1/16) - Inaccurate data entry, e.g., miskeyed or transposed provider number, referring NPI, date of service, procedure code, etc.
    /// </summary>
    public static readonly ConditionCode Cr2 = new(Values.Cr2);

    /// <summary>
    /// REQUEST FOR REOPENING REASON CODE - MISAPPLICATION OF A FEE SCHEDULE (EFFECTIVE 1/1/16) - Misapplication of a fee schedule.
    /// </summary>
    public static readonly ConditionCode Cr3 = new(Values.Cr3);

    /// <summary>
    /// REQUEST FOR REOPENING REASON CODE - COMPUTER ERRORS (EFFECTIVE 1/1/16) - Computer errors.
    /// </summary>
    public static readonly ConditionCode Cr4 = new(Values.Cr4);

    /// <summary>
    /// REQUEST FOR REOPENING REASON CODE - INCORRECTLY IDENTIFIED DUPLICATE CLAIM (EFFECTIVE 1/1/16) - Claims denied as duplicates which the party believes were incorrectly identified as a duplicate.
    /// </summary>
    public static readonly ConditionCode Cr5 = new(Values.Cr5);

    /// <summary>
    /// REQUEST FOR REOPENING REASON CODE - OTHER CLERICAL ERRORS OR MINOR ERRORS AND OMISSIONS NOT SPECIFIED IN R1-R5 ABOVE (EFFECTIVE 1/1/16) - Other clerical errors or minor errors and omissions not specified in R1-R5 above.
    /// </summary>
    public static readonly ConditionCode Cr6 = new(Values.Cr6);

    /// <summary>
    /// REQUEST FOR REOPENING REASON CODE - CORRECTIONS OTHER THAN CLERICAL ERRORS (EFFECTIVE 1/1/16) - Claim corrections other than clerical errors within one year of the date of initial determination.
    /// </summary>
    public static readonly ConditionCode Cr7 = new(Values.Cr7);

    /// <summary>
    /// REQUEST FOR REOPENING REASON CODE - NEW AND MATERIAL EVIDENCE (EFFECTIVE 1/1/16) - A reopening for good cause (one to four years from the date of the initial determination) due to new and material evidence that was not available or known at the time of the determination or decision and may result in a different conclusion.
    /// </summary>
    public static readonly ConditionCode Cr8 = new(Values.Cr8);

    /// <summary>
    /// REQUEST FOR REOPENING REASON CODE - FAULTY EVIDENCE (EFFECTIVE 1/1/16) - A reopening for good cause (one to four years from the date of the initial determination) because the evidence that was considered in making the determination or decision clearly shows that an obvious error was made at the time of the determination or decision.
    /// </summary>
    public static readonly ConditionCode Cr9 = new(Values.Cr9);

    /// <summary>
    /// UNITED MINE WORKERS OF AMERICA (UMWA) DEMONSTRATION INDICATOR - Used for United Mine Workers of America (UMWA) demonstration indicator ONLY.
    /// </summary>
    public static readonly ConditionCode Cw0 = new(Values.Cw0);

    /// <summary>
    /// DUPLICATE OF ORIGINAL BILL (EFFECTIVE 10/1/08) - Code indicates bill is exact duplicate of the original bill submitted.
    /// </summary>
    public static readonly ConditionCode Cw2 = new(Values.Cw2);

    /// <summary>
    /// LEVEL I APPEAL (EFFECTIVE 10/1/08) - Code indicates bill is submitted for reconsideration; the level of appeal / reconsideration (I) is specified/defined by the payer.
    /// </summary>
    public static readonly ConditionCode Cw3 = new(Values.Cw3);

    /// <summary>
    /// LEVEL II APPEAL (EFFECTIVE 10/1/08) - Code indicates bill is submitted for reconsideration; the level of appeal / reconsideration (II) is specified/defined by the payer.
    /// </summary>
    public static readonly ConditionCode Cw4 = new(Values.Cw4);

    /// <summary>
    /// LEVEL III APPEAL (EFFECTIVE 10/1/08) - Code indicates bill is submitted for reconsideration; the level of appeal / reconsideration (II) is specified/defined by the payer.
    /// </summary>
    public static readonly ConditionCode Cw5 = new(Values.Cw5);

    public ConditionCode(string value)
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
    public static ConditionCode FromCustom(string value)
    {
        return new ConditionCode(value);
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

    public static bool operator ==(ConditionCode value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(ConditionCode value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(ConditionCode value) => value.Value;

    public static explicit operator ConditionCode(string value) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        /// <summary>
        /// MILITARY SERVICE RELATED - Medical condition incurred during military service.
        /// </summary>
        public const string C01 = "01";

        /// <summary>
        /// CONDITION IS EMPLOYMENT RELATED - Patient alleges that medical condition is due to environment/events resulting from employment.
        /// </summary>
        public const string C02 = "02";

        /// <summary>
        /// PATIENT COVERED BY INSURANCE NOT REFLECTED HERE - Indicates that patient/patient representative has stated that coverage may exist beyond that reflected on this bill.
        /// </summary>
        public const string C03 = "03";

        /// <summary>
        /// INFORMATION ONLY BILL - Indicates submission of bill is for informational purposes only. Examples would include a bill submitted as a utilization report, or a bill for a beneficiary who enrolled in a risk-based managed care plan and the hospital expects to receive payment from the plan.
        /// </summary>
        public const string C04 = "04";

        /// <summary>
        /// LIEN HAS BEEN FILED - Provider has filed legal claim for recovery of funds potentially due a patient resulting from legal action initiated by or on behalf of the patient.
        /// </summary>
        public const string C05 = "05";

        /// <summary>
        /// ESRD PATIENT IN FIRST 30 MONTHS OF ENTITLEMENT COVERED BY EMPLOYER GROUP HEALTH INSURANCE - Code indicates Medicare as the secondary insurer because the patient also is covered through an employer group health insurance during his first 30 months of End Stage Renal Disease (ESRD) entitlement.
        /// </summary>
        public const string C06 = "06";

        /// <summary>
        /// TREATMENT OF NON-TERMINAL CONDITION FOR HOSPICE PATIENT - Code indicates the patient is a hospice enrollee, but the provider is not treating his terminal condition and is therefore, requesting regular Medicare reimbursement.
        /// </summary>
        public const string C07 = "07";

        /// <summary>
        /// BENEFICIARY WOULD NOT PROVIDE INFORMATION CONCERNING OTHER INSURANCE COVERAGE - Enter this code if the beneficiary would not provide information concerning other insurance coverage.
        /// </summary>
        public const string C08 = "08";

        /// <summary>
        /// NEITHER PATIENT NOR SPOUSE IS EMPLOYED - Indicates that in response to development questions, the patient and spouse (if the patient is married) have denied any employment.
        /// </summary>
        public const string C09 = "09";

        /// <summary>
        /// PATIENT AND/OR SPOUSE IS EMPLOYED BUT NO EGHP EXISTS - Code indicates that in response to development questions, the patient and/or spouse have indicated that one is or both are employed but have no group health insurance from an EGHP or other employer sponsored or provided health insurance that covers the patient.
        /// </summary>
        public const string C10 = "10";

        /// <summary>
        /// DISABLED BENEFICIARY BUT NO LGHP - Code indicates that in response to development questions, the disabled beneficiary and/or family members have indicated that one is or more are employed but have no group health insurance from an LGHP or other employer sponsored or provided health insurance that covers the patient.
        /// </summary>
        public const string C11 = "11";

        /// <summary>
        /// PATIENT IS HOMELESS - The patient is homeless.
        /// </summary>
        public const string C17 = "17";

        /// <summary>
        /// MAIDEN NAME RETAINED - A dependent spouse entitled to benefits who does not use her husband's last name.
        /// </summary>
        public const string C18 = "18";

        /// <summary>
        /// CHILD RETAINS MOTHER'S NAME - A patient who is a dependent child entitled to benefits and does not have its father's last name.
        /// </summary>
        public const string C19 = "19";

        /// <summary>
        /// BENEFICIARY REQUESTED BILLING - Provider realizes services are non-covered level of care or excluded, but beneficiary requests determination by payer. (Currently limited to home health and inpatient SNF claims.)
        /// </summary>
        public const string C20 = "20";

        /// <summary>
        /// BILLING FOR DENIAL NOTICE - Provider realizes services are non-covered level of care or excluded, but requests notice from Medicare or other payer.
        /// </summary>
        public const string C21 = "21";

        /// <summary>
        /// PATIENT ON MULTIPLE DRUG REGIMEN - A patient who is receiving multiple intravenous drugs while on home IV therapy.
        /// </summary>
        public const string C22 = "22";

        /// <summary>
        /// HOME CARE GIVER AVAILABLE - The patient has a caregiver available to assist him or her during self-administration of an intravenous drug.
        /// </summary>
        public const string C23 = "23";

        /// <summary>
        /// HOME IV PATIENT ALSO RECEIVING HHA SERVICES - The patient is under the care of Home Health Agency while receiving home IV drug therapy services.
        /// </summary>
        public const string C24 = "24";

        /// <summary>
        /// PATIENT IS NON-U.S. RESIDENT - The patient is not a resident of the United States.
        /// </summary>
        public const string C25 = "25";

        /// <summary>
        /// VA ELIGIBLE PATIENT CHOOSES TO RECEIVE SERVICES IN A MEDICARE CERTIFIED FACILITY - Indicates that the patient is a VA eligible patient and chooses to receive services in a Medicare certified provider instead of a VA facility.
        /// </summary>
        public const string C26 = "26";

        /// <summary>
        /// PATIENT REFERRED TO A SOLE COMMUNITY HOSPITAL FOR A DIAGNOSTIC LABORATORY TEST - To be reported by Sole Community hospitals only. Report this code to indicate the patient was referred for a diagnostic laboratory test. Do not report this code when a specimen only is referred.
        /// </summary>
        public const string C27 = "27";

        /// <summary>
        /// PATIENT AND/OR SPOUSE’S EGHP IS SECONDARY TO MEDICARE - Code indicates that in response to development questions, the patient and/or spouse have indicated that one is or both are employed and that there is group health insurance from an EGHP or other employer sponsored or provided health insurance that covers the patient but that either: (1) the EGHP is a single employer plan and the employer has fewer than 20 full and part-time employees; or, (2) the EGHP is a multi or multiple employer plan that elects to pay secondary to Medicare for employees and spouses aged 65 and older for those participating employers who have fewer than 20 employees.
        /// </summary>
        public const string C28 = "28";

        /// <summary>
        /// DISABLED BENEFICIARY AND/OR FAMILY MEMBER’S LGHP IS SECONDARY TO MEDICARE - Code indicates that in response to development questions, the patient and/or family member(s) have indicated that one is or more are employed. There also is group health insurance coverage from a LGHP or other employer sponsored or provided health insurance that covers the patient. Generally, (1) the LGHP is a single employer plan and that the employer has fewer than 100 full and part-time employees; or, (2), the LGHP is a multiple employer plan and that all employers participating in the plan have fewer than 100 full and part-time employees.
        /// </summary>
        public const string C29 = "29";

        /// <summary>
        /// QUALIFYING CLINICAL TRIALS - Non-research services provided to patients enrolled in a Qualified Clinical Trial.
        /// </summary>
        public const string C30 = "30";

        /// <summary>
        /// PATIENT IS STUDENT (FULL TIME - DAY) - Patient declares that he or she is enrolled as a full time day student.
        /// </summary>
        public const string C31 = "31";

        /// <summary>
        /// PATIENT IS STUDENT (COOPERATIVE/ WORK STUDY PROGRAM) - Self-explanatory.
        /// </summary>
        public const string C32 = "32";

        /// <summary>
        /// PATIENT IS STUDENT (FULL TIME - NIGHT) - Patient declares that he or she is enrolled as a full time night student.
        /// </summary>
        public const string C33 = "33";

        /// <summary>
        /// PATIENT IS STUDENT (PART TIME) - Patient declares that he or she is enrolled as a part time student.
        /// </summary>
        public const string C34 = "34";

        /// <summary>
        /// PACE ELIGIBLE PATIENT DISENROLLS DURING AN INPATIENT ADMISSION - Indicates that the patient is a PACE eligible patient that has disenrolled from PACE during an inpatient admission.
        /// </summary>
        public const string C35 = "35";

        /// <summary>
        /// GENERAL CARE PATIENT IN A SPECIAL UNIT - Patient temporarily placed in special care unit bed because no general care beds available.
        /// </summary>
        public const string C36 = "36";

        /// <summary>
        /// WARD ACCOMMODATION AT PATIENT REQUEST - Patient assigned to ward accommodations at patient’s request.
        /// </summary>
        public const string C37 = "37";

        /// <summary>
        /// SEMI-PRIVATE ROOM NOT AVAILABLE - Indicates that either private or ward accommodations were assigned because semi- private accommodations were not available.
        /// </summary>
        public const string C38 = "38";

        /// <summary>
        /// PRIVATE ROOM MEDICALLY NECESSARY - Patient needs a private room for medical requirements.
        /// </summary>
        public const string C39 = "39";

        /// <summary>
        /// SAME DAY TRANSFER - Patient transferred to another facility before midnight on the day of admission.
        /// </summary>
        public const string C40 = "40";

        /// <summary>
        /// PARTIAL HOSPITALIZATION - Indicates claim is for partial hospitalization services.
        /// </summary>
        public const string C41 = "41";

        /// <summary>
        /// CONTINUING CARE NOT RELATED TO INPATIENT HOSPITALIZATION - Continuing care not related to the condition or diagnosis for which the individual received inpatient hospital services.
        /// </summary>
        public const string C42 = "42";

        /// <summary>
        /// CONTINUING CARE NOT PROVIDED WITHIN PRESCRIBED POST-DISCHARGE WINDOW - Continuing care related to the inpatient admission but the prescribed care was not provided within the post-discharge window.
        /// </summary>
        public const string C43 = "43";

        /// <summary>
        /// INPATIENT ADMISSION CHANGED TO OUTPATIENT - For use on outpatient claims only, when the physician ordered inpatient services, but upon internal utilization review performed before the claim was originally submitted, the hospital determined that the services did not meet its inpatient criteria. (Note: For Medicare, the change in patient status from inpatient to outpatient is made prior to discharge or release, while the beneficiary is still a patient of the hospital.)
        /// </summary>
        public const string C44 = "44";

        /// <summary>
        /// GENDER INCONGRUENCE - Characterized by a marked and persistent incongruence between an individual's experienced gender and the sex at birth.
        /// </summary>
        public const string C45 = "45";

        /// <summary>
        /// NON-AVAILABILITY STATEMENT ON FILE - A non-availability statement must be issued for each TRICARE claim for non-emergency inpatient care when the TRICARE beneficiary resides within the catchment’s area (usually a 40-mile radius) of a Uniformed Services Hospital.
        /// </summary>
        public const string C46 = "46";

        /// <summary>
        /// TRANSFER FROM ANOTHER HOME HEALTH AGENCY (EFFECTIVE 7/1/10) - The patient was admitted to this home health agency as a transfer from another home health agency.
        /// </summary>
        public const string C47 = "47";

        /// <summary>
        /// PSYCHIATRIC RESIDENTIAL TREATMENT CENTERS FOR CHILDREN AND ADOLESCENTS (RTCS) - Code to identify claims submitted by a “TRICARE - authorized” psychiatric Residential Treatment Center (RTC) for Children and Adolescents.
        /// </summary>
        public const string C48 = "48";

        /// <summary>
        /// PRODUCT REPLACEMENT WITHIN PRODUCT LIFECYCLE (EFFECTIVE 1/1/15) - Replacement of a product earlier than the anticipated lifecycle.
        /// </summary>
        public const string C49 = "49";

        /// <summary>
        /// PRODUCT REPLACEMENT FOR KNOWN RECALL OF A PRODUCT - Manufacturer or FDA has identified the product for recall and therefore replacement.
        /// </summary>
        public const string C50 = "50";

        /// <summary>
        /// ATTESTATION OF UNRELATED OUTPATIENT NONDIAGNOSTIC SERVICES (EFFECTIVE 4/1/11) - The hospital attests that the outpatient nondiagnostic service provided within 3 calendars days (1 calendar day for non-subsection (d) hospitals) prior to the admission is not related to the admission to the inpatient stay. For use on outpatient claims only.
        /// </summary>
        public const string C51 = "51";

        /// <summary>
        /// OUT OF HOSPICE SERVICE AREA (EFFECTIVE 7/1/12) - Code used when the patient is discharged for moving out of the hospice service area, including patients admitted to a hospital without contractual arrangements with the hospice.
        /// </summary>
        public const string C52 = "52";

        /// <summary>
        /// INITIAL PLACEMENT OF A MEDICAL DEVICE PROVIDED AS PART OF A CLINICAL TRIAL OR A FREE SAMPLE. (EFFECTIVE 7/1/15) - Code is for outpatient claims that have received a device credit upon initial medical device placement in a clinical trial or a free sample.
        /// </summary>
        public const string C53 = "53";

        /// <summary>
        /// NO SKILLED HOME HEALTH VISITS IN BILLING PERIOD. POLICY EXCEPTION DOCUMENTED AT THE HOME HEALTH AGENCY (EFFECTIVE 7/1/16) - Report when the Home Health claim is submitted without any skilled visits due to a circumstance that is allowed by the payer and indicate that the policy exception is documented at the Home Health Agency.
        /// </summary>
        public const string C54 = "54";

        /// <summary>
        /// SNF BED NOT AVAILABLE - Code indicates the patient’s SNF admission was delayed more than 30 days after hospital discharge because a SNF bed was not available.
        /// </summary>
        public const string C55 = "55";

        /// <summary>
        /// MEDICAL APPROPRIATENESS - Code indicates the patient’s SNF admission was delayed more than 30 days after hospital discharge because his condition made it inappropriate to begin active care within that period.
        /// </summary>
        public const string C56 = "56";

        /// <summary>
        /// SNF READMISSION - Code indicates the patient was previously receiving Medicare covered SNF care within 30 days of this readmission.
        /// </summary>
        public const string C57 = "57";

        /// <summary>
        /// TERMINATED MEDICARE ADVANTAGE ENROLLEE - Code indicates that patient is a terminated enrollee in a Medicare Advantage plan whose three-day inpatient hospital stay was waived.
        /// </summary>
        public const string C58 = "58";

        /// <summary>
        /// NON-PRIMARY ESRD FACILITY - Code indicates that ESRD beneficiary received non- scheduled or emergency dialysis services at a facility other than his/her primary ESRD dialysis facility.
        /// </summary>
        public const string C59 = "59";

        /// <summary>
        /// DAY OUTLIER - A hospital being paid under a prospective payment system is reporting this stay as a day outlier.
        /// </summary>
        public const string C60 = "60";

        /// <summary>
        /// COST OUTLIER - A hospital being paid under a prospective payment system is requesting additional payment for this stay as a cost outlier.
        /// </summary>
        public const string C61 = "61";

        /// <summary>
        /// PROVIDER DOES NOT WISH COST OUTLIER PAYMENT - A hospital paid under a prospective payment system is NOT requesting additional payment for this stay as a cost outlier.
        /// </summary>
        public const string C66 = "66";

        /// <summary>
        /// BENEFICIARY ELECTS NOT TO USE LIFE TIME RESERVE (LTR) DAYS - Indicates beneficiary elects not to use LTR days.
        /// </summary>
        public const string C67 = "67";

        /// <summary>
        /// BENEFICIARY ELECTS TO USE LIFE TIME RESERVE (LTR) DAYS - Indicates beneficiary has elected to use LTR days when charges are less than LTR co-insurance amounts.
        /// </summary>
        public const string C68 = "68";

        /// <summary>
        /// IME/DGME/N&AH PAYMENT ONLY - Code indicates a request for a supplemental payment for IME/DGME/N&AH (Indirect Medical Education/Graduate Medical Education/ Nursing and Allied Health).
        /// </summary>
        public const string C69 = "69";

        /// <summary>
        /// SELF-ADMINISTERED ANEMIA MANAGEMENT DRUG - Code indicates the billing is for a home dialysis patient who self administers an anemia management drug, such as erythropoietin alpha (EPO) or darbepoetin alpha.
        /// </summary>
        public const string C70 = "70";

        /// <summary>
        /// FULL CARE IN UNIT - Code indicates the billing is for a patient who received staff-assisted dialysis services in a hospital or renal dialysis facility.
        /// </summary>
        public const string C71 = "71";

        /// <summary>
        /// SELF CARE IN UNIT - Code indicates the billing is for a patient who managed his own dialysis services without staff assistance in a hospital or renal dialysis facility.
        /// </summary>
        public const string C72 = "72";

        /// <summary>
        /// ESRD SELF CARE TRAINING - Code indicates the billing is for special dialysis services training when a patient or caregiver is learning to perform dialysis.
        /// </summary>
        public const string C73 = "73";

        /// <summary>
        /// HOME - Code indicates the billing is for a patient who received dialysis services at home, but where code 75 below does not apply.
        /// </summary>
        public const string C74 = "74";

        /// <summary>
        /// HOME - 100 PERCENT REIMBURSEMENT - Code indicates the billing is for a patient who received dialysis services at home, using a dialysis machine that was purchased by Medicare under the 100 percent program.
        /// </summary>
        public const string C75 = "75";

        /// <summary>
        /// BACK-UP IN FACILITY DIALYSIS - Code indicates the billing is for a home dialysis patient who received back-up dialysis in a facility.
        /// </summary>
        public const string C76 = "76";

        /// <summary>
        /// PROVIDER ACCEPTS OR IS OBLIGATED/REQUIRED DUE TO A CONTRACTUAL ARRANGEMENT OR LAW TO ACCEPT PAYMENT BY A PRIMARY PAYER AS PAYMENT IN FULL. - Code indicates you have accepted or are
        /// obligated/required due to a contractual
        /// arrangement or law to accept payment as
        /// payment in full. Therefore, no payment is due.
        /// </summary>
        public const string C77 = "77";

        /// <summary>
        /// NEW COVERAGE NOT IMPLEMENTED BY MANAGED CARE PLAN - Billing is for a newly covered service for which
        /// the managed care plan/HMO does not pay. (Note:
        /// For outpatient bills Condition Code 04 should be
        /// omitted).
        /// </summary>
        public const string C78 = "78";

        /// <summary>
        /// CORF SERVICES PROVIDED OFFSITE - Enter this code to indicate that physical therapy,
        /// occupational therapy, or speech pathology ser-
        /// vices were provided offsite.
        /// </summary>
        public const string C79 = "79";

        /// <summary>
        /// HOME DIALYSIS - NURSING FACILITY - Home dialysis furnished in a SNF or nursing facility.
        /// </summary>
        public const string C80 = "80";

        /// <summary>
        /// C-SECTIONS/INDUCTIONS &lt; 39 WEEKS - MEDICAL NECESSITY - C-sections or inductions performed at less than 39 weeks gestation for medical necessity.
        /// </summary>
        public const string C81 = "81";

        /// <summary>
        /// C-SECTIONS/INDUCTIONS &lt; 39 WEEKS - ELECTIVE - C-sections or inductions performed at less than 39 weeks gestation electively.
        /// </summary>
        public const string C82 = "82";

        /// <summary>
        /// C-SECTIONS/INDUCTIONS 39 WEEKS OR GREATER - C-sections or inductions performed at 39 weeks gestation or greater.
        /// </summary>
        public const string C83 = "83";

        /// <summary>
        /// DIALYSIS FOR ACUTE KIDNEY INJURY (AKI) (EFFECTIVE 1/1/17) - Dialysis facilities (Type of Bill 072x) enter this code to indicate that the billing is for a patient with AKI. (Not to be used for patients with End Stage Renal Disease)
        /// </summary>
        public const string C84 = "84";

        /// <summary>
        /// DELAYED RECERTIFICATION OF HOSPICE TERMINAL ILLNESS (EFFECTIVE 1/1/17) - Used when hospice recertification is untimely.
        /// </summary>
        public const string C85 = "85";

        /// <summary>
        /// ADDITIONAL HEMODIALYSIS TREATMENTS WITH MEDICAL JUSTIFICATION (ORIGINAL EFFECTIVE DATE DELAYED. NEW EFFECTIVE DATE TBD*) - Enter this code to indicate that the billing is for a patient receiving hemodialysis who exhibits a medical condition that necessitates hemodialysis at a frequency greater than the patient’s plan of care and all treatments on the claim are reasonable and necessary.
        /// </summary>
        public const string C86 = "86";

        /// <summary>
        /// ESRD SELF CARE RETRAINING (EFFECTIVE 7/1/17) - Code indicates the billing is for special dialysis services retraining where the patient or caregiver has previously completed dialysis training.
        /// </summary>
        public const string C87 = "87";

        /// <summary>
        /// ALLOGENEIC STEM CELL TRANSPLANT RELATED DONOR CHARGES (EFFECTIVE 7/1/20) - Claim submitted is solely for separately billed charges for evaluating related stem cell transplant donor candidates prior to the actual transplant claim.
        /// </summary>
        public const string C88 = "88";

        /// <summary>
        /// OPIOID TREATMENT PROGRAM (EFFECTIVE 1/1/21) - Indicates claim is for opioid treatment program services.
        /// </summary>
        public const string C89 = "89";

        /// <summary>
        /// EXPANDED ACCESS APPROVAL (EFFECTIVE 2/1/21) - Service provided as part of an Expanded Access approval.
        /// </summary>
        public const string C90 = "90";

        /// <summary>
        /// EMERGENCY USE AUTHORIZATION (EFFECTIVE 2/1/21) - Service provided as part of an Emergency Use Authorization.
        /// </summary>
        public const string C91 = "91";

        /// <summary>
        /// INTENSIVE OUTPATIENT PROGRAM (IOP) (EFFECTIVE FOR SERVICES FURNISHED ON OR AFTER 1/1/2024) - Code indicates claim is for Intensive Outpatient Services
        /// </summary>
        public const string C92 = "92";

        /// <summary>
        /// TRICARE EXTERNAL PARTNERSHIP PROGRAM - This code identifies TRICARE claims submitted under the External Partnership Program.
        /// </summary>
        public const string Ca0 = "A0";

        /// <summary>
        /// BIRTH DATE - INSURED A - The birth date of the individual in whose name the insurance is carried.
        /// </summary>
        public const string Ca1 = "A1";

        /// <summary>
        /// PHYSICALLY HANDICAPPED CHILDREN’S PROGRAM - Services provided under this program receive special funding through Title VII of the Social Security Act or the TRICARE program for the Handicapped.
        /// </summary>
        public const string Ca2 = "A2";

        /// <summary>
        /// SPECIAL FEDERAL FUNDING - This code has been designed for uniform use as defined by state law.
        /// </summary>
        public const string Ca3 = "A3";

        /// <summary>
        /// FAMILY PLANNING - This code has been designed for uniform use as defined by state law.
        /// </summary>
        public const string Ca4 = "A4";

        /// <summary>
        /// DISABILITY - This code has been designed for uniform use as defined by state law.
        /// </summary>
        public const string Ca5 = "A5";

        /// <summary>
        /// VACCINES/MEDICARE 100% PAYMENT - This code identifies that pneumococcal pneumonia and influenza vaccine services are reimbursed under special Medicare program provisions and Medicare deductible and coinsurance requirements do not apply.
        /// </summary>
        public const string Ca6 = "A6";

        /// <summary>
        /// HOSPITAL SERVICES PROVIDED IN A MOBILE FACILITY OR WITH PORTABLE UNITS (EFFECTIVE 4/1/20). - Code indicates that hospital services were provided in a mobile facility or with portable units.
        /// </summary>
        public const string Ca7 = "A7";

        /// <summary>
        /// SECOND OPINION SURGERY - Services requested to support second opinion on surgery.
        /// </summary>
        public const string Ca9 = "A9";

        /// <summary>
        /// ABORTION PERFORMED DUE TO RAPE - Code indicates abortion performed due to a rape.
        /// </summary>
        public const string Caa = "AA";

        /// <summary>
        /// ABORTION PERFORMED DUE TO INCEST - Code indicates abortion performed due to an incident of incest.
        /// </summary>
        public const string Cab = "AB";

        /// <summary>
        /// ABORTION PERFORMED DUE TO SERIOUS FETAL GENETIC DEFECT, DEFORMITY, OR ABNORMALITY - Code indicates abortion performed due to a genetic defect, a deformity, or abnormality to the fetus.
        /// </summary>
        public const string Cac = "AC";

        /// <summary>
        /// ABORTION PERFORMED DUE TO A LIFE ENDANGERING PHYSICAL CONDITION - Abortion performed due to a life endangering physical condition caused by, or, arising from or exacerbated by the pregnancy itself.
        /// </summary>
        public const string Cad = "AD";

        /// <summary>
        /// ABORTION PERFORMED DUE TO PHYSICAL HEALTH OF MOTHER THAT IS NOT LIFE ENDANGERING - Abortion performed due to physical health of mother that is not life endangering.
        /// </summary>
        public const string Cae = "AE";

        /// <summary>
        /// ABORTION PERFORMED DUE TO EMOTIONAL/PSYCHOLOGICAL HEALTH OF THE MOTHER - Abortion performed due to emotional psychological health of the mother.
        /// </summary>
        public const string Caf = "AF";

        /// <summary>
        /// ABORTION PERFORMED DUE TO SOCIAL OR ECONOMIC REASONS - Abortion performed due to social or economic reasons.
        /// </summary>
        public const string Cag = "AG";

        /// <summary>
        /// ELECTIVE ABORTION - Elective abortion.
        /// </summary>
        public const string Cah = "AH";

        /// <summary>
        /// STERILIZATION - Sterilization.
        /// </summary>
        public const string Cai = "AI";

        /// <summary>
        /// PAYER RESPONSIBLE FOR CO-PAYMENT - Payer responsible for co-payment.
        /// </summary>
        public const string Caj = "AJ";

        /// <summary>
        /// AIR AMBULANCE REQUIRED - For ambulance claims. Air ambulance required; time needed to transport poses a threat.
        /// </summary>
        public const string Cak = "AK";

        /// <summary>
        /// SPECIALIZED TREATMENT/BED UNAVAILABLE - ALTERNATE FACILITY TRANSPORT - For ambulance claims. Specialized treatment bed unavailable. Transport to alternate facility.
        /// </summary>
        public const string Cal = "AL";

        /// <summary>
        /// NON-EMERGENCY MEDICALLY NECESSARY STRETCHER TRANSPORT REQUIRED - For ambulance claims. Non-emergency medically necessary stretcher transport required.
        /// </summary>
        public const string Cam = "AM";

        /// <summary>
        /// PREADMISSION SCREENING NOT REQUIRED - Person meets the criteria for an exemption from preadmission screening.
        /// </summary>
        public const string Can = "AN";

        /// <summary>
        /// MEDICARE COORDINATED CARE DEMONSTRATION CLAIM - Patient is participant in the Medicare Coordinated Care Demonstration.
        /// </summary>
        public const string Cb0 = "B0";

        /// <summary>
        /// BENEFICIARY IS INELIGIBLE FOR DEMONSTRATION PROGRAM - Beneficiary is ineligible for demonstration program.
        /// </summary>
        public const string Cb1 = "B1";

        /// <summary>
        /// CRITICAL ACCESS HOSPITAL AMBULANCE ATTESTATION - Attestation by Critical Access Hospital that it meets the criteria for exemption from the ambulance fee schedule.
        /// </summary>
        public const string Cb2 = "B2";

        /// <summary>
        /// PREGNANCY INDICATOR - Indicates patient is pregnant. Required when mandated by law; determination of pregnancy completed in compliance with applicable law.
        /// </summary>
        public const string Cb3 = "B3";

        /// <summary>
        /// ADMISSION UNRELATED TO DISCHARGE ON SAME DAY - Report code when a patient is discharged/transferred from an acute care PPS hospital on the same day for symptoms unrelated to and/or not for evaluation and management of, the prior stay’s medical condition.
        /// </summary>
        public const string Cb4 = "B4";

        /// <summary>
        /// GULF OIL SPILL OF 2010 (EFFECTIVE 4/20/10) - This code identifies claims where the provision of all services on the claim are related, in whole or in part, to an illness, injury, or condition that was caused by or exacerbated by the effects, direct or indirect, of the 2010 oil spill in the Gulf of Mexico and/or circumstances related to such spill, including but not limited to subsequent clean-up activities.
        /// </summary>
        public const string Cbp = "BP";

        /// <summary>
        /// APPROVED AS BILLED - The services provided for this billing period have been reviewed by the QIO or intermediary, as appropriate, and are fully approved including any day or cost outlier.
        /// </summary>
        public const string Cc1 = "C1";

        /// <summary>
        /// AUTOMATIC APPROVAL AS BILLED BASED ON FOCUSED REVIEW - This should include only categories of cases that the QIO has determined it need not review under a focused review program. (No longer used for Medicare.)
        /// </summary>
        public const string Cc2 = "C2";

        /// <summary>
        /// PARTIAL APPROVAL - The services provided for this billing period have been reviewed by the QIO or intermediary, as appropriate, and some portion has been denied (days, or services).
        /// </summary>
        public const string Cc3 = "C3";

        /// <summary>
        /// ADMISSION/SERVICES DENIED - This should only be used to indicate that all of the services were denied by the QIO.
        /// </summary>
        public const string Cc4 = "C4";

        /// <summary>
        /// POST PAYMENT REVIEW APPLICABLE - This should be used indicated that the QIO review will take place after payment.
        /// </summary>
        public const string Cc5 = "C5";

        /// <summary>
        /// ADMISSION PREAUTHORIZATION - The QIO authorized this admission/service but has not reviewed the services provided.
        /// </summary>
        public const string Cc6 = "C6";

        /// <summary>
        /// EXTENDED AUTHORIZATION - The QIO has authorized these services for an extended length of time but has not reviewed the services provided.
        /// </summary>
        public const string Cc7 = "C7";

        /// <summary>
        /// CHANGES TO SERVICE DATES - Changes to service dates.
        /// </summary>
        public const string Cd0 = "D0";

        /// <summary>
        /// CHANGES TO CHARGES - Changes to charges.
        /// </summary>
        public const string Cd1 = "D1";

        /// <summary>
        /// CHANGES IN REVENUE CODES/HCPCS/HIPPS RATE CODES - Report this claim change reason code on a replacement claim (Bill Type Frequency Code 7) to reflect a change in Revenue Codes (FL42) HCPCS/HIPPS Rate Codes (FL44).
        /// </summary>
        public const string Cd2 = "D2";

        /// <summary>
        /// SECOND OR SUBSEQUENT INTERIM PPS BILL - Second or subsequent Interim PPS bill.
        /// </summary>
        public const string Cd3 = "D3";

        /// <summary>
        /// CHANGE IN CLINICAL CODES (ICD) FOR DIAGNOSIS AND/OR PROCEDURE CODES - Report this claim change reason code on a replacement claim (Bill Type Frequency Code 7) to reflect a change in diagnosis (FL67) and procedure codes (FL74).
        /// </summary>
        public const string Cd4 = "D4";

        /// <summary>
        /// CANCEL TO CORRECT INSURED’S ID OR PROVIDER ID - Cancel only to correct insured’s ID or provider identification number.
        /// </summary>
        public const string Cd5 = "D5";

        /// <summary>
        /// CANCEL ONLY TO REPAY A DUPLICATE OR OIG OVERPAYMENT - Cancel only to repay a duplicate payment or OIG overpayment. (Includes cancellation of an
        /// outpatient bill containing services required to be included on the inpatient bill.)
        /// </summary>
        public const string Cd6 = "D6";

        /// <summary>
        /// CHANGE TO MAKE MEDICARE THE SECONDARY PAYER - Change to make Medicare the secondary payer.
        /// </summary>
        public const string Cd7 = "D7";

        /// <summary>
        /// CHANGE TO MAKE MEDICARE THE PRIMARY PAYER - Change to make Medicare the primary payer.
        /// </summary>
        public const string Cd8 = "D8";

        /// <summary>
        /// ANY OTHER CHANGE - Any other change.
        /// </summary>
        public const string Cd9 = "D9";

        /// <summary>
        /// DISASTER RELATED - Used to identify claims that are or may be impacted by specific payer/health plan policies related to a national or regional disaster.
        /// </summary>
        public const string CdRa = "DR(a)";

        /// <summary>
        /// CHANGE IN PATIENT STATUS - Change in patient status.
        /// </summary>
        public const string Ce0 = "E0";

        /// <summary>
        /// DISTINCT MEDICAL VISIT - Report this code when multiple medical visits occurred on the same day in the same revenue center but the visits were distinct and constituted independent visits. An example of such a situation would be a beneficiary going to the emergency room twice on the same day, in the morning for a broken arm and later for chest pain.
        /// </summary>
        public const string Cg0 = "G0";

        /// <summary>
        /// DELAYED FILING; STATEMENT OF INTENT SUBMITTED - Code indicates submission of “Statement of Intent” within the qualifying period to specifically identify the existence of another third party liability situation.
        /// </summary>
        public const string Ch0 = "H0";

        /// <summary>
        /// DISCHARGE BY A HOSPICE PROVIDER FOR CAUSE (EFFECTIVE 1/1/09) - Discharge by a hospice provider for cause.
        /// </summary>
        public const string Ch2 = "H2";

        /// <summary>
        /// REOCCURRENCE OF GI BLEED COMORBID CATEGORY (EFFECTIVE 1/1/11) - Code indicates a reoccurrence of GI bleed comorbid category limited for use in conjunction with ESRD PPS and applicable to 072x types of bill only.
        /// </summary>
        public const string Ch3 = "H3";

        /// <summary>
        /// REOCCURRENCE OF PNEUMONIA COMORBID CATEGORY (EFFECTIVE 1/1/11) - Code indicates a reoccurrence of pneumonia comorbid category limited for use in conjunction with ESRD PPS and applicable to 072x types of bill only.
        /// </summary>
        public const string Ch4 = "H4";

        /// <summary>
        /// REOCCURRENCE OF PERICARDITIS COMORBID CATEGORY (EFFECTIVE 1/1/11) - Code indicates a reoccurrence of pericarditis comorbid category limited for use in conjunction with ESRD PPS and applicable to 072x types of bill only.
        /// </summary>
        public const string Ch5 = "H5";

        /// <summary>
        /// DO NOT RESUSCITATE ORDER (DNR) - FOR PUBLIC HEALTH DATA REPORTING ONLY when required by state or federal law or regulations. Code indicates that a DNR order was written at the time of or within the first 24 hours of the patient’s admission to the hospital and is clearly documented in the patient’s medical record.
        /// </summary>
        public const string Cp1 = "P1";

        /// <summary>
        /// DIRECT INPATIENT ADMISSION FROM EMERGENCY ROOM (EFFECTIVE 7/1/10) - FOR PUBLIC HEALTH DATA REPORTING ONLY when required by state or federal law or regulations. Code indicates that patient was admitted directly from this facility’s Emergency Room/Department.
        /// </summary>
        public const string Cp7 = "P7";

        /// <summary>
        /// REQUEST FOR REOPENING REASON CODE - MATHEMATICAL OR COMPUTATIONAL MISTAKES (EFFECTIVE 1/1/16) - Mathematical or computational mistakes.
        /// </summary>
        public const string Cr1 = "R1";

        /// <summary>
        /// REQUEST FOR REOPENING REASON CODE - INACCURATE DATA ENTRY (EFFECTIVE 1/1/16) - Inaccurate data entry, e.g., miskeyed or transposed provider number, referring NPI, date of service, procedure code, etc.
        /// </summary>
        public const string Cr2 = "R2";

        /// <summary>
        /// REQUEST FOR REOPENING REASON CODE - MISAPPLICATION OF A FEE SCHEDULE (EFFECTIVE 1/1/16) - Misapplication of a fee schedule.
        /// </summary>
        public const string Cr3 = "R3";

        /// <summary>
        /// REQUEST FOR REOPENING REASON CODE - COMPUTER ERRORS (EFFECTIVE 1/1/16) - Computer errors.
        /// </summary>
        public const string Cr4 = "R4";

        /// <summary>
        /// REQUEST FOR REOPENING REASON CODE - INCORRECTLY IDENTIFIED DUPLICATE CLAIM (EFFECTIVE 1/1/16) - Claims denied as duplicates which the party believes were incorrectly identified as a duplicate.
        /// </summary>
        public const string Cr5 = "R5";

        /// <summary>
        /// REQUEST FOR REOPENING REASON CODE - OTHER CLERICAL ERRORS OR MINOR ERRORS AND OMISSIONS NOT SPECIFIED IN R1-R5 ABOVE (EFFECTIVE 1/1/16) - Other clerical errors or minor errors and omissions not specified in R1-R5 above.
        /// </summary>
        public const string Cr6 = "R6";

        /// <summary>
        /// REQUEST FOR REOPENING REASON CODE - CORRECTIONS OTHER THAN CLERICAL ERRORS (EFFECTIVE 1/1/16) - Claim corrections other than clerical errors within one year of the date of initial determination.
        /// </summary>
        public const string Cr7 = "R7";

        /// <summary>
        /// REQUEST FOR REOPENING REASON CODE - NEW AND MATERIAL EVIDENCE (EFFECTIVE 1/1/16) - A reopening for good cause (one to four years from the date of the initial determination) due to new and material evidence that was not available or known at the time of the determination or decision and may result in a different conclusion.
        /// </summary>
        public const string Cr8 = "R8";

        /// <summary>
        /// REQUEST FOR REOPENING REASON CODE - FAULTY EVIDENCE (EFFECTIVE 1/1/16) - A reopening for good cause (one to four years from the date of the initial determination) because the evidence that was considered in making the determination or decision clearly shows that an obvious error was made at the time of the determination or decision.
        /// </summary>
        public const string Cr9 = "R9";

        /// <summary>
        /// UNITED MINE WORKERS OF AMERICA (UMWA) DEMONSTRATION INDICATOR - Used for United Mine Workers of America (UMWA) demonstration indicator ONLY.
        /// </summary>
        public const string Cw0 = "W0";

        /// <summary>
        /// DUPLICATE OF ORIGINAL BILL (EFFECTIVE 10/1/08) - Code indicates bill is exact duplicate of the original bill submitted.
        /// </summary>
        public const string Cw2 = "W2";

        /// <summary>
        /// LEVEL I APPEAL (EFFECTIVE 10/1/08) - Code indicates bill is submitted for reconsideration; the level of appeal / reconsideration (I) is specified/defined by the payer.
        /// </summary>
        public const string Cw3 = "W3";

        /// <summary>
        /// LEVEL II APPEAL (EFFECTIVE 10/1/08) - Code indicates bill is submitted for reconsideration; the level of appeal / reconsideration (II) is specified/defined by the payer.
        /// </summary>
        public const string Cw4 = "W4";

        /// <summary>
        /// LEVEL III APPEAL (EFFECTIVE 10/1/08) - Code indicates bill is submitted for reconsideration; the level of appeal / reconsideration (II) is specified/defined by the payer.
        /// </summary>
        public const string Cw5 = "W5";
    }
}
