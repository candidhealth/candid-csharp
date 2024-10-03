using System.Text.Json.Serialization;
using Candid.Net.Core;

#nullable enable

namespace Candid.Net.Tasks.V3;

public record TaskAssignment
{
    [JsonPropertyName("task_assignment_id")]
    public required string TaskAssignmentId { get; set; }

    [JsonPropertyName("assignee_user_id")]
    public string? AssigneeUserId { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
