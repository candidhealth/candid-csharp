using System.Text.Json.Serialization;
using Candid.Net.OrganizationProviders.V2;

#nullable enable

namespace Candid.Net.OrganizationProviders.V2;

public record OrganizationProvider
{
    /// <summary>
    /// Auto-generated ID set on creation
    /// </summary>
    [JsonPropertyName("organization_provider_id")]
    public required string OrganizationProviderId { get; set; }

    /// <summary>
    /// The employment status for the provider.
    /// </summary>
    [JsonPropertyName("employment_status")]
    public required EmploymentStatus EmploymentStatus { get; set; }

    /// <summary>
    /// The employment start date for the provider.
    /// </summary>
    [JsonPropertyName("employment_start_date")]
    public string? EmploymentStartDate { get; set; }

    /// <summary>
    /// The employment termination date for the provider.
    /// </summary>
    [JsonPropertyName("employment_termination_date")]
    public string? EmploymentTerminationDate { get; set; }
}
