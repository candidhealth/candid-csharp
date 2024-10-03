using System.Text.Json.Serialization;
using Candid.Net.Core;

#nullable enable

namespace Candid.Net.PreEncounter.Coverages.V1;

public record PlanDate
{
    [JsonPropertyName("start_date")]
    public required DateOnly StartDate { get; set; }

    [JsonPropertyName("end_date")]
    public DateOnly? EndDate { get; set; }

    [JsonPropertyName("field_name")]
    public required string FieldName { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
