using System.Text.Json.Serialization;
using Candid.Net.Core;

namespace Candid.Net.PreEncounter.Patients.V1;

[Serializable]
public record SearchProvidersRequest
{
    [JsonIgnore]
    public required string SearchCriteria { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
