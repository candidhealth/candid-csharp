using System.Net.Http;
using System.Text.Json;
using System.Threading;
using Candid.Net.Core;

#nullable enable

namespace Candid.Net.PreEncounter.Patients.V1;

public partial class V1Client
{
    private RawClient _client;

    internal V1Client(RawClient client)
    {
        _client = client;
    }

    /// <summary>
    /// Adds a patient. VersionConflictError is returned when the patient's external ID is already in use.
    /// </summary>
    /// <example>
    /// <code>
    /// await client.PreEncounter.Patients.V1.CreateAsync(
    ///     new CreatePatientRequest
    ///     {
    ///         SkipDuplicateCheck = true,
    ///         Body = new MutablePatient
    ///         {
    ///             Name = new HumanName
    ///             {
    ///                 Family = "string",
    ///                 Given = new List<string>() { "string" },
    ///                 Use = NameUse.Usual,
    ///                 Period = new Period
    ///                 {
    ///                     Start = new Dictionary<object, object?>() { { "key", "value" } },
    ///                     End = new Dictionary<object, object?>() { { "key", "value" } },
    ///                 },
    ///             },
    ///             OtherNames = new List<HumanName>()
    ///             {
    ///                 new HumanName
    ///                 {
    ///                     Family = "string",
    ///                     Given = new List<string>() { "string" },
    ///                     Use = NameUse.Usual,
    ///                     Period = new Period
    ///                     {
    ///                         Start = new Dictionary<object, object?>() { { "key", "value" } },
    ///                         End = new Dictionary<object, object?>() { { "key", "value" } },
    ///                     },
    ///                 },
    ///             },
    ///             Gender = Candid.Net.PreEncounter.Gender.Man,
    ///             BirthDate = new DateOnly(2023, 1, 15),
    ///             SocialSecurityNumber = "string",
    ///             BiologicalSex = Sex.Female,
    ///             SexualOrientation = SexualOrientation.Heterosexual,
    ///             Race = Race.AmericanIndianOrAlaskaNative,
    ///             Ethnicity = Ethnicity.HispanicOrLatino,
    ///             DisabilityStatus = DisabilityStatus.Disabled,
    ///             MaritalStatus = MaritalStatus.Annulled,
    ///             Deceased = new DateTime(2024, 01, 15, 09, 30, 00, 000),
    ///             MultipleBirth = 1,
    ///             PrimaryAddress = new Address
    ///             {
    ///                 Use = AddressUse.Home,
    ///                 Line = new List<string>() { "string" },
    ///                 City = "string",
    ///                 State = "string",
    ///                 PostalCode = "string",
    ///                 Country = "string",
    ///                 Period = new Period
    ///                 {
    ///                     Start = new Dictionary<object, object?>() { { "key", "value" } },
    ///                     End = new Dictionary<object, object?>() { { "key", "value" } },
    ///                 },
    ///             },
    ///             OtherAddresses = new List<Address>()
    ///             {
    ///                 new Address
    ///                 {
    ///                     Use = AddressUse.Home,
    ///                     Line = new List<string>() { "string" },
    ///                     City = "string",
    ///                     State = "string",
    ///                     PostalCode = "string",
    ///                     Country = "string",
    ///                     Period = new Period
    ///                     {
    ///                         Start = new Dictionary<object, object?>() { { "key", "value" } },
    ///                         End = new Dictionary<object, object?>() { { "key", "value" } },
    ///                     },
    ///                 },
    ///             },
    ///             PrimaryTelecom = new ContactPoint
    ///             {
    ///                 Value = "string",
    ///                 Use = ContactPointUse.Home,
    ///                 Period = new Dictionary<object, object?>() { { "key", "value" } },
    ///             },
    ///             OtherTelecoms = new List<ContactPoint>()
    ///             {
    ///                 new ContactPoint
    ///                 {
    ///                     Value = "string",
    ///                     Use = ContactPointUse.Home,
    ///                     Period = new Dictionary<object, object?>() { { "key", "value" } },
    ///                 },
    ///             },
    ///             Email = "string",
    ///             ElectronicCommunicationOptIn = true,
    ///             Photo = "string",
    ///             Language = "string",
    ///             ExternalProvenance = new ExternalProvenance
    ///             {
    ///                 ExternalId = "string",
    ///                 SystemName = "string",
    ///             },
    ///             Contacts = new List<Contact>()
    ///             {
    ///                 new Contact
    ///                 {
    ///                     Relationship = new List<Relationship>() { Relationship.Self },
    ///                     Name = new HumanName
    ///                     {
    ///                         Family = "string",
    ///                         Given = new List<string>() { "string" },
    ///                         Use = NameUse.Usual,
    ///                         Period = new Period
    ///                         {
    ///                             Start = new Dictionary<object, object?>() { { "key", "value" } },
    ///                             End = new Dictionary<object, object?>() { { "key", "value" } },
    ///                         },
    ///                     },
    ///                     Telecoms = new List<ContactPoint>()
    ///                     {
    ///                         new ContactPoint
    ///                         {
    ///                             Value = "string",
    ///                             Use = ContactPointUse.Home,
    ///                             Period = new Dictionary<object, object?>() { { "key", "value" } },
    ///                         },
    ///                     },
    ///                     Addresses = new List<Address>()
    ///                     {
    ///                         new Address
    ///                         {
    ///                             Use = AddressUse.Home,
    ///                             Line = new List<string>() { "string" },
    ///                             City = "string",
    ///                             State = "string",
    ///                             PostalCode = "string",
    ///                             Country = "string",
    ///                             Period = new Period
    ///                             {
    ///                                 Start = new Dictionary<object, object?>() { { "key", "value" } },
    ///                                 End = new Dictionary<object, object?>() { { "key", "value" } },
    ///                             },
    ///                         },
    ///                     },
    ///                     Period = new Period
    ///                     {
    ///                         Start = new Dictionary<object, object?>() { { "key", "value" } },
    ///                         End = new Dictionary<object, object?>() { { "key", "value" } },
    ///                     },
    ///                     HipaaAuthorization = true,
    ///                 },
    ///             },
    ///             GeneralPractitioners = new List<ExternalProvider>()
    ///             {
    ///                 new ExternalProvider
    ///                 {
    ///                     Name = new HumanName
    ///                     {
    ///                         Family = "string",
    ///                         Given = new List<string>() { "string" },
    ///                         Use = NameUse.Usual,
    ///                         Period = new Period
    ///                         {
    ///                             Start = new Dictionary<object, object?>() { { "key", "value" } },
    ///                             End = new Dictionary<object, object?>() { { "key", "value" } },
    ///                         },
    ///                     },
    ///                     Type = ExternalProviderType.Primary,
    ///                     Npi = "string",
    ///                     Telecoms = new List<ContactPoint>()
    ///                     {
    ///                         new ContactPoint
    ///                         {
    ///                             Value = "string",
    ///                             Use = ContactPointUse.Home,
    ///                             Period = new Dictionary<object, object?>() { { "key", "value" } },
    ///                         },
    ///                     },
    ///                     Addresses = new List<Address>()
    ///                     {
    ///                         new Dictionary<object, object?>() { { "key", "value" } },
    ///                     },
    ///                     Period = new Period
    ///                     {
    ///                         Start = new Dictionary<object, object?>() { { "key", "value" } },
    ///                         End = new Dictionary<object, object?>() { { "key", "value" } },
    ///                     },
    ///                     CanonicalId = "string",
    ///                 },
    ///             },
    ///             FilingOrder = new FilingOrder
    ///             {
    ///                 Coverages = new List<string>() { "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32" },
    ///             },
    ///             NonInsurancePayers = new List<string>() { "string" },
    ///             Guarantor = new Candid.Net.PreEncounter.Patients.V1.Guarantor
    ///             {
    ///                 Name = new HumanName
    ///                 {
    ///                     Family = "string",
    ///                     Given = new List<string>() { "string" },
    ///                     Use = NameUse.Usual,
    ///                     Period = new Period
    ///                     {
    ///                         Start = new Dictionary<object, object?>() { { "key", "value" } },
    ///                         End = new Dictionary<object, object?>() { { "key", "value" } },
    ///                     },
    ///                 },
    ///                 Telecom = new ContactPoint
    ///                 {
    ///                     Value = "string",
    ///                     Use = ContactPointUse.Home,
    ///                     Period = new Dictionary<object, object?>() { { "key", "value" } },
    ///                 },
    ///                 Email = "string",
    ///                 BirthDate = new DateOnly(2023, 1, 15),
    ///                 Address = new Address
    ///                 {
    ///                     Use = AddressUse.Home,
    ///                     Line = new List<string>() { "string" },
    ///                     City = "string",
    ///                     State = "string",
    ///                     PostalCode = "string",
    ///                     Country = "string",
    ///                     Period = new Period
    ///                     {
    ///                         Start = new Dictionary<object, object?>() { { "key", "value" } },
    ///                         End = new Dictionary<object, object?>() { { "key", "value" } },
    ///                     },
    ///                 },
    ///             },
    ///             SelfPay = true,
    ///             Authorizations = new List<Authorization>()
    ///             {
    ///                 new Authorization
    ///                 {
    ///                     PayerId = "string",
    ///                     PayerName = "string",
    ///                     AdditionalPayerInformation = new Dictionary<object, object?>()
    ///                     {
    ///                         { "key", "value" },
    ///                     },
    ///                     AuthorizationNumber = "string",
    ///                     CptCode = "string",
    ///                     Units = AuthorizationUnit.Visit,
    ///                     Quantity = new Dictionary<object, object?>() { { "key", "value" } },
    ///                     Period = new Dictionary<object, object?>() { { "key", "value" } },
    ///                     Notes = new Dictionary<object, object?>() { { "key", "value" } },
    ///                 },
    ///             },
    ///             Referrals = new List<Referral>()
    ///             {
    ///                 new Referral
    ///                 {
    ///                     Provider = new ExternalProvider
    ///                     {
    ///                         Name = new HumanName
    ///                         {
    ///                             Family = "string",
    ///                             Given = new List<string>() { "string" },
    ///                             Use = NameUse.Usual,
    ///                             Period = new Period
    ///                             {
    ///                                 Start = new Dictionary<object, object?>() { { "key", "value" } },
    ///                                 End = new Dictionary<object, object?>() { { "key", "value" } },
    ///                             },
    ///                         },
    ///                         Type = ExternalProviderType.Primary,
    ///                         Npi = "string",
    ///                         Telecoms = new List<ContactPoint>()
    ///                         {
    ///                             new ContactPoint
    ///                             {
    ///                                 Value = "string",
    ///                                 Use = ContactPointUse.Home,
    ///                                 Period = new Dictionary<object, object?>() { { "key", "value" } },
    ///                             },
    ///                         },
    ///                         Addresses = new List<Address>()
    ///                         {
    ///                             new Dictionary<object, object?>() { { "key", "value" } },
    ///                         },
    ///                         Period = new Period
    ///                         {
    ///                             Start = new Dictionary<object, object?>() { { "key", "value" } },
    ///                             End = new Dictionary<object, object?>() { { "key", "value" } },
    ///                         },
    ///                         CanonicalId = "string",
    ///                     },
    ///                     ReferralNumber = "string",
    ///                     Period = new Dictionary<object, object?>() { { "key", "value" } },
    ///                     Notes = new Dictionary<object, object?>() { { "key", "value" } },
    ///                 },
    ///             },
    ///         },
    ///     }
    /// );
    /// </code>
    /// </example>
    public async Task<Patient> CreateAsync(
        CreatePatientRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        var _query = new Dictionary<string, object>();
        if (request.SkipDuplicateCheck != null)
        {
            _query["skip_duplicate_check"] = request.SkipDuplicateCheck.ToString();
        }
        var response = await _client.MakeRequestAsync(
            new RawClient.JsonApiRequest
            {
                BaseUrl = _client.Options.Environment.PreEncounter,
                Method = HttpMethod.Post,
                Path = "/patients/v1",
                Body = request.Body,
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
                return JsonUtils.Deserialize<Patient>(responseBody)!;
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
    /// Searches for patients that match the query parameters.
    /// </summary>
    /// <example>
    /// <code>
    /// await client.PreEncounter.Patients.V1.GetMultiAsync(
    ///     new PatientsSearchRequestPaginated
    ///     {
    ///         Limit = 1,
    ///         Mrn = "string",
    ///         PageToken = "string",
    ///         SortField = "string",
    ///         SortDirection = Candid.Net.PreEncounter.SortDirection.Asc,
    ///     }
    /// );
    /// </code>
    /// </example>
    public async Task<PatientPage> GetMultiAsync(
        PatientsSearchRequestPaginated request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        var _query = new Dictionary<string, object>();
        if (request.Limit != null)
        {
            _query["limit"] = request.Limit.ToString();
        }
        if (request.Mrn != null)
        {
            _query["mrn"] = request.Mrn;
        }
        if (request.PageToken != null)
        {
            _query["page_token"] = request.PageToken;
        }
        if (request.SortField != null)
        {
            _query["sort_field"] = request.SortField;
        }
        if (request.SortDirection != null)
        {
            _query["sort_direction"] = request.SortDirection.Value.Stringify();
        }
        var response = await _client.MakeRequestAsync(
            new RawClient.JsonApiRequest
            {
                BaseUrl = _client.Options.Environment.PreEncounter,
                Method = HttpMethod.Get,
                Path = "/patients/v1/get_multi",
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
                return JsonUtils.Deserialize<PatientPage>(responseBody)!;
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
    /// Gets a patient.
    /// </summary>
    /// <example>
    /// <code>
    /// await client.PreEncounter.Patients.V1.GetAsync("string");
    /// </code>
    /// </example>
    public async Task<Patient> GetAsync(
        string id,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.JsonApiRequest
            {
                BaseUrl = _client.Options.Environment.PreEncounter,
                Method = HttpMethod.Get,
                Path = $"/patients/v1/{id}",
                Options = options,
            },
            cancellationToken
        );
        var responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode is >= 200 and < 400)
        {
            try
            {
                return JsonUtils.Deserialize<Patient>(responseBody)!;
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
    /// Gets a patient along with it's full history. The return list is ordered by version ascending.
    /// </summary>
    /// <example>
    /// <code>
    /// await client.PreEncounter.Patients.V1.GetHistoryAsync("string");
    /// </code>
    /// </example>
    public async Task<IEnumerable<Patient>> GetHistoryAsync(
        string id,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.JsonApiRequest
            {
                BaseUrl = _client.Options.Environment.PreEncounter,
                Method = HttpMethod.Get,
                Path = $"/patients/v1/{id}/history",
                Options = options,
            },
            cancellationToken
        );
        var responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode is >= 200 and < 400)
        {
            try
            {
                return JsonUtils.Deserialize<IEnumerable<Patient>>(responseBody)!;
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
    /// Updates a patient. The path must contain the most recent version to prevent race conditions. Updating historic versions is not supported.
    /// </summary>
    /// <example>
    /// <code>
    /// await client.PreEncounter.Patients.V1.UpdateAsync(
    ///     "string",
    ///     "string",
    ///     new MutablePatient
    ///     {
    ///         Name = new HumanName
    ///         {
    ///             Family = "string",
    ///             Given = new List<string>() { "string" },
    ///             Use = NameUse.Usual,
    ///             Period = new Period
    ///             {
    ///                 Start = new Dictionary<object, object?>() { { "key", "value" } },
    ///                 End = new Dictionary<object, object?>() { { "key", "value" } },
    ///             },
    ///         },
    ///         OtherNames = new List<HumanName>()
    ///         {
    ///             new HumanName
    ///             {
    ///                 Family = "string",
    ///                 Given = new List<string>() { "string" },
    ///                 Use = NameUse.Usual,
    ///                 Period = new Period
    ///                 {
    ///                     Start = new Dictionary<object, object?>() { { "key", "value" } },
    ///                     End = new Dictionary<object, object?>() { { "key", "value" } },
    ///                 },
    ///             },
    ///         },
    ///         Gender = Candid.Net.PreEncounter.Gender.Man,
    ///         BirthDate = new DateOnly(2023, 1, 15),
    ///         SocialSecurityNumber = "string",
    ///         BiologicalSex = Sex.Female,
    ///         SexualOrientation = SexualOrientation.Heterosexual,
    ///         Race = Race.AmericanIndianOrAlaskaNative,
    ///         Ethnicity = Ethnicity.HispanicOrLatino,
    ///         DisabilityStatus = DisabilityStatus.Disabled,
    ///         MaritalStatus = MaritalStatus.Annulled,
    ///         Deceased = new DateTime(2024, 01, 15, 09, 30, 00, 000),
    ///         MultipleBirth = 1,
    ///         PrimaryAddress = new Address
    ///         {
    ///             Use = AddressUse.Home,
    ///             Line = new List<string>() { "string" },
    ///             City = "string",
    ///             State = "string",
    ///             PostalCode = "string",
    ///             Country = "string",
    ///             Period = new Period
    ///             {
    ///                 Start = new Dictionary<object, object?>() { { "key", "value" } },
    ///                 End = new Dictionary<object, object?>() { { "key", "value" } },
    ///             },
    ///         },
    ///         OtherAddresses = new List<Address>()
    ///         {
    ///             new Address
    ///             {
    ///                 Use = AddressUse.Home,
    ///                 Line = new List<string>() { "string" },
    ///                 City = "string",
    ///                 State = "string",
    ///                 PostalCode = "string",
    ///                 Country = "string",
    ///                 Period = new Period
    ///                 {
    ///                     Start = new Dictionary<object, object?>() { { "key", "value" } },
    ///                     End = new Dictionary<object, object?>() { { "key", "value" } },
    ///                 },
    ///             },
    ///         },
    ///         PrimaryTelecom = new ContactPoint
    ///         {
    ///             Value = "string",
    ///             Use = ContactPointUse.Home,
    ///             Period = new Dictionary<object, object?>() { { "key", "value" } },
    ///         },
    ///         OtherTelecoms = new List<ContactPoint>()
    ///         {
    ///             new ContactPoint
    ///             {
    ///                 Value = "string",
    ///                 Use = ContactPointUse.Home,
    ///                 Period = new Dictionary<object, object?>() { { "key", "value" } },
    ///             },
    ///         },
    ///         Email = "string",
    ///         ElectronicCommunicationOptIn = true,
    ///         Photo = "string",
    ///         Language = "string",
    ///         ExternalProvenance = new ExternalProvenance
    ///         {
    ///             ExternalId = "string",
    ///             SystemName = "string",
    ///         },
    ///         Contacts = new List<Contact>()
    ///         {
    ///             new Contact
    ///             {
    ///                 Relationship = new List<Relationship>() { Relationship.Self },
    ///                 Name = new HumanName
    ///                 {
    ///                     Family = "string",
    ///                     Given = new List<string>() { "string" },
    ///                     Use = NameUse.Usual,
    ///                     Period = new Period
    ///                     {
    ///                         Start = new Dictionary<object, object?>() { { "key", "value" } },
    ///                         End = new Dictionary<object, object?>() { { "key", "value" } },
    ///                     },
    ///                 },
    ///                 Telecoms = new List<ContactPoint>()
    ///                 {
    ///                     new ContactPoint
    ///                     {
    ///                         Value = "string",
    ///                         Use = ContactPointUse.Home,
    ///                         Period = new Dictionary<object, object?>() { { "key", "value" } },
    ///                     },
    ///                 },
    ///                 Addresses = new List<Address>()
    ///                 {
    ///                     new Address
    ///                     {
    ///                         Use = AddressUse.Home,
    ///                         Line = new List<string>() { "string" },
    ///                         City = "string",
    ///                         State = "string",
    ///                         PostalCode = "string",
    ///                         Country = "string",
    ///                         Period = new Period
    ///                         {
    ///                             Start = new Dictionary<object, object?>() { { "key", "value" } },
    ///                             End = new Dictionary<object, object?>() { { "key", "value" } },
    ///                         },
    ///                     },
    ///                 },
    ///                 Period = new Period
    ///                 {
    ///                     Start = new Dictionary<object, object?>() { { "key", "value" } },
    ///                     End = new Dictionary<object, object?>() { { "key", "value" } },
    ///                 },
    ///                 HipaaAuthorization = true,
    ///             },
    ///         },
    ///         GeneralPractitioners = new List<ExternalProvider>()
    ///         {
    ///             new ExternalProvider
    ///             {
    ///                 Name = new HumanName
    ///                 {
    ///                     Family = "string",
    ///                     Given = new List<string>() { "string" },
    ///                     Use = NameUse.Usual,
    ///                     Period = new Period
    ///                     {
    ///                         Start = new Dictionary<object, object?>() { { "key", "value" } },
    ///                         End = new Dictionary<object, object?>() { { "key", "value" } },
    ///                     },
    ///                 },
    ///                 Type = ExternalProviderType.Primary,
    ///                 Npi = "string",
    ///                 Telecoms = new List<ContactPoint>()
    ///                 {
    ///                     new ContactPoint
    ///                     {
    ///                         Value = "string",
    ///                         Use = ContactPointUse.Home,
    ///                         Period = new Dictionary<object, object?>() { { "key", "value" } },
    ///                     },
    ///                 },
    ///                 Addresses = new List<Address>()
    ///                 {
    ///                     new Dictionary<object, object?>() { { "key", "value" } },
    ///                 },
    ///                 Period = new Period
    ///                 {
    ///                     Start = new Dictionary<object, object?>() { { "key", "value" } },
    ///                     End = new Dictionary<object, object?>() { { "key", "value" } },
    ///                 },
    ///                 CanonicalId = "string",
    ///             },
    ///         },
    ///         FilingOrder = new FilingOrder
    ///         {
    ///             Coverages = new List<string>() { "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32" },
    ///         },
    ///         NonInsurancePayers = new List<string>() { "string" },
    ///         Guarantor = new Candid.Net.PreEncounter.Patients.V1.Guarantor
    ///         {
    ///             Name = new HumanName
    ///             {
    ///                 Family = "string",
    ///                 Given = new List<string>() { "string" },
    ///                 Use = NameUse.Usual,
    ///                 Period = new Period
    ///                 {
    ///                     Start = new Dictionary<object, object?>() { { "key", "value" } },
    ///                     End = new Dictionary<object, object?>() { { "key", "value" } },
    ///                 },
    ///             },
    ///             Telecom = new ContactPoint
    ///             {
    ///                 Value = "string",
    ///                 Use = ContactPointUse.Home,
    ///                 Period = new Dictionary<object, object?>() { { "key", "value" } },
    ///             },
    ///             Email = "string",
    ///             BirthDate = new DateOnly(2023, 1, 15),
    ///             Address = new Address
    ///             {
    ///                 Use = AddressUse.Home,
    ///                 Line = new List<string>() { "string" },
    ///                 City = "string",
    ///                 State = "string",
    ///                 PostalCode = "string",
    ///                 Country = "string",
    ///                 Period = new Period
    ///                 {
    ///                     Start = new Dictionary<object, object?>() { { "key", "value" } },
    ///                     End = new Dictionary<object, object?>() { { "key", "value" } },
    ///                 },
    ///             },
    ///         },
    ///         SelfPay = true,
    ///         Authorizations = new List<Authorization>()
    ///         {
    ///             new Authorization
    ///             {
    ///                 PayerId = "string",
    ///                 PayerName = "string",
    ///                 AdditionalPayerInformation = new Dictionary<object, object?>()
    ///                 {
    ///                     { "key", "value" },
    ///                 },
    ///                 AuthorizationNumber = "string",
    ///                 CptCode = "string",
    ///                 Units = AuthorizationUnit.Visit,
    ///                 Quantity = new Dictionary<object, object?>() { { "key", "value" } },
    ///                 Period = new Dictionary<object, object?>() { { "key", "value" } },
    ///                 Notes = new Dictionary<object, object?>() { { "key", "value" } },
    ///             },
    ///         },
    ///         Referrals = new List<Referral>()
    ///         {
    ///             new Referral
    ///             {
    ///                 Provider = new ExternalProvider
    ///                 {
    ///                     Name = new HumanName
    ///                     {
    ///                         Family = "string",
    ///                         Given = new List<string>() { "string" },
    ///                         Use = NameUse.Usual,
    ///                         Period = new Period
    ///                         {
    ///                             Start = new Dictionary<object, object?>() { { "key", "value" } },
    ///                             End = new Dictionary<object, object?>() { { "key", "value" } },
    ///                         },
    ///                     },
    ///                     Type = ExternalProviderType.Primary,
    ///                     Npi = "string",
    ///                     Telecoms = new List<ContactPoint>()
    ///                     {
    ///                         new ContactPoint
    ///                         {
    ///                             Value = "string",
    ///                             Use = ContactPointUse.Home,
    ///                             Period = new Dictionary<object, object?>() { { "key", "value" } },
    ///                         },
    ///                     },
    ///                     Addresses = new List<Address>()
    ///                     {
    ///                         new Dictionary<object, object?>() { { "key", "value" } },
    ///                     },
    ///                     Period = new Period
    ///                     {
    ///                         Start = new Dictionary<object, object?>() { { "key", "value" } },
    ///                         End = new Dictionary<object, object?>() { { "key", "value" } },
    ///                     },
    ///                     CanonicalId = "string",
    ///                 },
    ///                 ReferralNumber = "string",
    ///                 Period = new Dictionary<object, object?>() { { "key", "value" } },
    ///                 Notes = new Dictionary<object, object?>() { { "key", "value" } },
    ///             },
    ///         },
    ///     }
    /// );
    /// </code>
    /// </example>
    public async Task<Patient> UpdateAsync(
        string id,
        string version,
        MutablePatient request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.JsonApiRequest
            {
                BaseUrl = _client.Options.Environment.PreEncounter,
                Method = HttpMethod.Put,
                Path = $"/patients/v1/{id}/{version}",
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
                return JsonUtils.Deserialize<Patient>(responseBody)!;
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
    /// Sets a patient as deactivated. The path must contain the most recent version to prevent race conditions. Deactivating historic versions is not supported. Subsequent updates via PUT to the patient will "reactivate" the patient and set the deactivated flag to false.
    /// </summary>
    /// <example>
    /// <code>
    /// await client.PreEncounter.Patients.V1.DeactivateAsync("string", "string");
    /// </code>
    /// </example>
    public async System.Threading.Tasks.Task DeactivateAsync(
        string id,
        string version,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.JsonApiRequest
            {
                BaseUrl = _client.Options.Environment.PreEncounter,
                Method = HttpMethod.Delete,
                Path = $"/patients/v1/{id}/{version}",
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

    /// <summary>
    /// Returns a list of Patients based on the search criteria.
    /// </summary>
    /// <example>
    /// <code>
    /// await client.PreEncounter.Patients.V1.SearchAsync(
    ///     new PatientGetMultiRequest { Mrn = "string", SimilarNameOrdering = "string" }
    /// );
    /// </code>
    /// </example>
    public async Task<IEnumerable<Patient>> SearchAsync(
        PatientGetMultiRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        var _query = new Dictionary<string, object>();
        if (request.Mrn != null)
        {
            _query["mrn"] = request.Mrn;
        }
        if (request.SimilarNameOrdering != null)
        {
            _query["similar_name_ordering"] = request.SimilarNameOrdering;
        }
        var response = await _client.MakeRequestAsync(
            new RawClient.JsonApiRequest
            {
                BaseUrl = _client.Options.Environment.PreEncounter,
                Method = HttpMethod.Get,
                Path = "/patients/v1",
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
                return JsonUtils.Deserialize<IEnumerable<Patient>>(responseBody)!;
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
    /// Scans up to 100 patient updates. The since query parameter is inclusive, and the result list is ordered by updatedAt ascending.
    /// </summary>
    /// <example>
    /// <code>
    /// await client.PreEncounter.Patients.V1.ScanAsync(
    ///     new PatientScanRequest { Since = new DateTime(2024, 01, 15, 09, 30, 00, 000) }
    /// );
    /// </code>
    /// </example>
    public async Task<IEnumerable<Patient>> ScanAsync(
        PatientScanRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        var _query = new Dictionary<string, object>();
        _query["since"] = request.Since.ToString(Constants.DateTimeFormat);
        var response = await _client.MakeRequestAsync(
            new RawClient.JsonApiRequest
            {
                BaseUrl = _client.Options.Environment.PreEncounter,
                Method = HttpMethod.Get,
                Path = "/patients/v1/updates/scan",
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
                return JsonUtils.Deserialize<IEnumerable<Patient>>(responseBody)!;
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
