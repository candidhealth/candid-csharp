using System.Text.Json.Serialization;
using Candid.Net.Core;
using Candid.Net.CustomSchemas.V1;

namespace Candid.Net.ChargeCapture.V1;

[Serializable]
public record FindByMetadataRequest
{
    /// <summary>
    /// Filter by metadata schema instances. This will return all charge captures
    /// that match any of the provided schema instances.
    /// </summary>
    [JsonPropertyName("metadata")]
    public IEnumerable<SchemaInstance> Metadata { get; set; } = new List<SchemaInstance>();

    /// <summary>
    /// Maximum number of entities per page, defaults to 100.
    /// </summary>
    [JsonPropertyName("limit")]
    public int? Limit { get; set; }

    [JsonPropertyName("page_token")]
    public string? PageToken { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
