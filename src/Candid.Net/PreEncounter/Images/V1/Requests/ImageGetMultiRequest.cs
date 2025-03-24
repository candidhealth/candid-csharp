using Candid.Net.Core;

#nullable enable

namespace Candid.Net.PreEncounter.Images.V1;

public record ImageGetMultiRequest
{
    public string? PatientId { get; set; }

    public string? CoverageId { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
