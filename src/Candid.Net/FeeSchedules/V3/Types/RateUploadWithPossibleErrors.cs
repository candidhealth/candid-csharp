using System.Text.Json.Serialization;
using Candid.Net.Core;

#nullable enable

namespace Candid.Net.FeeSchedules.V3;

public record RateUploadWithPossibleErrors
{
    [JsonPropertyName("rate_upload")]
    public required object RateUpload { get; set; }

    [JsonPropertyName("existing_rate")]
    public Rate? ExistingRate { get; set; }

    [JsonPropertyName("possible_errors")]
    public IEnumerable<object> PossibleErrors { get; set; } = new List<object>();

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
