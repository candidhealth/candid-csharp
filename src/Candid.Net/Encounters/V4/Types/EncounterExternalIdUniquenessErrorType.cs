using System.Text.Json.Serialization;
using Candid.Net.Core;

#nullable enable

namespace Candid.Net.Encounters.V4;

public record EncounterExternalIdUniquenessErrorType
{
    [JsonPropertyName("external_id")]
    public string? ExternalId { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
