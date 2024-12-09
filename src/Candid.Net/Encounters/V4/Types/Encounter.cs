using System.Text.Json.Serialization;
using Candid.Net;
using Candid.Net.BillingNotes.V2;
using Candid.Net.Core;
using Candid.Net.CustomSchemas.V1;
using Candid.Net.EncounterProviders.V2;

#nullable enable

namespace Candid.Net.Encounters.V4;

public record Encounter
{
    /// <summary>
    /// A patient control number (PCN) is a unique identifier assigned to a patient within a healthcare system or facility.
    /// It's used to track and manage a patient's medical records, treatments, and other healthcare-related information.
    /// </summary>
    [JsonPropertyName("patient_control_number")]
    public string? PatientControlNumber { get; set; }

    [JsonPropertyName("encounter_id")]
    public required string EncounterId { get; set; }

    [JsonPropertyName("claims")]
    public IEnumerable<Claim> Claims { get; set; } = new List<Claim>();

    /// <summary>
    /// Contains the identification information of the individual receiving medical services.
    /// </summary>
    [JsonPropertyName("patient")]
    public required Patient Patient { get; set; }

    /// <summary>
    /// Personal and contact info for the guarantor of the patient responsibility.
    /// </summary>
    [JsonPropertyName("guarantor")]
    public Guarantor.V1.Guarantor? Guarantor { get; set; }

    /// <summary>
    /// The billing provider is the provider or business entity submitting the claim. Billing provider may be, but is not necessarily, the same person/NPI as the rendering provider. From a payer's perspective, this represents the person or entity being reimbursed. When a contract exists with the target payer, the billing provider should be the entity contracted with the payer. In some circumstances, this will be an individual provider. In that case, submit that provider's NPI and the tax ID (TIN) that the provider gave to the payer during contracting. In other cases, the billing entity will be a medical group. If so, submit the group NPI and the group's tax ID. Box 33 on the CMS-1500 claim form.
    /// </summary>
    [JsonPropertyName("billing_provider")]
    public required EncounterProvider BillingProvider { get; set; }

    /// <summary>
    /// The rendering provider is the practitioner -- physician, nurse practitioner, etc. -- performing the service.
    /// For telehealth services, the rendering provider performs the visit, asynchronous communication, or other service. The rendering provider address should generally be the same as the service facility address.
    /// </summary>
    [JsonPropertyName("rendering_provider")]
    public required EncounterProvider RenderingProvider { get; set; }

    [JsonPropertyName("referring_provider")]
    public EncounterProvider? ReferringProvider { get; set; }

    [JsonPropertyName("initial_referring_provider")]
    public EncounterProvider? InitialReferringProvider { get; set; }

    [JsonPropertyName("supervising_provider")]
    public EncounterProvider? SupervisingProvider { get; set; }

    /// <summary>
    /// Encounter Service facility is typically the location a medical service was rendered, such as a provider office or hospital. For telehealth, service facility can represent the provider's location when the service was delivered (e.g., home), or the location where an in-person visit would have taken place, whichever is easier to identify. If the provider is in-network, service facility may be defined in payer contracts. Box 32 on the CMS-1500 claim form. Note that for an in-network claim to be successfully adjudicated, the service facility address listed on claims must match what was provided to the payer during the credentialing process.
    /// </summary>
    [JsonPropertyName("service_facility")]
    public required EncounterServiceFacility ServiceFacility { get; set; }

    /// <summary>
    /// Subscriber_primary is required when responsible_party is INSURANCE_PAY (i.e. when the claim should be billed to insurance).
    /// These are not required fields when responsible_party is SELF_PAY (i.e. when the claim should be billed to the patient).
    /// However, if you collect this for patients, even self-pay, we recommend including it when sending encounters to Candid.
    /// Note: Cash Pay is no longer a valid payer_id in v4, please use responsible party to define self-pay claims.
    /// </summary>
    [JsonPropertyName("subscriber_primary")]
    public Subscriber? SubscriberPrimary { get; set; }

    /// <summary>
    /// Contains details of the secondary insurance subscriber.
    /// </summary>
    [JsonPropertyName("subscriber_secondary")]
    public Subscriber? SubscriberSecondary { get; set; }

    /// <summary>
    /// Box 23 on the CMS-1500 claim form.
    /// </summary>
    [JsonPropertyName("prior_authorization_number")]
    public string? PriorAuthorizationNumber { get; set; }

    /// <summary>
    /// Defines the party to be billed with the initial balance owed on the claim.
    /// </summary>
    [JsonPropertyName("responsible_party")]
    public required ResponsiblePartyType ResponsibleParty { get; set; }

    /// <summary>
    /// URL that links directly to the claim created in Candid.
    /// </summary>
    [JsonPropertyName("url")]
    public required string Url { get; set; }

    /// <summary>
    /// Ideally, this field should contain no more than 12 diagnoses. However, more diagnoses may be submitted at this time, and coders will later prioritize the 12 that will be submitted to the payor.
    /// </summary>
    [JsonPropertyName("diagnoses")]
    public IEnumerable<Diagnosis> Diagnoses { get; set; } = new List<Diagnosis>();

    /// <summary>
    /// Holds a collection of clinical observations made by healthcare providers during patient encounters.
    /// </summary>
    [JsonPropertyName("clinical_notes")]
    public IEnumerable<ClinicalNoteCategory> ClinicalNotes { get; set; } =
        new List<ClinicalNoteCategory>();

    /// <summary>
    /// Spot to store misc, human-readable, notes about this encounter to be
    /// used in the billing process.
    /// </summary>
    [JsonPropertyName("billing_notes")]
    public IEnumerable<BillingNote>? BillingNotes { get; set; }

    /// <summary>
    /// Box 24B on the CMS-1500 claim form. 837p Loop2300, CLM-05-1. 02 for telemedicine, 11 for in-person. Full list [here](https://www.cms.gov/Medicare/Coding/place-of-service-codes/Place_of_Service_Code_Set).
    /// </summary>
    [JsonPropertyName("place_of_service_code")]
    public FacilityTypeCode? PlaceOfServiceCode { get; set; }

    /// <summary>
    /// Box 24B on the CMS-1500 claim form. 837p Loop2300, CLM-05-1. 02 for telemedicine, 11 for in-person. Full list [here](https://www.cms.gov/Medicare/Coding/place-of-service-codes/Place_of_Service_Code_Set).
    /// </summary>
    [JsonPropertyName("place_of_service_code_as_submitted")]
    public FacilityTypeCode? PlaceOfServiceCodeAsSubmitted { get; set; }

    [JsonPropertyName("patient_histories")]
    public IEnumerable<PatientHistoryCategory> PatientHistories { get; set; } =
        new List<PatientHistoryCategory>();

    [JsonPropertyName("patient_payments")]
    public IEnumerable<PatientPayments.V3.PatientPayment> PatientPayments { get; set; } =
        new List<PatientPayments.V3.PatientPayment>();

    [JsonPropertyName("tags")]
    public IEnumerable<Tag> Tags { get; set; } = new List<Tag>();

    /// <summary>
    /// The entity that performed the coding of medical services for the claim.
    /// </summary>
    [JsonPropertyName("coding_attribution")]
    public CodingAttributionType? CodingAttribution { get; set; }

    [JsonPropertyName("work_queue_id")]
    public string? WorkQueueId { get; set; }

    [JsonPropertyName("work_queue_membership_activated_at")]
    public DateTime? WorkQueueMembershipActivatedAt { get; set; }

    /// <summary>
    /// The party who is responsible for taking the next action on an Encounter, as defined by ownership of open Tasks.
    /// </summary>
    [JsonPropertyName("owner_of_next_action")]
    public required EncounterOwnerOfNextActionType OwnerOfNextAction { get; set; }

    /// <summary>
    /// The party who originally submitted the Claim.
    /// For Claims originating in Candid, this will be EncounterSubmissionOriginType.CANDID.
    /// For Encounters created with an external_claim_submission object, this will be EncounterSubmissionOriginType.EXTERNAL.
    /// </summary>
    [JsonPropertyName("submission_origin")]
    public required EncounterSubmissionOriginType SubmissionOrigin { get; set; }

    /// <summary>
    /// Key-value pairs that must adhere to a schema created via the Custom Schema API. Multiple schema
    /// instances cannot be created for the same schema on an encounter.
    /// </summary>
    [JsonPropertyName("schema_instances")]
    public IEnumerable<SchemaInstance> SchemaInstances { get; set; } = new List<SchemaInstance>();

    /// <summary>
    /// Refers to REF\*9F on the 837p. Value cannot be greater than 50 characters.
    /// </summary>
    [JsonPropertyName("referral_number")]
    public string? ReferralNumber { get; set; }

    /// <summary>
    /// A client-specified unique ID to associate with this encounter;
    /// for example, your internal encounter ID or a Dr. Chrono encounter ID.
    /// This field should not contain PHI.
    /// </summary>
    [JsonPropertyName("external_id")]
    public required string ExternalId { get; set; }

    /// <summary>
    /// Date formatted as YYYY-MM-DD; eg: 2019-08-24.
    /// This date must be the local date in the timezone where the service occurred.
    /// Box 24a on the CMS-1500 claim form.
    /// If service occurred over a range of dates, this should be the start date.
    /// date_of_service must be defined on either the encounter or the service lines but not both.
    /// If there are greater than zero service lines, it is recommended to specify date_of_service on the service_line instead of on the encounter to prepare for future API versions.
    /// </summary>
    [JsonPropertyName("date_of_service")]
    public DateOnly? DateOfService { get; set; }

    /// <summary>
    /// Date formatted as YYYY-MM-DD; eg: 2019-08-25.
    /// This date must be the local date in the timezone where the service occurred.
    /// If omitted, the Encounter is assumed to be for a single day.
    /// Must not be temporally before the date_of_service field.
    /// If there are greater than zero service lines, it is recommended to specify end_date_of_service on the service_line instead of on the encounter to prepare for future API versions.
    /// </summary>
    [JsonPropertyName("end_date_of_service")]
    public DateOnly? EndDateOfService { get; set; }

    /// <summary>
    /// Whether this patient has authorized the release of medical information
    /// for billing purpose.
    /// Box 12 on the CMS-1500 claim form.
    /// </summary>
    [JsonPropertyName("patient_authorized_release")]
    public required bool PatientAuthorizedRelease { get; set; }

    /// <summary>
    /// Whether this patient has authorized insurance payments to be made to you,
    /// not them. If false, patient may receive reimbursement.
    /// Box 13 on the CMS-1500 claim form.
    /// </summary>
    [JsonPropertyName("benefits_assigned_to_provider")]
    public required bool BenefitsAssignedToProvider { get; set; }

    /// <summary>
    /// Whether you have accepted the patient's authorization for insurance payments
    /// to be made to you, not them.
    /// Box 27 on the CMS-1500 claim form.
    /// </summary>
    [JsonPropertyName("provider_accepts_assignment")]
    public required bool ProviderAcceptsAssignment { get; set; }

    /// <summary>
    /// Human-readable description of the appointment type (ex: "Acupuncture - Headaches").
    /// </summary>
    [JsonPropertyName("appointment_type")]
    public string? AppointmentType { get; set; }

    [JsonPropertyName("existing_medications")]
    public IEnumerable<Medication>? ExistingMedications { get; set; }

    [JsonPropertyName("vitals")]
    public Vitals? Vitals { get; set; }

    [JsonPropertyName("interventions")]
    public IEnumerable<Intervention>? Interventions { get; set; }

    /// <summary>
    /// Specifies the address to which payments for the claim should be sent.
    /// </summary>
    [JsonPropertyName("pay_to_address")]
    public StreetAddressLongZip? PayToAddress { get; set; }

    /// <summary>
    /// Whether or not this was a synchronous or asynchronous encounter.
    /// Asynchronous encounters occur when providers and patients communicate online using
    /// forms, instant messaging, or other pre-recorded digital mediums.
    /// Synchronous encounters occur in live, real-time settings where the patient interacts
    /// directly with the provider, such as over video or a phone call.
    /// </summary>
    [JsonPropertyName("synchronicity")]
    public SynchronicityType? Synchronicity { get; set; }

    /// <summary>
    /// Defines if the Encounter is to be billed by Candid to the responsible_party.
    /// Examples for when this should be set to NOT_BILLABLE include
    /// if the Encounter has not occurred yet or if there is no intention of ever billing the responsible_party.
    /// </summary>
    [JsonPropertyName("billable_status")]
    public required BillableStatusType BillableStatus { get; set; }

    /// <summary>
    /// Defines additional information on the claim needed by the payer.
    /// Box 19 on the CMS-1500 claim form.
    /// </summary>
    [JsonPropertyName("additional_information")]
    public string? AdditionalInformation { get; set; }

    /// <summary>
    /// 837p Loop2300 REF\*4N
    /// Required when mandated by government law or regulation to obtain authorization for specific service(s) but, for the
    /// reasons listed in one of the enum values of ServiceAuthorizationExceptionCode, the service was performed without
    /// obtaining the authorization.
    /// </summary>
    [JsonPropertyName("service_authorization_exception_code")]
    public ServiceAuthorizationExceptionCode? ServiceAuthorizationExceptionCode { get; set; }

    /// <summary>
    /// 837p Loop2300 DTP\*435, CMS-1500 Box 18
    /// Required on all ambulance claims when the patient was known to be admitted to the hospital.
    /// OR
    /// Required on all claims involving inpatient medical visits.
    /// </summary>
    [JsonPropertyName("admission_date")]
    public DateOnly? AdmissionDate { get; set; }

    /// <summary>
    /// 837p Loop2300 DTP\*096, CMS-1500 Box 18
    /// Required for inpatient claims when the patient was discharged from the facility and the discharge date is known.
    /// </summary>
    [JsonPropertyName("discharge_date")]
    public DateOnly? DischargeDate { get; set; }

    /// <summary>
    /// 837p Loop2300 DTP\*431, CMS-1500 Box 14
    /// Required for the initial medical service or visit performed in response to a medical emergency when the date is available and is different than the date of service.
    /// OR
    /// This date is the onset of acute symptoms for the current illness or condition.
    /// </summary>
    [JsonPropertyName("onset_of_current_illness_or_symptom_date")]
    public DateOnly? OnsetOfCurrentIllnessOrSymptomDate { get; set; }

    /// <summary>
    /// 837p Loop2300 DTP\*484, CMS-1500 Box 14
    /// Required when, in the judgment of the provider, the services on this claim are related to the patient's pregnancy.
    /// </summary>
    [JsonPropertyName("last_menstrual_period_date")]
    public DateOnly? LastMenstrualPeriodDate { get; set; }

    /// <summary>
    /// 837i Loop2300, CLM-1300 Box 20
    /// Code indicating the reason why a request was delayed
    /// </summary>
    [JsonPropertyName("delay_reason_code")]
    public DelayReasonCode? DelayReasonCode { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
