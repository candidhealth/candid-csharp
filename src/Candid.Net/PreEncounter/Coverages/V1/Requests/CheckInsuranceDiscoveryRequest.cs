using global::Candid.Net.Core;
using global::System.Text.Json.Serialization;

namespace Candid.Net.PreEncounter.Coverages.V1;

[Serializable]
public record CheckInsuranceDiscoveryRequest
{
    [JsonPropertyName("patient_id")]
    public required string PatientId { get; set; }

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
