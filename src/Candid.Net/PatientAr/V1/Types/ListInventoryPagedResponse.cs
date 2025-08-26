using System.Text.Json.Serialization;
using Candid.Net.Core;

#nullable enable

namespace Candid.Net.PatientAr.V1;

public record ListInventoryPagedResponse
{
    /// <summary>
    /// List of inventory records matching the filters
    /// </summary>
    [JsonPropertyName("records")]
    public IEnumerable<InventoryRecord> Records { get; set; } = new List<InventoryRecord>();

    /// <summary>
    /// Token for the next page of results, if available
    /// </summary>
    [JsonPropertyName("next_page_token")]
    public string? NextPageToken { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
