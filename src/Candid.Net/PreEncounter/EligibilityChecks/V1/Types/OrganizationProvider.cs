using System.Text.Json.Serialization;
using Candid.Net.Core;

#nullable enable

namespace Candid.Net.PreEncounter.EligibilityChecks.V1;

public record OrganizationProvider
{
    [JsonPropertyName("organization_name")]
    public string? OrganizationName { get; set; }

    [JsonPropertyName("npi")]
    public required string Npi { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
