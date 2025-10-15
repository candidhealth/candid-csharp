using System.Text.Json;
using System.Text.Json.Serialization;
using Candid.Net;
using Candid.Net.Core;

namespace Candid.Net.ExpectedNetworkStatus.V2;

[Serializable]
public record InsuranceType : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// The line of business associated with the patient’s insurance
    /// </summary>
    [JsonPropertyName("line_of_business")]
    public required LineOfBusiness LineOfBusiness { get; set; }

    [JsonPropertyName("insurance_type_codes")]
    public required InsuranceTypeCodes InsuranceTypeCodes { get; set; }

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
