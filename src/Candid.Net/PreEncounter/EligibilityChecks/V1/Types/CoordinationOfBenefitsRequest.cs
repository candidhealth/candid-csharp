using System.Text.Json;
using System.Text.Json.Serialization;
using Candid.Net;
using Candid.Net.Core;

namespace Candid.Net.PreEncounter.EligibilityChecks.V1;

/// <summary>
/// An object representing the data for a coordination of benefits request.
/// </summary>
[Serializable]
public record CoordinationOfBenefitsRequest : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// The Payer ID. Each check must be for a participating health plan for which the patient has coverage.
    /// Medicare and Medicare Advantage plans are not supported.
    /// </summary>
    [JsonPropertyName("trading_partner_service_id")]
    public required string TradingPartnerServiceId { get; set; }

    [JsonPropertyName("provider")]
    public required CobProvider Provider { get; set; }

    [JsonPropertyName("subscriber")]
    public required CobSubscriber Subscriber { get; set; }

    [JsonPropertyName("dependent")]
    public CobDependent? Dependent { get; set; }

    [JsonPropertyName("encounter")]
    public required CobEncounter Encounter { get; set; }

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
