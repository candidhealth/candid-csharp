using System.Text.Json.Serialization;
using Candid.Net.Core;

#nullable enable

namespace Candid.Net.PreEncounter.Images.V1;

public record MutableImage
{
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
