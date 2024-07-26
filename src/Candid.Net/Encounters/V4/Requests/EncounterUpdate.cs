using System.Text.Json.Serialization;
using Candid.Net;
using Candid.Net.CustomSchemas.V1;
using Candid.Net.Encounters.V4;

#nullable enable

namespace Candid.Net.Encounters.V4;

public record EncounterUpdate
{
    /// <summary>
    /// Box 23 on the CMS-1500 claim form.
    /// </summary>
    [JsonPropertyName("prior_authorization_number")]
    public string? PriorAuthorizationNumber { get; init; }

    /// <summary>
    /// A client-specified unique ID to associate with this encounter;
    /// for example, your internal encounter ID or a Dr. Chrono encounter ID.
    /// This field should not contain PHI.
    ///
    /// </summary>
    [JsonPropertyName("external_id")]
    public string? ExternalId { get; init; }

    /// <summary>
    /// Date formatted as YYYY-MM-DD; eg: 2019-08-24.
    /// This date must be the local date in the timezone where the service occurred.
    /// Box 24a on the CMS-1500 claim form.
    /// If service occurred over a range of dates, this should be the start date.
    /// If service lines have distinct date_of_service values, updating the encounter's date_of_service will fail. If all service line date_of_service values are the same, updating the encounter's date_of_service will update all service line date_of_service values.
    ///
    /// </summary>
    [JsonPropertyName("date_of_service")]
    public DateOnly? DateOfService { get; init; }

    /// <summary>
    /// Ideally, this field should contain no more than 12 diagnoses. However, more diagnoses
    /// may be submitted at this time, and coders will later prioritize the 12 that will be
    /// submitted to the payor.
    ///
    /// </summary>
    [JsonPropertyName("diagnosis_ids")]
    public IEnumerable<string>? DiagnosisIds { get; init; }

    /// <summary>
    /// Names of tags that should be on the encounter.  Note all tags on encounter will be overriden with this list.
    /// </summary>
    [JsonPropertyName("tag_ids")]
    public IEnumerable<string>? TagIds { get; init; }

    /// <summary>
    /// Holds a collection of clinical observations made by healthcare providers during patient encounters.
    /// </summary>
    [JsonPropertyName("clinical_notes")]
    public IEnumerable<ClinicalNoteCategoryCreate>? ClinicalNotes { get; init; }

    /// <summary>
    /// Specifies the address to which payments for the claim should be sent.
    /// </summary>
    [JsonPropertyName("pay_to_address")]
    public StreetAddressLongZip? PayToAddress { get; init; }

    /// <summary>
    /// Defines if the Encounter is to be billed by Candid to the responsible_party. Examples for when this should be set to NOT_BILLABLE include if the Encounter has not occurred yet or if there is no intention of ever billing the responsible_party.
    ///
    /// </summary>
    [JsonPropertyName("billable_status")]
    public BillableStatusType? BillableStatus { get; init; }

    /// <summary>
    /// Defines the party to be billed with the initial balance owed on the claim. Use SELF_PAY if you intend to bill self pay/cash pay.
    ///
    /// </summary>
    [JsonPropertyName("responsible_party")]
    public ResponsiblePartyType? ResponsibleParty { get; init; }

    /// <summary>
    /// Whether you have accepted the patient's authorization for insurance payments to be made to you, not them. Box 27 on the CMS-1500 claim form.
    ///
    /// </summary>
    [JsonPropertyName("provider_accepts_assignment")]
    public bool? ProviderAcceptsAssignment { get; init; }

    /// <summary>
    /// Whether this patient has authorized insurance payments to be made to you, not them. If false, patient may receive reimbursement. Box 13 on the CMS-1500 claim form.
    ///
    /// </summary>
    [JsonPropertyName("benefits_assigned_to_provider")]
    public bool? BenefitsAssignedToProvider { get; init; }

    /// <summary>
    /// Whether or not this was a synchronous or asynchronous encounter. Asynchronous encounters occur when providers and patients communicate online using forms, instant messaging, or other pre-recorded digital mediums. Synchronous encounters occur in live, real-time settings where the patient interacts directly with the provider, such as over video or a phone call.
    ///
    /// </summary>
    [JsonPropertyName("synchronicity")]
    public SynchronicityType? Synchronicity { get; init; }

    /// <summary>
    /// Box 24B on the CMS-1500 claim form. Line-level place of service is not currently supported. 02 for telemedicine, 11 for in-person. Full list [here](https://www.cms.gov/Medicare/Coding/place-of-service-codes/Place_of_Service_Code_Set).
    ///
    /// </summary>
    [JsonPropertyName("place_of_service_code")]
    public FacilityTypeCode? PlaceOfServiceCode { get; init; }

    /// <summary>
    /// Box 24B on the CMS-1500 claim form. Line-level place of service is not currently supported. 02 for telemedicine, 11 for in-person. Full list [here](https://www.cms.gov/Medicare/Coding/place-of-service-codes/Place_of_Service_Code_Set).
    ///
    /// </summary>
    [JsonPropertyName("place_of_service_code_as_submitted")]
    public FacilityTypeCode? PlaceOfServiceCodeAsSubmitted { get; init; }

    /// <summary>
    /// Human-readable description of the appointment type (ex: "Acupuncture - Headaches").
    ///
    /// </summary>
    [JsonPropertyName("appointment_type")]
    public string? AppointmentType { get; init; }

    /// <summary>
    /// Date formatted as YYYY-MM-DD; eg: 2019-08-25.
    /// This date must be the local date in the timezone where the service occurred.
    /// If omitted, the Encounter is assumed to be for a single day.
    /// Must not be temporally before the date_of_service field.
    /// If service lines have distinct end_date_of_service values, updating the encounter's end_date_of_service will fail. If all service line end_date_of_service values are the same, updating the encounter's end_date_of_service will update all service line date_of_service values.
    ///
    /// </summary>
    [JsonPropertyName("end_date_of_service")]
    public DateOnly? EndDateOfService { get; init; }

    /// <summary>
    /// Contains details of the primary insurance subscriber.
    /// </summary>
    [JsonPropertyName("subscriber_primary")]
    public SubscriberCreate? SubscriberPrimary { get; init; }

    /// <summary>
    /// Contains details of the secondary insurance subscriber.
    /// </summary>
    [JsonPropertyName("subscriber_secondary")]
    public SubscriberCreate? SubscriberSecondary { get; init; }

    /// <summary>
    /// Defines additional information on the claim needed by the payer.
    /// Box 19 on the CMS-1500 claim form.
    ///
    /// </summary>
    [JsonPropertyName("additional_information")]
    public string? AdditionalInformation { get; init; }

    /// <summary>
    /// 837p Loop2300 REF*4N
    /// Required when mandated by government law or regulation to obtain authorization for specific service(s) but, for the
    /// reasons listed in one of the enum values of ServiceAuthorizationExceptionCode, the service was performed without
    /// obtaining the authorization.
    ///
    /// </summary>
    [JsonPropertyName("service_authorization_exception_code")]
    public ServiceAuthorizationExceptionCode? ServiceAuthorizationExceptionCode { get; init; }

    /// <summary>
    /// 837p Loop2300 DTP*435, CMS-1500 Box 18
    /// Required on all ambulance claims when the patient was known to be admitted to the hospital.
    /// OR
    /// Required on all claims involving inpatient medical visits.
    ///
    /// </summary>
    [JsonPropertyName("admission_date")]
    public DateOnly? AdmissionDate { get; init; }

    /// <summary>
    /// 837p Loop2300 DTP*096, CMS-1500 Box 18
    /// Required for inpatient claims when the patient was discharged from the facility and the discharge date is known.
    ///
    /// </summary>
    [JsonPropertyName("discharge_date")]
    public DateOnly? DischargeDate { get; init; }

    /// <summary>
    /// 837p Loop2300 DTP*431, CMS-1500 Box 14
    /// Required for the initial medical service or visit performed in response to a medical emergency when the date is available and is different than the date of service.
    /// OR
    /// This date is the onset of acute symptoms for the current illness or condition.
    ///
    /// </summary>
    [JsonPropertyName("onset_of_current_illness_or_symptom_date")]
    public DateOnly? OnsetOfCurrentIllnessOrSymptomDate { get; init; }

    /// <summary>
    /// 837p Loop2300 DTP*484, CMS-1500 Box 14
    /// Required when, in the judgment of the provider, the services on this claim are related to the patient's pregnancy.
    ///
    /// </summary>
    [JsonPropertyName("last_menstrual_period_date")]
    public DateOnly? LastMenstrualPeriodDate { get; init; }

    /// <summary>
    /// 837i Loop2300, CLM-1300 Box 20
    /// Code indicating the reason why a request was delayed
    ///
    /// </summary>
    [JsonPropertyName("delay_reason_code")]
    public DelayReasonCode? DelayReasonCode { get; init; }

    /// <summary>
    /// Whether this patient has authorized the release of medical information
    /// for billing purpose.
    /// Box 12 on the CMS-1500 claim form.
    ///
    /// </summary>
    [JsonPropertyName("patient_authorized_release")]
    public bool? PatientAuthorizedRelease { get; init; }

    /// <summary>
    /// Key-value pairs that must adhere to a schema created via the Custom Schema API. Multiple schema
    /// instances cannot be created for the same schema on an encounter. Updating schema instances utilizes PUT
    /// semantics, so the schema instances on the encounter will be set to whatever inputs are provided. If null
    /// is provided as an input, then the encounter's schema instances will be cleared.
    ///
    /// </summary>
    [JsonPropertyName("schema_instances")]
    public IEnumerable<SchemaInstance>? SchemaInstances { get; init; }
}
