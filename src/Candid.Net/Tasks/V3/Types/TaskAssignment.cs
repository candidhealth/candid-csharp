using System.Text.Json.Serialization;

#nullable enable

namespace Candid.Net.Tasks.V3;

public record TaskAssignment
{
    [JsonPropertyName("task_assignment_id")]
    public required string TaskAssignmentId { get; init; }

    [JsonPropertyName("assignee_user_id")]
    public string? AssigneeUserId { get; init; }
}
