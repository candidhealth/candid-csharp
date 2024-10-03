using System.Text.Json.Serialization;
using Candid.Net.Core;

#nullable enable

namespace Candid.Net.PreEncounter.Patients.V1;

public record ExternalProvenance
{
    [JsonPropertyName("external_id")]
    public required string ExternalId { get; set; }

    [JsonPropertyName("system_name")]
    public required string SystemName { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
