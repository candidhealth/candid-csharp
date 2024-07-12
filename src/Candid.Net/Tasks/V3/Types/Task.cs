using System.Text.Json.Serialization;
using Candid.Net.Tasks;
using Candid.Net.Tasks.V3;

#nullable enable

namespace Candid.Net.Tasks.V3;

public record Task
{
    [JsonPropertyName("task_id")]
    public required Guid TaskId { get; init; }

    [JsonPropertyName("encounter_id")]
    public required Guid EncounterId { get; init; }

    [JsonPropertyName("task_type")]
    public required TaskType TaskType { get; init; }

    [JsonPropertyName("description")]
    public required string Description { get; init; }

    [JsonPropertyName("blocks_claim_submission")]
    public required bool BlocksClaimSubmission { get; init; }

    [JsonPropertyName("external_id")]
    public required string ExternalId { get; init; }

    [JsonPropertyName("patient_name")]
    public required string PatientName { get; init; }

    [JsonPropertyName("patient_external_id")]
    public required string PatientExternalId { get; init; }

    [JsonPropertyName("payer_name")]
    public string? PayerName { get; init; }

    [JsonPropertyName("payer_id")]
    public string? PayerId { get; init; }

    [JsonPropertyName("status")]
    public required TaskStatus Status { get; init; }

    [JsonPropertyName("notes")]
    public IEnumerable<TaskNote> Notes { get; init; } = new List<TaskNote>();

    [JsonPropertyName("created_at")]
    public required DateTime CreatedAt { get; init; }

    /// <summary>
    /// The time of most recent update to the task only
    /// </summary>
    [JsonPropertyName("updated_at")]
    public required DateTime UpdatedAt { get; init; }

    /// <summary>
    /// The time of most recent update to the task or any of its notes
    /// </summary>
    [JsonPropertyName("agg_updated_at")]
    public required DateTime AggUpdatedAt { get; init; }

    [JsonPropertyName("date_of_service")]
    public required DateOnly DateOfService { get; init; }

    [JsonPropertyName("assignments")]
    public IEnumerable<TaskAssignment> Assignments { get; init; } = new List<TaskAssignment>();

    [JsonPropertyName("category")]
    public TaskCategory? Category { get; init; }
}
