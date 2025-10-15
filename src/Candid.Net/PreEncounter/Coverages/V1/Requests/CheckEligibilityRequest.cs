using System.Text.Json.Serialization;
using Candid.Net.Core;

namespace Candid.Net.PreEncounter.Coverages.V1;

[Serializable]
public record CheckEligibilityRequest
{
    [JsonPropertyName("service_code")]
    public required ServiceTypeCode ServiceCode { get; set; }

    [JsonPropertyName("date_of_service")]
    public required DateOnly DateOfService { get; set; }

    [JsonPropertyName("npi")]
    public required string Npi { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
