using System.Text.Json.Serialization;
using Candid.Net.Core;

#nullable enable

namespace Candid.Net.PreEncounter.EligibilityChecks.V1;

public record EligibilityRecommendation
{
    /// <summary>
    /// The unique UUID identifier for an EligibilityRecommendation.
    /// </summary>
    [JsonPropertyName("id")]
    public required string Id { get; set; }

    [JsonPropertyName("recommendation")]
    public required object Recommendation { get; set; }

    [JsonPropertyName("patient")]
    public required EligibilityRecommendationPatientInfo Patient { get; set; }

    /// <summary>
    /// The organization that owns this object.
    /// </summary>
    [JsonPropertyName("organization_id")]
    public required string OrganizationId { get; set; }

    /// <summary>
    /// True if the object is deactivated.  Deactivated objects are not returned in search results but are returned in all other endpoints including scan.
    /// </summary>
    [JsonPropertyName("deactivated")]
    public required bool Deactivated { get; set; }

    /// <summary>
    /// The version of the object. Any update to any property of an object object will create a new version.
    /// </summary>
    [JsonPropertyName("version")]
    public required int Version { get; set; }

    [JsonPropertyName("updated_at")]
    public required DateTime UpdatedAt { get; set; }

    /// <summary>
    /// The user ID of the user who last updated the object.
    /// </summary>
    [JsonPropertyName("updating_user_id")]
    public required string UpdatingUserId { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
