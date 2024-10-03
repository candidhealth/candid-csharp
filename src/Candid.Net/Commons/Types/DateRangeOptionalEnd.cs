using System.Text.Json.Serialization;
using Candid.Net.Core;

#nullable enable

namespace Candid.Net;

public record DateRangeOptionalEnd
{
    [JsonPropertyName("start_date")]
    public required string StartDate { get; set; }

    [JsonPropertyName("end_date")]
    public string? EndDate { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
