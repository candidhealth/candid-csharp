using System.Net.Http;
using System.Text.Json;
using System.Threading;
using Candid.Net.Core;

#nullable enable

namespace Candid.Net.Encounters.V4;

public partial class V4Client
{
    private RawClient _client;

    internal V4Client(RawClient client)
    {
        _client = client;
    }

    /// <example>
    /// <code>
    /// await client.Encounters.V4.GetAllAsync(
    ///     new GetAllEncountersRequest
    ///     {
    ///         Limit = 100,
    ///         ClaimStatus = ClaimStatus.BillerReceived,
    ///         Sort = EncounterSortOptions.CreatedAtAsc,
    ///         PageToken = "eyJ0b2tlbiI6IjEiLCJwYWdlX3Rva2VuIjoiMiJ9",
    ///         DateOfServiceMin = new DateOnly(2019, 8, 24),
    ///         DateOfServiceMax = new DateOnly(2019, 8, 25),
    ///         PrimaryPayerNames = "Medicare,Medicaid",
    ///         SearchTerm = "doe",
    ///         ExternalId = "123456",
    ///         DiagnosesUpdatedSince = new DateTime(2019, 08, 24, 14, 15, 22, 000),
    ///     }
    /// );
    /// </code>
    /// </example>
    public async Task<EncounterPage> GetAllAsync(
        GetAllEncountersRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        var _query = new Dictionary<string, object>();
        _query["tag_ids"] = request.TagIds;
        if (request.Limit != null)
        {
            _query["limit"] = request.Limit.ToString();
        }
        if (request.ClaimStatus != null)
        {
            _query["claim_status"] = request.ClaimStatus.Value.Stringify();
        }
        if (request.Sort != null)
        {
            _query["sort"] = request.Sort.Value.Stringify();
        }
        if (request.PageToken != null)
        {
            _query["page_token"] = request.PageToken;
        }
        if (request.DateOfServiceMin != null)
        {
            _query["date_of_service_min"] = request.DateOfServiceMin.Value.ToString(
                Constants.DateFormat
            );
        }
        if (request.DateOfServiceMax != null)
        {
            _query["date_of_service_max"] = request.DateOfServiceMax.Value.ToString(
                Constants.DateFormat
            );
        }
        if (request.PrimaryPayerNames != null)
        {
            _query["primary_payer_names"] = request.PrimaryPayerNames;
        }
        if (request.SearchTerm != null)
        {
            _query["search_term"] = request.SearchTerm;
        }
        if (request.ExternalId != null)
        {
            _query["external_id"] = request.ExternalId;
        }
        if (request.DiagnosesUpdatedSince != null)
        {
            _query["diagnoses_updated_since"] = request.DiagnosesUpdatedSince.Value.ToString(
                Constants.DateTimeFormat
            );
        }
        if (request.WorkQueueId != null)
        {
            _query["work_queue_id"] = request.WorkQueueId;
        }
        if (request.BillableStatus != null)
        {
            _query["billable_status"] = request.BillableStatus.Value.Stringify();
        }
        if (request.ResponsibleParty != null)
        {
            _query["responsible_party"] = request.ResponsibleParty.Value.Stringify();
        }
        if (request.OwnerOfNextAction != null)
        {
            _query["owner_of_next_action"] = request.OwnerOfNextAction.Value.Stringify();
        }
        if (request.PatientExternalId != null)
        {
            _query["patient_external_id"] = request.PatientExternalId;
        }
        var response = await _client.MakeRequestAsync(
            new RawClient.JsonApiRequest
            {
                BaseUrl = _client.Options.Environment.CandidApi,
                Method = HttpMethod.Get,
                Path = "/api/encounters/v4",
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
                return JsonUtils.Deserialize<EncounterPage>(responseBody)!;
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
    /// await client.Encounters.V4.GetAsync("d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32");
    /// </code>
    /// </example>
    public async Task<Encounter> GetAsync(
        string encounterId,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.JsonApiRequest
            {
                BaseUrl = _client.Options.Environment.CandidApi,
                Method = HttpMethod.Get,
                Path = $"/api/encounters/v4/{encounterId}",
                Options = options,
            },
            cancellationToken
        );
        var responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode is >= 200 and < 400)
        {
            try
            {
                return JsonUtils.Deserialize<Encounter>(responseBody)!;
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
    /// await client.Encounters.V4.CreateAsync(
    ///     new EncounterCreate
    ///     {
    ///         Patient = new PatientCreate
    ///         {
    ///             PhoneNumbers = new List&lt;PhoneNumber&gt;()
    ///             {
    ///                 new PhoneNumber { Number = "1234567890", Type = PhoneNumberType.Home },
    ///             },
    ///             PhoneConsent = true,
    ///             Email = "johndoe@joincandidhealth.com",
    ///             NonInsurancePayers = new List&lt;string&gt;() { "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32" },
    ///             NonInsurancePayersInfo = new List&lt;PatientNonInsurancePayerInfoCreate&gt;()
    ///             {
    ///                 new PatientNonInsurancePayerInfoCreate
    ///                 {
    ///                     NonInsurancePayerId = "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
    ///                     MemberId = "string",
    ///                     ClinicalTrialInfo = new List&lt;PatientClinicalTrialInfoCreate&gt;()
    ///                     {
    ///                         new PatientClinicalTrialInfoCreate
    ///                         {
    ///                             ClinicalTrialId = "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
    ///                         },
    ///                     },
    ///                 },
    ///             },
    ///             EmailConsent = true,
    ///             ExternalId = "string",
    ///             DateOfBirth = new DateOnly(2023, 1, 15),
    ///             Address = new StreetAddressShortZip
    ///             {
    ///                 Address1 = "123 Main St",
    ///                 Address2 = "Apt 1",
    ///                 City = "New York",
    ///                 State = State.Ny,
    ///                 ZipCode = "10001",
    ///                 ZipPlusFourCode = "1234",
    ///             },
    ///             FirstName = "string",
    ///             LastName = "string",
    ///             Gender = Candid.Net.Gender.Male,
    ///         },
    ///         BillingProvider = new BillingProvider
    ///         {
    ///             Address = new StreetAddressLongZip
    ///             {
    ///                 Address1 = "123 Main St",
    ///                 Address2 = "Apt 1",
    ///                 City = "New York",
    ///                 State = State.Ny,
    ///                 ZipCode = "10001",
    ///                 ZipPlusFourCode = "1234",
    ///             },
    ///             TaxId = "string",
    ///             Npi = "string",
    ///             TaxonomyCode = "string",
    ///             ProviderCommercialLicenseType =
    ///                 BillingProviderCommercialLicenseType.LicensedClinicalSocialWorker,
    ///         },
    ///         RenderingProvider = new RenderingProvider
    ///         {
    ///             Npi = "string",
    ///             TaxonomyCode = "string",
    ///             Address = new StreetAddressLongZip
    ///             {
    ///                 Address1 = "123 Main St",
    ///                 Address2 = "Apt 1",
    ///                 City = "New York",
    ///                 State = State.Ny,
    ///                 ZipCode = "10001",
    ///                 ZipPlusFourCode = "1234",
    ///             },
    ///         },
    ///         ReferringProvider = new ReferringProvider
    ///         {
    ///             Npi = "string",
    ///             TaxonomyCode = "string",
    ///             Address = new StreetAddressLongZip
    ///             {
    ///                 Address1 = "123 Main St",
    ///                 Address2 = "Apt 1",
    ///                 City = "New York",
    ///                 State = State.Ny,
    ///                 ZipCode = "10001",
    ///                 ZipPlusFourCode = "1234",
    ///             },
    ///         },
    ///         InitialReferringProvider = new InitialReferringProvider
    ///         {
    ///             Npi = "string",
    ///             TaxonomyCode = "string",
    ///             Address = new StreetAddressLongZip
    ///             {
    ///                 Address1 = "123 Main St",
    ///                 Address2 = "Apt 1",
    ///                 City = "New York",
    ///                 State = State.Ny,
    ///                 ZipCode = "10001",
    ///                 ZipPlusFourCode = "1234",
    ///             },
    ///             Qualifier = QualifierCode.Dq,
    ///         },
    ///         SupervisingProvider = new SupervisingProvider
    ///         {
    ///             Npi = "string",
    ///             TaxonomyCode = "string",
    ///             Address = new StreetAddressLongZip
    ///             {
    ///                 Address1 = "123 Main St",
    ///                 Address2 = "Apt 1",
    ///                 City = "New York",
    ///                 State = State.Ny,
    ///                 ZipCode = "10001",
    ///                 ZipPlusFourCode = "1234",
    ///             },
    ///         },
    ///         ServiceFacility = new EncounterServiceFacilityBase
    ///         {
    ///             OrganizationName = "string",
    ///             Npi = "string",
    ///             Address = new StreetAddressLongZip
    ///             {
    ///                 Address1 = "123 Main St",
    ///                 Address2 = "Apt 1",
    ///                 City = "New York",
    ///                 State = State.Ny,
    ///                 ZipCode = "10001",
    ///                 ZipPlusFourCode = "1234",
    ///             },
    ///             SecondaryIdentification = "string",
    ///         },
    ///         SubscriberPrimary = new SubscriberCreate
    ///         {
    ///             InsuranceCard = new InsuranceCardCreate
    ///             {
    ///                 MemberId = "string",
    ///                 PayerName = "string",
    ///                 PayerId = "string",
    ///             },
    ///             PatientRelationshipToSubscriberCode = PatientRelationshipToInsuredCodeAll.Spouse,
    ///             FirstName = "string",
    ///             LastName = "string",
    ///             Gender = Candid.Net.Gender.Male,
    ///         },
    ///         SubscriberSecondary = new SubscriberCreate
    ///         {
    ///             InsuranceCard = new InsuranceCardCreate
    ///             {
    ///                 MemberId = "string",
    ///                 PayerName = "string",
    ///                 PayerId = "string",
    ///             },
    ///             PatientRelationshipToSubscriberCode = PatientRelationshipToInsuredCodeAll.Spouse,
    ///             FirstName = "string",
    ///             LastName = "string",
    ///             Gender = Candid.Net.Gender.Male,
    ///         },
    ///         SubscriberTertiary = new SubscriberCreate
    ///         {
    ///             InsuranceCard = new InsuranceCardCreate
    ///             {
    ///                 MemberId = "string",
    ///                 PayerName = "string",
    ///                 PayerId = "string",
    ///             },
    ///             PatientRelationshipToSubscriberCode = PatientRelationshipToInsuredCodeAll.Spouse,
    ///             FirstName = "string",
    ///             LastName = "string",
    ///             Gender = Candid.Net.Gender.Male,
    ///         },
    ///         PriorAuthorizationNumber = "string",
    ///         ResponsibleParty = ResponsiblePartyType.InsurancePay,
    ///         Diagnoses = new List&lt;DiagnosisCreate&gt;()
    ///         {
    ///             new DiagnosisCreate
    ///             {
    ///                 Name = "string",
    ///                 CodeType = DiagnosisTypeCode.Abf,
    ///                 Code = "string",
    ///             },
    ///         },
    ///         ClinicalNotes = new List&lt;ClinicalNoteCategoryCreate&gt;()
    ///         {
    ///             new ClinicalNoteCategoryCreate
    ///             {
    ///                 Category = NoteCategory.Clinical,
    ///                 Notes = new List&lt;ClinicalNote&gt;() { },
    ///             },
    ///         },
    ///         BillingNotes = new List&lt;BillingNoteBase&gt;() { new BillingNoteBase { Text = "string" } },
    ///         PlaceOfServiceCode = FacilityTypeCode.Pharmacy,
    ///         PatientHistories = new List&lt;PatientHistoryCategory&gt;()
    ///         {
    ///             new PatientHistoryCategory
    ///             {
    ///                 Category = PatientHistoryCategoryEnum.PresentIllness,
    ///                 Questions = new List&lt;IntakeQuestion&gt;()
    ///                 {
    ///                     new IntakeQuestion
    ///                     {
    ///                         Id = "6E7FBCE4-A8EA-46D0-A8D8-FF83CA3BB176",
    ///                         Text = "Do you have any allergies?",
    ///                         Responses = new List&lt;IntakeResponseAndFollowUps&gt;()
    ///                         {
    ///                             new IntakeResponseAndFollowUps
    ///                             {
    ///                                 Response = "No allergies",
    ///                                 FollowUps = new List&lt;IntakeFollowUp&gt;()
    ///                                 {
    ///                                     new IntakeFollowUp
    ///                                     {
    ///                                         Id = "4F3D57F9-AC94-49D6-87E4-E804B709917A",
    ///                                         Text = "Do you have any allergies?",
    ///                                         Response = "No allergies",
    ///                                     },
    ///                                 },
    ///                             },
    ///                         },
    ///                     },
    ///                 },
    ///             },
    ///         },
    ///         ServiceLines = new List&lt;ServiceLineCreate&gt;()
    ///         {
    ///             new ServiceLineCreate
    ///             {
    ///                 ProcedureCode = "string",
    ///                 Quantity = "string",
    ///                 Units = ServiceLineUnits.Mj,
    ///                 DiagnosisPointers = new List&lt;int&gt;() { },
    ///             },
    ///         },
    ///         Guarantor = new GuarantorCreate
    ///         {
    ///             PhoneNumbers = new List&lt;PhoneNumber&gt;()
    ///             {
    ///                 new PhoneNumber { Number = "1234567890", Type = PhoneNumberType.Home },
    ///             },
    ///             PhoneConsent = true,
    ///             Email = "johndoe@joincandidhealth.com",
    ///             EmailConsent = true,
    ///             FirstName = "string",
    ///             LastName = "string",
    ///             ExternalId = "string",
    ///             DateOfBirth = new DateOnly(2023, 1, 15),
    ///             Address = new StreetAddressShortZip
    ///             {
    ///                 Address1 = "123 Main St",
    ///                 Address2 = "Apt 1",
    ///                 City = "New York",
    ///                 State = State.Ny,
    ///                 ZipCode = "10001",
    ///                 ZipPlusFourCode = "1234",
    ///             },
    ///         },
    ///         ExternalClaimSubmission = new ExternalClaimSubmissionCreate
    ///         {
    ///             ClaimCreatedAt = new DateTime(2023, 01, 01, 12, 00, 00, 000),
    ///             PatientControlNumber = "PATIENT_CONTROL_NUMBER",
    ///             SubmissionRecords = new List&lt;ClaimSubmissionRecordCreate&gt;()
    ///             {
    ///                 new ClaimSubmissionRecordCreate
    ///                 {
    ///                     SubmittedAt = new DateTime(2023, 01, 01, 13, 00, 00, 000),
    ///                     ClaimFrequencyCode = ClaimFrequencyTypeCode.Original,
    ///                     PayerResponsibility = ClaimSubmissionPayerResponsibilityType.Primary,
    ///                     IntendedSubmissionMedium = IntendedSubmissionMedium.Electronic,
    ///                 },
    ///                 new ClaimSubmissionRecordCreate
    ///                 {
    ///                     SubmittedAt = new DateTime(2023, 01, 04, 12, 00, 00, 000),
    ///                     ClaimFrequencyCode = ClaimFrequencyTypeCode.Replacement,
    ///                     PayerResponsibility = ClaimSubmissionPayerResponsibilityType.Primary,
    ///                     IntendedSubmissionMedium = IntendedSubmissionMedium.Paper,
    ///                 },
    ///             },
    ///         },
    ///         TagIds = new List&lt;string&gt;() { "string" },
    ///         SchemaInstances = new List&lt;SchemaInstance&gt;()
    ///         {
    ///             new SchemaInstance
    ///             {
    ///                 SchemaId = "ec096b13-f80a-471d-aaeb-54b021c9d582",
    ///                 Content = new Dictionary&lt;string, object&gt;()
    ///                 {
    ///                     { "provider_category", "internist" },
    ///                     { "is_urgent_care", true },
    ///                     { "bmi", 24.2 },
    ///                     { "age", 38 },
    ///                 },
    ///             },
    ///         },
    ///         ReferralNumber = "string",
    ///         EpsdtReferral = new EpsdtReferral
    ///         {
    ///             ConditionIndicator1 = EpsdtReferralConditionIndicatorCode.Av,
    ///         },
    ///         ClaimSupplementalInformation = new List&lt;ClaimSupplementalInformation&gt;()
    ///         {
    ///             new ClaimSupplementalInformation
    ///             {
    ///                 AttachmentReportTypeCode = ReportTypeCode.C03,
    ///                 AttachmentTransmissionCode = ReportTransmissionCode.Cbm,
    ///             },
    ///         },
    ///         ExternalId = "string",
    ///         DateOfService = new DateOnly(2023, 1, 15),
    ///         EndDateOfService = new DateOnly(2023, 1, 15),
    ///         PatientAuthorizedRelease = true,
    ///         BenefitsAssignedToProvider = true,
    ///         ProviderAcceptsAssignment = true,
    ///         AppointmentType = "string",
    ///         ExistingMedications = new List&lt;Medication&gt;()
    ///         {
    ///             new Medication
    ///             {
    ///                 Name = "Lisinopril",
    ///                 RxCui = "860975",
    ///                 Dosage = "10mg",
    ///                 DosageForm = "Tablet",
    ///                 Frequency = "Once Daily",
    ///                 AsNeeded = true,
    ///             },
    ///         },
    ///         Vitals = new Vitals
    ///         {
    ///             HeightIn = 70,
    ///             WeightLbs = 165,
    ///             BloodPressureSystolicMmhg = 115,
    ///             BloodPressureDiastolicMmhg = 85,
    ///             BodyTemperatureF = 98,
    ///             HemoglobinGdl = 15.1,
    ///             HematocritPct = 51.2,
    ///         },
    ///         Interventions = new List&lt;Intervention&gt;()
    ///         {
    ///             new Intervention
    ///             {
    ///                 Name = "Physical Therapy Session",
    ///                 Category = InterventionCategory.Lifestyle,
    ///                 Description =
    ///                     "A session focused on improving muscular strength, flexibility, and range of motion post-injury.",
    ///                 Medication = new Medication
    ///                 {
    ///                     Name = "Lisinopril",
    ///                     RxCui = "860975",
    ///                     Dosage = "10mg",
    ///                     DosageForm = "Tablet",
    ///                     Frequency = "Once Daily",
    ///                     AsNeeded = true,
    ///                 },
    ///                 Labs = new List&lt;Lab&gt;()
    ///                 {
    ///                     new Lab
    ///                     {
    ///                         Name = "Genetic Health Labs",
    ///                         Code = "GH12345",
    ///                         CodeType = LabCodeType.Quest,
    ///                     },
    ///                 },
    ///             },
    ///         },
    ///         PayToAddress = new StreetAddressLongZip
    ///         {
    ///             Address1 = "123 Main St",
    ///             Address2 = "Apt 1",
    ///             City = "New York",
    ///             State = State.Ny,
    ///             ZipCode = "10001",
    ///             ZipPlusFourCode = "1234",
    ///         },
    ///         Synchronicity = SynchronicityType.Synchronous,
    ///         BillableStatus = BillableStatusType.Billable,
    ///         AdditionalInformation = "string",
    ///         ServiceAuthorizationExceptionCode = ServiceAuthorizationExceptionCode.C1,
    ///         AdmissionDate = new DateOnly(2023, 1, 15),
    ///         DischargeDate = new DateOnly(2023, 1, 15),
    ///         OnsetOfCurrentIllnessOrSymptomDate = new DateOnly(2023, 1, 15),
    ///         LastMenstrualPeriodDate = new DateOnly(2023, 1, 15),
    ///         DelayReasonCode = DelayReasonCode.C1,
    ///     }
    /// );
    /// </code>
    /// </example>
    public async Task<Encounter> CreateAsync(
        EncounterCreate request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.JsonApiRequest
            {
                BaseUrl = _client.Options.Environment.CandidApi,
                Method = HttpMethod.Post,
                Path = "/api/encounters/v4",
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
                return JsonUtils.Deserialize<Encounter>(responseBody)!;
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

    /// <summary>
    /// Create an encounter from a pre-encounter patient and appointment. This endpoint is intended to be used by consumers who are managing
    /// patients and appointments in the pre-encounter service and is currently under development. Consumers who are not taking advantage
    /// of the pre-encounter service should use the standard create endpoint.
    ///
    /// The endpoint will create an encounter from the provided fields, pulling information from the provided patient and appointment objects
    /// where applicable. In particular, the following fields are populated from the patient and appointment objects:
    ///
    /// - Patient
    /// - Referring Provider
    /// - Subscriber Primary
    /// - Subscriber Secondary
    /// - Referral Number
    /// - Responsible Party
    /// - Guarantor
    ///
    /// Utilizing this endpoint opts you into automatic updating of the encounter when the patient or appointment is updated, assuming the
    /// encounter has not already been submitted or adjudicated.
    /// </summary>
    /// <example>
    /// <code>
    /// await client.Encounters.V4.CreateFromPreEncounterPatientAsync(
    ///     new EncounterCreateFromPreEncounter
    ///     {
    ///         PreEncounterPatientId = "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
    ///         PreEncounterAppointmentIds = new List&lt;string&gt;() { "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32" },
    ///         BillingProvider = new BillingProvider
    ///         {
    ///             Address = new StreetAddressLongZip
    ///             {
    ///                 Address1 = "123 Main St",
    ///                 Address2 = "Apt 1",
    ///                 City = "New York",
    ///                 State = State.Ny,
    ///                 ZipCode = "10001",
    ///                 ZipPlusFourCode = "1234",
    ///             },
    ///             TaxId = "string",
    ///             Npi = "string",
    ///             TaxonomyCode = "string",
    ///             ProviderCommercialLicenseType =
    ///                 BillingProviderCommercialLicenseType.LicensedClinicalSocialWorker,
    ///         },
    ///         RenderingProvider = new RenderingProvider
    ///         {
    ///             Npi = "string",
    ///             TaxonomyCode = "string",
    ///             Address = new StreetAddressLongZip
    ///             {
    ///                 Address1 = "123 Main St",
    ///                 Address2 = "Apt 1",
    ///                 City = "New York",
    ///                 State = State.Ny,
    ///                 ZipCode = "10001",
    ///                 ZipPlusFourCode = "1234",
    ///             },
    ///         },
    ///         InitialReferringProvider = new InitialReferringProvider
    ///         {
    ///             Npi = "string",
    ///             TaxonomyCode = "string",
    ///             Address = new StreetAddressLongZip
    ///             {
    ///                 Address1 = "123 Main St",
    ///                 Address2 = "Apt 1",
    ///                 City = "New York",
    ///                 State = State.Ny,
    ///                 ZipCode = "10001",
    ///                 ZipPlusFourCode = "1234",
    ///             },
    ///             Qualifier = QualifierCode.Dq,
    ///         },
    ///         SupervisingProvider = new SupervisingProvider
    ///         {
    ///             Npi = "string",
    ///             TaxonomyCode = "string",
    ///             Address = new StreetAddressLongZip
    ///             {
    ///                 Address1 = "123 Main St",
    ///                 Address2 = "Apt 1",
    ///                 City = "New York",
    ///                 State = State.Ny,
    ///                 ZipCode = "10001",
    ///                 ZipPlusFourCode = "1234",
    ///             },
    ///         },
    ///         ServiceFacility = new EncounterServiceFacilityBase
    ///         {
    ///             OrganizationName = "string",
    ///             Npi = "string",
    ///             Address = new StreetAddressLongZip
    ///             {
    ///                 Address1 = "123 Main St",
    ///                 Address2 = "Apt 1",
    ///                 City = "New York",
    ///                 State = State.Ny,
    ///                 ZipCode = "10001",
    ///                 ZipPlusFourCode = "1234",
    ///             },
    ///             SecondaryIdentification = "string",
    ///         },
    ///         Diagnoses = new List&lt;DiagnosisCreate&gt;()
    ///         {
    ///             new DiagnosisCreate
    ///             {
    ///                 Name = "string",
    ///                 CodeType = DiagnosisTypeCode.Abf,
    ///                 Code = "string",
    ///             },
    ///         },
    ///         ClinicalNotes = new List&lt;ClinicalNoteCategoryCreate&gt;()
    ///         {
    ///             new ClinicalNoteCategoryCreate
    ///             {
    ///                 Category = NoteCategory.Clinical,
    ///                 Notes = new List&lt;ClinicalNote&gt;() { },
    ///             },
    ///         },
    ///         BillingNotes = new List&lt;BillingNoteBase&gt;() { new BillingNoteBase { Text = "string" } },
    ///         PlaceOfServiceCode = FacilityTypeCode.Pharmacy,
    ///         PatientHistories = new List&lt;PatientHistoryCategory&gt;()
    ///         {
    ///             new PatientHistoryCategory
    ///             {
    ///                 Category = PatientHistoryCategoryEnum.PresentIllness,
    ///                 Questions = new List&lt;IntakeQuestion&gt;()
    ///                 {
    ///                     new IntakeQuestion
    ///                     {
    ///                         Id = "6E7FBCE4-A8EA-46D0-A8D8-FF83CA3BB176",
    ///                         Text = "Do you have any allergies?",
    ///                         Responses = new List&lt;IntakeResponseAndFollowUps&gt;()
    ///                         {
    ///                             new IntakeResponseAndFollowUps
    ///                             {
    ///                                 Response = "No allergies",
    ///                                 FollowUps = new List&lt;IntakeFollowUp&gt;()
    ///                                 {
    ///                                     new IntakeFollowUp
    ///                                     {
    ///                                         Id = "4F3D57F9-AC94-49D6-87E4-E804B709917A",
    ///                                         Text = "Do you have any allergies?",
    ///                                         Response = "No allergies",
    ///                                     },
    ///                                 },
    ///                             },
    ///                         },
    ///                     },
    ///                 },
    ///             },
    ///         },
    ///         ServiceLines = new List&lt;ServiceLineCreate&gt;()
    ///         {
    ///             new ServiceLineCreate
    ///             {
    ///                 ProcedureCode = "string",
    ///                 Quantity = "string",
    ///                 Units = ServiceLineUnits.Mj,
    ///                 DiagnosisPointers = new List&lt;int&gt;() { },
    ///             },
    ///         },
    ///         ExternalClaimSubmission = new ExternalClaimSubmissionCreate
    ///         {
    ///             ClaimCreatedAt = new DateTime(2023, 01, 01, 12, 00, 00, 000),
    ///             PatientControlNumber = "PATIENT_CONTROL_NUMBER",
    ///             SubmissionRecords = new List&lt;ClaimSubmissionRecordCreate&gt;()
    ///             {
    ///                 new ClaimSubmissionRecordCreate
    ///                 {
    ///                     SubmittedAt = new DateTime(2023, 01, 01, 13, 00, 00, 000),
    ///                     ClaimFrequencyCode = ClaimFrequencyTypeCode.Original,
    ///                     PayerResponsibility = ClaimSubmissionPayerResponsibilityType.Primary,
    ///                     IntendedSubmissionMedium = IntendedSubmissionMedium.Electronic,
    ///                 },
    ///                 new ClaimSubmissionRecordCreate
    ///                 {
    ///                     SubmittedAt = new DateTime(2023, 01, 04, 12, 00, 00, 000),
    ///                     ClaimFrequencyCode = ClaimFrequencyTypeCode.Replacement,
    ///                     PayerResponsibility = ClaimSubmissionPayerResponsibilityType.Primary,
    ///                     IntendedSubmissionMedium = IntendedSubmissionMedium.Paper,
    ///                 },
    ///             },
    ///         },
    ///         TagIds = new List&lt;string&gt;() { "string" },
    ///         SchemaInstances = new List&lt;SchemaInstance&gt;()
    ///         {
    ///             new SchemaInstance
    ///             {
    ///                 SchemaId = "ec096b13-f80a-471d-aaeb-54b021c9d582",
    ///                 Content = new Dictionary&lt;string, object&gt;()
    ///                 {
    ///                     { "provider_category", "internist" },
    ///                     { "is_urgent_care", true },
    ///                     { "bmi", 24.2 },
    ///                     { "age", 38 },
    ///                 },
    ///             },
    ///         },
    ///         ExternalId = "string",
    ///         DateOfService = new DateOnly(2023, 1, 15),
    ///         EndDateOfService = new DateOnly(2023, 1, 15),
    ///         PatientAuthorizedRelease = true,
    ///         BenefitsAssignedToProvider = true,
    ///         ProviderAcceptsAssignment = true,
    ///         AppointmentType = "string",
    ///         ExistingMedications = new List&lt;Medication&gt;()
    ///         {
    ///             new Medication
    ///             {
    ///                 Name = "Lisinopril",
    ///                 RxCui = "860975",
    ///                 Dosage = "10mg",
    ///                 DosageForm = "Tablet",
    ///                 Frequency = "Once Daily",
    ///                 AsNeeded = true,
    ///             },
    ///         },
    ///         Vitals = new Vitals
    ///         {
    ///             HeightIn = 70,
    ///             WeightLbs = 165,
    ///             BloodPressureSystolicMmhg = 115,
    ///             BloodPressureDiastolicMmhg = 85,
    ///             BodyTemperatureF = 98,
    ///             HemoglobinGdl = 15.1,
    ///             HematocritPct = 51.2,
    ///         },
    ///         Interventions = new List&lt;Intervention&gt;()
    ///         {
    ///             new Intervention
    ///             {
    ///                 Name = "Physical Therapy Session",
    ///                 Category = InterventionCategory.Lifestyle,
    ///                 Description =
    ///                     "A session focused on improving muscular strength, flexibility, and range of motion post-injury.",
    ///                 Medication = new Medication
    ///                 {
    ///                     Name = "Lisinopril",
    ///                     RxCui = "860975",
    ///                     Dosage = "10mg",
    ///                     DosageForm = "Tablet",
    ///                     Frequency = "Once Daily",
    ///                     AsNeeded = true,
    ///                 },
    ///                 Labs = new List&lt;Lab&gt;()
    ///                 {
    ///                     new Lab
    ///                     {
    ///                         Name = "Genetic Health Labs",
    ///                         Code = "GH12345",
    ///                         CodeType = LabCodeType.Quest,
    ///                     },
    ///                 },
    ///             },
    ///         },
    ///         PayToAddress = new StreetAddressLongZip
    ///         {
    ///             Address1 = "123 Main St",
    ///             Address2 = "Apt 1",
    ///             City = "New York",
    ///             State = State.Ny,
    ///             ZipCode = "10001",
    ///             ZipPlusFourCode = "1234",
    ///         },
    ///         Synchronicity = SynchronicityType.Synchronous,
    ///         BillableStatus = BillableStatusType.Billable,
    ///         AdditionalInformation = "string",
    ///         ServiceAuthorizationExceptionCode = ServiceAuthorizationExceptionCode.C1,
    ///         AdmissionDate = new DateOnly(2023, 1, 15),
    ///         DischargeDate = new DateOnly(2023, 1, 15),
    ///         OnsetOfCurrentIllnessOrSymptomDate = new DateOnly(2023, 1, 15),
    ///         LastMenstrualPeriodDate = new DateOnly(2023, 1, 15),
    ///         DelayReasonCode = DelayReasonCode.C1,
    ///     }
    /// );
    /// </code>
    /// </example>
    public async Task<Encounter> CreateFromPreEncounterPatientAsync(
        EncounterCreateFromPreEncounter request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.JsonApiRequest
            {
                BaseUrl = _client.Options.Environment.CandidApi,
                Method = HttpMethod.Post,
                Path = "/api/encounters/v4/create-from-pre-encounter",
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
                return JsonUtils.Deserialize<Encounter>(responseBody)!;
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
    /// await client.Encounters.V4.UpdateAsync(
    ///     "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
    ///     new EncounterUpdate
    ///     {
    ///         DiagnosisIds = new List&lt;string&gt;() { "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32" },
    ///         PlaceOfServiceCodeAsSubmitted = FacilityTypeCode.Pharmacy,
    ///         BenefitsAssignedToProvider = true,
    ///         PriorAuthorizationNumber = "string",
    ///         ExternalId = "string",
    ///         DateOfService = new DateOnly(2023, 1, 15),
    ///         TagIds = new List&lt;string&gt;() { },
    ///         ClinicalNotes = new List&lt;ClinicalNoteCategoryCreate&gt;() { },
    ///         PayToAddress = new StreetAddressLongZip
    ///         {
    ///             Address1 = "123 Main St",
    ///             Address2 = "Apt 1",
    ///             City = "New York",
    ///             State = State.Ny,
    ///             ZipCode = "10001",
    ///             ZipPlusFourCode = "1234",
    ///         },
    ///         BillableStatus = BillableStatusType.Billable,
    ///         ResponsibleParty = ResponsiblePartyType.InsurancePay,
    ///         ProviderAcceptsAssignment = true,
    ///         Synchronicity = SynchronicityType.Synchronous,
    ///         PlaceOfServiceCode = FacilityTypeCode.Pharmacy,
    ///         AppointmentType = "string",
    ///         EndDateOfService = new DateOnly(2023, 1, 15),
    ///         SubscriberPrimary = new SubscriberCreate
    ///         {
    ///             InsuranceCard = new InsuranceCardCreate
    ///             {
    ///                 MemberId = "string",
    ///                 PayerName = "string",
    ///                 PayerId = "string",
    ///             },
    ///             PatientRelationshipToSubscriberCode = PatientRelationshipToInsuredCodeAll.Spouse,
    ///             FirstName = "string",
    ///             LastName = "string",
    ///             Gender = Candid.Net.Gender.Male,
    ///         },
    ///         SubscriberSecondary = new SubscriberCreate
    ///         {
    ///             InsuranceCard = new InsuranceCardCreate
    ///             {
    ///                 MemberId = "string",
    ///                 PayerName = "string",
    ///                 PayerId = "string",
    ///             },
    ///             PatientRelationshipToSubscriberCode = PatientRelationshipToInsuredCodeAll.Spouse,
    ///             FirstName = "string",
    ///             LastName = "string",
    ///             Gender = Candid.Net.Gender.Male,
    ///         },
    ///         SubscriberTertiary = new SubscriberCreate
    ///         {
    ///             InsuranceCard = new InsuranceCardCreate
    ///             {
    ///                 MemberId = "string",
    ///                 PayerName = "string",
    ///                 PayerId = "string",
    ///             },
    ///             PatientRelationshipToSubscriberCode = PatientRelationshipToInsuredCodeAll.Spouse,
    ///             FirstName = "string",
    ///             LastName = "string",
    ///             Gender = Candid.Net.Gender.Male,
    ///         },
    ///         AdditionalInformation = "string",
    ///         ServiceAuthorizationExceptionCode = ServiceAuthorizationExceptionCode.C1,
    ///         AdmissionDate = new DateOnly(2023, 1, 15),
    ///         DischargeDate = new DateOnly(2023, 1, 15),
    ///         OnsetOfCurrentIllnessOrSymptomDate = new DateOnly(2023, 1, 15),
    ///         LastMenstrualPeriodDate = new DateOnly(2023, 1, 15),
    ///         DelayReasonCode = DelayReasonCode.C1,
    ///         Patient = new PatientUpdate(),
    ///         PatientAuthorizedRelease = true,
    ///         SchemaInstances = new List&lt;SchemaInstance&gt;() { },
    ///         Vitals = new VitalsUpdate
    ///         {
    ///             HeightIn = 70,
    ///             WeightLbs = 165,
    ///             BloodPressureSystolicMmhg = 115,
    ///             BloodPressureDiastolicMmhg = 85,
    ///             BodyTemperatureF = 98,
    ///             HemoglobinGdl = 15.1,
    ///             HematocritPct = 51.2,
    ///         },
    ///         ExistingMedications = new List&lt;Medication&gt;() { },
    ///         RenderingProvider = new RenderingProviderUpdate(),
    ///         ServiceFacility = new EncounterServiceFacilityUpdate
    ///         {
    ///             OrganizationName = "Test Organization",
    ///             Address = new StreetAddressLongZip
    ///             {
    ///                 Address1 = "123 Main St",
    ///                 Address2 = "Apt 1",
    ///                 City = "New York",
    ///                 State = State.Ny,
    ///                 ZipCode = "10001",
    ///                 ZipPlusFourCode = "1234",
    ///             },
    ///         },
    ///         Guarantor = new GuarantorUpdate(),
    ///         BillingProvider = new BillingProviderUpdate(),
    ///         SupervisingProvider = new SupervisingProviderUpdate(),
    ///         ReferringProvider = new ReferringProviderUpdate(),
    ///         InitialReferringProvider = new InitialReferringProviderUpdate(),
    ///         ReferralNumber = "string",
    ///         EpsdtReferral = new EpsdtReferral
    ///         {
    ///             ConditionIndicator1 = EpsdtReferralConditionIndicatorCode.Av,
    ///         },
    ///         ClaimSupplementalInformation = new List&lt;ClaimSupplementalInformation&gt;() { },
    ///     }
    /// );
    /// </code>
    /// </example>
    public async Task<Encounter> UpdateAsync(
        string encounterId,
        EncounterUpdate request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.JsonApiRequest
            {
                BaseUrl = _client.Options.Environment.CandidApi,
                Method = HttpMethodExtensions.Patch,
                Path = $"/api/encounters/v4/{encounterId}",
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
                return JsonUtils.Deserialize<Encounter>(responseBody)!;
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
