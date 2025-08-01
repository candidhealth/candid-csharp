using System.Text.Json.Serialization;
using Candid.Net;
using Candid.Net.Core;
using Candid.Net.CustomSchemas.V1;
using Candid.Net.EncounterProviders.V2;
using Candid.Net.Guarantor.V1;

#nullable enable

namespace Candid.Net.Encounters.V4;

public record EncounterUpdate
{
    /// <summary>
    /// Refers Box 24H on the CMS1500 form and Loop 2300 CRC - EPSDT Referral on the 837P form
    /// </summary>
    [JsonPropertyName("epsdt_referral")]
    public EpsdtReferral? EpsdtReferral { get; set; }

    /// <summary>
    /// Holds a collection of clinical observations made by healthcare providers during patient encounters. Please note that medical records for appeals should be sent using the Encounter Attachments API.
    /// </summary>
    [JsonPropertyName("clinical_notes")]
    public IEnumerable<ClinicalNoteCategoryCreate>? ClinicalNotes { get; set; }

    /// <summary>
    /// Refers to Loop 2300 - Segment PWK on the 837P form. No more than 10 entries are permitted.
    /// </summary>
    [JsonPropertyName("claim_supplemental_information")]
    public IEnumerable<ClaimSupplementalInformation>? ClaimSupplementalInformation { get; set; }

    /// <summary>
    /// Key-value pairs that must adhere to a schema created via the Custom Schema API. Multiple schema
    /// instances cannot be created for the same schema on an encounter. Updating schema instances utilizes PUT
    /// semantics, so the schema instances on the encounter will be set to whatever inputs are provided. If null
    /// is provided as an input, then the encounter's schema instances will be cleared.
    /// </summary>
    [JsonPropertyName("schema_instances")]
    public IEnumerable<SchemaInstance>? SchemaInstances { get; set; }

    /// <summary>
    /// Existing medications that should be on the encounter.
    /// Note all current existing medications on encounter will be overridden with this list.
    /// </summary>
    [JsonPropertyName("existing_medications")]
    public IEnumerable<Medication>? ExistingMedications { get; set; }

    /// <summary>
    /// Personal and contact info for the guarantor of the patient responsibility.
    /// </summary>
    [JsonPropertyName("guarantor")]
    public GuarantorUpdate? Guarantor { get; set; }

    /// <summary>
    /// Contains details of the primary insurance subscriber.
    /// </summary>
    [JsonPropertyName("subscriber_primary")]
    public SubscriberCreate? SubscriberPrimary { get; set; }

    /// <summary>
    /// Contains details of the secondary insurance subscriber.
    /// </summary>
    [JsonPropertyName("subscriber_secondary")]
    public SubscriberCreate? SubscriberSecondary { get; set; }

    /// <summary>
    /// Contains details of the tertiary insurance subscriber.
    /// </summary>
    [JsonPropertyName("subscriber_tertiary")]
    public SubscriberCreate? SubscriberTertiary { get; set; }

    /// <summary>
    /// Specifies the address to which payments for the claim should be sent.
    /// </summary>
    [JsonPropertyName("pay_to_address")]
    public StreetAddressLongZip? PayToAddress { get; set; }

    /// <summary>
    /// Ideally, this field should contain no more than 12 diagnoses. However, more diagnoses
    /// may be submitted at this time, and coders will later prioritize the 12 that will be
    /// submitted to the payor.
    /// </summary>
    [JsonPropertyName("diagnosis_ids")]
    public IEnumerable<string>? DiagnosisIds { get; set; }

    /// <summary>
    /// The second iteration of Loop ID-2310. Use code "P3 - Primary Care Provider" in this loop to
    /// indicate the initial referral from the primary care provider or whatever provider wrote the initial referral for this patient's episode of care being billed/reported in this transaction.
    /// </summary>
    [JsonPropertyName("initial_referring_provider")]
    public InitialReferringProviderUpdate? InitialReferringProvider { get; set; }

    /// <summary>
    /// The final provider who referred the services that were rendered.
    /// All physicians who order services or refer Medicare beneficiaries must
    /// report this data.
    /// </summary>
    [JsonPropertyName("referring_provider")]
    public ReferringProviderUpdate? ReferringProvider { get; set; }

    /// <summary>
    /// Contains the identification information of the individual receiving medical services.
    /// </summary>
    [JsonPropertyName("patient")]
    public PatientUpdate? Patient { get; set; }

    /// <summary>
    /// The rendering provider is the practitioner -- physician, nurse practitioner, etc. -- performing the service.
    /// For telehealth services, the rendering provider performs the visit, asynchronous communication, or other service. The rendering provider address should generally be the same as the service facility address.
    /// </summary>
    [JsonPropertyName("rendering_provider")]
    public RenderingProviderUpdate? RenderingProvider { get; set; }

    /// <summary>
    /// Encounter Service facility is typically the location a medical service was rendered, such as a provider office or hospital. For telehealth, service facility can represent the provider's location when the service was delivered (e.g., home), or the location where an in-person visit would have taken place, whichever is easier to identify. If the provider is in-network, service facility may be defined in payer contracts. Box 32 on the CMS-1500 claim form. Note that for an in-network claim to be successfully adjudicated, the service facility address listed on claims must match what was provided to the payer during the credentialing process.
    /// </summary>
    [JsonPropertyName("service_facility")]
    public EncounterServiceFacilityUpdate? ServiceFacility { get; set; }

    /// <summary>
    /// Required when the rendering provider is supervised by a physician. If not required by this implementation guide, do not send.
    /// </summary>
    [JsonPropertyName("supervising_provider")]
    public SupervisingProviderUpdate? SupervisingProvider { get; set; }

    /// <summary>
    /// The billing provider is the provider or business entity submitting the claim. Billing provider may be, but is not necessarily, the same person/NPI as the rendering provider. From a payer's perspective, this represents the person or entity being reimbursed. When a contract exists with the target payer, the billing provider should be the entity contracted with the payer. In some circumstances, this will be an individual provider. In that case, submit that provider's NPI and the tax ID (TIN) that the provider gave to the payer during contracting. In other cases, the billing entity will be a medical group. If so, submit the group NPI and the group's tax ID. Box 33 on the CMS-1500 claim form.
    /// </summary>
    [JsonPropertyName("billing_provider")]
    public BillingProviderUpdate? BillingProvider { get; set; }

    /// <summary>
    /// Box 24B on the CMS-1500 claim form. 837p Loop2300, CLM-05-1. 02 for telemedicine, 11 for in-person. Full list [here](https://www.cms.gov/Medicare/Coding/place-of-service-codes/Place_of_Service_Code_Set).
    /// </summary>
    [JsonPropertyName("place_of_service_code_as_submitted")]
    public FacilityTypeCode? PlaceOfServiceCodeAsSubmitted { get; set; }

    /// <summary>
    /// Whether this patient has authorized insurance payments to be made to you, not them. If false, patient may receive reimbursement. Box 13 on the CMS-1500 claim form.
    /// </summary>
    [JsonPropertyName("benefits_assigned_to_provider")]
    public bool? BenefitsAssignedToProvider { get; set; }

    /// <summary>
    /// Box 23 on the CMS-1500 claim form.
    /// </summary>
    [JsonPropertyName("prior_authorization_number")]
    public string? PriorAuthorizationNumber { get; set; }

    /// <summary>
    /// A client-specified unique ID to associate with this encounter;
    /// for example, your internal encounter ID or a Dr. Chrono encounter ID.
    /// This field should not contain PHI.
    /// </summary>
    [JsonPropertyName("external_id")]
    public string? ExternalId { get; set; }

    /// <summary>
    /// Date formatted as YYYY-MM-DD; eg: 2019-08-24.
    /// This date must be the local date in the timezone where the service occurred.
    /// Box 24a on the CMS-1500 claim form.
    /// If service occurred over a range of dates, this should be the start date.
    /// If service lines have distinct date_of_service values, updating the encounter's date_of_service will fail. If all service line date_of_service values are the same, updating the encounter's date_of_service will update all service line date_of_service values.
    /// </summary>
    [JsonPropertyName("date_of_service")]
    public DateOnly? DateOfService { get; set; }

    /// <summary>
    /// Names of tags that should be on the encounter.  Note all tags on encounter will be overridden with this list.
    /// </summary>
    [JsonPropertyName("tag_ids")]
    public IEnumerable<string>? TagIds { get; set; }

    /// <summary>
    /// Defines if the Encounter is to be billed by Candid to the responsible_party. Examples for when this should be set to NOT_BILLABLE include if the Encounter has not occurred yet or if there is no intention of ever billing the responsible_party.
    /// </summary>
    [JsonPropertyName("billable_status")]
    public BillableStatusType? BillableStatus { get; set; }

    /// <summary>
    /// Defines the party to be billed with the initial balance owed on the claim. Use SELF_PAY if you intend to bill self pay/cash pay.
    /// </summary>
    [JsonPropertyName("responsible_party")]
    public ResponsiblePartyType? ResponsibleParty { get; set; }

    /// <summary>
    /// Whether you have accepted the patient's authorization for insurance payments to be made to you, not them. Box 27 on the CMS-1500 claim form.
    /// </summary>
    [JsonPropertyName("provider_accepts_assignment")]
    public bool? ProviderAcceptsAssignment { get; set; }

    /// <summary>
    /// Whether or not this was a synchronous or asynchronous encounter. Asynchronous encounters occur when providers and patients communicate online using forms, instant messaging, or other pre-recorded digital mediums. Synchronous encounters occur in live, real-time settings where the patient interacts directly with the provider, such as over video or a phone call.
    /// </summary>
    [JsonPropertyName("synchronicity")]
    public SynchronicityType? Synchronicity { get; set; }

    /// <summary>
    /// Box 24B on the CMS-1500 claim form. 837p Loop2300, CLM-05-1. 02 for telemedicine, 11 for in-person. Full list [here](https://www.cms.gov/Medicare/Coding/place-of-service-codes/Place_of_Service_Code_Set).
    /// </summary>
    [JsonPropertyName("place_of_service_code")]
    public FacilityTypeCode? PlaceOfServiceCode { get; set; }

    /// <summary>
    /// Human-readable description of the appointment type (ex: "Acupuncture - Headaches").
    /// </summary>
    [JsonPropertyName("appointment_type")]
    public string? AppointmentType { get; set; }

    /// <summary>
    /// Date formatted as YYYY-MM-DD; eg: 2019-08-25.
    /// This date must be the local date in the timezone where the service occurred.
    /// If omitted, the Encounter is assumed to be for a single day.
    /// Must not be temporally before the date_of_service field.
    /// If service lines have distinct end_date_of_service values, updating the encounter's end_date_of_service will fail. If all service line end_date_of_service values are the same, updating the encounter's end_date_of_service will update all service line date_of_service values.
    /// </summary>
    [JsonPropertyName("end_date_of_service")]
    public DateOnly? EndDateOfService { get; set; }

    /// <summary>
    /// Defines additional information on the claim needed by the payer.
    /// Box 19 on the CMS-1500 claim form.
    /// </summary>
    [JsonPropertyName("additional_information")]
    public string? AdditionalInformation { get; set; }

    /// <summary>
    /// 837p Loop2300 REF*4N
    /// Required when mandated by government law or regulation to obtain authorization for specific service(s) but, for the
    /// reasons listed in one of the enum values of ServiceAuthorizationExceptionCode, the service was performed without
    /// obtaining the authorization.
    /// </summary>
    [JsonPropertyName("service_authorization_exception_code")]
    public ServiceAuthorizationExceptionCode? ServiceAuthorizationExceptionCode { get; set; }

    /// <summary>
    /// 837p Loop2300 DTP*435, CMS-1500 Box 18
    /// Required on all ambulance claims when the patient was known to be admitted to the hospital.
    /// OR
    /// Required on all claims involving inpatient medical visits.
    /// </summary>
    [JsonPropertyName("admission_date")]
    public DateOnly? AdmissionDate { get; set; }

    /// <summary>
    /// 837p Loop2300 DTP*096, CMS-1500 Box 18
    /// Required for inpatient claims when the patient was discharged from the facility and the discharge date is known.
    /// </summary>
    [JsonPropertyName("discharge_date")]
    public DateOnly? DischargeDate { get; set; }

    /// <summary>
    /// 837p Loop2300 DTP*431, CMS-1500 Box 14
    /// Required for the initial medical service or visit performed in response to a medical emergency when the date is available and is different than the date of service.
    /// OR
    /// This date is the onset of acute symptoms for the current illness or condition.
    /// </summary>
    [JsonPropertyName("onset_of_current_illness_or_symptom_date")]
    public DateOnly? OnsetOfCurrentIllnessOrSymptomDate { get; set; }

    /// <summary>
    /// 837p Loop2300 DTP*484, CMS-1500 Box 14
    /// Required when, in the judgment of the provider, the services on this claim are related to the patient's pregnancy.de
    /// </summary>
    [JsonPropertyName("last_menstrual_period_date")]
    public DateOnly? LastMenstrualPeriodDate { get; set; }

    /// <summary>
    /// 837i Loop2300, CLM-1300 Box 20
    /// Code indicating the reason why a request was delayed
    /// </summary>
    [JsonPropertyName("delay_reason_code")]
    public DelayReasonCode? DelayReasonCode { get; set; }

    /// <summary>
    /// Whether this patient has authorized the release of medical information
    /// for billing purpose.
    /// Box 12 on the CMS-1500 claim form.
    /// </summary>
    [JsonPropertyName("patient_authorized_release")]
    public bool? PatientAuthorizedRelease { get; set; }

    /// <summary>
    /// If a vitals entity already exists for the encounter, then all values will be updated to the provided values.
    /// Otherwise, a new vitals object will be created for the encounter.
    /// </summary>
    [JsonPropertyName("vitals")]
    public VitalsUpdate? Vitals { get; set; }

    /// <summary>
    /// Refers to REF*9F on the 837p. Value cannot be greater than 50 characters.
    /// </summary>
    [JsonPropertyName("referral_number")]
    public string? ReferralNumber { get; set; }

    /// <summary>
    /// When Medicaid is billed as the secondary payer the Carrier Code is used to identify the primary payer. This is required for certain states.
    /// </summary>
    [JsonPropertyName("secondary_payer_carrier_code")]
    public string? SecondaryPayerCarrierCode { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
