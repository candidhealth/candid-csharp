using System.Text.Json.Serialization;
using Candid.Net.Core;

namespace Candid.Net.Payers.V3;

[Serializable]
public record GetAllPayersRequest
{
    /// <summary>
    /// Maximum number of entities per page, defaults to 100.
    /// </summary>
    [JsonIgnore]
    public int? Limit { get; set; }

    [JsonIgnore]
    public string? SearchTerm { get; set; }

    [JsonIgnore]
    public string? PageToken { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
