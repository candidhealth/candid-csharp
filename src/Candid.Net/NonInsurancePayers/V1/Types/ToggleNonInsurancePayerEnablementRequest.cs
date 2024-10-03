using System.Text.Json.Serialization;
using Candid.Net.Core;

#nullable enable

namespace Candid.Net.NonInsurancePayers.V1;

public record ToggleNonInsurancePayerEnablementRequest
{
    [JsonPropertyName("enabled")]
    public required bool Enabled { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
