using global::Candid.Net;
using global::Candid.Net.Core;
using global::System.Text.Json;

namespace Candid.Net.PreServiceRules.V1;

public partial class V1Client : IV1Client
{
    private readonly RawClient _client;

    internal V1Client(RawClient client)
    {
        _client = client;
    }

    private async global::System.Threading.Tasks.Task<
        WithRawResponse<string>
    > CreateEncounterRunAsyncCore(
        PreServiceEncounterRunCreate request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        var _headers = await new global::Candid.Net.Core.HeadersBuilder.Builder()
            .Add(_client.Options.Headers)
            .Add(_client.Options.AdditionalHeaders)
            .Add(options?.AdditionalHeaders)
            .BuildAsync()
            .ConfigureAwait(false);
        var response = await _client
            .SendRequestAsync(
                new JsonRequest
                {
                    BaseUrl = _client.Options.Environment.CandidApi,
                    Method = HttpMethod.Post,
                    Path = "/api/pre-service/v1/runs/encounter",
                    Body = request,
                    Headers = _headers,
                    Options = options,
                },
                cancellationToken
            )
            .ConfigureAwait(false);
        if (response.StatusCode is >= 200 and < 400)
        {
            var responseBody = await response
                .Raw.Content.ReadAsStringAsync(cancellationToken)
                .ConfigureAwait(false);
            try
            {
                var responseData = JsonUtils.Deserialize<string>(responseBody)!;
                return new WithRawResponse<string>()
                {
                    Data = responseData,
                    RawResponse = new global::Candid.Net.RawResponse()
                    {
                        StatusCode = response.Raw.StatusCode,
                        Url = response.Raw.RequestMessage?.RequestUri ?? new Uri("about:blank"),
                        Headers = ResponseHeaders.FromHttpResponseMessage(response.Raw),
                    },
                };
            }
            catch (JsonException e)
            {
                throw new CandidApiException(
                    "Failed to deserialize response",
                    response.StatusCode,
                    responseBody,
                    e,
                    rawResponse: new global::Candid.Net.RawResponse()
                    {
                        StatusCode = response.Raw.StatusCode,
                        Url = response.Raw.RequestMessage?.RequestUri ?? new Uri("about:blank"),
                        Headers = ResponseHeaders.FromHttpResponseMessage(response.Raw),
                    }
                );
            }
        }
        {
            var responseBody = await response
                .Raw.Content.ReadAsStringAsync(cancellationToken)
                .ConfigureAwait(false);
            throw new CandidApiException(
                $"Error with status code {response.StatusCode}",
                response.StatusCode,
                responseBody,
                rawResponse: new global::Candid.Net.RawResponse()
                {
                    StatusCode = response.Raw.StatusCode,
                    Url = response.Raw.RequestMessage?.RequestUri ?? new Uri("about:blank"),
                    Headers = ResponseHeaders.FromHttpResponseMessage(response.Raw),
                }
            );
        }
    }

    private async global::System.Threading.Tasks.Task<
        WithRawResponse<PreServiceRun>
    > GetRunAsyncCore(
        string runId,
        GetPreServiceRunRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        var _queryString = new global::Candid.Net.Core.QueryStringBuilder.Builder(capacity: 1)
            .Add("include_initial_entity_state", request.IncludeInitialEntityState)
            .MergeAdditional(options?.AdditionalQueryParameters)
            .Build();
        var _headers = await new global::Candid.Net.Core.HeadersBuilder.Builder()
            .Add(_client.Options.Headers)
            .Add(_client.Options.AdditionalHeaders)
            .Add(options?.AdditionalHeaders)
            .BuildAsync()
            .ConfigureAwait(false);
        var response = await _client
            .SendRequestAsync(
                new JsonRequest
                {
                    BaseUrl = _client.Options.Environment.CandidApi,
                    Method = HttpMethod.Get,
                    Path = string.Format(
                        "/api/pre-service/v1/runs/{0}",
                        ValueConvert.ToPathParameterString(runId)
                    ),
                    QueryString = _queryString,
                    Headers = _headers,
                    Options = options,
                },
                cancellationToken
            )
            .ConfigureAwait(false);
        if (response.StatusCode is >= 200 and < 400)
        {
            var responseBody = await response
                .Raw.Content.ReadAsStringAsync(cancellationToken)
                .ConfigureAwait(false);
            try
            {
                var responseData = JsonUtils.Deserialize<PreServiceRun>(responseBody)!;
                return new WithRawResponse<PreServiceRun>()
                {
                    Data = responseData,
                    RawResponse = new global::Candid.Net.RawResponse()
                    {
                        StatusCode = response.Raw.StatusCode,
                        Url = response.Raw.RequestMessage?.RequestUri ?? new Uri("about:blank"),
                        Headers = ResponseHeaders.FromHttpResponseMessage(response.Raw),
                    },
                };
            }
            catch (JsonException e)
            {
                throw new CandidApiException(
                    "Failed to deserialize response",
                    response.StatusCode,
                    responseBody,
                    e,
                    rawResponse: new global::Candid.Net.RawResponse()
                    {
                        StatusCode = response.Raw.StatusCode,
                        Url = response.Raw.RequestMessage?.RequestUri ?? new Uri("about:blank"),
                        Headers = ResponseHeaders.FromHttpResponseMessage(response.Raw),
                    }
                );
            }
        }
        {
            var responseBody = await response
                .Raw.Content.ReadAsStringAsync(cancellationToken)
                .ConfigureAwait(false);
            throw new CandidApiException(
                $"Error with status code {response.StatusCode}",
                response.StatusCode,
                responseBody,
                rawResponse: new global::Candid.Net.RawResponse()
                {
                    StatusCode = response.Raw.StatusCode,
                    Url = response.Raw.RequestMessage?.RequestUri ?? new Uri("about:blank"),
                    Headers = ResponseHeaders.FromHttpResponseMessage(response.Raw),
                }
            );
        }
    }

    private async global::System.Threading.Tasks.Task<
        WithRawResponse<IEnumerable<PreServicePipelineSummary>>
    > GetPipelinesAsyncCore(
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        var _headers = await new global::Candid.Net.Core.HeadersBuilder.Builder()
            .Add(_client.Options.Headers)
            .Add(_client.Options.AdditionalHeaders)
            .Add(options?.AdditionalHeaders)
            .BuildAsync()
            .ConfigureAwait(false);
        var response = await _client
            .SendRequestAsync(
                new JsonRequest
                {
                    BaseUrl = _client.Options.Environment.CandidApi,
                    Method = HttpMethod.Get,
                    Path = "/api/pre-service/v1/pipelines",
                    Headers = _headers,
                    Options = options,
                },
                cancellationToken
            )
            .ConfigureAwait(false);
        if (response.StatusCode is >= 200 and < 400)
        {
            var responseBody = await response
                .Raw.Content.ReadAsStringAsync(cancellationToken)
                .ConfigureAwait(false);
            try
            {
                var responseData = JsonUtils.Deserialize<IEnumerable<PreServicePipelineSummary>>(
                    responseBody
                )!;
                return new WithRawResponse<IEnumerable<PreServicePipelineSummary>>()
                {
                    Data = responseData,
                    RawResponse = new global::Candid.Net.RawResponse()
                    {
                        StatusCode = response.Raw.StatusCode,
                        Url = response.Raw.RequestMessage?.RequestUri ?? new Uri("about:blank"),
                        Headers = ResponseHeaders.FromHttpResponseMessage(response.Raw),
                    },
                };
            }
            catch (JsonException e)
            {
                throw new CandidApiException(
                    "Failed to deserialize response",
                    response.StatusCode,
                    responseBody,
                    e,
                    rawResponse: new global::Candid.Net.RawResponse()
                    {
                        StatusCode = response.Raw.StatusCode,
                        Url = response.Raw.RequestMessage?.RequestUri ?? new Uri("about:blank"),
                        Headers = ResponseHeaders.FromHttpResponseMessage(response.Raw),
                    }
                );
            }
        }
        {
            var responseBody = await response
                .Raw.Content.ReadAsStringAsync(cancellationToken)
                .ConfigureAwait(false);
            throw new CandidApiException(
                $"Error with status code {response.StatusCode}",
                response.StatusCode,
                responseBody,
                rawResponse: new global::Candid.Net.RawResponse()
                {
                    StatusCode = response.Raw.StatusCode,
                    Url = response.Raw.RequestMessage?.RequestUri ?? new Uri("about:blank"),
                    Headers = ResponseHeaders.FromHttpResponseMessage(response.Raw),
                }
            );
        }
    }

    /// <summary>
    /// Submit a representation of an encounter to the Candid rules engine. Note that this encounter will not be created in Candid.
    /// Returns a run_id that can be polled via GET /runs/{run_id} to retrieve the results once complete.
    /// </summary>
    /// <example><code>
    /// await client.PreServiceRules.V1.CreateEncounterRunAsync(
    ///     new PreServiceEncounterRunCreate
    ///     {
    ///         Entity = new PreServiceEncounterCreate
    ///         {
    ///             ExternalId = "enc-123",
    ///             PatientAuthorizedRelease = true,
    ///             BenefitsAssignedToProvider = true,
    ///             ProviderAcceptsAssignment = true,
    ///             ResponsibleParty = ResponsiblePartyType.InsurancePay,
    ///             SubmissionExpectation = EncounterSubmissionExpectation.TargetProfessional,
    ///             DateOfService = new DateOnly(2026, 10, 15),
    ///             Patient = new PatientCreate
    ///             {
    ///                 ExternalId = "p-456",
    ///                 FirstName = "Jane",
    ///                 LastName = "Doe",
    ///                 Gender = global::Candid.Net.Individual.Gender.Female,
    ///                 DateOfBirth = new DateOnly(1960, 1, 1),
    ///                 Address = new StreetAddressShortZip
    ///                 {
    ///                     Address1 = "1 Main St",
    ///                     City = "Fairfax",
    ///                     State = State.Va,
    ///                     ZipCode = "22031",
    ///                 },
    ///             },
    ///             RenderingProvider = new RenderingProvider
    ///             {
    ///                 FirstName = "Ada",
    ///                 LastName = "Lovelace",
    ///                 Npi = "1234567893",
    ///             },
    ///             BillingProvider = new BillingProvider
    ///             {
    ///                 Npi = "1558375857",
    ///                 TaxId = "202265068",
    ///                 OrganizationName = "Example Clinic",
    ///                 Address = new StreetAddressLongZip
    ///                 {
    ///                     Address1 = "1 Main St",
    ///                     City = "Fairfax",
    ///                     State = State.Va,
    ///                     ZipCode = "22031",
    ///                     ZipPlusFourCode = "4634",
    ///                 },
    ///             },
    ///             SubscriberPrimary = new SubscriberCreate
    ///             {
    ///                 FirstName = "Jane",
    ///                 LastName = "Doe",
    ///                 Gender = global::Candid.Net.Individual.Gender.Female,
    ///                 PatientRelationshipToSubscriberCode = PatientRelationshipToInsuredCodeAll.Self,
    ///                 InsuranceCard = new InsuranceCardCreate
    ///                 {
    ///                     MemberId = "123456789",
    ///                     PayerName = "Example Payer",
    ///                     PayerId = "12345",
    ///                 },
    ///             },
    ///             HealthCareCodeInformation = new HealthCareCodeInformationCreate
    ///             {
    ///                 PrincipalDiagnosis = new PrincipalDiagnosisNew
    ///                 {
    ///                     PrimaryDiagnosisCode = "Z01.411",
    ///                     PrincipalDiagnosisCodeQualifier = PrincipalDiagnosisCodeQualifier.Cabk,
    ///                 },
    ///             },
    ///             ServiceLines = new List&lt;UniversalServiceLineCreate&gt;()
    ///             {
    ///                 new UniversalServiceLineCreate
    ///                 {
    ///                     ProcedureCode = "99213",
    ///                     Quantity = "1",
    ///                     Units = ServiceLineUnits.Un,
    ///                     ChargeAmountCents = 20600,
    ///                     DiagnosisPointers = new List&lt;int&gt;() { 0 },
    ///                 },
    ///             },
    ///         },
    ///         PipelineId = "pre-service-claim-athena",
    ///         EnabledRuleIds = new List&lt;string&gt;() { },
    ///         DisabledRuleIds = new List&lt;string&gt;() { },
    ///         IdempotencyKey = "enc-123-run-1",
    ///     }
    /// );
    /// </code></example>
    public WithRawResponseTask<string> CreateEncounterRunAsync(
        PreServiceEncounterRunCreate request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        return new WithRawResponseTask<string>(
            CreateEncounterRunAsyncCore(request, options, cancellationToken)
        );
    }

    /// <summary>
    /// Retrieve the result of a pre-service run. This endpoint supports long-polling.
    /// </summary>
    /// <example><code>
    /// await client.PreServiceRules.V1.GetRunAsync(
    ///     "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
    ///     new GetPreServiceRunRequest()
    /// );
    /// </code></example>
    public WithRawResponseTask<PreServiceRun> GetRunAsync(
        string runId,
        GetPreServiceRunRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        return new WithRawResponseTask<PreServiceRun>(
            GetRunAsyncCore(runId, request, options, cancellationToken)
        );
    }

    /// <summary>
    /// List the pre-service pipelines available to the authenticated organization.
    /// </summary>
    /// <example><code>
    /// await client.PreServiceRules.V1.GetPipelinesAsync();
    /// </code></example>
    public WithRawResponseTask<IEnumerable<PreServicePipelineSummary>> GetPipelinesAsync(
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        return new WithRawResponseTask<IEnumerable<PreServicePipelineSummary>>(
            GetPipelinesAsyncCore(options, cancellationToken)
        );
    }
}
