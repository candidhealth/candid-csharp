using Candid.Net.Core;

#nullable enable

namespace Candid.Net.PreEncounter.Coverages.V1;

public record CoverageGetMultiRequest
{
    public string? PatientId { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
