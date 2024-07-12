using System.Text.Json.Serialization;
using Candid.Net;
using Candid.Net.BillingNotes.V2;
using Candid.Net.EncounterProviders.V2;
using Candid.Net.Encounters.V4;
using Candid.Net.Guarantor.V1;
using Candid.Net.PatientPayments.V3;

#nullable enable

namespace Candid.Net.Encounters.V4;

public record Encounter
{
    /// <summary>
    /// A patient control number (PCN) is a unique identifier assigned to a patient within a healthcare system or facility.
    /// It's used to track and manage a patient's medical records, treatments, and other healthcare-related information.
    /// </summary>
    [JsonPropertyName("patient_control_number")]
    public string? PatientControlNumber { get; init; }

    /// <summary>
    /// Date formatted as YYYY-MM-DD; eg: 2019-08-24.
    /// This date must be the local date in the timezone where the service occurred.
    /// Box 24a on the CMS-1500 claim form.
    /// If service occurred over a range of dates, this should be the start date.
    /// date_of_service must be defined on either the encounter or the service lines but not both.
    /// </summary>
    [JsonPropertyName("date_of_service")]
    public required DateOnly DateOfService { get; init; }

    /// <summary>
    /// Date formatted as YYYY-MM-DD; eg: 2019-08-25.
    /// This date must be the local date in the timezone where the service occurred.
    /// If omitted, the Encounter is assumed to be for a single day.
    /// Must not be temporally before the date_of_service field.
    /// </summary>
    [JsonPropertyName("end_date_of_service")]
    public DateOnly? EndDateOfService { get; init; }

    [JsonPropertyName("encounter_id")]
    public required Guid EncounterId { get; init; }

    [JsonPropertyName("claims")]
    public IEnumerable<Claim> Claims { get; init; } = new List<Claim>();

    /// <summary>
    /// Contains the identification information of the individual receiving medical services.
    /// </summary>
    [JsonPropertyName("patient")]
    public required Patient Patient { get; init; }

    /// <summary>
    /// Personal and contact info for the guarantor of the patient responsibility.
    /// </summary>
    [JsonPropertyName("guarantor")]
    public Guarantor? Guarantor { get; init; }

    /// <summary>
    /// The billing provider is the provider or business entity submitting the claim. Billing provider may be, but is not necessarily, the same person/NPI as the rendering provider. From a payer's perspective, this represents the person or entity being reimbursed. When a contract exists with the target payer, the billing provider should be the entity contracted with the payer. In some circumstances, this will be an individual provider. In that case, submit that provider's NPI and the tax ID (TIN) that the provider gave to the payer during contracting. In other cases, the billing entity will be a medical group. If so, submit the group NPI and the group's tax ID. Box 33 on the CMS-1500 claim form.
    /// </summary>
    [JsonPropertyName("billing_provider")]
    public required EncounterProvider BillingProvider { get; init; }

    /// <summary>
    /// The rendering provider is the practitioner -- physician, nurse practitioner, etc. -- performing the service.
    /// For telehealth services, the rendering provider performs the visit, asynchronous communication, or other service. The rendering provider address should generally be the same as the service facility address.
    /// </summary>
    [JsonPropertyName("rendering_provider")]
    public required EncounterProvider RenderingProvider { get; init; }

    [JsonPropertyName("referring_provider")]
    public EncounterProvider? ReferringProvider { get; init; }

    [JsonPropertyName("initial_referring_provider")]
    public EncounterProvider? InitialReferringProvider { get; init; }

    [JsonPropertyName("supervising_provider")]
    public EncounterProvider? SupervisingProvider { get; init; }

    [JsonPropertyName("ordering_provider")]
    public EncounterProvider? OrderingProvider { get; init; }

    /// <summary>
    /// Encounter Service facility is typically the location a medical service was rendered, such as a provider office or hospital. For telehealth, service facility can represent the provider's location when the service was delivered (e.g., home), or the location where an in-person visit would have taken place, whichever is easier to identify. If the provider is in-network, service facility may be defined in payer contracts. Box 32 on the CMS-1500 claim form. Note that for an in-network claim to be successfully adjudicated, the service facility address listed on claims must match what was provided to the payer during the credentialing process.
    /// </summary>
    [JsonPropertyName("service_facility")]
    public required EncounterServiceFacility ServiceFacility { get; init; }

    /// <summary>
    /// Subscriber_primary is required when responsible_party is INSURANCE_PAY (i.e. when the claim should be billed to insurance).
    /// These are not required fields when responsible_party is SELF_PAY (i.e. when the claim should be billed to the patient).
    /// However, if you collect this for patients, even self-pay, we recommend including it when sending encounters to Candid.
    /// Note: Cash Pay is no longer a valid payer_id in v4, please use responsible party to define self-pay claims.
    /// </summary>
    [JsonPropertyName("subscriber_primary")]
    public Subscriber? SubscriberPrimary { get; init; }

    /// <summary>
    /// Contains details of the secondary insurance subscriber.
    /// </summary>
    [JsonPropertyName("subscriber_secondary")]
    public Subscriber? SubscriberSecondary { get; init; }

    /// <summary>
    /// URL that links directly to the claim created in Candid.
    /// </summary>
    [JsonPropertyName("url")]
    public required string Url { get; init; }

    /// <summary>
    /// Ideally, this field should contain no more than 12 diagnoses. However, more diagnoses may be submitted at this time, and coders will later prioritize the 12 that will be submitted to the payor.
    /// </summary>
    [JsonPropertyName("diagnoses")]
    public IEnumerable<Diagnosis> Diagnoses { get; init; } = new List<Diagnosis>();

    /// <summary>
    /// Holds a collection of clinical observations made by healthcare providers during patient encounters.
    /// </summary>
    [JsonPropertyName("clinical_notes")]
    public IEnumerable<ClinicalNoteCategory> ClinicalNotes { get; init; } =
        new List<ClinicalNoteCategory>();

    /// <summary>
    /// Spot to store misc, human-readable, notes about this encounter to be
    /// used in the billing process.
    /// </summary>
    [JsonPropertyName("billing_notes")]
    public IEnumerable<BillingNote>? BillingNotes { get; init; }

    /// <summary>
    /// Box 24B on the CMS-1500 claim form. Line-level place of service is not currently supported. 02 for telemedicine, 11 for in-person. Full list [here](https://www.cms.gov/Medicare/Coding/place-of-service-codes/Place_of_Service_Code_Set).
    /// </summary>
    [JsonPropertyName("place_of_service_code")]
    public FacilityTypeCode? PlaceOfServiceCode { get; init; }

    /// <summary>
    /// Box 24B on the CMS-1500 claim form. Line-level place of service is not currently supported. 02 for telemedicine, 11 for in-person. Full list [here](https://www.cms.gov/Medicare/Coding/place-of-service-codes/Place_of_Service_Code_Set).
    /// </summary>
    [JsonPropertyName("place_of_service_code_as_submitted")]
    public FacilityTypeCode? PlaceOfServiceCodeAsSubmitted { get; init; }

    [JsonPropertyName("patient_histories")]
    public IEnumerable<PatientHistoryCategory> PatientHistories { get; init; } =
        new List<PatientHistoryCategory>();

    [JsonPropertyName("patient_payments")]
    public IEnumerable<PatientPayment> PatientPayments { get; init; } = new List<PatientPayment>();

    [JsonPropertyName("tags")]
    public IEnumerable<Tag> Tags { get; init; } = new List<Tag>();

    /// <summary>
    /// The entity that performed the coding of medical services for the claim.
    /// </summary>
    [JsonPropertyName("coding_attribution")]
    public CodingAttributionType? CodingAttribution { get; init; }

    [JsonPropertyName("work_queue_id")]
    public string? WorkQueueId { get; init; }

    [JsonPropertyName("work_queue_membership_activated_at")]
    public DateTime? WorkQueueMembershipActivatedAt { get; init; }

    /// <summary>
    /// The party who is responsible for taking the next action on an Encounter, as defined by ownership of open Tasks.
    /// </summary>
    [JsonPropertyName("owner_of_next_action")]
    public required EncounterOwnerOfNextActionType OwnerOfNextAction { get; init; }

    /// <summary>
    /// The party who originally submitted the Claim.
    /// For Claims originating in Candid, this will be EncounterSubmissionOriginType.CANDID.
    /// For Encounters created with an external_claim_submission object, this will be EncounterSubmissionOriginType.EXTERNAL.
    /// </summary>
    [JsonPropertyName("submission_origin")]
    public required EncounterSubmissionOriginType SubmissionOrigin { get; init; }

    /// <summary>
    /// A client-specified unique ID to associate with this encounter;
    /// for example, your internal encounter ID or a Dr. Chrono encounter ID.
    /// This field should not contain PHI.
    /// </summary>
    [JsonPropertyName("external_id")]
    public required string ExternalId { get; init; }

    /// <summary>
    /// Box 23 on the CMS-1500 claim form.
    /// </summary>
    [JsonPropertyName("prior_authorization_number")]
    public string? PriorAuthorizationNumber { get; init; }

    /// <summary>
    /// Whether this patient has authorized the release of medical information
    /// for billing purpose.
    /// Box 12 on the CMS-1500 claim form.
    /// </summary>
    [JsonPropertyName("patient_authorized_release")]
    public required bool PatientAuthorizedRelease { get; init; }

    /// <summary>
    /// Whether this patient has authorized insurance payments to be made to you,
    /// not them. If false, patient may receive reimbursement.
    /// Box 13 on the CMS-1500 claim form.
    /// </summary>
    [JsonPropertyName("benefits_assigned_to_provider")]
    public required bool BenefitsAssignedToProvider { get; init; }

    /// <summary>
    /// Whether you have accepted the patient's authorization for insurance payments
    /// to be made to you, not them.
    /// Box 27 on the CMS-1500 claim form.
    /// </summary>
    [JsonPropertyName("provider_accepts_assignment")]
    public required bool ProviderAcceptsAssignment { get; init; }

    /// <summary>
    /// Human-readable description of the appointment type (ex: "Acupuncture - Headaches").
    /// </summary>
    [JsonPropertyName("appointment_type")]
    public string? AppointmentType { get; init; }

    [JsonPropertyName("existing_medications")]
    public IEnumerable<Medication>? ExistingMedications { get; init; }

    [JsonPropertyName("vitals")]
    public Vitals? Vitals { get; init; }

    [JsonPropertyName("interventions")]
    public IEnumerable<Intervention>? Interventions { get; init; }

    /// <summary>
    /// Specifies the address to which payments for the claim should be sent.
    /// </summary>
    [JsonPropertyName("pay_to_address")]
    public StreetAddressLongZip? PayToAddress { get; init; }

    /// <summary>
    /// Whether or not this was a synchronous or asynchronous encounter.
    /// Asynchronous encounters occur when providers and patients communicate online using
    /// forms, instant messaging, or other pre-recorded digital mediums.
    /// Synchronous encounters occur in live, real-time settings where the patient interacts
    /// directly with the provider, such as over video or a phone call.
    /// </summary>
    [JsonPropertyName("synchronicity")]
    public SynchronicityType? Synchronicity { get; init; }

    /// <summary>
    /// Defines if the Encounter is to be billed by Candid to the responsible_party.
    /// Examples for when this should be set to NOT_BILLABLE include
    /// if the Encounter has not occurred yet or if there is no intention of ever billing the responsible_party.
    /// </summary>
    [JsonPropertyName("billable_status")]
    public required BillableStatusType BillableStatus { get; init; }

    /// <summary>
    /// Defines the party to be billed with the initial balance owed on the claim.
    /// </summary>
    [JsonPropertyName("responsible_party")]
    public required ResponsiblePartyType ResponsibleParty { get; init; }

    /// <summary>
    /// Defines additional information on the claim needed by the payer.
    /// Box 19 on the CMS-1500 claim form.
    /// </summary>
    [JsonPropertyName("additional_information")]
    public string? AdditionalInformation { get; init; }

    /// <summary>
    /// 837p Loop2300 REF\*4N
    /// Required when mandated by government law or regulation to obtain authorization for specific service(s) but, for the
    /// reasons listed in one of the enum values of ServiceAuthorizationExceptionCode, the service was performed without
    /// obtaining the authorization.
    /// </summary>
    [JsonPropertyName("service_authorization_exception_code")]
    public ServiceAuthorizationExceptionCode? ServiceAuthorizationExceptionCode { get; init; }

    /// <summary>
    /// 837p Loop2300 DTP\*435, CMS-1500 Box 18
    /// Required on all ambulance claims when the patient was known to be admitted to the hospital.
    /// OR
    /// Required on all claims involving inpatient medical visits.
    /// </summary>
    [JsonPropertyName("admission_date")]
    public DateOnly? AdmissionDate { get; init; }

    /// <summary>
    /// 837p Loop2300 DTP\*096, CMS-1500 Box 18
    /// Required for inpatient claims when the patient was discharged from the facility and the discharge date is known.
    /// </summary>
    [JsonPropertyName("discharge_date")]
    public DateOnly? DischargeDate { get; init; }

    /// <summary>
    /// 837p Loop2300 DTP\*431, CMS-1500 Box 14
    /// Required for the initial medical service or visit performed in response to a medical emergency when the date is available and is different than the date of service.
    /// OR
    /// This date is the onset of acute symptoms for the current illness or condition.
    /// </summary>
    [JsonPropertyName("onset_of_current_illness_or_symptom_date")]
    public DateOnly? OnsetOfCurrentIllnessOrSymptomDate { get; init; }

    /// <summary>
    /// 837p Loop2300 DTP\*484, CMS-1500 Box 14
    /// Required when, in the judgment of the provider, the services on this claim are related to the patient's pregnancy.
    /// </summary>
    [JsonPropertyName("last_menstrual_period_date")]
    public DateOnly? LastMenstrualPeriodDate { get; init; }

    /// <summary>
    /// 837i Loop2300, CLM-1300 Box 20
    /// Code indicating the reason why a request was delayed
    /// </summary>
    [JsonPropertyName("delay_reason_code")]
    public DelayReasonCode? DelayReasonCode { get; init; }
}
