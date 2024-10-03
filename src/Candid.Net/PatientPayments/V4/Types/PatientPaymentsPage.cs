using System.Text.Json.Serialization;
using Candid.Net.Core;

#nullable enable

namespace Candid.Net.PatientPayments.V4;

public record PatientPaymentsPage
{
    [JsonPropertyName("items")]
    public IEnumerable<PatientPayment> Items { get; set; } = new List<PatientPayment>();

    [JsonPropertyName("prev_page_token")]
    public string? PrevPageToken { get; set; }

    [JsonPropertyName("next_page_token")]
    public string? NextPageToken { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
