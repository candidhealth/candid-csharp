using global::Candid.Net.Core;
using global::System.Text.Json.Serialization;

namespace Candid.Net.PreServiceRules.V1;

[Serializable]
public record PreServiceEncounterRunCreate
{
    /// <summary>
    /// The encounter to evaluate against the rules engine.
    /// </summary>
    [JsonPropertyName("entity")]
    public required PreServiceEncounterCreate Entity { get; set; }

    /// <summary>
    /// Identifies the set of rules to run against the encounter.
    /// </summary>
    [JsonPropertyName("pipeline_id")]
    public required string PipelineId { get; set; }

    /// <summary>
    /// IDs of disabled rules to force-enable for this run (e.g. for testing new rules).
    /// </summary>
    [JsonPropertyName("enabled_rule_ids")]
    public IEnumerable<string> EnabledRuleIds { get; set; } = new List<string>();

    /// <summary>
    /// IDs of enabled rules to force-disable for this run (e.g., to "override" or skip certain rules).
    /// </summary>
    [JsonPropertyName("disabled_rule_ids")]
    public IEnumerable<string> DisabledRuleIds { get; set; } = new List<string>();

    /// <summary>
    /// Prevents multiple rule runs from being dispatched in response to duplicate requests.
    /// </summary>
    [JsonPropertyName("idempotency_key")]
    public required string IdempotencyKey { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
