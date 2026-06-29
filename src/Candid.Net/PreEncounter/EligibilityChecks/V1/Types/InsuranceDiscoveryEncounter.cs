using global::Candid.Net;
using global::Candid.Net.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace Candid.Net.PreEncounter.EligibilityChecks.V1;

/// <summary>
/// The date range for the service. If not specified, Stedi defaults to the current date.
/// You can specify either a single date_of_service or a beginning_date_of_service and end_date_of_service.
/// </summary>
[Serializable]
public record InsuranceDiscoveryEncounter : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// A single date of service, formatted as YYYYMMDD.
    /// </summary>
    [JsonPropertyName("date_of_service")]
    public string? DateOfService { get; set; }

    /// <summary>
    /// The beginning date of service, formatted as YYYYMMDD.
    /// </summary>
    [JsonPropertyName("beginning_date_of_service")]
    public string? BeginningDateOfService { get; set; }

    /// <summary>
    /// The end date of service, formatted as YYYYMMDD.
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
