using System.Text.Json.Serialization;
using Candid.Net.Core;

#nullable enable

namespace Candid.Net.PreEncounter.EligibilityChecks.V1;

public record EligibilityCheck
{
    [JsonPropertyName("batch_id")]
    public string? BatchId { get; set; }

    [JsonPropertyName("errors")]
    public IEnumerable<EligibilityCheckError>? Errors { get; set; }

    [JsonPropertyName("request")]
    public EligibilityRequest? Request { get; set; }

    [JsonPropertyName("response")]
    public required object Response { get; set; }

    [JsonPropertyName("parsed_response")]
    public ParsedResponse? ParsedResponse { get; set; }

    [JsonPropertyName("request_corrections")]
    public IEnumerable<RequestCorrection>? RequestCorrections { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
