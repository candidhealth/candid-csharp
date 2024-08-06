using System.Text.Json.Serialization;

#nullable enable

namespace Candid.Net.PreEncounter.Coverages.V1;

public record Coverage
{
    [JsonPropertyName("id")]
    public required string Id { get; set; }

    /// <summary>
    /// The organization that owns this coverage.
    /// </summary>
    [JsonPropertyName("organization_id")]
    public required string OrganizationId { get; set; }

    /// <summary>
    /// True if the coverage is deactivated. Deactivated coverages are not returned in search results but are returned in all other endpoints including scan.
    /// </summary>
    [JsonPropertyName("deactivated")]
    public required bool Deactivated { get; set; }

    /// <summary>
    /// The version of the coverage. Any update to any property of a coverage object will create a new version.
    /// </summary>
    [JsonPropertyName("version")]
    public required int Version { get; set; }

    [JsonPropertyName("updated_at")]
    public required DateTime UpdatedAt { get; set; }

    /// <summary>
    /// The user ID of the user who last updated the coverage.
    /// </summary>
    [JsonPropertyName("updating_user_id")]
    public required string UpdatingUserId { get; set; }
}
