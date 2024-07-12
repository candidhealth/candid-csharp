using System.Text.Json.Serialization;
using Candid.Net;
using Candid.Net.BillingNotes.V2;
using Candid.Net.ClaimSubmission.V1;
using Candid.Net.EncounterProviders.V2;
using Candid.Net.Encounters.V4;
using Candid.Net.Guarantor.V1;
using Candid.Net.ServiceLines.V2;

#nullable enable

namespace Candid.Net.Encounters.V4;

public record EncounterCreate
{
    /// <summary>
    /// Date formatted as YYYY-MM-DD; eg: 2019-08-24.
    /// This date must be the local date in the timezone where the service occurred.
    /// Box 24a on the CMS-1500 claim form.
    /// If service occurred over a range of dates, this should be the start date.
    /// date_of_service must be defined on either the encounter or the service lines but not both.
    /// If there are greater than zero service lines, it is recommended to specify date_of_service on the service_line instead of on the encounter to prepare for future API versions.
    ///
    /// </summary>
    [JsonPropertyName("date_of_service")]
    public DateOnly? DateOfService { get; init; }

    /// <summary>
    /// Date formatted as YYYY-MM-DD; eg: 2019-08-25.
    /// This date must be the local date in the timezone where the service occurred.
    /// If omitted, the Encounter is assumed to be for a single day.
    /// Must not be temporally before the date_of_service field.
    /// If there are greater than zero service lines, it is recommended to specify end_date_of_service on the service_line instead of on the encounter to prepare for future API versions.
    ///
    /// </summary>
    [JsonPropertyName("end_date_of_service")]
    public DateOnly? EndDateOfService { get; init; }

    /// <summary>
    /// Contains the identification information of the individual receiving medical services.
    ///
    /// </summary>
    [JsonPropertyName("patient")]
    public required PatientCreate Patient { get; init; }

    /// <summary>
    /// The billing provider is the provider or business entity submitting the claim. Billing provider may be, but is not necessarily, the same person/NPI as the rendering provider. From a payer's perspective, this represents the person or entity being reimbursed. When a contract exists with the target payer, the billing provider should be the entity contracted with the payer. In some circumstances, this will be an individual provider. In that case, submit that provider's NPI and the tax ID (TIN) that the provider gave to the payer during contracting. In other cases, the billing entity will be a medical group. If so, submit the group NPI and the group's tax ID. Box 33 on the CMS-1500 claim form.
    ///
    /// </summary>
    [JsonPropertyName("billing_provider")]
    public required BillingProvider BillingProvider { get; init; }

    /// <summary>
    /// The rendering provider is the practitioner -- physician, nurse practitioner, etc. -- performing the service.
    /// For telehealth services, the rendering provider performs the visit, asynchronous communication, or other service. The rendering provider address should generally be the same as the service facility address.
    ///
    /// </summary>
    [JsonPropertyName("rendering_provider")]
    public required RenderingProvider RenderingProvider { get; init; }

    /// <summary>
    /// The final provider who referred the services that were rendered.
    /// All physicians who order services or refer Medicare beneficiaries must
    /// report this data.
    ///
    /// </summary>
    [JsonPropertyName("referring_provider")]
    public ReferringProvider? ReferringProvider { get; init; }

    /// <summary>
    /// The first provider who referred the services that were rendered.
    /// All physicians who order services or refer Medicare beneficiaries must
    /// report this data. This field cannot be populated unless referring_provider is first populated.
    ///
    /// </summary>
    [JsonPropertyName("initial_referring_provider")]
    public InitialReferringProvider? InitialReferringProvider { get; init; }

    /// <summary>
    /// The provider who is supervising the rendering provider.
    ///
    /// </summary>
    [JsonPropertyName("supervising_provider")]
    public SupervisingProvider? SupervisingProvider { get; init; }

    /// <summary>
    /// The provider who ordered the services that were rendered.
    ///
    /// </summary>
    [JsonPropertyName("ordering_provider")]
    public OrderingProvider? OrderingProvider { get; init; }

    /// <summary>
    /// Encounter Service facility is typically the location a medical service was rendered, such as a provider office or hospital. For telehealth, service facility can represent the provider's location when the service was delivered (e.g., home), or the location where an in-person visit would have taken place, whichever is easier to identify. If the provider is in-network, service facility may be defined in payer contracts. Box 32 on the CMS-1500 claim form. Note that for an in-network claim to be successfully adjudicated, the service facility address listed on claims must match what was provided to the payer during the credentialing process.
    ///
    /// </summary>
    [JsonPropertyName("service_facility")]
    public EncounterServiceFacilityBase? ServiceFacility { get; init; }

    /// <summary>
    /// Subscriber_primary is required when responsible_party is INSURANCE_PAY (i.e. when the claim should be billed to insurance).
    /// These are not required fields when responsible_party is SELF_PAY (i.e. when the claim should be billed to the patient).
    /// However, if you collect this for patients, even self-pay, we recommend including it when sending encounters to Candid.
    /// Note: Cash Pay is no longer a valid payer_id in v4, please use responsible party to define self-pay claims.
    ///
    /// </summary>
    [JsonPropertyName("subscriber_primary")]
    public SubscriberCreate? SubscriberPrimary { get; init; }

    /// <summary>
    /// Please always include this when you have it, even for self-pay claims.
    ///
    /// </summary>
    [JsonPropertyName("subscriber_secondary")]
    public SubscriberCreate? SubscriberSecondary { get; init; }

    /// <summary>
    /// Ideally, this field should contain no more than 12 diagnoses. However, more diagnoses
    /// may be submitted at this time, and coders will later prioritize the 12 that will be
    /// submitted to the payor.
    ///
    /// </summary>
    [JsonPropertyName("diagnoses")]
    public IEnumerable<DiagnosisCreate> Diagnoses { get; init; } = new List<DiagnosisCreate>();

    /// <summary>
    /// Holds a collection of clinical observations made by healthcare providers during patient encounters.
    /// </summary>
    [JsonPropertyName("clinical_notes")]
    public IEnumerable<ClinicalNoteCategoryCreate>? ClinicalNotes { get; init; }

    /// <summary>
    /// Spot to store misc, human-readable, notes about this encounter to be used
    /// in the billing process.
    ///
    /// </summary>
    [JsonPropertyName("billing_notes")]
    public IEnumerable<BillingNoteBase>? BillingNotes { get; init; }

    /// <summary>
    /// Box 24B on the CMS-1500 claim form. Line-level place of service is not currently supported. 02 for telemedicine, 11 for in-person. Full list [here](https://www.cms.gov/Medicare/Coding/place-of-service-codes/Place_of_Service_Code_Set).
    ///
    /// </summary>
    [JsonPropertyName("place_of_service_code")]
    public required FacilityTypeCode PlaceOfServiceCode { get; init; }

    [JsonPropertyName("patient_histories")]
    public IEnumerable<PatientHistoryCategory>? PatientHistories { get; init; }

    /// <summary>
    /// Each service line must be linked to a diagnosis. Concretely,
    /// `service_line.diagnosis_pointers`must contain at least one entry which should be
    /// in bounds of the diagnoses list field.
    ///
    /// </summary>
    [JsonPropertyName("service_lines")]
    public IEnumerable<ServiceLineCreate>? ServiceLines { get; init; }

    /// <summary>
    /// Personal and contact info for the guarantor of the patient responsibility.
    ///
    /// </summary>
    [JsonPropertyName("guarantor")]
    public GuarantorCreate? Guarantor { get; init; }

    /// <summary>
    /// ***This field is in beta.***
    /// To be included for claims that have been submitted outside of Candid.
    /// Candid supports posting remits and payments to these claims and working them in-platform (e.g. editing, resubmitting).
    ///
    /// </summary>
    [JsonPropertyName("external_claim_submission")]
    public ExternalClaimSubmissionCreate? ExternalClaimSubmission { get; init; }

    /// <summary>
    /// Names of tags that should be on the encounter.
    /// </summary>
    [JsonPropertyName("tag_ids")]
    public IEnumerable<string>? TagIds { get; init; }
}
