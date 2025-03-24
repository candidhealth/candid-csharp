using Candid.Net.Core;

#nullable enable

namespace Candid.Net.PreEncounter.Patients.V1;

public record SearchProvidersRequest
{
    public required string SearchCriteria { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
