using System.Net.Http;
using System.Text.Json;
using Candid.Net.Core;

#nullable enable

namespace Candid.Net.Encounters.V4;

public class V4Client
{
    private RawClient _client;

    public V4Client(RawClient client)
    {
        _client = client;
    }

    public async Task<EncounterPage> GetAllAsync(
        GetAllEncountersRequest request,
        RequestOptions? options = null
    )
    {
        var _query = new Dictionary<string, object>() { };
        _query["tag_ids"] = request.TagIds;
        if (request.Limit != null)
        {
            _query["limit"] = request.Limit.ToString();
        }
        if (request.ClaimStatus != null)
        {
            _query["claim_status"] = JsonSerializer.Serialize(request.ClaimStatus.Value);
        }
        if (request.Sort != null)
        {
            _query["sort"] = JsonSerializer.Serialize(request.Sort.Value);
        }
        if (request.PageToken != null)
        {
            _query["page_token"] = request.PageToken;
        }
        if (request.DateOfServiceMin != null)
        {
            _query["date_of_service_min"] = request.DateOfServiceMin.ToString();
        }
        if (request.DateOfServiceMax != null)
        {
            _query["date_of_service_max"] = request.DateOfServiceMax.ToString();
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
            _query["billable_status"] = JsonSerializer.Serialize(request.BillableStatus.Value);
        }
        if (request.ResponsibleParty != null)
        {
            _query["responsible_party"] = JsonSerializer.Serialize(request.ResponsibleParty.Value);
        }
        if (request.OwnerOfNextAction != null)
        {
            _query["owner_of_next_action"] = JsonSerializer.Serialize(
                request.OwnerOfNextAction.Value
            );
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
                Options = options
            }
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
            JsonUtils.Deserialize<object>(responseBody)
        );
    }

    public async Task<Encounter> GetAsync(string encounterId, RequestOptions? options = null)
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.JsonApiRequest
            {
                BaseUrl = _client.Options.Environment.CandidApi,
                Method = HttpMethod.Get,
                Path = $"/api/encounters/v4/{encounterId}",
                Options = options
            }
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
            JsonUtils.Deserialize<object>(responseBody)
        );
    }

    public async Task<Encounter> CreateAsync(
        EncounterCreate request,
        RequestOptions? options = null
    )
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.JsonApiRequest
            {
                BaseUrl = _client.Options.Environment.CandidApi,
                Method = HttpMethod.Post,
                Path = "/api/encounters/v4",
                Body = request,
                Options = options
            }
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
            JsonUtils.Deserialize<object>(responseBody)
        );
    }

    public async Task<Encounter> UpdateAsync(
        string encounterId,
        EncounterUpdate request,
        RequestOptions? options = null
    )
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.JsonApiRequest
            {
                BaseUrl = _client.Options.Environment.CandidApi,
                Method = HttpMethodExtensions.Patch,
                Path = $"/api/encounters/v4/{encounterId}",
                Body = request,
                Options = options
            }
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
            JsonUtils.Deserialize<object>(responseBody)
        );
    }
}
