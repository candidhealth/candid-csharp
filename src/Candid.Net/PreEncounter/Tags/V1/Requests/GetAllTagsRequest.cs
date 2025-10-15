using System.Text.Json.Serialization;
using Candid.Net.Core;

namespace Candid.Net.PreEncounter.Tags.V1;

[Serializable]
public record GetAllTagsRequest
{
    [JsonIgnore]
    public int? Limit { get; set; }

    [JsonIgnore]
    public string? PageToken { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
