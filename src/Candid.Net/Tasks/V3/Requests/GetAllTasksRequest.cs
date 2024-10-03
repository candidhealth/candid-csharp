using Candid.Net.Core;
using Candid.Net.Tasks;

#nullable enable

namespace Candid.Net.Tasks.V3;

public record GetAllTasksRequest
{
    /// <summary>
    /// Defaults to 100
    /// </summary>
    public int? Limit { get; set; }

    public string? PageToken { get; set; }

    public TaskStatus? Status { get; set; }

    public TaskType? TaskType { get; set; }

    /// <summary>
    /// Only return tasks with categories that match one in this comma-separated list.
    /// </summary>
    public string? Categories { get; set; }

    /// <summary>
    /// Only return tasks updated on or after this date-time
    /// </summary>
    public DateTime? UpdatedSince { get; set; }

    /// <summary>
    /// Only return tasks associated with this encounter
    /// </summary>
    public string? EncounterId { get; set; }

    /// <summary>
    /// Query tasks by encounter_id, claim_id, task_id, or external_id
    /// </summary>
    public string? SearchTerm { get; set; }

    /// <summary>
    /// Only return tasks assigned to this user
    /// </summary>
    public string? AssignedToId { get; set; }

    /// <summary>
    /// The minimum date of service for the linked encounter
    /// </summary>
    public DateOnly? DateOfServiceMin { get; set; }

    /// <summary>
    /// The maximum date of service for the linked encounter
    /// </summary>
    public DateOnly? DateOfServiceMax { get; set; }

    /// <summary>
    /// The NPI of the billing provider associated with the task's claim
    /// </summary>
    public string? BillingProviderNpi { get; set; }

    /// <summary>
    /// Defaults to updated_at:desc
    /// </summary>
    public TaskSortOptions? Sort { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
