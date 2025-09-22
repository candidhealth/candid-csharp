using Candid.Net.Core;

#nullable enable

namespace Candid.Net.Encounters.V4;

public record EncounterRenderingOrAttendingProviderRequiredError
{
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
