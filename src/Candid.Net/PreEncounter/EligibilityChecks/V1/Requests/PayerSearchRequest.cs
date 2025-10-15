using System.Text.Json.Serialization;
using Candid.Net.Core;

namespace Candid.Net.PreEncounter.EligibilityChecks.V1;

[Serializable]
public record PayerSearchRequest
{
    [JsonIgnore]
    public int? PageSize { get; set; }

    [JsonIgnore]
    public string? PageToken { get; set; }

    [JsonIgnore]
    public string? Query { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
