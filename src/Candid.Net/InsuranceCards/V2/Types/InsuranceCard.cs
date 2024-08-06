using System.Text.Json.Serialization;

#nullable enable

namespace Candid.Net.InsuranceCards.V2;

public record InsuranceCard
{
    [JsonPropertyName("insurance_card_id")]
    public required string InsuranceCardId { get; set; }

    [JsonPropertyName("member_id")]
    public required string MemberId { get; set; }

    [JsonPropertyName("payer_name")]
    public required string PayerName { get; set; }

    [JsonPropertyName("payer_id")]
    public required string PayerId { get; set; }

    [JsonPropertyName("rx_bin")]
    public string? RxBin { get; set; }

    [JsonPropertyName("rx_pcn")]
    public string? RxPcn { get; set; }

    [JsonPropertyName("image_url_front")]
    public string? ImageUrlFront { get; set; }

    [JsonPropertyName("image_url_back")]
    public string? ImageUrlBack { get; set; }
}
