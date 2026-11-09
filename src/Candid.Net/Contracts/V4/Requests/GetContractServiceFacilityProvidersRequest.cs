using global::Candid.Net.Core;
using global::System.Text.Json.Serialization;

namespace Candid.Net.Contracts.V4;

[Serializable]
public record GetContractServiceFacilityProvidersRequest
{
    [JsonIgnore]
    public string? SearchTerm { get; set; }

    [JsonIgnore]
    public string? PageToken { get; set; }

    /// <summary>
    /// Max number of providers returned per page. Defaults to 100. Max is 1000.
    /// </summary>
    [JsonIgnore]
    public int? Limit { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
