using System.Text.Json;
using System.Text.Json.Serialization;
using Candid.Net;
using Candid.Net.Core;

namespace Candid.Net.HealthCareCodeInformation.V1;

/// <summary>
/// This correspond to BBR, BR, and CAH code qualifier values.
/// </summary>
[Serializable]
public record PrincipalProcedureInformationNew : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("principal_procedure_code_qualifier")]
    public required PrincipalProcedureInformationCodeQualifier PrincipalProcedureCodeQualifier { get; set; }

    [JsonPropertyName("principal_procedure_code")]
    public required string PrincipalProcedureCode { get; set; }

    /// <summary>
    /// An [RFC 3339, section 5.6 datetime](https://ijmacd.github.io/rfc3339-iso8601/).
    /// For example, 2017-07-21T17:32:28Z.
    /// In practice, only the date portion of this is used for claim submission, so
    /// midnight time is fine.
    /// </summary>
    [JsonPropertyName("procedure_date")]
    public required DateTime ProcedureDate { get; set; }

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
