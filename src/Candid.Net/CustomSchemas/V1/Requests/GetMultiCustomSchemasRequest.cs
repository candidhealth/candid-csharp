using global::Candid.Net.Core;
using global::System.Text.Json.Serialization;

namespace Candid.Net.CustomSchemas.V1;

[Serializable]
public record GetMultiCustomSchemasRequest
{
    /// <summary>
    /// Filter to a specific organization's schemas. If not provided, defaults to the requesting user's organization.
    /// </summary>
    [JsonIgnore]
    public string? OrganizationId { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
