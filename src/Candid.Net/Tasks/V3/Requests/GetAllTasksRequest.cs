using Candid.Net.Tasks;
using Candid.Net.Tasks.V3;

#nullable enable

namespace Candid.Net.Tasks.V3;

public record GetAllTasksRequest
{
    /// <summary>
    /// Defaults to 100
    /// </summary>
    public int? Limit { get; init; }

    public string? PageToken { get; init; }

    public TaskStatus? Status { get; init; }

    public TaskType? TaskType { get; init; }

    /// <summary>
    /// Only return tasks with categories that match one in this comma-separated list.
    /// </summary>
    public string? Categories { get; init; }

    /// <summary>
    /// Only return tasks updated on or after this date-time
    /// </summary>
    public DateTime? UpdatedSince { get; init; }

    /// <summary>
    /// Only return tasks associated with this encounter
    /// </summary>
    public string? EncounterId { get; init; }

    /// <summary>
    /// Query tasks by encounter_id, claim_id, task_id, or external_id
    /// </summary>
    public string? SearchTerm { get; init; }

    /// <summary>
    /// Only return tasks assigned to this user
    /// </summary>
    public string? AssignedToId { get; init; }

    /// <summary>
    /// The minimum date of service for the linked encounter
    /// </summary>
    public DateOnly? DateOfServiceMin { get; init; }

    /// <summary>
    /// The maximum date of service for the linked encounter
    /// </summary>
    public DateOnly? DateOfServiceMax { get; init; }

    /// <summary>
    /// The NPI of the billing provider associated with the task's claim
    /// </summary>
    public string? BillingProviderNpi { get; init; }

    /// <summary>
    /// Defaults to updated_at:desc
    /// </summary>
    public TaskSortOptions? Sort { get; init; }
}
