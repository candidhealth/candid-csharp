using System.Text.Json.Serialization;
using Candid.Net.Core;
using Candid.Net.Tasks.Commons;

namespace Candid.Net.Tasks.V3;

[Serializable]
public record GetAllTasksRequest
{
    /// <summary>
    /// Defaults to 100
    /// </summary>
    [JsonIgnore]
    public int? Limit { get; set; }

    [JsonIgnore]
    public string? PageToken { get; set; }

    [JsonIgnore]
    public Candid.Net.Tasks.Commons.TaskStatus? Status { get; set; }

    [JsonIgnore]
    public TaskType? TaskType { get; set; }

    /// <summary>
    /// Only return tasks with categories that match one in this comma-separated list.
    /// </summary>
    [JsonIgnore]
    public string? Categories { get; set; }

    /// <summary>
    /// Only return tasks updated on or after this date-time
    /// </summary>
    [JsonIgnore]
    public DateTime? UpdatedSince { get; set; }

    /// <summary>
    /// Only return tasks associated with this encounter
    /// </summary>
    [JsonIgnore]
    public string? EncounterId { get; set; }

    /// <summary>
    /// Query tasks by encounter_id, claim_id, task_id, or external_id
    /// </summary>
    [JsonIgnore]
    public string? SearchTerm { get; set; }

    /// <summary>
    /// Only return tasks assigned to this user
    /// </summary>
    [JsonIgnore]
    public string? AssignedToId { get; set; }

    /// <summary>
    /// The minimum date of service for the linked encounter
    /// </summary>
    [JsonIgnore]
    public DateOnly? DateOfServiceMin { get; set; }

    /// <summary>
    /// The maximum date of service for the linked encounter
    /// </summary>
    [JsonIgnore]
    public DateOnly? DateOfServiceMax { get; set; }

    /// <summary>
    /// The NPI of the billing provider associated with the task's claim
    /// </summary>
    [JsonIgnore]
    public string? BillingProviderNpi { get; set; }

    /// <summary>
    /// Defaults to updated_at:desc
    /// </summary>
    [JsonIgnore]
    public TaskSortOptions? Sort { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
