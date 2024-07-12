using System.Text.Json.Serialization;
using Candid.Net.Tasks;

#nullable enable

namespace Candid.Net.Tasks.V3;

public record TaskUpdateV3
{
    [JsonPropertyName("status")]
    public TaskStatus? Status { get; init; }

    [JsonPropertyName("assignee_user_id")]
    public Guid? AssigneeUserId { get; init; }

    [JsonPropertyName("blocks_claim_submission")]
    public bool? BlocksClaimSubmission { get; init; }
}
