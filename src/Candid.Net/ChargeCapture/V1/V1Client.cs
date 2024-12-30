using System.Net.Http;
using System.Text.Json;
using System.Threading;
using Candid.Net.Core;

#nullable enable

namespace Candid.Net.ChargeCapture.V1;

public partial class V1Client
{
    private RawClient _client;

    internal V1Client(RawClient client)
    {
        _client = client;
    }

    /// <example>
    /// <code>
    /// await client.ChargeCapture.V1.CreateAsync(
    ///     new CreateChargeCaptureRequest
    ///     {
    ///         Data = new ChargeCaptureData
    ///         {
    ///             Diagnoses = new List&lt;DiagnosisCreate&gt;() { },
    ///             Interventions = new List&lt;Intervention&gt;() { },
    ///             ExternalClaimSubmission = new ExternalClaimSubmissionCreate
    ///             {
    ///                 ClaimCreatedAt = new DateTime(2023, 01, 01, 12, 00, 00, 000),
    ///                 PatientControlNumber = "PATIENT_CONTROL_NUMBER",
    ///                 SubmissionRecords = new List&lt;ClaimSubmissionRecordCreate&gt;()
    ///                 {
    ///                     new ClaimSubmissionRecordCreate
    ///                     {
    ///                         SubmittedAt = new DateTime(2023, 01, 01, 13, 00, 00, 000),
    ///                         ClaimFrequencyCode = ClaimFrequencyTypeCode.Original,
    ///                         PayerResponsibility = ClaimSubmissionPayerResponsibilityType.Primary,
    ///                         IntendedSubmissionMedium = IntendedSubmissionMedium.Electronic,
    ///                     },
    ///                     new ClaimSubmissionRecordCreate
    ///                     {
    ///                         SubmittedAt = new DateTime(2023, 01, 04, 12, 00, 00, 000),
    ///                         ClaimFrequencyCode = ClaimFrequencyTypeCode.Replacement,
    ///                         PayerResponsibility = ClaimSubmissionPayerResponsibilityType.Primary,
    ///                         IntendedSubmissionMedium = IntendedSubmissionMedium.Paper,
    ///                     },
    ///                 },
    ///             },
    ///             ServiceLines = new List&lt;ServiceLineCreate&gt;() { },
    ///             PatientHistories = new List&lt;PatientHistoryCategory&gt;() { },
    ///             BillingNotes = new List&lt;BillingNote&gt;() { },
    ///             BenefitsAssignedToProvider = true,
    ///             PriorAuthorizationNumber = "string",
    ///             ExternalId = "string",
    ///             DateOfService = new DateOnly(2023, 1, 15),
    ///             TagIds = new List&lt;string&gt;() { },
    ///             ClinicalNotes = new List&lt;ClinicalNoteCategoryCreate&gt;() { },
    ///             PayToAddress = new StreetAddressLongZip
    ///             {
    ///                 Address1 = "123 Main St",
    ///                 Address2 = "Apt 1",
    ///                 City = "New York",
    ///                 State = State.Ny,
    ///                 ZipCode = "10001",
    ///                 ZipPlusFourCode = "1234",
    ///             },
    ///             BillableStatus = BillableStatusType.Billable,
    ///             ResponsibleParty = ResponsiblePartyType.InsurancePay,
    ///             ProviderAcceptsAssignment = true,
    ///             Synchronicity = SynchronicityType.Synchronous,
    ///             PlaceOfServiceCode = FacilityTypeCode.Pharmacy,
    ///             AppointmentType = "string",
    ///             EndDateOfService = new DateOnly(2023, 1, 15),
    ///             SubscriberPrimary = new SubscriberCreate
    ///             {
    ///                 InsuranceCard = new InsuranceCardCreate
    ///                 {
    ///                     MemberId = "string",
    ///                     PayerName = "string",
    ///                     PayerId = "string",
    ///                 },
    ///                 PatientRelationshipToSubscriberCode = PatientRelationshipToInsuredCodeAll.Spouse,
    ///                 FirstName = "string",
    ///                 LastName = "string",
    ///                 Gender = Candid.Net.Gender.Male,
    ///             },
    ///             SubscriberSecondary = new SubscriberCreate
    ///             {
    ///                 InsuranceCard = new InsuranceCardCreate
    ///                 {
    ///                     MemberId = "string",
    ///                     PayerName = "string",
    ///                     PayerId = "string",
    ///                 },
    ///                 PatientRelationshipToSubscriberCode = PatientRelationshipToInsuredCodeAll.Spouse,
    ///                 FirstName = "string",
    ///                 LastName = "string",
    ///                 Gender = Candid.Net.Gender.Male,
    ///             },
    ///             AdditionalInformation = "string",
    ///             ServiceAuthorizationExceptionCode = ServiceAuthorizationExceptionCode.C1,
    ///             AdmissionDate = new DateOnly(2023, 1, 15),
    ///             DischargeDate = new DateOnly(2023, 1, 15),
    ///             OnsetOfCurrentIllnessOrSymptomDate = new DateOnly(2023, 1, 15),
    ///             LastMenstrualPeriodDate = new DateOnly(2023, 1, 15),
    ///             DelayReasonCode = DelayReasonCode.C1,
    ///             Patient = new PatientUpdate(),
    ///             PatientAuthorizedRelease = true,
    ///             SchemaInstances = new List&lt;SchemaInstance&gt;() { },
    ///             Vitals = new VitalsUpdate
    ///             {
    ///                 HeightIn = 70,
    ///                 WeightLbs = 165,
    ///                 BloodPressureSystolicMmhg = 115,
    ///                 BloodPressureDiastolicMmhg = 85,
    ///                 BodyTemperatureF = 98,
    ///                 HemoglobinGdl = 15.1,
    ///                 HematocritPct = 51.2,
    ///             },
    ///             ExistingMedications = new List&lt;Medication&gt;() { },
    ///             RenderingProvider = new RenderingProviderUpdate(),
    ///             ServiceFacility = new EncounterServiceFacilityUpdate
    ///             {
    ///                 OrganizationName = "Test Organization",
    ///                 Address = new StreetAddressLongZip
    ///                 {
    ///                     Address1 = "123 Main St",
    ///                     Address2 = "Apt 1",
    ///                     City = "New York",
    ///                     State = State.Ny,
    ///                     ZipCode = "10001",
    ///                     ZipPlusFourCode = "1234",
    ///                 },
    ///             },
    ///             Guarantor = new GuarantorUpdate(),
    ///             BillingProvider = new BillingProviderUpdate(),
    ///             SupervisingProvider = new SupervisingProviderUpdate(),
    ///             ReferringProvider = new ReferringProviderUpdate(),
    ///             InitialReferringProvider = new InitialReferringProviderUpdate(),
    ///             ReferralNumber = "string",
    ///         },
    ///         EncounterExternalId = "string",
    ///         EhrSourceUrl = "string",
    ///         PatientExternalId = "string",
    ///         Status = ChargeCaptureStatus.Planned,
    ///     }
    /// );
    /// </code>
    /// </example>
    public async Task<ChargeCapture> CreateAsync(
        CreateChargeCaptureRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.JsonApiRequest
            {
                BaseUrl = _client.Options.Environment.CandidApi,
                Method = HttpMethod.Post,
                Path = "/api/charge_captures/v1",
                Body = request,
                Options = options,
            },
            cancellationToken
        );
        var responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode is >= 200 and < 400)
        {
            try
            {
                return JsonUtils.Deserialize<ChargeCapture>(responseBody)!;
            }
            catch (JsonException e)
            {
                throw new CandidException("Failed to deserialize response", e);
            }
        }

        throw new CandidApiException(
            $"Error with status code {response.StatusCode}",
            response.StatusCode,
            responseBody
        );
    }

    /// <example>
    /// <code>
    /// await client.ChargeCapture.V1.DeleteAsync("d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32");
    /// </code>
    /// </example>
    public async System.Threading.Tasks.Task DeleteAsync(
        string chargeCaptureId,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.JsonApiRequest
            {
                BaseUrl = _client.Options.Environment.CandidApi,
                Method = HttpMethod.Delete,
                Path = $"/api/charge_captures/v1/{chargeCaptureId}",
                Options = options,
            },
            cancellationToken
        );
        if (response.StatusCode is >= 200 and < 400)
        {
            return;
        }
        var responseBody = await response.Raw.Content.ReadAsStringAsync();
        throw new CandidApiException(
            $"Error with status code {response.StatusCode}",
            response.StatusCode,
            responseBody
        );
    }

    /// <example>
    /// <code>
    /// await client.ChargeCapture.V1.UpdateAsync(
    ///     "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
    ///     new ChargeCaptureUpdate
    ///     {
    ///         Data = new ChargeCaptureData
    ///         {
    ///             Diagnoses = new List&lt;DiagnosisCreate&gt;() { },
    ///             Interventions = new List&lt;Intervention&gt;() { },
    ///             ExternalClaimSubmission = new ExternalClaimSubmissionCreate
    ///             {
    ///                 ClaimCreatedAt = new DateTime(2023, 01, 01, 12, 00, 00, 000),
    ///                 PatientControlNumber = "PATIENT_CONTROL_NUMBER",
    ///                 SubmissionRecords = new List&lt;ClaimSubmissionRecordCreate&gt;()
    ///                 {
    ///                     new ClaimSubmissionRecordCreate
    ///                     {
    ///                         SubmittedAt = new DateTime(2023, 01, 01, 13, 00, 00, 000),
    ///                         ClaimFrequencyCode = ClaimFrequencyTypeCode.Original,
    ///                         PayerResponsibility = ClaimSubmissionPayerResponsibilityType.Primary,
    ///                         IntendedSubmissionMedium = IntendedSubmissionMedium.Electronic,
    ///                     },
    ///                     new ClaimSubmissionRecordCreate
    ///                     {
    ///                         SubmittedAt = new DateTime(2023, 01, 04, 12, 00, 00, 000),
    ///                         ClaimFrequencyCode = ClaimFrequencyTypeCode.Replacement,
    ///                         PayerResponsibility = ClaimSubmissionPayerResponsibilityType.Primary,
    ///                         IntendedSubmissionMedium = IntendedSubmissionMedium.Paper,
    ///                     },
    ///                 },
    ///             },
    ///             ServiceLines = new List&lt;ServiceLineCreate&gt;() { },
    ///             PatientHistories = new List&lt;PatientHistoryCategory&gt;() { },
    ///             BillingNotes = new List&lt;BillingNote&gt;() { },
    ///             BenefitsAssignedToProvider = true,
    ///             PriorAuthorizationNumber = "string",
    ///             ExternalId = "string",
    ///             DateOfService = new DateOnly(2023, 1, 15),
    ///             TagIds = new List&lt;string&gt;() { },
    ///             ClinicalNotes = new List&lt;ClinicalNoteCategoryCreate&gt;() { },
    ///             PayToAddress = new StreetAddressLongZip
    ///             {
    ///                 Address1 = "123 Main St",
    ///                 Address2 = "Apt 1",
    ///                 City = "New York",
    ///                 State = State.Ny,
    ///                 ZipCode = "10001",
    ///                 ZipPlusFourCode = "1234",
    ///             },
    ///             BillableStatus = BillableStatusType.Billable,
    ///             ResponsibleParty = ResponsiblePartyType.InsurancePay,
    ///             ProviderAcceptsAssignment = true,
    ///             Synchronicity = SynchronicityType.Synchronous,
    ///             PlaceOfServiceCode = FacilityTypeCode.Pharmacy,
    ///             AppointmentType = "string",
    ///             EndDateOfService = new DateOnly(2023, 1, 15),
    ///             SubscriberPrimary = new SubscriberCreate
    ///             {
    ///                 InsuranceCard = new InsuranceCardCreate
    ///                 {
    ///                     MemberId = "string",
    ///                     PayerName = "string",
    ///                     PayerId = "string",
    ///                 },
    ///                 PatientRelationshipToSubscriberCode = PatientRelationshipToInsuredCodeAll.Spouse,
    ///                 FirstName = "string",
    ///                 LastName = "string",
    ///                 Gender = Candid.Net.Gender.Male,
    ///             },
    ///             SubscriberSecondary = new SubscriberCreate
    ///             {
    ///                 InsuranceCard = new InsuranceCardCreate
    ///                 {
    ///                     MemberId = "string",
    ///                     PayerName = "string",
    ///                     PayerId = "string",
    ///                 },
    ///                 PatientRelationshipToSubscriberCode = PatientRelationshipToInsuredCodeAll.Spouse,
    ///                 FirstName = "string",
    ///                 LastName = "string",
    ///                 Gender = Candid.Net.Gender.Male,
    ///             },
    ///             AdditionalInformation = "string",
    ///             ServiceAuthorizationExceptionCode = ServiceAuthorizationExceptionCode.C1,
    ///             AdmissionDate = new DateOnly(2023, 1, 15),
    ///             DischargeDate = new DateOnly(2023, 1, 15),
    ///             OnsetOfCurrentIllnessOrSymptomDate = new DateOnly(2023, 1, 15),
    ///             LastMenstrualPeriodDate = new DateOnly(2023, 1, 15),
    ///             DelayReasonCode = DelayReasonCode.C1,
    ///             Patient = new PatientUpdate(),
    ///             PatientAuthorizedRelease = true,
    ///             SchemaInstances = new List&lt;SchemaInstance&gt;() { },
    ///             Vitals = new VitalsUpdate
    ///             {
    ///                 HeightIn = 70,
    ///                 WeightLbs = 165,
    ///                 BloodPressureSystolicMmhg = 115,
    ///                 BloodPressureDiastolicMmhg = 85,
    ///                 BodyTemperatureF = 98,
    ///                 HemoglobinGdl = 15.1,
    ///                 HematocritPct = 51.2,
    ///             },
    ///             ExistingMedications = new List&lt;Medication&gt;() { },
    ///             RenderingProvider = new RenderingProviderUpdate(),
    ///             ServiceFacility = new EncounterServiceFacilityUpdate
    ///             {
    ///                 OrganizationName = "Test Organization",
    ///                 Address = new StreetAddressLongZip
    ///                 {
    ///                     Address1 = "123 Main St",
    ///                     Address2 = "Apt 1",
    ///                     City = "New York",
    ///                     State = State.Ny,
    ///                     ZipCode = "10001",
    ///                     ZipPlusFourCode = "1234",
    ///                 },
    ///             },
    ///             Guarantor = new GuarantorUpdate(),
    ///             BillingProvider = new BillingProviderUpdate(),
    ///             SupervisingProvider = new SupervisingProviderUpdate(),
    ///             ReferringProvider = new ReferringProviderUpdate(),
    ///             InitialReferringProvider = new InitialReferringProviderUpdate(),
    ///             ReferralNumber = "string",
    ///         },
    ///         EncounterExternalId = "string",
    ///         EhrSourceUrl = "string",
    ///         PatientExternalId = "string",
    ///         Status = ChargeCaptureStatus.Planned,
    ///     }
    /// );
    /// </code>
    /// </example>
    public async Task<ChargeCapture> UpdateAsync(
        string chargeCaptureId,
        ChargeCaptureUpdate request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.JsonApiRequest
            {
                BaseUrl = _client.Options.Environment.CandidApi,
                Method = HttpMethodExtensions.Patch,
                Path = $"/api/charge_captures/v1/{chargeCaptureId}",
                Body = request,
                Options = options,
            },
            cancellationToken
        );
        var responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode is >= 200 and < 400)
        {
            try
            {
                return JsonUtils.Deserialize<ChargeCapture>(responseBody)!;
            }
            catch (JsonException e)
            {
                throw new CandidException("Failed to deserialize response", e);
            }
        }

        throw new CandidApiException(
            $"Error with status code {response.StatusCode}",
            response.StatusCode,
            responseBody
        );
    }

    /// <example>
    /// <code>
    /// await client.ChargeCapture.V1.GetAsync("d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32");
    /// </code>
    /// </example>
    public async Task<ChargeCapture> GetAsync(
        string chargeCaptureId,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.JsonApiRequest
            {
                BaseUrl = _client.Options.Environment.CandidApi,
                Method = HttpMethod.Get,
                Path = $"/api/charge_captures/v1/{chargeCaptureId}",
                Options = options,
            },
            cancellationToken
        );
        var responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode is >= 200 and < 400)
        {
            try
            {
                return JsonUtils.Deserialize<ChargeCapture>(responseBody)!;
            }
            catch (JsonException e)
            {
                throw new CandidException("Failed to deserialize response", e);
            }
        }

        throw new CandidApiException(
            $"Error with status code {response.StatusCode}",
            response.StatusCode,
            responseBody
        );
    }

    /// <example>
    /// <code>
    /// await client.ChargeCapture.V1.GetAllAsync(
    ///     new GetAllChargeCapturesRequest
    ///     {
    ///         Limit = 1,
    ///         PageToken = "eyJ0b2tlbiI6IjEiLCJwYWdlX3Rva2VuIjoiMiJ9",
    ///         PatientExternalId = "string",
    ///         Status = ChargeCaptureStatus.Planned,
    ///         ExternalId = "string",
    ///     }
    /// );
    /// </code>
    /// </example>
    public async Task<ChargeCapturePage> GetAllAsync(
        GetAllChargeCapturesRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        var _query = new Dictionary<string, object>();
        if (request.Limit != null)
        {
            _query["limit"] = request.Limit.ToString();
        }
        if (request.PageToken != null)
        {
            _query["page_token"] = request.PageToken;
        }
        if (request.PatientExternalId != null)
        {
            _query["patient_external_id"] = request.PatientExternalId;
        }
        if (request.Status != null)
        {
            _query["status"] = request.Status.Value.Stringify();
        }
        if (request.ExternalId != null)
        {
            _query["external_id"] = request.ExternalId;
        }
        var response = await _client.MakeRequestAsync(
            new RawClient.JsonApiRequest
            {
                BaseUrl = _client.Options.Environment.CandidApi,
                Method = HttpMethod.Get,
                Path = "/api/charge_captures/v1",
                Query = _query,
                Options = options,
            },
            cancellationToken
        );
        var responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode is >= 200 and < 400)
        {
            try
            {
                return JsonUtils.Deserialize<ChargeCapturePage>(responseBody)!;
            }
            catch (JsonException e)
            {
                throw new CandidException("Failed to deserialize response", e);
            }
        }

        throw new CandidApiException(
            $"Error with status code {response.StatusCode}",
            response.StatusCode,
            responseBody
        );
    }
}
