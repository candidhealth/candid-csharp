using System.Text.Json.Serialization;
using Candid.Net.Tasks;

#nullable enable

namespace Candid.Net.Tasks.V3;

public record TaskCreateV3
{
    [JsonPropertyName("encounter_id")]
    public required string EncounterId { get; init; }

    [JsonPropertyName("task_type")]
    public required TaskType TaskType { get; init; }

    [JsonPropertyName("description")]
    public required string Description { get; init; }

    [JsonPropertyName("blocks_claim_submission")]
    public bool? BlocksClaimSubmission { get; init; }

    [JsonPropertyName("assignee_user_id")]
    public string? AssigneeUserId { get; init; }

    [JsonPropertyName("category")]
    public TaskCategory? Category { get; init; }

    [JsonPropertyName("work_queue_id")]
    public required string WorkQueueId { get; init; }
}
