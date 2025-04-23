using System.Text.Json.Serialization;
using Candid.Net.Core;

#nullable enable

namespace Candid.Net.Superbills.V1;

public record SuperbillResponse
{
    /// <summary>
    /// Each object represents a single Superbill for a single billing provider.
    /// </summary>
    [JsonPropertyName("superbills")]
    public IEnumerable<Superbill> Superbills { get; set; } = new List<Superbill>();

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
