using System.Text.Json;
using System.Text.Json.Serialization;
using Candid.Net;
using Candid.Net.Core;
using Candid.Net.Eras;
using Candid.Net.ServiceLines.V2;

namespace Candid.Net.Claims;

[Serializable]
public record Claim : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("claim_id")]
    public required string ClaimId { get; set; }

    [JsonPropertyName("status")]
    public required ClaimStatus Status { get; set; }

    [JsonPropertyName("clearinghouse")]
    public string? Clearinghouse { get; set; }

    [JsonPropertyName("clearinghouse_claim_id")]
    public string? ClearinghouseClaimId { get; set; }

    [JsonPropertyName("payer_claim_id")]
    public string? PayerClaimId { get; set; }

    [JsonPropertyName("clia_number")]
    public string? CliaNumber { get; set; }

    [JsonPropertyName("service_lines")]
    public IEnumerable<ServiceLine> ServiceLines { get; set; } = new List<ServiceLine>();

    [JsonPropertyName("eras")]
    public IEnumerable<Era> Eras { get; set; } = new List<Era>();

    [JsonIgnore]
    public ReadOnlyAdditionalProperties AdditionalProperties { get; private set; } = new();

    void IJsonOnDeserialized.OnDeserialized() =>
        AdditionalProperties.CopyFromExtensionData(_extensionData);

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
