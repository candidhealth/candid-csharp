using System.Text.Json;
using System.Text.Json.Serialization;
using Candid.Net;
using Candid.Net.Core;

namespace Candid.Net.FeeSchedules.V3;

/// <summary>
/// A rate value in cents for a specific time range.  Rate entries can be deactivated, which is set by using the deelte_rate endpoint.  Deactivated rate entries are not considered when matching against service lines.
/// </summary>
[Serializable]
public record RateEntry : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("start_date")]
    public required DateOnly StartDate { get; set; }

    [JsonPropertyName("end_date")]
    public DateOnly? EndDate { get; set; }

    [JsonPropertyName("rate_cents")]
    public required int RateCents { get; set; }

    [JsonPropertyName("is_deactivated")]
    public required bool IsDeactivated { get; set; }

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
