using Candid.Net.Core;

#nullable enable

namespace Candid.Net.PatientAr.V1;

public record GetInventoryRecordsRequest
{
    /// <summary>
    /// Timestamp to filter records since, inclusive
    /// </summary>
    public DateTime? Since { get; set; }

    /// <summary>
    /// Maximum number of records to return, default is 100
    /// </summary>
    public int? Limit { get; set; }

    public string? PageToken { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
