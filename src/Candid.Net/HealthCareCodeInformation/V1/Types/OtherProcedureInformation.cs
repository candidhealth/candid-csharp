using System.Text.Json;
using System.Text.Json.Serialization;
using Candid.Net;
using Candid.Net.Core;

namespace Candid.Net.HealthCareCodeInformation.V1;

/// <summary>
/// This corresponds to the BBQ or BQ code qualifier values.
/// </summary>
[Serializable]
public record OtherProcedureInformation : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("other_procedure_code_qualifier")]
    public required OtherProcedureInformationCodeQualifier OtherProcedureCodeQualifier { get; set; }

    [JsonPropertyName("other_procedure_code")]
    public required string OtherProcedureCode { get; set; }

    /// <summary>
    /// An [RFC 3339, section 5.6 datetime](https://ijmacd.github.io/rfc3339-iso8601/).
    /// For example, 2017-07-21T17:32:28Z.
    /// In practice, only the date portion of this is used for claim submission, so
    /// midnight time is fine.
    /// </summary>
    [JsonPropertyName("other_procedure_date")]
    public required DateOnly OtherProcedureDate { get; set; }

    /// <summary>
    /// The id of this health care code information if it is already stored.
    /// If this is not set, this is referring to a new health care code information to be added
    /// to the encounter.  If it is set, this refers to an update of an existing health care code
    /// information object on the encounter.
    /// </summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>
    /// The encounter_id of this health care code information if it is already stored.
    /// This will be set by the server in responses, but clients are not expected to set it.
    /// </summary>
    [JsonPropertyName("encounter_id")]
    public string? EncounterId { get; set; }

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
