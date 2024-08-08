using System.Net.Http;
using System.Text.Json;
using Candid.Net.Core;

#nullable enable

namespace Candid.Net.FeeSchedules.V3;

public class V3Client
{
    private RawClient _client;

    public V3Client(RawClient client)
    {
        _client = client;
    }

    /// <summary>
    /// Gets the rate that matches a service line. No result means no rate exists matching the service line's dimensions.
    /// </summary>
    public async Task<MatchResult?> GetMatchAsync(
        string serviceLineId,
        RequestOptions? options = null
    )
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.JsonApiRequest
            {
                BaseUrl = _client.Options.Environment.CandidApi,
                Method = HttpMethod.Get,
                Path = $"/api/fee-schedules/v3/service-line/{serviceLineId}/match",
                Options = options
            }
        );
        var responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode is >= 200 and < 400)
        {
            try
            {
                return JsonUtils.Deserialize<MatchResult?>(responseBody)!;
            }
            catch (JsonException e)
            {
                throw new CandidClientException("Failed to deserialize response", e);
            }
        }

        throw new CandidClientApiException(
            $"Error with status code {response.StatusCode}",
            response.StatusCode,
            JsonUtils.Deserialize<object>(responseBody)
        );
    }

    /// <summary>
    /// Tests a service line against a rate to see if it matches.
    /// </summary>
    public async Task<MatchTestResult> TestMatchAsync(
        string serviceLineId,
        string rateId,
        RequestOptions? options = null
    )
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.JsonApiRequest
            {
                BaseUrl = _client.Options.Environment.CandidApi,
                Method = HttpMethod.Get,
                Path = $"/api/fee-schedules/v3/service-line/{serviceLineId}/match/{rateId}",
                Options = options
            }
        );
        var responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode is >= 200 and < 400)
        {
            try
            {
                return JsonUtils.Deserialize<MatchTestResult>(responseBody)!;
            }
            catch (JsonException e)
            {
                throw new CandidClientException("Failed to deserialize response", e);
            }
        }

        throw new CandidClientApiException(
            $"Error with status code {response.StatusCode}",
            response.StatusCode,
            JsonUtils.Deserialize<object>(responseBody)
        );
    }

    /// <summary>
    /// Gets a list of dimensions with their rates. The rates returned will always be the most recent versions of those rates.
    /// </summary>
    public async Task<RatesPage> GetMultiAsync(
        GetMultiRequest request,
        RequestOptions? options = null
    )
    {
        var _query = new Dictionary<string, object>() { };
        _query["states"] = request.States.Select(_value => _value.ToString()).ToList();
        _query["zip_codes"] = request.ZipCodes;
        _query["license_types"] = request.LicenseTypes.Select(_value => _value.ToString()).ToList();
        _query["facility_type_codes"] = request
            .FacilityTypeCodes.Select(_value => _value.ToString())
            .ToList();
        _query["network_types"] = request.NetworkTypes.Select(_value => _value.ToString()).ToList();
        _query["modifiers"] = request.Modifiers.Select(_value => _value.ToString()).ToList();
        if (request.PageToken != null)
        {
            _query["page_token"] = request.PageToken;
        }
        if (request.Limit != null)
        {
            _query["limit"] = request.Limit.ToString();
        }
        if (request.ActiveDate != null)
        {
            _query["active_date"] = request.ActiveDate.ToString();
        }
        if (request.PayerUuid != null)
        {
            _query["payer_uuid"] = request.PayerUuid.ToString();
        }
        if (request.OrganizationBillingProviderId != null)
        {
            _query["organization_billing_provider_id"] =
                request.OrganizationBillingProviderId.ToString();
        }
        if (request.CptCode != null)
        {
            _query["cpt_code"] = request.CptCode;
        }
        var response = await _client.MakeRequestAsync(
            new RawClient.JsonApiRequest
            {
                BaseUrl = _client.Options.Environment.CandidApi,
                Method = HttpMethod.Get,
                Path = "/api/fee-schedules/v3",
                Query = _query,
                Options = options
            }
        );
        var responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode is >= 200 and < 400)
        {
            try
            {
                return JsonUtils.Deserialize<RatesPage>(responseBody)!;
            }
            catch (JsonException e)
            {
                throw new CandidClientException("Failed to deserialize response", e);
            }
        }

        throw new CandidClientApiException(
            $"Error with status code {response.StatusCode}",
            response.StatusCode,
            JsonUtils.Deserialize<object>(responseBody)
        );
    }

    /// <summary>
    /// Gets unique values for a dimension based on other selection criteria. The response is a list of dimensions with your criteria and the unique values populated. This API is useful for driving pivots on dimension values.
    /// </summary>
    public async Task<DimensionsPage> GetUniqueValuesForDimensionAsync(
        GetUniqueDimensionValuesRequest request,
        RequestOptions? options = null
    )
    {
        var _query = new Dictionary<string, object>() { };
        _query["pivot_dimension"] = JsonSerializer.Serialize(request.PivotDimension);
        _query["states"] = request.States.Select(_value => _value.ToString()).ToList();
        _query["zip_codes"] = request.ZipCodes;
        _query["license_types"] = request.LicenseTypes.Select(_value => _value.ToString()).ToList();
        _query["facility_type_codes"] = request
            .FacilityTypeCodes.Select(_value => _value.ToString())
            .ToList();
        _query["network_types"] = request.NetworkTypes.Select(_value => _value.ToString()).ToList();
        _query["modifiers"] = request.Modifiers.Select(_value => _value.ToString()).ToList();
        if (request.PageToken != null)
        {
            _query["page_token"] = request.PageToken;
        }
        if (request.Limit != null)
        {
            _query["limit"] = request.Limit.ToString();
        }
        if (request.PayerUuid != null)
        {
            _query["payer_uuid"] = request.PayerUuid.ToString();
        }
        if (request.OrganizationBillingProviderId != null)
        {
            _query["organization_billing_provider_id"] =
                request.OrganizationBillingProviderId.ToString();
        }
        if (request.CptCode != null)
        {
            _query["cpt_code"] = request.CptCode;
        }
        var response = await _client.MakeRequestAsync(
            new RawClient.JsonApiRequest
            {
                BaseUrl = _client.Options.Environment.CandidApi,
                Method = HttpMethod.Get,
                Path = "/api/fee-schedules/v3/unique-dimension-values",
                Query = _query,
                Options = options
            }
        );
        var responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode is >= 200 and < 400)
        {
            try
            {
                return JsonUtils.Deserialize<DimensionsPage>(responseBody)!;
            }
            catch (JsonException e)
            {
                throw new CandidClientException("Failed to deserialize response", e);
            }
        }

        throw new CandidClientApiException(
            $"Error with status code {response.StatusCode}",
            response.StatusCode,
            JsonUtils.Deserialize<object>(responseBody)
        );
    }

    /// <summary>
    /// Gets every version of a rate.
    /// </summary>
    public async Task<IEnumerable<Rate>> GetRateHistoryAsync(
        string rateId,
        RequestOptions? options = null
    )
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.JsonApiRequest
            {
                BaseUrl = _client.Options.Environment.CandidApi,
                Method = HttpMethod.Get,
                Path = $"/api/fee-schedules/v3/{rateId}/history",
                Options = options
            }
        );
        var responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode is >= 200 and < 400)
        {
            try
            {
                return JsonUtils.Deserialize<IEnumerable<Rate>>(responseBody)!;
            }
            catch (JsonException e)
            {
                throw new CandidClientException("Failed to deserialize response", e);
            }
        }

        throw new CandidClientApiException(
            $"Error with status code {response.StatusCode}",
            response.StatusCode,
            JsonUtils.Deserialize<object>(responseBody)
        );
    }

    /// <summary>
    /// Uploads a new fee schedule.\n Each rate may either be totally new as qualified by it's dimensions or a new version for an existing rate.\n If adding a new version to an existing rate, the rate must be posted with the next version number (previous version + 1) or a EntityConflictError will be returned.\n Use the dry run flag to discover already existing rates and to run validations. If validations for any rate fail, no rates will be saved to the system.
    /// </summary>
    public async Task<IEnumerable<Rate>> UploadFeeScheduleAsync(
        FeeScheduleUploadRequest request,
        RequestOptions? options = null
    )
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.JsonApiRequest
            {
                BaseUrl = _client.Options.Environment.CandidApi,
                Method = HttpMethod.Post,
                Path = "/api/fee-schedules/v3",
                Body = request,
                Options = options
            }
        );
        var responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode is >= 200 and < 400)
        {
            try
            {
                return JsonUtils.Deserialize<IEnumerable<Rate>>(responseBody)!;
            }
            catch (JsonException e)
            {
                throw new CandidClientException("Failed to deserialize response", e);
            }
        }

        throw new CandidClientApiException(
            $"Error with status code {response.StatusCode}",
            response.StatusCode,
            JsonUtils.Deserialize<object>(responseBody)
        );
    }

    /// <summary>
    /// Soft deletes a rate from the system. Only the most recent version of a rate can be deleted.
    /// </summary>
    public async Task DeleteRateAsync(string rateId, int version, RequestOptions? options = null)
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.JsonApiRequest
            {
                BaseUrl = _client.Options.Environment.CandidApi,
                Method = HttpMethod.Delete,
                Path = $"/api/fee-schedules/v3/{rateId}/{version}",
                Options = options
            }
        );
        if (response.StatusCode is >= 200 and < 400)
        {
            return;
        }
        var responseBody = await response.Raw.Content.ReadAsStringAsync();
        throw new CandidClientApiException(
            $"Error with status code {response.StatusCode}",
            response.StatusCode,
            JsonUtils.Deserialize<object>(responseBody)
        );
    }

    /// <summary>
    /// Gets the default payer threshold
    /// </summary>
    public async Task<PayerThreshold> GetPayerThresholdsDefaultAsync(RequestOptions? options = null)
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.JsonApiRequest
            {
                BaseUrl = _client.Options.Environment.CandidApi,
                Method = HttpMethod.Get,
                Path = "/api/fee-schedules/v3/payer-threshold/default",
                Options = options
            }
        );
        var responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode is >= 200 and < 400)
        {
            try
            {
                return JsonUtils.Deserialize<PayerThreshold>(responseBody)!;
            }
            catch (JsonException e)
            {
                throw new CandidClientException("Failed to deserialize response", e);
            }
        }

        throw new CandidClientApiException(
            $"Error with status code {response.StatusCode}",
            response.StatusCode,
            JsonUtils.Deserialize<object>(responseBody)
        );
    }

    /// <summary>
    /// Gets a list of payers and thresholds by their uuids
    /// </summary>
    public async Task<PayerThresholdsPage> GetPayerThresholdsAsync(
        PayerThresholdGetRequest request,
        RequestOptions? options = null
    )
    {
        var _query = new Dictionary<string, object>() { };
        _query["payer_uuids"] = request.PayerUuids.Select(_value => _value.ToString()).ToList();
        var response = await _client.MakeRequestAsync(
            new RawClient.JsonApiRequest
            {
                BaseUrl = _client.Options.Environment.CandidApi,
                Method = HttpMethod.Get,
                Path = "/api/fee-schedules/v3/payer-threshold",
                Query = _query,
                Options = options
            }
        );
        var responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode is >= 200 and < 400)
        {
            try
            {
                return JsonUtils.Deserialize<PayerThresholdsPage>(responseBody)!;
            }
            catch (JsonException e)
            {
                throw new CandidClientException("Failed to deserialize response", e);
            }
        }

        throw new CandidClientApiException(
            $"Error with status code {response.StatusCode}",
            response.StatusCode,
            JsonUtils.Deserialize<object>(responseBody)
        );
    }

    /// <summary>
    /// Sets the threshold information for a payer
    /// </summary>
    public async Task<PayerThreshold> SetPayerThresholdAsync(
        string payerUuid,
        PayerThreshold request,
        RequestOptions? options = null
    )
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.JsonApiRequest
            {
                BaseUrl = _client.Options.Environment.CandidApi,
                Method = HttpMethod.Put,
                Path = $"/api/fee-schedules/v3/payer-threshold/{payerUuid}",
                Body = request,
                Options = options
            }
        );
        var responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode is >= 200 and < 400)
        {
            try
            {
                return JsonUtils.Deserialize<PayerThreshold>(responseBody)!;
            }
            catch (JsonException e)
            {
                throw new CandidClientException("Failed to deserialize response", e);
            }
        }

        throw new CandidClientApiException(
            $"Error with status code {response.StatusCode}",
            response.StatusCode,
            JsonUtils.Deserialize<object>(responseBody)
        );
    }
}
