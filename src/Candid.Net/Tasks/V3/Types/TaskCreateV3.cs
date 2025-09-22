using System.Text.Json.Serialization;
using Candid.Net.Core;
using Candid.Net.Tasks.Commons;

#nullable enable

namespace Candid.Net.Tasks.V3;

public record TaskCreateV3
{
    [JsonPropertyName("encounter_id")]
    public required string EncounterId { get; set; }

    [JsonPropertyName("task_type")]
    public required TaskType TaskType { get; set; }

    [JsonPropertyName("description")]
    public required string Description { get; set; }

    [JsonPropertyName("blocks_claim_submission")]
    public bool? BlocksClaimSubmission { get; set; }

    [JsonPropertyName("assignee_user_id")]
    public string? AssigneeUserId { get; set; }

    [JsonPropertyName("category")]
    public TaskCategory? Category { get; set; }

    [JsonPropertyName("work_queue_id")]
    public required string WorkQueueId { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
