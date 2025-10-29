using System.Net.Http;
using System.Text.Json;
using System.Threading;
using Candid.Net.Core;
using Candid.Net.PreEncounter.Common;

namespace Candid.Net.PreEncounter.Patients.V1;

public partial class V1Client
{
    private RawClient _client;

    internal V1Client(RawClient client)
    {
        _client = client;
    }

    /// <summary>
    /// Adds a patient.  VersionConflictError is returned when the patient's external ID is already in use.
    /// </summary>
    /// <example><code>
    /// await client.PreEncounter.Patients.V1.CreateAsync(
    ///     new CreatePatientRequest
    ///     {
    ///         Body = new MutablePatient
    ///         {
    ///             Name = new HumanName
    ///             {
    ///                 Family = "family",
    ///                 Given = new List&lt;string&gt;() { "given", "given" },
    ///                 Use = NameUse.Usual,
    ///             },
    ///             OtherNames = new List&lt;HumanName&gt;()
    ///             {
    ///                 new HumanName
    ///                 {
    ///                     Family = "family",
    ///                     Given = new List&lt;string&gt;() { "given", "given" },
    ///                     Use = NameUse.Usual,
    ///                 },
    ///                 new HumanName
    ///                 {
    ///                     Family = "family",
    ///                     Given = new List&lt;string&gt;() { "given", "given" },
    ///                     Use = NameUse.Usual,
    ///                 },
    ///             },
    ///             BirthDate = new DateOnly(2023, 1, 15),
    ///             BiologicalSex = Sex.Female,
    ///             PrimaryAddress = new global::Candid.Net.PreEncounter.Common.Address
    ///             {
    ///                 Use = AddressUse.Home,
    ///                 Line = new List&lt;string&gt;() { "line", "line" },
    ///                 City = "city",
    ///                 State = "state",
    ///                 PostalCode = "postal_code",
    ///                 Country = "country",
    ///             },
    ///             OtherAddresses = new List&lt;global::Candid.Net.PreEncounter.Common.Address&gt;()
    ///             {
    ///                 new global::Candid.Net.PreEncounter.Common.Address
    ///                 {
    ///                     Use = AddressUse.Home,
    ///                     Line = new List&lt;string&gt;() { "line", "line" },
    ///                     City = "city",
    ///                     State = "state",
    ///                     PostalCode = "postal_code",
    ///                     Country = "country",
    ///                 },
    ///                 new global::Candid.Net.PreEncounter.Common.Address
    ///                 {
    ///                     Use = AddressUse.Home,
    ///                     Line = new List&lt;string&gt;() { "line", "line" },
    ///                     City = "city",
    ///                     State = "state",
    ///                     PostalCode = "postal_code",
    ///                     Country = "country",
    ///                 },
    ///             },
    ///             OtherTelecoms = new List&lt;ContactPoint&gt;()
    ///             {
    ///                 new ContactPoint { Value = "value", Use = ContactPointUse.Home },
    ///                 new ContactPoint { Value = "value", Use = ContactPointUse.Home },
    ///             },
    ///             Contacts = new List&lt;Contact&gt;()
    ///             {
    ///                 new Contact
    ///                 {
    ///                     Relationship = new List&lt;Relationship&gt;()
    ///                     {
    ///                         Relationship.Self,
    ///                         Relationship.Self,
    ///                     },
    ///                     Name = new HumanName
    ///                     {
    ///                         Family = "family",
    ///                         Given = new List&lt;string&gt;() { "given", "given" },
    ///                         Use = NameUse.Usual,
    ///                     },
    ///                     Telecoms = new List&lt;ContactPoint&gt;()
    ///                     {
    ///                         new ContactPoint { Value = "value", Use = ContactPointUse.Home },
    ///                         new ContactPoint { Value = "value", Use = ContactPointUse.Home },
    ///                     },
    ///                     Addresses = new List&lt;global::Candid.Net.PreEncounter.Common.Address&gt;()
    ///                     {
    ///                         new global::Candid.Net.PreEncounter.Common.Address
    ///                         {
    ///                             Use = AddressUse.Home,
    ///                             Line = new List&lt;string&gt;() { "line", "line" },
    ///                             City = "city",
    ///                             State = "state",
    ///                             PostalCode = "postal_code",
    ///                             Country = "country",
    ///                         },
    ///                         new global::Candid.Net.PreEncounter.Common.Address
    ///                         {
    ///                             Use = AddressUse.Home,
    ///                             Line = new List&lt;string&gt;() { "line", "line" },
    ///                             City = "city",
    ///                             State = "state",
    ///                             PostalCode = "postal_code",
    ///                             Country = "country",
    ///                         },
    ///                     },
    ///                 },
    ///                 new Contact
    ///                 {
    ///                     Relationship = new List&lt;Relationship&gt;()
    ///                     {
    ///                         Relationship.Self,
    ///                         Relationship.Self,
    ///                     },
    ///                     Name = new HumanName
    ///                     {
    ///                         Family = "family",
    ///                         Given = new List&lt;string&gt;() { "given", "given" },
    ///                         Use = NameUse.Usual,
    ///                     },
    ///                     Telecoms = new List&lt;ContactPoint&gt;()
    ///                     {
    ///                         new ContactPoint { Value = "value", Use = ContactPointUse.Home },
    ///                         new ContactPoint { Value = "value", Use = ContactPointUse.Home },
    ///                     },
    ///                     Addresses = new List&lt;global::Candid.Net.PreEncounter.Common.Address&gt;()
    ///                     {
    ///                         new global::Candid.Net.PreEncounter.Common.Address
    ///                         {
    ///                             Use = AddressUse.Home,
    ///                             Line = new List&lt;string&gt;() { "line", "line" },
    ///                             City = "city",
    ///                             State = "state",
    ///                             PostalCode = "postal_code",
    ///                             Country = "country",
    ///                         },
    ///                         new global::Candid.Net.PreEncounter.Common.Address
    ///                         {
    ///                             Use = AddressUse.Home,
    ///                             Line = new List&lt;string&gt;() { "line", "line" },
    ///                             City = "city",
    ///                             State = "state",
    ///                             PostalCode = "postal_code",
    ///                             Country = "country",
    ///                         },
    ///                     },
    ///                 },
    ///             },
    ///             GeneralPractitioners = new List&lt;ExternalProvider&gt;()
    ///             {
    ///                 new ExternalProvider
    ///                 {
    ///                     Name = new HumanName
    ///                     {
    ///                         Family = "family",
    ///                         Given = new List&lt;string&gt;() { "given", "given" },
    ///                         Use = NameUse.Usual,
    ///                     },
    ///                     Telecoms = new List&lt;ContactPoint&gt;()
    ///                     {
    ///                         new ContactPoint { Value = "value", Use = ContactPointUse.Home },
    ///                         new ContactPoint { Value = "value", Use = ContactPointUse.Home },
    ///                     },
    ///                 },
    ///                 new ExternalProvider
    ///                 {
    ///                     Name = new HumanName
    ///                     {
    ///                         Family = "family",
    ///                         Given = new List&lt;string&gt;() { "given", "given" },
    ///                         Use = NameUse.Usual,
    ///                     },
    ///                     Telecoms = new List&lt;ContactPoint&gt;()
    ///                     {
    ///                         new ContactPoint { Value = "value", Use = ContactPointUse.Home },
    ///                         new ContactPoint { Value = "value", Use = ContactPointUse.Home },
    ///                     },
    ///                 },
    ///             },
    ///             FilingOrder = new FilingOrder
    ///             {
    ///                 Coverages = new List&lt;string&gt;()
    ///                 {
    ///                     "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
    ///                     "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
    ///                 },
    ///             },
    ///         },
    ///     }
    /// );
    /// </code></example>
    public async global::System.Threading.Tasks.Task<Patient> CreateAsync(
        CreatePatientRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        var _query = new Dictionary<string, object>();
        if (request.SkipDuplicateCheck != null)
        {
            _query["skip_duplicate_check"] = JsonUtils.Serialize(request.SkipDuplicateCheck.Value);
        }
        var response = await _client
            .SendRequestAsync(
                new JsonRequest
                {
                    BaseUrl = _client.Options.Environment.PreEncounter,
                    Method = HttpMethod.Post,
                    Path = "/patients/v1",
                    Body = request.Body,
                    Query = _query,
                    Options = options,
                },
                cancellationToken
            )
            .ConfigureAwait(false);
        if (response.StatusCode is >= 200 and < 400)
        {
            var responseBody = await response.Raw.Content.ReadAsStringAsync();
            try
            {
                return JsonUtils.Deserialize<Patient>(responseBody)!;
            }
            catch (JsonException e)
            {
                throw new CandidException("Failed to deserialize response", e);
            }
        }

        {
            var responseBody = await response.Raw.Content.ReadAsStringAsync();
            throw new CandidApiException(
                $"Error with status code {response.StatusCode}",
                response.StatusCode,
                responseBody
            );
        }
    }

    /// <summary>
    /// Adds a patient and hydrates their MRN with a pre-existing MRN.  Once this patient is created their MRN will not be editable. BadRequestError is returned when the MRN is greater than 20 characters. VersionConflictError is returned when the patient's external ID is already in use.
    /// </summary>
    /// <example><code>
    /// await client.PreEncounter.Patients.V1.CreateWithMrnAsync(
    ///     new CreatePatientWithMrnRequest
    ///     {
    ///         Body = new MutablePatientWithMrn
    ///         {
    ///             Mrn = "mrn",
    ///             Name = new HumanName
    ///             {
    ///                 Family = "family",
    ///                 Given = new List&lt;string&gt;() { "given", "given" },
    ///                 Use = NameUse.Usual,
    ///             },
    ///             OtherNames = new List&lt;HumanName&gt;()
    ///             {
    ///                 new HumanName
    ///                 {
    ///                     Family = "family",
    ///                     Given = new List&lt;string&gt;() { "given", "given" },
    ///                     Use = NameUse.Usual,
    ///                 },
    ///                 new HumanName
    ///                 {
    ///                     Family = "family",
    ///                     Given = new List&lt;string&gt;() { "given", "given" },
    ///                     Use = NameUse.Usual,
    ///                 },
    ///             },
    ///             BirthDate = new DateOnly(2023, 1, 15),
    ///             BiologicalSex = Sex.Female,
    ///             PrimaryAddress = new global::Candid.Net.PreEncounter.Common.Address
    ///             {
    ///                 Use = AddressUse.Home,
    ///                 Line = new List&lt;string&gt;() { "line", "line" },
    ///                 City = "city",
    ///                 State = "state",
    ///                 PostalCode = "postal_code",
    ///                 Country = "country",
    ///             },
    ///             OtherAddresses = new List&lt;global::Candid.Net.PreEncounter.Common.Address&gt;()
    ///             {
    ///                 new global::Candid.Net.PreEncounter.Common.Address
    ///                 {
    ///                     Use = AddressUse.Home,
    ///                     Line = new List&lt;string&gt;() { "line", "line" },
    ///                     City = "city",
    ///                     State = "state",
    ///                     PostalCode = "postal_code",
    ///                     Country = "country",
    ///                 },
    ///                 new global::Candid.Net.PreEncounter.Common.Address
    ///                 {
    ///                     Use = AddressUse.Home,
    ///                     Line = new List&lt;string&gt;() { "line", "line" },
    ///                     City = "city",
    ///                     State = "state",
    ///                     PostalCode = "postal_code",
    ///                     Country = "country",
    ///                 },
    ///             },
    ///             OtherTelecoms = new List&lt;ContactPoint&gt;()
    ///             {
    ///                 new ContactPoint { Value = "value", Use = ContactPointUse.Home },
    ///                 new ContactPoint { Value = "value", Use = ContactPointUse.Home },
    ///             },
    ///             Contacts = new List&lt;Contact&gt;()
    ///             {
    ///                 new Contact
    ///                 {
    ///                     Relationship = new List&lt;Relationship&gt;()
    ///                     {
    ///                         Relationship.Self,
    ///                         Relationship.Self,
    ///                     },
    ///                     Name = new HumanName
    ///                     {
    ///                         Family = "family",
    ///                         Given = new List&lt;string&gt;() { "given", "given" },
    ///                         Use = NameUse.Usual,
    ///                     },
    ///                     Telecoms = new List&lt;ContactPoint&gt;()
    ///                     {
    ///                         new ContactPoint { Value = "value", Use = ContactPointUse.Home },
    ///                         new ContactPoint { Value = "value", Use = ContactPointUse.Home },
    ///                     },
    ///                     Addresses = new List&lt;global::Candid.Net.PreEncounter.Common.Address&gt;()
    ///                     {
    ///                         new global::Candid.Net.PreEncounter.Common.Address
    ///                         {
    ///                             Use = AddressUse.Home,
    ///                             Line = new List&lt;string&gt;() { "line", "line" },
    ///                             City = "city",
    ///                             State = "state",
    ///                             PostalCode = "postal_code",
    ///                             Country = "country",
    ///                         },
    ///                         new global::Candid.Net.PreEncounter.Common.Address
    ///                         {
    ///                             Use = AddressUse.Home,
    ///                             Line = new List&lt;string&gt;() { "line", "line" },
    ///                             City = "city",
    ///                             State = "state",
    ///                             PostalCode = "postal_code",
    ///                             Country = "country",
    ///                         },
    ///                     },
    ///                 },
    ///                 new Contact
    ///                 {
    ///                     Relationship = new List&lt;Relationship&gt;()
    ///                     {
    ///                         Relationship.Self,
    ///                         Relationship.Self,
    ///                     },
    ///                     Name = new HumanName
    ///                     {
    ///                         Family = "family",
    ///                         Given = new List&lt;string&gt;() { "given", "given" },
    ///                         Use = NameUse.Usual,
    ///                     },
    ///                     Telecoms = new List&lt;ContactPoint&gt;()
    ///                     {
    ///                         new ContactPoint { Value = "value", Use = ContactPointUse.Home },
    ///                         new ContactPoint { Value = "value", Use = ContactPointUse.Home },
    ///                     },
    ///                     Addresses = new List&lt;global::Candid.Net.PreEncounter.Common.Address&gt;()
    ///                     {
    ///                         new global::Candid.Net.PreEncounter.Common.Address
    ///                         {
    ///                             Use = AddressUse.Home,
    ///                             Line = new List&lt;string&gt;() { "line", "line" },
    ///                             City = "city",
    ///                             State = "state",
    ///                             PostalCode = "postal_code",
    ///                             Country = "country",
    ///                         },
    ///                         new global::Candid.Net.PreEncounter.Common.Address
    ///                         {
    ///                             Use = AddressUse.Home,
    ///                             Line = new List&lt;string&gt;() { "line", "line" },
    ///                             City = "city",
    ///                             State = "state",
    ///                             PostalCode = "postal_code",
    ///                             Country = "country",
    ///                         },
    ///                     },
    ///                 },
    ///             },
    ///             GeneralPractitioners = new List&lt;ExternalProvider&gt;()
    ///             {
    ///                 new ExternalProvider
    ///                 {
    ///                     Name = new HumanName
    ///                     {
    ///                         Family = "family",
    ///                         Given = new List&lt;string&gt;() { "given", "given" },
    ///                         Use = NameUse.Usual,
    ///                     },
    ///                     Telecoms = new List&lt;ContactPoint&gt;()
    ///                     {
    ///                         new ContactPoint { Value = "value", Use = ContactPointUse.Home },
    ///                         new ContactPoint { Value = "value", Use = ContactPointUse.Home },
    ///                     },
    ///                 },
    ///                 new ExternalProvider
    ///                 {
    ///                     Name = new HumanName
    ///                     {
    ///                         Family = "family",
    ///                         Given = new List&lt;string&gt;() { "given", "given" },
    ///                         Use = NameUse.Usual,
    ///                     },
    ///                     Telecoms = new List&lt;ContactPoint&gt;()
    ///                     {
    ///                         new ContactPoint { Value = "value", Use = ContactPointUse.Home },
    ///                         new ContactPoint { Value = "value", Use = ContactPointUse.Home },
    ///                     },
    ///                 },
    ///             },
    ///             FilingOrder = new FilingOrder
    ///             {
    ///                 Coverages = new List&lt;string&gt;()
    ///                 {
    ///                     "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
    ///                     "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
    ///                 },
    ///             },
    ///         },
    ///     }
    /// );
    /// </code></example>
    public async global::System.Threading.Tasks.Task<Patient> CreateWithMrnAsync(
        CreatePatientWithMrnRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        var _query = new Dictionary<string, object>();
        if (request.SkipDuplicateCheck != null)
        {
            _query["skip_duplicate_check"] = JsonUtils.Serialize(request.SkipDuplicateCheck.Value);
        }
        var response = await _client
            .SendRequestAsync(
                new JsonRequest
                {
                    BaseUrl = _client.Options.Environment.PreEncounter,
                    Method = HttpMethod.Post,
                    Path = "/patients/v1/with_mrn",
                    Body = request.Body,
                    Query = _query,
                    Options = options,
                },
                cancellationToken
            )
            .ConfigureAwait(false);
        if (response.StatusCode is >= 200 and < 400)
        {
            var responseBody = await response.Raw.Content.ReadAsStringAsync();
            try
            {
                return JsonUtils.Deserialize<Patient>(responseBody)!;
            }
            catch (JsonException e)
            {
                throw new CandidException("Failed to deserialize response", e);
            }
        }

        {
            var responseBody = await response.Raw.Content.ReadAsStringAsync();
            throw new CandidApiException(
                $"Error with status code {response.StatusCode}",
                response.StatusCode,
                responseBody
            );
        }
    }

    /// <summary>
    /// Searches for patients that match the query parameters.
    /// </summary>
    /// <example><code>
    /// await client.PreEncounter.Patients.V1.GetMultiAsync(new PatientsSearchRequestPaginated());
    /// </code></example>
    public async global::System.Threading.Tasks.Task<PatientPage> GetMultiAsync(
        PatientsSearchRequestPaginated request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        var _query = new Dictionary<string, object>();
        if (request.Limit != null)
        {
            _query["limit"] = request.Limit.Value.ToString();
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
        var response = await _client
            .SendRequestAsync(
                new JsonRequest
                {
                    BaseUrl = _client.Options.Environment.PreEncounter,
                    Method = HttpMethod.Get,
                    Path = "/patients/v1/get_multi",
                    Query = _query,
                    Options = options,
                },
                cancellationToken
            )
            .ConfigureAwait(false);
        if (response.StatusCode is >= 200 and < 400)
        {
            var responseBody = await response.Raw.Content.ReadAsStringAsync();
            try
            {
                return JsonUtils.Deserialize<PatientPage>(responseBody)!;
            }
            catch (JsonException e)
            {
                throw new CandidException("Failed to deserialize response", e);
            }
        }

        {
            var responseBody = await response.Raw.Content.ReadAsStringAsync();
            throw new CandidApiException(
                $"Error with status code {response.StatusCode}",
                response.StatusCode,
                responseBody
            );
        }
    }

    /// <summary>
    /// Searches for referring providers that match the query parameters.  The search is case-insensitive, supports fuzzy matching, and matches against provider name and NPI. The search criteria must be an alphanumeric string, and the search is limited to the first 20 results.
    /// </summary>
    /// <example><code>
    /// await client.PreEncounter.Patients.V1.SearchProvidersAsync(
    ///     new SearchProvidersRequest { SearchCriteria = "search_criteria" }
    /// );
    /// </code></example>
    public async global::System.Threading.Tasks.Task<
        IEnumerable<ExternalProvider>
    > SearchProvidersAsync(
        SearchProvidersRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        var _query = new Dictionary<string, object>();
        _query["search_criteria"] = request.SearchCriteria;
        var response = await _client
            .SendRequestAsync(
                new JsonRequest
                {
                    BaseUrl = _client.Options.Environment.PreEncounter,
                    Method = HttpMethod.Get,
                    Path = "/patients/v1/search_providers",
                    Query = _query,
                    Options = options,
                },
                cancellationToken
            )
            .ConfigureAwait(false);
        if (response.StatusCode is >= 200 and < 400)
        {
            var responseBody = await response.Raw.Content.ReadAsStringAsync();
            try
            {
                return JsonUtils.Deserialize<IEnumerable<ExternalProvider>>(responseBody)!;
            }
            catch (JsonException e)
            {
                throw new CandidException("Failed to deserialize response", e);
            }
        }

        {
            var responseBody = await response.Raw.Content.ReadAsStringAsync();
            throw new CandidApiException(
                $"Error with status code {response.StatusCode}",
                response.StatusCode,
                responseBody
            );
        }
    }

    /// <summary>
    /// Gets a patient.
    /// </summary>
    /// <example><code>
    /// await client.PreEncounter.Patients.V1.GetAsync("id");
    /// </code></example>
    public async global::System.Threading.Tasks.Task<Patient> GetAsync(
        string id,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        var response = await _client
            .SendRequestAsync(
                new JsonRequest
                {
                    BaseUrl = _client.Options.Environment.PreEncounter,
                    Method = HttpMethod.Get,
                    Path = string.Format(
                        "/patients/v1/{0}",
                        ValueConvert.ToPathParameterString(id)
                    ),
                    Options = options,
                },
                cancellationToken
            )
            .ConfigureAwait(false);
        if (response.StatusCode is >= 200 and < 400)
        {
            var responseBody = await response.Raw.Content.ReadAsStringAsync();
            try
            {
                return JsonUtils.Deserialize<Patient>(responseBody)!;
            }
            catch (JsonException e)
            {
                throw new CandidException("Failed to deserialize response", e);
            }
        }

        {
            var responseBody = await response.Raw.Content.ReadAsStringAsync();
            throw new CandidApiException(
                $"Error with status code {response.StatusCode}",
                response.StatusCode,
                responseBody
            );
        }
    }

    /// <summary>
    /// Gets a patient by mrn.
    /// </summary>
    /// <example><code>
    /// await client.PreEncounter.Patients.V1.GetByMrnAsync("mrn");
    /// </code></example>
    public async global::System.Threading.Tasks.Task<Patient> GetByMrnAsync(
        string mrn,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        var response = await _client
            .SendRequestAsync(
                new JsonRequest
                {
                    BaseUrl = _client.Options.Environment.PreEncounter,
                    Method = HttpMethod.Get,
                    Path = string.Format(
                        "/patients/v1/mrn/{0}",
                        ValueConvert.ToPathParameterString(mrn)
                    ),
                    Options = options,
                },
                cancellationToken
            )
            .ConfigureAwait(false);
        if (response.StatusCode is >= 200 and < 400)
        {
            var responseBody = await response.Raw.Content.ReadAsStringAsync();
            try
            {
                return JsonUtils.Deserialize<Patient>(responseBody)!;
            }
            catch (JsonException e)
            {
                throw new CandidException("Failed to deserialize response", e);
            }
        }

        {
            var responseBody = await response.Raw.Content.ReadAsStringAsync();
            throw new CandidApiException(
                $"Error with status code {response.StatusCode}",
                response.StatusCode,
                responseBody
            );
        }
    }

    /// <summary>
    /// Gets a patient along with it's full history.  The return list is ordered by version ascending.
    /// </summary>
    /// <example><code>
    /// await client.PreEncounter.Patients.V1.GetHistoryAsync("id");
    /// </code></example>
    public async global::System.Threading.Tasks.Task<IEnumerable<Patient>> GetHistoryAsync(
        string id,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        var response = await _client
            .SendRequestAsync(
                new JsonRequest
                {
                    BaseUrl = _client.Options.Environment.PreEncounter,
                    Method = HttpMethod.Get,
                    Path = string.Format(
                        "/patients/v1/{0}/history",
                        ValueConvert.ToPathParameterString(id)
                    ),
                    Options = options,
                },
                cancellationToken
            )
            .ConfigureAwait(false);
        if (response.StatusCode is >= 200 and < 400)
        {
            var responseBody = await response.Raw.Content.ReadAsStringAsync();
            try
            {
                return JsonUtils.Deserialize<IEnumerable<Patient>>(responseBody)!;
            }
            catch (JsonException e)
            {
                throw new CandidException("Failed to deserialize response", e);
            }
        }

        {
            var responseBody = await response.Raw.Content.ReadAsStringAsync();
            throw new CandidApiException(
                $"Error with status code {response.StatusCode}",
                response.StatusCode,
                responseBody
            );
        }
    }

    /// <summary>
    /// Updates a patient. The path must contain the next version number to prevent race conditions. For example, if the current version of the patient is n, you will need to send a request to this endpoint with `/{id}/n+1` to update the patient. Updating historic versions is not supported.
    /// </summary>
    /// <example><code>
    /// await client.PreEncounter.Patients.V1.UpdateAsync(
    ///     "id",
    ///     "version",
    ///     new MutablePatient
    ///     {
    ///         Name = new HumanName
    ///         {
    ///             Family = "family",
    ///             Given = new List&lt;string&gt;() { "given", "given" },
    ///             Use = NameUse.Usual,
    ///         },
    ///         OtherNames = new List&lt;HumanName&gt;()
    ///         {
    ///             new HumanName
    ///             {
    ///                 Family = "family",
    ///                 Given = new List&lt;string&gt;() { "given", "given" },
    ///                 Use = NameUse.Usual,
    ///             },
    ///             new HumanName
    ///             {
    ///                 Family = "family",
    ///                 Given = new List&lt;string&gt;() { "given", "given" },
    ///                 Use = NameUse.Usual,
    ///             },
    ///         },
    ///         BirthDate = new DateOnly(2023, 1, 15),
    ///         BiologicalSex = Sex.Female,
    ///         PrimaryAddress = new global::Candid.Net.PreEncounter.Common.Address
    ///         {
    ///             Use = AddressUse.Home,
    ///             Line = new List&lt;string&gt;() { "line", "line" },
    ///             City = "city",
    ///             State = "state",
    ///             PostalCode = "postal_code",
    ///             Country = "country",
    ///         },
    ///         OtherAddresses = new List&lt;global::Candid.Net.PreEncounter.Common.Address&gt;()
    ///         {
    ///             new global::Candid.Net.PreEncounter.Common.Address
    ///             {
    ///                 Use = AddressUse.Home,
    ///                 Line = new List&lt;string&gt;() { "line", "line" },
    ///                 City = "city",
    ///                 State = "state",
    ///                 PostalCode = "postal_code",
    ///                 Country = "country",
    ///             },
    ///             new global::Candid.Net.PreEncounter.Common.Address
    ///             {
    ///                 Use = AddressUse.Home,
    ///                 Line = new List&lt;string&gt;() { "line", "line" },
    ///                 City = "city",
    ///                 State = "state",
    ///                 PostalCode = "postal_code",
    ///                 Country = "country",
    ///             },
    ///         },
    ///         OtherTelecoms = new List&lt;ContactPoint&gt;()
    ///         {
    ///             new ContactPoint { Value = "value", Use = ContactPointUse.Home },
    ///             new ContactPoint { Value = "value", Use = ContactPointUse.Home },
    ///         },
    ///         Contacts = new List&lt;Contact&gt;()
    ///         {
    ///             new Contact
    ///             {
    ///                 Relationship = new List&lt;Relationship&gt;() { Relationship.Self, Relationship.Self },
    ///                 Name = new HumanName
    ///                 {
    ///                     Family = "family",
    ///                     Given = new List&lt;string&gt;() { "given", "given" },
    ///                     Use = NameUse.Usual,
    ///                 },
    ///                 Telecoms = new List&lt;ContactPoint&gt;()
    ///                 {
    ///                     new ContactPoint { Value = "value", Use = ContactPointUse.Home },
    ///                     new ContactPoint { Value = "value", Use = ContactPointUse.Home },
    ///                 },
    ///                 Addresses = new List&lt;global::Candid.Net.PreEncounter.Common.Address&gt;()
    ///                 {
    ///                     new global::Candid.Net.PreEncounter.Common.Address
    ///                     {
    ///                         Use = AddressUse.Home,
    ///                         Line = new List&lt;string&gt;() { "line", "line" },
    ///                         City = "city",
    ///                         State = "state",
    ///                         PostalCode = "postal_code",
    ///                         Country = "country",
    ///                     },
    ///                     new global::Candid.Net.PreEncounter.Common.Address
    ///                     {
    ///                         Use = AddressUse.Home,
    ///                         Line = new List&lt;string&gt;() { "line", "line" },
    ///                         City = "city",
    ///                         State = "state",
    ///                         PostalCode = "postal_code",
    ///                         Country = "country",
    ///                     },
    ///                 },
    ///             },
    ///             new Contact
    ///             {
    ///                 Relationship = new List&lt;Relationship&gt;() { Relationship.Self, Relationship.Self },
    ///                 Name = new HumanName
    ///                 {
    ///                     Family = "family",
    ///                     Given = new List&lt;string&gt;() { "given", "given" },
    ///                     Use = NameUse.Usual,
    ///                 },
    ///                 Telecoms = new List&lt;ContactPoint&gt;()
    ///                 {
    ///                     new ContactPoint { Value = "value", Use = ContactPointUse.Home },
    ///                     new ContactPoint { Value = "value", Use = ContactPointUse.Home },
    ///                 },
    ///                 Addresses = new List&lt;global::Candid.Net.PreEncounter.Common.Address&gt;()
    ///                 {
    ///                     new global::Candid.Net.PreEncounter.Common.Address
    ///                     {
    ///                         Use = AddressUse.Home,
    ///                         Line = new List&lt;string&gt;() { "line", "line" },
    ///                         City = "city",
    ///                         State = "state",
    ///                         PostalCode = "postal_code",
    ///                         Country = "country",
    ///                     },
    ///                     new global::Candid.Net.PreEncounter.Common.Address
    ///                     {
    ///                         Use = AddressUse.Home,
    ///                         Line = new List&lt;string&gt;() { "line", "line" },
    ///                         City = "city",
    ///                         State = "state",
    ///                         PostalCode = "postal_code",
    ///                         Country = "country",
    ///                     },
    ///                 },
    ///             },
    ///         },
    ///         GeneralPractitioners = new List&lt;ExternalProvider&gt;()
    ///         {
    ///             new ExternalProvider
    ///             {
    ///                 Name = new HumanName
    ///                 {
    ///                     Family = "family",
    ///                     Given = new List&lt;string&gt;() { "given", "given" },
    ///                     Use = NameUse.Usual,
    ///                 },
    ///                 Telecoms = new List&lt;ContactPoint&gt;()
    ///                 {
    ///                     new ContactPoint { Value = "value", Use = ContactPointUse.Home },
    ///                     new ContactPoint { Value = "value", Use = ContactPointUse.Home },
    ///                 },
    ///             },
    ///             new ExternalProvider
    ///             {
    ///                 Name = new HumanName
    ///                 {
    ///                     Family = "family",
    ///                     Given = new List&lt;string&gt;() { "given", "given" },
    ///                     Use = NameUse.Usual,
    ///                 },
    ///                 Telecoms = new List&lt;ContactPoint&gt;()
    ///                 {
    ///                     new ContactPoint { Value = "value", Use = ContactPointUse.Home },
    ///                     new ContactPoint { Value = "value", Use = ContactPointUse.Home },
    ///                 },
    ///             },
    ///         },
    ///         FilingOrder = new FilingOrder
    ///         {
    ///             Coverages = new List&lt;string&gt;()
    ///             {
    ///                 "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
    ///                 "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
    ///             },
    ///         },
    ///     }
    /// );
    /// </code></example>
    public async global::System.Threading.Tasks.Task<Patient> UpdateAsync(
        string id,
        string version,
        MutablePatient request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        var response = await _client
            .SendRequestAsync(
                new JsonRequest
                {
                    BaseUrl = _client.Options.Environment.PreEncounter,
                    Method = HttpMethod.Put,
                    Path = string.Format(
                        "/patients/v1/{0}/{1}",
                        ValueConvert.ToPathParameterString(id),
                        ValueConvert.ToPathParameterString(version)
                    ),
                    Body = request,
                    Options = options,
                },
                cancellationToken
            )
            .ConfigureAwait(false);
        if (response.StatusCode is >= 200 and < 400)
        {
            var responseBody = await response.Raw.Content.ReadAsStringAsync();
            try
            {
                return JsonUtils.Deserialize<Patient>(responseBody)!;
            }
            catch (JsonException e)
            {
                throw new CandidException("Failed to deserialize response", e);
            }
        }

        {
            var responseBody = await response.Raw.Content.ReadAsStringAsync();
            throw new CandidApiException(
                $"Error with status code {response.StatusCode}",
                response.StatusCode,
                responseBody
            );
        }
    }

    /// <summary>
    /// Sets a patient as deactivated.  The path must contain the most recent version plus 1 to prevent race conditions.  Deactivating historic versions is not supported.
    /// </summary>
    /// <example><code>
    /// await client.PreEncounter.Patients.V1.DeactivateAsync("id", "version");
    /// </code></example>
    public async global::System.Threading.Tasks.Task DeactivateAsync(
        string id,
        string version,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        var response = await _client
            .SendRequestAsync(
                new JsonRequest
                {
                    BaseUrl = _client.Options.Environment.PreEncounter,
                    Method = HttpMethod.Delete,
                    Path = string.Format(
                        "/patients/v1/{0}/{1}",
                        ValueConvert.ToPathParameterString(id),
                        ValueConvert.ToPathParameterString(version)
                    ),
                    Options = options,
                },
                cancellationToken
            )
            .ConfigureAwait(false);
        if (response.StatusCode is >= 200 and < 400)
        {
            return;
        }
        {
            var responseBody = await response.Raw.Content.ReadAsStringAsync();
            throw new CandidApiException(
                $"Error with status code {response.StatusCode}",
                response.StatusCode,
                responseBody
            );
        }
    }

    /// <summary>
    /// Removes the deactivated flag for a patient.  The path must contain the most recent version plus 1 to prevent race conditions.  Reactivating historic versions is not supported.
    /// </summary>
    /// <example><code>
    /// await client.PreEncounter.Patients.V1.ReactivateAsync("id", "version");
    /// </code></example>
    public async global::System.Threading.Tasks.Task ReactivateAsync(
        string id,
        string version,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        var response = await _client
            .SendRequestAsync(
                new JsonRequest
                {
                    BaseUrl = _client.Options.Environment.PreEncounter,
                    Method = HttpMethodExtensions.Patch,
                    Path = string.Format(
                        "/patients/v1/{0}/{1}",
                        ValueConvert.ToPathParameterString(id),
                        ValueConvert.ToPathParameterString(version)
                    ),
                    Options = options,
                },
                cancellationToken
            )
            .ConfigureAwait(false);
        if (response.StatusCode is >= 200 and < 400)
        {
            return;
        }
        {
            var responseBody = await response.Raw.Content.ReadAsStringAsync();
            throw new CandidApiException(
                $"Error with status code {response.StatusCode}",
                response.StatusCode,
                responseBody
            );
        }
    }

    /// <summary>
    /// Returns a list of Patients based on the search criteria.
    /// </summary>
    /// <example><code>
    /// await client.PreEncounter.Patients.V1.SearchAsync(new PatientGetMultiRequest());
    /// </code></example>
    public async global::System.Threading.Tasks.Task<IEnumerable<Patient>> SearchAsync(
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
        var response = await _client
            .SendRequestAsync(
                new JsonRequest
                {
                    BaseUrl = _client.Options.Environment.PreEncounter,
                    Method = HttpMethod.Get,
                    Path = "/patients/v1",
                    Query = _query,
                    Options = options,
                },
                cancellationToken
            )
            .ConfigureAwait(false);
        if (response.StatusCode is >= 200 and < 400)
        {
            var responseBody = await response.Raw.Content.ReadAsStringAsync();
            try
            {
                return JsonUtils.Deserialize<IEnumerable<Patient>>(responseBody)!;
            }
            catch (JsonException e)
            {
                throw new CandidException("Failed to deserialize response", e);
            }
        }

        {
            var responseBody = await response.Raw.Content.ReadAsStringAsync();
            throw new CandidApiException(
                $"Error with status code {response.StatusCode}",
                response.StatusCode,
                responseBody
            );
        }
    }

    /// <summary>
    /// Scans up to 1000 patient updates. The since query parameter is inclusive, and the result list is ordered by updatedAt ascending.
    ///
    /// **Polling Pattern:**
    /// To continuously poll for updates without gaps:
    /// 1. Make your initial request with a `since` timestamp (e.g., `since=2020-01-01T13:00:00.000Z`)
    /// 2. The API returns 100 by default and up to 1000 patient records, sorted by `updated_at` ascending
    /// 3. Find the `updated_at` value from the last record in the response
    /// 4. Use that `updated_at` value as the `since` parameter in your next request
    /// 5. Repeat steps 2-4 to ingest updates until you receive an empty list
    ///
    /// **Important Notes:**
    /// - The `since` parameter is inclusive, so you may receive the last record from the previous batch again (you can deduplicate by ID and version)
    /// - All patient records include `updated_at`, `id`, `version`, `deactivated`, and `updating_user` fields for tracking changes
    /// - Timestamps have millisecond resolution for precise ordering
    /// </summary>
    /// <example><code>
    /// await client.PreEncounter.Patients.V1.ScanAsync(
    ///     new PatientScanRequest { Since = new DateTime(2024, 01, 15, 09, 30, 00, 000) }
    /// );
    /// </code></example>
    public async global::System.Threading.Tasks.Task<IEnumerable<Patient>> ScanAsync(
        PatientScanRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        var _query = new Dictionary<string, object>();
        _query["since"] = request.Since.ToString(Constants.DateTimeFormat);
        if (request.MaxResults != null)
        {
            _query["maxResults"] = request.MaxResults.Value.ToString();
        }
        var response = await _client
            .SendRequestAsync(
                new JsonRequest
                {
                    BaseUrl = _client.Options.Environment.PreEncounter,
                    Method = HttpMethod.Get,
                    Path = "/patients/v1/updates/scan",
                    Query = _query,
                    Options = options,
                },
                cancellationToken
            )
            .ConfigureAwait(false);
        if (response.StatusCode is >= 200 and < 400)
        {
            var responseBody = await response.Raw.Content.ReadAsStringAsync();
            try
            {
                return JsonUtils.Deserialize<IEnumerable<Patient>>(responseBody)!;
            }
            catch (JsonException e)
            {
                throw new CandidException("Failed to deserialize response", e);
            }
        }

        {
            var responseBody = await response.Raw.Content.ReadAsStringAsync();
            throw new CandidApiException(
                $"Error with status code {response.StatusCode}",
                response.StatusCode,
                responseBody
            );
        }
    }
}
