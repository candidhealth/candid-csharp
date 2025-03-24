using System.Text.Json.Serialization;
using Candid.Net.Core;

#nullable enable

namespace Candid.Net.PreEncounter.Images.V1;

public record PatientAssociation
{
    [JsonPropertyName("id")]
    public required string Id { get; set; }

    [JsonPropertyName("notes")]
    public string? Notes { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
