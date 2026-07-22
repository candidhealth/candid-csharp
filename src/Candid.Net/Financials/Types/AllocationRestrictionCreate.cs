using global::Candid.Net;
using global::Candid.Net.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace Candid.Net.Financials;

/// <summary>
/// Constrains which claims a payment's credit can be auto-allocated to. Restrictions of the same
/// restriction_type are OR'd together (any value may match); different restriction_types are AND'd
/// (every type present must match). A payment with no restrictions can be allocated to any claim.
/// </summary>
[Serializable]
public record AllocationRestrictionCreate : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("restriction_type")]
    public required AllocationRestrictionType RestrictionType { get; set; }

    /// <summary>
    /// For billing_provider_npi, the NPI. For service_facility_id, the organization service facility ID.
    /// </summary>
    [JsonPropertyName("restriction_value")]
    public required string RestrictionValue { get; set; }

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
