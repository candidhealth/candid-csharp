using global::Candid.Net;
using global::Candid.Net.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace Candid.Net.PreEncounter.EligibilityChecks.V1;

/// <summary>
/// Information about the encounter for the COB check.
/// Service dates must be within the past 2 years and must not be in the future.
/// </summary>
[Serializable]
public record CobEncounter : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// The date of service. Defaults to the current date if not specified.
    /// </summary>
    [JsonPropertyName("date_of_service")]
    public string? DateOfService { get; set; }

    /// <summary>
    /// The beginning date of service. If included, end_date_of_service is also required.
    /// </summary>
    [JsonPropertyName("beginning_date_of_service")]
    public string? BeginningDateOfService { get; set; }

    /// <summary>
    /// The end date of service. If included, beginning_date_of_service is also required.
    /// </summary>
    [JsonPropertyName("end_date_of_service")]
    public string? EndDateOfService { get; set; }

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
