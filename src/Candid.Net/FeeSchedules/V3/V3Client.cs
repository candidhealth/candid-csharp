using System.Net.Http;
using System.Text.Json;
using System.Threading;
using Candid.Net.Core;

namespace Candid.Net.FeeSchedules.V3;

public partial class V3Client
{
    private RawClient _client;

    internal V3Client(RawClient client)
    {
        _client = client;
    }

    /// <summary>
    /// Gets the rate that matches a service line.  No result means no rate exists matching the service line's dimensions.
    /// </summary>
    /// <example><code>
    /// await client.FeeSchedules.V3.GetMatchAsync("d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32");
    /// </code></example>
    public async global::System.Threading.Tasks.Task<MatchResult?> GetMatchAsync(
        string serviceLineId,
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
                        "/api/fee-schedules/v3/service-line/{0}/match",
                        ValueConvert.ToPathParameterString(serviceLineId)
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
                return JsonUtils.Deserialize<MatchResult?>(responseBody)!;
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
    /// Tests a service line against a rate to see if it matches.
    /// </summary>
    /// <example><code>
    /// await client.FeeSchedules.V3.TestMatchAsync(
    ///     "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
    ///     "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32"
    /// );
    /// </code></example>
    public async global::System.Threading.Tasks.Task<MatchTestResult> TestMatchAsync(
        string serviceLineId,
        string rateId,
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
                        "/api/fee-schedules/v3/service-line/{0}/match/{1}",
                        ValueConvert.ToPathParameterString(serviceLineId),
                        ValueConvert.ToPathParameterString(rateId)
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
                return JsonUtils.Deserialize<MatchTestResult>(responseBody)!;
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
    /// Gets a list of dimensions with their rates. The rates returned will always be the most recent versions of those rates.
    /// </summary>
    /// <example><code>
    /// await client.FeeSchedules.V3.GetMultiAsync(new GetMultiRequest());
    /// </code></example>
    public async global::System.Threading.Tasks.Task<RatesPage> GetMultiAsync(
        GetMultiRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        var _query = new Dictionary<string, object>();
        _query["states"] = request.States.Select(_value => _value.Stringify()).ToList();
        _query["zip_codes"] = request.ZipCodes;
        _query["license_types"] = request
            .LicenseTypes.Select(_value => _value.Stringify())
            .ToList();
        _query["facility_type_codes"] = request
            .FacilityTypeCodes.Select(_value => _value.Stringify())
            .ToList();
        _query["network_types"] = request
            .NetworkTypes.Select(_value => _value.Stringify())
            .ToList();
        _query["payer_plan_group_ids"] = request.PayerPlanGroupIds;
        _query["modifiers"] = request.Modifiers.Select(_value => _value.Stringify()).ToList();
        if (request.PageToken != null)
        {
            _query["page_token"] = request.PageToken;
        }
        if (request.Limit != null)
        {
            _query["limit"] = request.Limit.Value.ToString();
        }
        if (request.ActiveDate != null)
        {
            _query["active_date"] = request.ActiveDate.Value.ToString(Constants.DateFormat);
        }
        if (request.PayerUuid != null)
        {
            _query["payer_uuid"] = request.PayerUuid;
        }
        if (request.OrganizationBillingProviderId != null)
        {
            _query["organization_billing_provider_id"] = request.OrganizationBillingProviderId;
        }
        if (request.CptCode != null)
        {
            _query["cpt_code"] = request.CptCode;
        }
        var response = await _client
            .SendRequestAsync(
                new JsonRequest
                {
                    BaseUrl = _client.Options.Environment.CandidApi,
                    Method = HttpMethod.Get,
                    Path = "/api/fee-schedules/v3",
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
                return JsonUtils.Deserialize<RatesPage>(responseBody)!;
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
    /// Gets unique values for a dimension based on other selection criteria. The response is a list of dimensions with your criteria and the unique values populated. This API is useful for driving pivots on dimension values.
    /// </summary>
    /// <example><code>
    /// await client.FeeSchedules.V3.GetUniqueValuesForDimensionAsync(
    ///     new GetUniqueDimensionValuesRequest { PivotDimension = DimensionName.PayerUuid }
    /// );
    /// </code></example>
    public async global::System.Threading.Tasks.Task<DimensionsPage> GetUniqueValuesForDimensionAsync(
        GetUniqueDimensionValuesRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        var _query = new Dictionary<string, object>();
        _query["pivot_dimension"] = request.PivotDimension.Stringify();
        _query["states"] = request.States.Select(_value => _value.Stringify()).ToList();
        _query["zip_codes"] = request.ZipCodes;
        _query["license_types"] = request
            .LicenseTypes.Select(_value => _value.Stringify())
            .ToList();
        _query["facility_type_codes"] = request
            .FacilityTypeCodes.Select(_value => _value.Stringify())
            .ToList();
        _query["network_types"] = request
            .NetworkTypes.Select(_value => _value.Stringify())
            .ToList();
        _query["payer_plan_group_ids"] = request.PayerPlanGroupIds;
        _query["modifiers"] = request.Modifiers.Select(_value => _value.Stringify()).ToList();
        if (request.PageToken != null)
        {
            _query["page_token"] = request.PageToken;
        }
        if (request.Limit != null)
        {
            _query["limit"] = request.Limit.Value.ToString();
        }
        if (request.PayerUuid != null)
        {
            _query["payer_uuid"] = request.PayerUuid;
        }
        if (request.OrganizationBillingProviderId != null)
        {
            _query["organization_billing_provider_id"] = request.OrganizationBillingProviderId;
        }
        if (request.CptCode != null)
        {
            _query["cpt_code"] = request.CptCode;
        }
        var response = await _client
            .SendRequestAsync(
                new JsonRequest
                {
                    BaseUrl = _client.Options.Environment.CandidApi,
                    Method = HttpMethod.Get,
                    Path = "/api/fee-schedules/v3/unique-dimension-values",
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
                return JsonUtils.Deserialize<DimensionsPage>(responseBody)!;
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
    /// Gets every version of a rate.
    /// </summary>
    /// <example><code>
    /// await client.FeeSchedules.V3.GetRateHistoryAsync("d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32");
    /// </code></example>
    public async global::System.Threading.Tasks.Task<IEnumerable<Rate>> GetRateHistoryAsync(
        string rateId,
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
                        "/api/fee-schedules/v3/{0}/history",
                        ValueConvert.ToPathParameterString(rateId)
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
                return JsonUtils.Deserialize<IEnumerable<Rate>>(responseBody)!;
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
    /// Uploads a new fee schedule.
    ///
    /// Each rate may either be totally new as qualified by it's dimensions or a new version for an existing rate.
    ///
    /// If adding a new version to an existing rate, the rate must be posted with the next version number (previous version + 1) or a EntityConflictError will
    /// be returned.
    ///
    /// Use the dry run flag to discover already existing rates and to run validations.  If validations for any rate fail, no rates will
    /// be saved to the system.
    /// </summary>
    /// <example><code>
    /// await client.FeeSchedules.V3.UploadFeeScheduleAsync(
    ///     new FeeScheduleUploadRequest
    ///     {
    ///         DryRun = true,
    ///         Rates = new List&lt;RateUpload&gt;()
    ///         {
    ///             new RateUpload(
    ///                 new RateUpload.NewRate(
    ///                     new NewRate
    ///                     {
    ///                         Dimensions = new Dimensions
    ///                         {
    ///                             PayerUuid = "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
    ///                             OrganizationBillingProviderId = "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
    ///                             States = new HashSet&lt;State&gt;() { State.Aa },
    ///                             ZipCodes = new HashSet&lt;string&gt;() { "zip_codes" },
    ///                             LicenseTypes = new HashSet&lt;LicenseType&gt;() { LicenseType.Md },
    ///                             FacilityTypeCodes = new HashSet&lt;FacilityTypeCode&gt;()
    ///                             {
    ///                                 FacilityTypeCode.Pharmacy,
    ///                             },
    ///                             NetworkTypes = new HashSet&lt;global::Candid.Net.Commons.NetworkType&gt;()
    ///                             {
    ///                                 global::Candid.Net.Commons.NetworkType.Ppo,
    ///                             },
    ///                             PayerPlanGroupIds = new HashSet&lt;string&gt;()
    ///                             {
    ///                                 "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
    ///                             },
    ///                             CptCode = "cpt_code",
    ///                             Modifiers = new HashSet&lt;ProcedureModifier&gt;() { ProcedureModifier.Av },
    ///                         },
    ///                         Entries = new List&lt;RateEntry&gt;()
    ///                         {
    ///                             new RateEntry
    ///                             {
    ///                                 StartDate = new DateOnly(2023, 1, 15),
    ///                                 RateCents = 1,
    ///                                 IsDeactivated = true,
    ///                             },
    ///                             new RateEntry
    ///                             {
    ///                                 StartDate = new DateOnly(2023, 1, 15),
    ///                                 RateCents = 1,
    ///                                 IsDeactivated = true,
    ///                             },
    ///                         },
    ///                     }
    ///                 )
    ///             ),
    ///             new RateUpload(
    ///                 new RateUpload.NewRate(
    ///                     new NewRate
    ///                     {
    ///                         Dimensions = new Dimensions
    ///                         {
    ///                             PayerUuid = "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
    ///                             OrganizationBillingProviderId = "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
    ///                             States = new HashSet&lt;State&gt;() { State.Aa },
    ///                             ZipCodes = new HashSet&lt;string&gt;() { "zip_codes" },
    ///                             LicenseTypes = new HashSet&lt;LicenseType&gt;() { LicenseType.Md },
    ///                             FacilityTypeCodes = new HashSet&lt;FacilityTypeCode&gt;()
    ///                             {
    ///                                 FacilityTypeCode.Pharmacy,
    ///                             },
    ///                             NetworkTypes = new HashSet&lt;global::Candid.Net.Commons.NetworkType&gt;()
    ///                             {
    ///                                 global::Candid.Net.Commons.NetworkType.Ppo,
    ///                             },
    ///                             PayerPlanGroupIds = new HashSet&lt;string&gt;()
    ///                             {
    ///                                 "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
    ///                             },
    ///                             CptCode = "cpt_code",
    ///                             Modifiers = new HashSet&lt;ProcedureModifier&gt;() { ProcedureModifier.Av },
    ///                         },
    ///                         Entries = new List&lt;RateEntry&gt;()
    ///                         {
    ///                             new RateEntry
    ///                             {
    ///                                 StartDate = new DateOnly(2023, 1, 15),
    ///                                 RateCents = 1,
    ///                                 IsDeactivated = true,
    ///                             },
    ///                             new RateEntry
    ///                             {
    ///                                 StartDate = new DateOnly(2023, 1, 15),
    ///                                 RateCents = 1,
    ///                                 IsDeactivated = true,
    ///                             },
    ///                         },
    ///                     }
    ///                 )
    ///             ),
    ///         },
    ///     }
    /// );
    /// </code></example>
    public async global::System.Threading.Tasks.Task<IEnumerable<Rate>> UploadFeeScheduleAsync(
        FeeScheduleUploadRequest request,
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
                    Path = "/api/fee-schedules/v3",
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
                return JsonUtils.Deserialize<IEnumerable<Rate>>(responseBody)!;
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
    /// Soft deletes a rate from the system.  Only the most recent version of a rate can be deleted.
    /// </summary>
    /// <example><code>
    /// await client.FeeSchedules.V3.DeleteRateAsync("d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32", 1);
    /// </code></example>
    public async global::System.Threading.Tasks.Task DeleteRateAsync(
        string rateId,
        int version,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        var response = await _client
            .SendRequestAsync(
                new JsonRequest
                {
                    BaseUrl = _client.Options.Environment.CandidApi,
                    Method = HttpMethod.Delete,
                    Path = string.Format(
                        "/api/fee-schedules/v3/{0}/{1}",
                        ValueConvert.ToPathParameterString(rateId),
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
    /// Gets the default payer threshold
    /// </summary>
    /// <example><code>
    /// await client.FeeSchedules.V3.GetPayerThresholdsDefaultAsync();
    /// </code></example>
    public async global::System.Threading.Tasks.Task<PayerThreshold> GetPayerThresholdsDefaultAsync(
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
                    Path = "/api/fee-schedules/v3/payer-threshold/default",
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
                return JsonUtils.Deserialize<PayerThreshold>(responseBody)!;
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
    /// Gets a list of payers and thresholds by their uuids
    /// </summary>
    /// <example><code>
    /// await client.FeeSchedules.V3.GetPayerThresholdsAsync(
    ///     new PayerThresholdGetRequest { PayerUuids = ["d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32"] }
    /// );
    /// </code></example>
    public async global::System.Threading.Tasks.Task<PayerThresholdsPage> GetPayerThresholdsAsync(
        PayerThresholdGetRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        var _query = new Dictionary<string, object>();
        _query["payer_uuids"] = request.PayerUuids;
        var response = await _client
            .SendRequestAsync(
                new JsonRequest
                {
                    BaseUrl = _client.Options.Environment.CandidApi,
                    Method = HttpMethod.Get,
                    Path = "/api/fee-schedules/v3/payer-threshold",
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
                return JsonUtils.Deserialize<PayerThresholdsPage>(responseBody)!;
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
    /// Sets the threshold information for a payer
    /// </summary>
    /// <example><code>
    /// await client.FeeSchedules.V3.SetPayerThresholdAsync(
    ///     "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
    ///     new PayerThreshold { DisablePaidIncorrectly = true }
    /// );
    /// </code></example>
    public async global::System.Threading.Tasks.Task<PayerThreshold> SetPayerThresholdAsync(
        string payerUuid,
        PayerThreshold request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        var response = await _client
            .SendRequestAsync(
                new JsonRequest
                {
                    BaseUrl = _client.Options.Environment.CandidApi,
                    Method = HttpMethod.Put,
                    Path = string.Format(
                        "/api/fee-schedules/v3/payer-threshold/{0}",
                        ValueConvert.ToPathParameterString(payerUuid)
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
                return JsonUtils.Deserialize<PayerThreshold>(responseBody)!;
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
    /// Hard deletes rates from the system that match the provided dimensions.  This is a destructive operation and cannot be undone.  If an empty dimensions object is provided, all rates will be hard deleted.  The maximum number of rates this API will delete at a time is 10000.  Returns the number of rates deleted and if that number is the maximum, the caller should call this API again to continue deleting rates.
    /// </summary>
    /// <example><code>
    /// await client.FeeSchedules.V3.HardDeleteRatesAsync(
    ///     new OptionalDimensions
    ///     {
    ///         States = new HashSet&lt;State&gt;() { State.Aa },
    ///         ZipCodes = new HashSet&lt;string&gt;() { "zip_codes" },
    ///         LicenseTypes = new HashSet&lt;LicenseType&gt;() { LicenseType.Md },
    ///         FacilityTypeCodes = new HashSet&lt;FacilityTypeCode&gt;() { FacilityTypeCode.Pharmacy },
    ///         NetworkTypes = new HashSet&lt;global::Candid.Net.Commons.NetworkType&gt;()
    ///         {
    ///             global::Candid.Net.Commons.NetworkType.Ppo,
    ///         },
    ///         PayerPlanGroupIds = new HashSet&lt;string&gt;() { "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32" },
    ///         Modifiers = new HashSet&lt;ProcedureModifier&gt;() { ProcedureModifier.Av },
    ///     }
    /// );
    /// </code></example>
    public async global::System.Threading.Tasks.Task<int> HardDeleteRatesAsync(
        OptionalDimensions request,
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
                    Path = "/api/fee-schedules/v3/hard-delete",
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
                return JsonUtils.Deserialize<int>(responseBody)!;
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
    /// Hard deletes specific rates from the system by their IDs. This is a destructive operation and cannot be undone. Limited to 100 rate IDs maximum per request. For bulk deletion of more than 100 rates, use the hard_delete_rates endpoint with dimension filters. Returns the number of rates deleted.
    /// </summary>
    /// <example><code>
    /// await client.FeeSchedules.V3.HardDeleteRatesByIdsAsync(
    ///     new HardDeleteRatesByIdsRequest
    ///     {
    ///         RateIds = new List&lt;string&gt;()
    ///         {
    ///             "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
    ///             "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
    ///         },
    ///     }
    /// );
    /// </code></example>
    public async global::System.Threading.Tasks.Task<int> HardDeleteRatesByIdsAsync(
        HardDeleteRatesByIdsRequest request,
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
                    Path = "/api/fee-schedules/v3/hard-delete-by-ids",
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
                return JsonUtils.Deserialize<int>(responseBody)!;
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
