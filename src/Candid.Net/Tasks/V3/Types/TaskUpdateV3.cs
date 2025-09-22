using System.Text.Json.Serialization;
using Candid.Net.Core;
using Candid.Net.Tasks.Commons;

#nullable enable

namespace Candid.Net.Tasks.V3;

public record TaskUpdateV3
{
    [JsonPropertyName("status")]
    public TaskStatus? Status { get; set; }

    [JsonPropertyName("assignee_user_id")]
    public string? AssigneeUserId { get; set; }

    [JsonPropertyName("blocks_claim_submission")]
    public bool? BlocksClaimSubmission { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
