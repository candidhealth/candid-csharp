using System.Text.Json.Serialization;
using Candid.Net.Contracts.V2;

#nullable enable

namespace Candid.Net.Contracts.V2;

public record ContractsPage
{
    [JsonPropertyName("items")]
    public IEnumerable<Contract> Items { get; set; } = new List<Contract>();
}
