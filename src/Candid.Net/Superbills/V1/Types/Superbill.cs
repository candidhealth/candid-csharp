using System.Text.Json.Serialization;
using Candid.Net.Core;

#nullable enable

namespace Candid.Net.Superbills.V1;

public record Superbill
{
    /// <summary>
    /// Primary id of the superbill.
    /// </summary>
    [JsonPropertyName("superbill_id")]
    public required string SuperbillId { get; set; }

    /// <summary>
    /// external_id of the patient.
    /// </summary>
    [JsonPropertyName("patient_external_id")]
    public required string PatientExternalId { get; set; }

    /// <summary>
    /// Authenticated URL for downloading the generated superbill file.
    /// </summary>
    [JsonPropertyName("authed_url")]
    public required string AuthedUrl { get; set; }

    /// <summary>
    /// Minimum (inclusive) date selected for this superbill.
    /// </summary>
    [JsonPropertyName("date_range_min")]
    public required DateOnly DateRangeMin { get; set; }

    /// <summary>
    /// Maximum (inclusive) date selected for this superbill.
    /// </summary>
    [JsonPropertyName("date_range_max")]
    public required DateOnly DateRangeMax { get; set; }

    /// <summary>
    /// Original filename of the superbill.
    /// </summary>
    [JsonPropertyName("file_name")]
    public required string FileName { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
