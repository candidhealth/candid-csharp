using global::Candid.Net;
using global::Candid.Net.Core;
using global::Candid.Net.Credentialing.V2;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace Candid.Net.Contracts.V3;

/// <summary>
/// A rendering provider with their credentialing spans scoped to the contract's contracting provider and payer.
/// </summary>
[Serializable]
public record ContractProviderCredentialing : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("provider")]
    public required global::Candid.Net.OrganizationProviders.V2.OrganizationProvider Provider { get; set; }

    [JsonPropertyName("credentialing_spans")]
    public IEnumerable<ProviderCredentialingSpan> CredentialingSpans { get; set; } =
        new List<ProviderCredentialingSpan>();

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
