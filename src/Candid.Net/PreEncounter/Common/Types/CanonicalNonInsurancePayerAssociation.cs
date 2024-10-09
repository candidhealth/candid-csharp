using System.Text.Json.Serialization;
using Candid.Net.Core;

#nullable enable

namespace Candid.Net.PreEncounter;

public record CanonicalNonInsurancePayerAssociation
{
    [JsonPropertyName("id")]
    public required string Id { get; set; }

    [JsonPropertyName("member_id")]
    public string? MemberId { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
