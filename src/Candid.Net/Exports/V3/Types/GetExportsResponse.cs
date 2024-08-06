using System.Text.Json.Serialization;

#nullable enable

namespace Candid.Net.Exports.V3;

public record GetExportsResponse
{
    /// <summary>
    /// Report name; contains date strings representing the start and end date of the export.
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    [JsonPropertyName("created_at")]
    public required DateTime CreatedAt { get; set; }

    /// <summary>
    /// Authenticated URL where a customer's report can be retrieved.
    /// </summary>
    [JsonPropertyName("authenticated_download_url")]
    public required string AuthenticatedDownloadUrl { get; set; }

    /// <summary>
    /// Expiration datetime of the authenticated URL. URLs expire after 2 minutes.
    /// </summary>
    [JsonPropertyName("authenticated_download_url_expiration")]
    public required DateTime AuthenticatedDownloadUrlExpiration { get; set; }
}
