using Candid.Net.Core;

#nullable enable

namespace Candid.Net.PreEncounter.Tags.V1;

public record GetAllTagsRequest
{
    public int? Limit { get; set; }

    public string? PageToken { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
