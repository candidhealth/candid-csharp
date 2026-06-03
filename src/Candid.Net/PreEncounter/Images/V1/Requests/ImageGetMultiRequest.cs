using System.Text.Json.Serialization;
using Candid.Net.Core;

namespace Candid.Net.PreEncounter.Images.V1;

[Serializable]
public record ImageGetMultiRequest
{
    [JsonIgnore]
    public string? PatientId { get; set; }

    [JsonIgnore]
    public string? CoverageId { get; set; }

    [JsonIgnore]
    public string? FileType { get; set; }

    [JsonIgnore]
    public string? PatientNotes { get; set; }

    /// <summary>
    /// The field to order by. Defaults to updatedAt.
    /// </summary>
    [JsonIgnore]
    public ImageSortField? SortField { get; set; }

    /// <summary>
    /// The direction to order by. Defaults to desc.
    /// </summary>
    [JsonIgnore]
    public global::Candid.Net.PreEncounter.Common.SortDirection? SortDirection { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
