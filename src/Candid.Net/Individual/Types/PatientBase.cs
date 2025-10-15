using System.Text.Json;
using System.Text.Json.Serialization;
using Candid.Net;
using Candid.Net.Commons;
using Candid.Net.Core;

namespace Candid.Net.Individual;

[Serializable]
public record PatientBase : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// The ID used to identify this individual in your system. For example, your internal patient ID or an EHR patient ID.
    /// </summary>
    [JsonPropertyName("external_id")]
    public required string ExternalId { get; set; }

    /// <summary>
    /// Box 3 on the CMS-1500 claim form or Form Locator 10 on a UB-04 claim form. The date format should be in ISO 8601 date; formatted YYYY-MM-DD (i.e. 2012-02-01)
    /// </summary>
    [JsonPropertyName("date_of_birth")]
    public required DateOnly DateOfBirth { get; set; }

    /// <summary>
    /// Box 5 on the CMS-1500 claim form or Form Locator 9 on a UB-04 claim form.
    /// </summary>
    [JsonPropertyName("address")]
    public required StreetAddressShortZip Address { get; set; }

    [JsonPropertyName("first_name")]
    public required string FirstName { get; set; }

    [JsonPropertyName("last_name")]
    public required string LastName { get; set; }

    [JsonPropertyName("gender")]
    public required Gender Gender { get; set; }

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
