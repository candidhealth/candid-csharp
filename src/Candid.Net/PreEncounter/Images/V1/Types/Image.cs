using System.Text.Json.Serialization;
using Candid.Net.Core;

#nullable enable

namespace Candid.Net.PreEncounter.Images.V1;

public record Image
{
    [JsonPropertyName("id")]
    public required string Id { get; set; }

    /// <summary>
    /// A signed URL to the image.  This url can be used to upload an image to GCP storage or to read the image contents.
    /// </summary>
    [JsonPropertyName("signed_url")]
    public required string SignedUrl { get; set; }

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
    /// The version of the object.  Any update to any property of an object object will create a new version.
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

    [JsonPropertyName("file_name")]
    public required string FileName { get; set; }

    [JsonPropertyName("display_name")]
    public required string DisplayName { get; set; }

    [JsonPropertyName("file_type")]
    public required string FileType { get; set; }

    [JsonPropertyName("status")]
    public required ImageStatus Status { get; set; }

    [JsonPropertyName("coverage")]
    public CoverageAssociation? Coverage { get; set; }

    [JsonPropertyName("patient")]
    public PatientAssociation? Patient { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
