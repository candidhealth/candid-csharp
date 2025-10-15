using System.Net.Http;
using System.Text.Json;
using System.Threading;
using Candid.Net.Core;

namespace Candid.Net.WriteOffs.V1;

public partial class V1Client
{
    private RawClient _client;

    internal V1Client(RawClient client)
    {
        _client = client;
    }

    /// <summary>
    /// Returns all write-offs satisfying the search criteria.
    /// </summary>
    /// <example><code>
    /// await client.WriteOffs.V1.GetMultiAsync(new GetMultiWriteOffsRequest());
    /// </code></example>
    public async System.Threading.Tasks.Task<WriteOffsPage> GetMultiAsync(
        GetMultiWriteOffsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        var _query = new Dictionary<string, object>();
        _query["account_types"] = request
            .AccountTypes.Select(_value => _value.Stringify())
            .ToList();
        if (request.Limit != null)
        {
            _query["limit"] = request.Limit.Value.ToString();
        }
        if (request.PatientExternalId != null)
        {
            _query["patient_external_id"] = request.PatientExternalId;
        }
        if (request.PayerUuid != null)
        {
            _query["payer_uuid"] = request.PayerUuid;
        }
        if (request.ServiceLineId != null)
        {
            _query["service_line_id"] = request.ServiceLineId;
        }
        if (request.ClaimId != null)
        {
            _query["claim_id"] = request.ClaimId;
        }
        if (request.BillingProviderId != null)
        {
            _query["billing_provider_id"] = request.BillingProviderId;
        }
        if (request.Sort != null)
        {
            _query["sort"] = request.Sort.Value.Stringify();
        }
        if (request.SortDirection != null)
        {
            _query["sort_direction"] = request.SortDirection.Value.Stringify();
        }
        if (request.PageToken != null)
        {
            _query["page_token"] = request.PageToken;
        }
        var response = await _client
            .SendRequestAsync(
                new JsonRequest
                {
                    BaseUrl = _client.Options.Environment.CandidApi,
                    Method = HttpMethod.Get,
                    Path = "/api/write-offs/v1",
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
                return JsonUtils.Deserialize<WriteOffsPage>(responseBody)!;
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
    /// Retrieves a previously created write off by its `write_off_id`.
    /// </summary>
    /// <example><code>
    /// await client.WriteOffs.V1.GetAsync("d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32");
    /// </code></example>
    public async System.Threading.Tasks.Task<WriteOff> GetAsync(
        string writeOffId,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        var response = await _client
            .SendRequestAsync(
                new JsonRequest
                {
                    BaseUrl = _client.Options.Environment.CandidApi,
                    Method = HttpMethod.Get,
                    Path = string.Format(
                        "/api/write-offs/v1/{0}",
                        ValueConvert.ToPathParameterString(writeOffId)
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
                return JsonUtils.Deserialize<WriteOff>(responseBody)!;
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
    /// Creates one or many write-offs applied toward a specific service line,
    /// claim, or billing provider.
    /// </summary>
    /// <example><code>
    /// await client.WriteOffs.V1.CreateAsync(
    ///     new CreateWriteOffsRequest
    ///     {
    ///         WriteOffs = new List&lt;WriteOffCreate&gt;()
    ///         {
    ///             new WriteOffCreate(
    ///                 new Candid.Net.WriteOffs.V1.WriteOffCreate.Patient(
    ///                     new PatientWriteOffCreate
    ///                     {
    ///                         WriteOffTimestamp = new DateTime(2024, 01, 15, 09, 30, 00, 000),
    ///                         WriteOffReason = PatientWriteOffReason.SmallBalance,
    ///                         ServiceLineId = "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
    ///                         AmountCents = 1,
    ///                     }
    ///                 )
    ///             ),
    ///             new WriteOffCreate(
    ///                 new Candid.Net.WriteOffs.V1.WriteOffCreate.Patient(
    ///                     new PatientWriteOffCreate
    ///                     {
    ///                         WriteOffTimestamp = new DateTime(2024, 01, 15, 09, 30, 00, 000),
    ///                         WriteOffReason = PatientWriteOffReason.SmallBalance,
    ///                         ServiceLineId = "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
    ///                         AmountCents = 1,
    ///                     }
    ///                 )
    ///             ),
    ///         },
    ///     }
    /// );
    /// </code></example>
    public async System.Threading.Tasks.Task<CreateWriteOffsResponse> CreateAsync(
        CreateWriteOffsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        var response = await _client
            .SendRequestAsync(
                new JsonRequest
                {
                    BaseUrl = _client.Options.Environment.CandidApi,
                    Method = HttpMethod.Post,
                    Path = "/api/write-offs/v1",
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
                return JsonUtils.Deserialize<CreateWriteOffsResponse>(responseBody)!;
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
    /// Reverts a write off given a `write_off_id`.
    /// </summary>
    /// <example><code>
    /// await client.WriteOffs.V1.RevertAsync("d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32");
    /// </code></example>
    public async System.Threading.Tasks.Task<WriteOff> RevertAsync(
        string writeOffId,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        var response = await _client
            .SendRequestAsync(
                new JsonRequest
                {
                    BaseUrl = _client.Options.Environment.CandidApi,
                    Method = HttpMethod.Post,
                    Path = string.Format(
                        "/api/write-offs/v1/{0}/revert",
                        ValueConvert.ToPathParameterString(writeOffId)
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
                return JsonUtils.Deserialize<WriteOff>(responseBody)!;
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
    /// Reverts an Insurance Balance Adjustment given an `adjustment_id`
    /// </summary>
    /// <example><code>
    /// await client.WriteOffs.V1.RevertInsuranceBalanceAdjustmentAsync(
    ///     "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32"
    /// );
    /// </code></example>
    public async System.Threading.Tasks.Task<WriteOff> RevertInsuranceBalanceAdjustmentAsync(
        string adjustmentId,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        var response = await _client
            .SendRequestAsync(
                new JsonRequest
                {
                    BaseUrl = _client.Options.Environment.CandidApi,
                    Method = HttpMethod.Post,
                    Path = string.Format(
                        "/api/write-offs/v1/{0}/revert",
                        ValueConvert.ToPathParameterString(adjustmentId)
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
                return JsonUtils.Deserialize<WriteOff>(responseBody)!;
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
    /// Reverts an ERA-originated Insurance Balance Adjustment given an `adjustment_id`
    /// </summary>
    /// <example><code>
    /// await client.WriteOffs.V1.RevertEraOriginatedInsuranceBalanceAdjustmentAsync(
    ///     "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32"
    /// );
    /// </code></example>
    public async System.Threading.Tasks.Task<string> RevertEraOriginatedInsuranceBalanceAdjustmentAsync(
        string adjustmentId,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        var response = await _client
            .SendRequestAsync(
                new JsonRequest
                {
                    BaseUrl = _client.Options.Environment.CandidApi,
                    Method = HttpMethod.Post,
                    Path = string.Format(
                        "/api/write-offs/v1/{0}/revert-era-originated",
                        ValueConvert.ToPathParameterString(adjustmentId)
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
                return JsonUtils.Deserialize<string>(responseBody)!;
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
