using System.Text.Json.Serialization;
using Candid.Net.Tasks;

#nullable enable

namespace Candid.Net.Tasks.V3;

public record Task
{
    [JsonPropertyName("task_id")]
    public required string TaskId { get; set; }

    [JsonPropertyName("encounter_id")]
    public required string EncounterId { get; set; }

    [JsonPropertyName("task_type")]
    public required TaskType TaskType { get; set; }

    [JsonPropertyName("description")]
    public required string Description { get; set; }

    [JsonPropertyName("blocks_claim_submission")]
    public required bool BlocksClaimSubmission { get; set; }

    [JsonPropertyName("external_id")]
    public required string ExternalId { get; set; }

    [JsonPropertyName("patient_name")]
    public required string PatientName { get; set; }

    [JsonPropertyName("patient_external_id")]
    public required string PatientExternalId { get; set; }

    [JsonPropertyName("payer_name")]
    public string? PayerName { get; set; }

    [JsonPropertyName("payer_id")]
    public string? PayerId { get; set; }

    [JsonPropertyName("status")]
    public required TaskStatus Status { get; set; }

    [JsonPropertyName("notes")]
    public IEnumerable<TaskNote> Notes { get; set; } = new List<TaskNote>();

    [JsonPropertyName("created_at")]
    public required DateTime CreatedAt { get; set; }

    /// <summary>
    /// The time of most recent update to the task only
    /// </summary>
    [JsonPropertyName("updated_at")]
    public required DateTime UpdatedAt { get; set; }

    /// <summary>
    /// The time of most recent update to the task or any of its notes
    /// </summary>
    [JsonPropertyName("agg_updated_at")]
    public required DateTime AggUpdatedAt { get; set; }

    [JsonPropertyName("date_of_service")]
    public required DateOnly DateOfService { get; set; }

    [JsonPropertyName("assignments")]
    public IEnumerable<TaskAssignment> Assignments { get; set; } = new List<TaskAssignment>();

    [JsonPropertyName("category")]
    public TaskCategory? Category { get; set; }
}
