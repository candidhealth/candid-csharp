using global::Candid.Net;
using global::Candid.Net.BillingNotes.V2;
using global::Candid.Net.ClaimSubmission.V1;
using global::Candid.Net.Commons;
using global::Candid.Net.Core;
using global::Candid.Net.CustomSchemas.V1;
using global::Candid.Net.EncounterProviders.V2;
using global::Candid.Net.Encounters.V4;
using global::Candid.Net.Guarantor.V1;
using global::Candid.Net.HealthCareCodeInformation.V1;
using global::Candid.Net.Individual;
using global::Candid.Net.PropertyAndCasualty.V1;
using global::Candid.Net.RelatedCauses.V1;
using global::Candid.Net.ServiceFacility;
using global::Candid.Net.ServiceLines.V2;
using global::Candid.Net.X12.V1;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace Candid.Net.PreServiceRules.V1;

/// <summary>
/// The encounter to run pre-service rules against. This should represent the state of the encounter/claim in the source system.
/// In an Electronic Health Record (EHR) system, this might be a claim, billing note, or other entity. A client should transform
/// the source system entity into this encounter shape in order to run Candid rules.
/// </summary>
[Serializable]
public record PreServiceEncounterCreate : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// The client's internal ID for this encounter, or the relevant entity in their source system. Returned in the run
    /// result so the client can match results back to their own records.
    /// </summary>
    [JsonPropertyName("external_id")]
    public required string ExternalId { get; set; }

    /// <summary>
    /// Whether this patient has authorized the release of medical information for billing purposes.
    /// Box 12 on the CMS-1500 claim form or Form Locator 52 on a UB-04 claim form.
    /// </summary>
    [JsonPropertyName("patient_authorized_release")]
    public required bool PatientAuthorizedRelease { get; set; }

    /// <summary>
    /// Whether this patient has authorized insurance payments to be made to the provider.
    /// Box 13 on the CMS-1500 claim form or Form Locator 53 on a UB-04 claim form.
    /// </summary>
    [JsonPropertyName("benefits_assigned_to_provider")]
    public required bool BenefitsAssignedToProvider { get; set; }

    /// <summary>
    /// Whether the provider has accepted the patient's authorization for insurance payments.
    /// Box 27 on the CMS-1500 claim form.
    /// </summary>
    [JsonPropertyName("provider_accepts_assignment")]
    public required bool ProviderAcceptsAssignment { get; set; }

    /// <summary>
    /// The patient receiving the service.
    /// </summary>
    [JsonPropertyName("patient")]
    public required PatientCreate Patient { get; set; }

    /// <summary>
    /// Defines the party responsible for the initial balance. Use SELF_PAY for self-pay encounters.
    /// </summary>
    [JsonPropertyName("responsible_party")]
    public required ResponsiblePartyType ResponsibleParty { get; set; }

    /// <summary>
    /// The provider or business entity submitting the claim. Box 33 on the CMS-1500 claim form.
    /// </summary>
    [JsonPropertyName("billing_provider")]
    public required BillingProvider BillingProvider { get; set; }

    /// <summary>
    /// Describes the currently expected target form for this encounter (professional or institutional).
    /// </summary>
    [JsonPropertyName("submission_expectation")]
    public required EncounterSubmissionExpectation SubmissionExpectation { get; set; }

    /// <summary>
    /// Date formatted as YYYY-MM-DD. Box 24a on the CMS-1500 claim form.
    /// If service occurred over a range of dates, this should be the start date.
    /// </summary>
    [JsonPropertyName("date_of_service")]
    public DateOnly? DateOfService { get; set; }

    /// <summary>
    /// Date formatted as YYYY-MM-DD. If omitted, assumed to be a single-day encounter.
    /// </summary>
    [JsonPropertyName("end_date_of_service")]
    public DateOnly? EndDateOfService { get; set; }

    /// <summary>
    /// Specifies the address to which payments for the claim should be sent.
    /// </summary>
    [JsonPropertyName("pay_to_address")]
    public StreetAddressLongZip? PayToAddress { get; set; }

    /// <summary>
    /// The final provider who referred the services that were rendered.
    /// All physicians who order services or refer Medicare beneficiaries must report this data.
    /// </summary>
    [JsonPropertyName("referring_provider")]
    public ReferringProvider? ReferringProvider { get; set; }

    /// <summary>
    /// Required when the rendering provider is supervised by a physician.
    /// </summary>
    [JsonPropertyName("supervising_provider")]
    public SupervisingProvider? SupervisingProvider { get; set; }

    /// <summary>
    /// The location where the medical service was rendered.
    /// Box 32 on the CMS-1500 claim form.
    /// </summary>
    [JsonPropertyName("service_facility")]
    public EncounterServiceFacilityBase? ServiceFacility { get; set; }

    /// <summary>
    /// Required when responsible_party is INSURANCE_PAY.
    /// Not required for self-pay encounters, but include it when available.
    /// </summary>
    [JsonPropertyName("subscriber_primary")]
    public SubscriberCreate? SubscriberPrimary { get; set; }

    /// <summary>
    /// Include when available, even for self-pay claims.
    /// </summary>
    [JsonPropertyName("subscriber_secondary")]
    public SubscriberCreate? SubscriberSecondary { get; set; }

    /// <summary>
    /// Box 23 on the CMS-1500 claim form or Form Locator 63 on a UB-04 claim form.
    /// </summary>
    [JsonPropertyName("prior_authorization_number")]
    public string? PriorAuthorizationNumber { get; set; }

    /// <summary>
    /// Key-value pairs that must adhere to a schema created via the Custom Schema API.
    /// Multiple schema instances cannot be created for the same schema on an encounter.
    /// </summary>
    [JsonPropertyName("schema_instances")]
    public IEnumerable<SchemaInstance>? SchemaInstances { get; set; }

    /// <summary>
    /// Box 24B on the CMS-1500 claim form. 02 for telemedicine, 11 for in-person.
    /// Not used on UB-04 or 837i claim forms.
    /// </summary>
    [JsonPropertyName("place_of_service_code")]
    public FacilityTypeCode? PlaceOfServiceCode { get; set; }

    /// <summary>
    /// The practitioner performing the service.
    /// For telehealth services, the rendering provider performs the visit or asynchronous communication.
    /// </summary>
    [JsonPropertyName("rendering_provider")]
    public RenderingProvider? RenderingProvider { get; set; }

    /// <summary>
    /// Service lines for this encounter.
    /// </summary>
    [JsonPropertyName("service_lines")]
    public IEnumerable<UniversalServiceLineCreate>? ServiceLines { get; set; }

    /// <summary>
    /// Health care code information associated with this encounter, including diagnoses,
    /// vitals, procedures, occurrences, reason for visit, and other code-related fields.
    /// </summary>
    [JsonPropertyName("health_care_code_information")]
    public HealthCareCodeInformationCreate? HealthCareCodeInformation { get; set; }

    /// <summary>
    /// 837i Loop ID-2310. The individual with overall responsibility for the patient.
    /// Used in institutional claims processing.
    /// </summary>
    [JsonPropertyName("attending_provider")]
    public RenderingProvider? AttendingProvider { get; set; }

    /// <summary>
    /// The second iteration of Loop ID-2310 on an 837P form. Use code "P3 - Primary Care Provider" in this loop to
    /// indicate the initial referral from the primary care provider or whatever provider wrote the initial referral for this patient's episode of care being billed/reported in this transaction.
    /// Not used in an 837i claim.
    /// </summary>
    [JsonPropertyName("initial_referring_provider")]
    public InitialReferringProvider? InitialReferringProvider { get; set; }

    /// <summary>
    /// The treating provider is the provider who treats the patient. This is only supported for professional encounters.
    /// </summary>
    [JsonPropertyName("treating_provider")]
    public TreatingProvider? TreatingProvider { get; set; }

    /// <summary>
    /// 837i NM1 2500 variant for Loop ID-2310. Used to indicate the individual whom has primary responsibility for surgical procedures in institutional claims processing.
    /// </summary>
    [JsonPropertyName("operating_provider")]
    public RenderingProvider? OperatingProvider { get; set; }

    /// <summary>
    /// 837i NM1 2500 variant for Loop ID-2310. Used to indicate the individual whom has secondary responsibility for surgical procedures in institutional claims processing. Only used when operating_provider is also set.
    /// </summary>
    [JsonPropertyName("other_operating_provider")]
    public RenderingProvider? OtherOperatingProvider { get; set; }

    /// <summary>
    /// The ID of an existing Organization Service Facility to use for this encounter. Note: this field is accepted for API parity but is not resolved during pre-service evaluation; provide service_facility directly if the service facility data is needed for rules.
    /// </summary>
    [JsonPropertyName("service_facility_id")]
    public string? ServiceFacilityId { get; set; }

    /// <summary>
    /// Include when available, even for self-pay claims.
    /// </summary>
    [JsonPropertyName("subscriber_tertiary")]
    public SubscriberCreate? SubscriberTertiary { get; set; }

    /// <summary>
    /// Personal and contact info for the guarantor of the patient responsibility.
    /// </summary>
    [JsonPropertyName("guarantor")]
    public GuarantorCreate? Guarantor { get; set; }

    /// <summary>
    /// Holds a collection of clinical observations made by healthcare providers during patient encounters.
    /// </summary>
    [JsonPropertyName("clinical_notes")]
    public IEnumerable<ClinicalNoteCategoryCreate>? ClinicalNotes { get; set; }

    /// <summary>
    /// Spot to store misc, human-readable, notes about this encounter to be used in the billing process.
    /// </summary>
    [JsonPropertyName("billing_notes")]
    public IEnumerable<BillingNoteBase>? BillingNotes { get; set; }

    [JsonPropertyName("patient_histories")]
    public IEnumerable<PatientHistoryCategory>? PatientHistories { get; set; }

    /// <summary>
    /// Names of tags that should be on the encounter.
    /// </summary>
    [JsonPropertyName("tag_ids")]
    public IEnumerable<string>? TagIds { get; set; }

    /// <summary>
    /// To be included for claims that have been submitted outside of Candid.
    /// </summary>
    [JsonPropertyName("external_claim_submission")]
    public ExternalClaimSubmissionCreate? ExternalClaimSubmission { get; set; }

    /// <summary>
    /// Refers to REF*9F on the 837p and 837i. Value cannot be greater than 50 characters.
    /// </summary>
    [JsonPropertyName("referral_number")]
    public string? ReferralNumber { get; set; }

    /// <summary>
    /// Refers to Box 24H on the CMS1500 form and Loop 2300 CRC - EPSDT Referral on the 837P and 837i form.
    /// </summary>
    [JsonPropertyName("epsdt_referral")]
    public EpsdtReferral? EpsdtReferral { get; set; }

    /// <summary>
    /// Refers to Loop 2300 - Segment PWK on the 837P and 837i forms. No more than 10 entries are permitted.
    /// </summary>
    [JsonPropertyName("claim_supplemental_information")]
    public IEnumerable<ClaimSupplementalInformation>? ClaimSupplementalInformation { get; set; }

    /// <summary>
    /// When Medicaid is billed as the secondary payer the Carrier Code is used to identify the primary payer. This is required for certain states.
    /// </summary>
    [JsonPropertyName("secondary_payer_carrier_code")]
    public string? SecondaryPayerCarrierCode { get; set; }

    /// <summary>
    /// Corresponds to box 10a on the CMS-1500 (Loop 2300 on 837).
    /// </summary>
    [JsonPropertyName("related_causes_information")]
    public RelatedCausesInformationCreate? RelatedCausesInformation { get; set; }

    /// <summary>
    /// 837p Loop2010 REF02, CMS1500 Box 11b.
    /// </summary>
    [JsonPropertyName("property_casualty_claim_number")]
    public string? PropertyCasualtyClaimNumber { get; set; }

    /// <summary>
    /// 837p Loop2300 DTP*439, CMS1500 Box 15.
    /// </summary>
    [JsonPropertyName("accident_date")]
    public DateOnly? AccidentDate { get; set; }

    /// <summary>
    /// Patient identifier for Property and Casualty claims. 837p Loop 2010CA.
    /// </summary>
    [JsonPropertyName("property_casualty_patient_identifier")]
    public PropertyCasualtyPatientIdentifierCreate? PropertyCasualtyPatientIdentifier { get; set; }

    /// <summary>
    /// 837i Loop 2300 DTP-03
    /// Extension of the admission date with hour (0-23 integer) details.
    /// </summary>
    [JsonPropertyName("admission_hour")]
    public int? AdmissionHour { get; set; }

    /// <summary>
    /// 837i Loop 2300 CL1-01. Code used to indicate the priority of an admission or visit.
    /// Equivalent to Form Locator 14 Priority of Admission on a UB-04 claim, not used on CMS-1500 claim forms.
    /// </summary>
    [JsonPropertyName("admission_type_code")]
    public TypeOfAdmissionOrVisitCode? AdmissionTypeCode { get; set; }

    /// <summary>
    /// 837i Loop 2300 CL1-02. Code used to indicate the conditions under which an admission occurs.
    /// Equivalent to Form Locator 15 Point of Origin on a UB-04 claim, not used on CMS-1500 claim forms.
    /// </summary>
    [JsonPropertyName("admission_source_code")]
    public PointOfOriginForAdmissionOrVisitCode? AdmissionSourceCode { get; set; }

    /// <summary>
    /// 837i Loop 2300 DTP-03
    /// Extension of the discharge date with hour (0-23 integer) details.
    /// </summary>
    [JsonPropertyName("discharge_hour")]
    public int? DischargeHour { get; set; }

    /// <summary>
    /// 837i CL1-03 or Form Locator 17 on a UB-04 claim form. This is a required field on UB-04 claims.
    /// Code indicating patient status as of the "statement covers through date".
    /// </summary>
    [JsonPropertyName("discharge_status")]
    public PatientDischargeStatusCode? DischargeStatus { get; set; }

    /// <summary>
    /// Four digit code used in institutional forms to indicate the type of bill. Professional forms are not required to submit this attribute.
    /// </summary>
    [JsonPropertyName("type_of_bill")]
    public TypeOfBillCompositeUpdate? TypeOfBill { get; set; }

    /// <summary>
    /// 837i-REF1000 -- an optional state indicating where an accident related to the encounter occurred.
    /// </summary>
    [JsonPropertyName("accident_state_or_province_code")]
    public State? AccidentStateOrProvinceCode { get; set; }

    [JsonIgnore]
    public ReadOnlyAdditionalProperties AdditionalProperties { get; private set; } = new();

    void IJsonOnDeserialized.OnDeserialized() =>
        AdditionalProperties.CopyFromExtensionData(_extensionData);

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
