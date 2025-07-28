using Candid.Net.Core;

#nullable enable

namespace Candid.Net.PreEncounter.EligibilityChecks.V1;

public record PayerSearchRequest
{
    public int? PageSize { get; set; }

    public string? PageToken { get; set; }

    public string? Query { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
