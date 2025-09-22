using Candid.Net.Core;

#nullable enable

namespace Candid.Net.Payers.V4;

public record GetAllPayersRequest
{
    /// <summary>
    /// Maximum number of entities per page, defaults to 100.
    /// </summary>
    public int? Limit { get; set; }

    public string? SearchTerm { get; set; }

    public string? PageToken { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
