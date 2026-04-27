using System.Text.Json.Serialization;
using Candid.Net.Core;

namespace Candid.Net.PreEncounter.OrganizationExternalProviders.V1;

[Serializable]
public record OrganizationExternalProviderGetMultiRequest
{
    [JsonIgnore]
    public int? Limit { get; set; }

    [JsonIgnore]
    public string? PageToken { get; set; }

    /// <summary>
    /// Defaults to name.family.
    /// </summary>
    [JsonIgnore]
    public string? SortField { get; set; }

    /// <summary>
    /// Defaults to ascending.
    /// </summary>
    [JsonIgnore]
    public global::Candid.Net.PreEncounter.Common.SortDirection? SortDirection { get; set; }

    [JsonIgnore]
    public string? Npi { get; set; }

    [JsonIgnore]
    public OrganizationExternalProviderType? Type { get; set; }

    [JsonIgnore]
    public string? FirstName { get; set; }

    [JsonIgnore]
    public string? LastName { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
