using global::Candid.Net.Core;
using global::System.Text.Json.Serialization;

namespace Candid.Net.NonInsurancePayers.V1;

[Serializable]
public record GetNonInsurancePayerRequest
{
    /// <summary>
    /// Organization context for cross-org access. If not provided, defaults to the requesting user's organization.
    /// </summary>
    [JsonIgnore]
    public string? OrganizationId { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
