using System.Text.Json.Serialization;
using Candid.Net.Core;

namespace Candid.Net.PatientAr.V1;

[Serializable]
public record GetInventoryRecordsRequest
{
    /// <summary>
    /// Timestamp to filter records since, inclusive
    /// </summary>
    [JsonIgnore]
    public DateTime? Since { get; set; }

    /// <summary>
    /// Maximum number of records to return, default is 100
    /// </summary>
    [JsonIgnore]
    public int? Limit { get; set; }

    [JsonIgnore]
    public string? PageToken { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
