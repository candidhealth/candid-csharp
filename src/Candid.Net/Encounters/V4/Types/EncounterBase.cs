using System.Text.Json.Serialization;
using Candid.Net;
using Candid.Net.Encounters.V4;

#nullable enable

namespace Candid.Net.Encounters.V4;

public record EncounterBase
{
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
