using System.Net.Http;
using System.Text.Json;
using Candid.Net.Core;
using Candid.Net.Tasks.V3;

#nullable enable

namespace Candid.Net.Tasks.V3;

public class V3Client
{
    private RawClient _client;

    public V3Client(RawClient client)
    {
        _client = client;
    }

    public async Task<TaskActions> GetActionsAsync(Guid taskId)
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.JsonApiRequest
            {
                Method = HttpMethod.Get,
                Path = $"/api/tasks/v3/{taskId}/actions"
            }
        );
        var responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode is >= 200 and < 400)
        {
            return JsonSerializer.Deserialize<TaskActions>(responseBody)!;
        }
        throw new Exception(responseBody);
    }

    public async Task<TaskPage> GetMultiAsync(GetAllTasksRequest request)
    {
        var _query = new Dictionary<string, object>() { };
        if (request.Limit != null)
        {
            _query["limit"] = request.Limit.ToString();
        }
        if (request.PageToken != null)
        {
            _query["page_token"] = request.PageToken;
        }
        if (request.Status != null)
        {
            _query["status"] = JsonSerializer.Serialize(request.Status.Value);
        }
        if (request.TaskType != null)
        {
            _query["task_type"] = JsonSerializer.Serialize(request.TaskType.Value);
        }
        if (request.Categories != null)
        {
            _query["categories"] = request.Categories;
        }
        if (request.UpdatedSince != null)
        {
            _query["updated_since"] = request.UpdatedSince.Value.ToString("o0");
        }
        if (request.EncounterId != null)
        {
            _query["encounter_id"] = request.EncounterId.ToString();
        }
        if (request.SearchTerm != null)
        {
            _query["search_term"] = request.SearchTerm;
        }
        if (request.AssignedToId != null)
        {
            _query["assigned_to_id"] = request.AssignedToId.ToString();
        }
        if (request.DateOfServiceMin != null)
        {
            _query["date_of_service_min"] = request.DateOfServiceMin.ToString();
        }
        if (request.DateOfServiceMax != null)
        {
            _query["date_of_service_max"] = request.DateOfServiceMax.ToString();
        }
        if (request.BillingProviderNpi != null)
        {
            _query["billing_provider_npi"] = request.BillingProviderNpi;
        }
        if (request.Sort != null)
        {
            _query["sort"] = JsonSerializer.Serialize(request.Sort.Value);
        }
        var response = await _client.MakeRequestAsync(
            new RawClient.JsonApiRequest
            {
                Method = HttpMethod.Get,
                Path = "/api/tasks/v3",
                Query = _query
            }
        );
        var responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode is >= 200 and < 400)
        {
            return JsonSerializer.Deserialize<TaskPage>(responseBody)!;
        }
        throw new Exception(responseBody);
    }

    public async Task<Task> GetAsync(Guid taskId)
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.JsonApiRequest
            {
                Method = HttpMethod.Get,
                Path = $"/api/tasks/v3/{taskId}"
            }
        );
        var responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode is >= 200 and < 400)
        {
            return JsonSerializer.Deserialize<Task>(responseBody)!;
        }
        throw new Exception(responseBody);
    }

    public async Task<Task> CreateAsync(TaskCreateV3 request)
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.JsonApiRequest
            {
                Method = HttpMethod.Post,
                Path = "/api/tasks/v3",
                Body = request
            }
        );
        var responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode is >= 200 and < 400)
        {
            return JsonSerializer.Deserialize<Task>(responseBody)!;
        }
        throw new Exception(responseBody);
    }

    public async Task<Task> UpdateAsync(Guid taskId, TaskUpdateV3 request)
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.JsonApiRequest
            {
                Method = HttpMethodExtensions.Patch,
                Path = $"/api/tasks/v3/{taskId}",
                Body = request
            }
        );
        var responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode is >= 200 and < 400)
        {
            return JsonSerializer.Deserialize<Task>(responseBody)!;
        }
        throw new Exception(responseBody);
    }
}
