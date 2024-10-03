using System.Text.Json.Serialization;
using Candid.Net.Core;

#nullable enable

namespace Candid.Net.Encounters.V4;

public record Medication
{
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    [JsonPropertyName("rx_cui")]
    public string? RxCui { get; set; }

    [JsonPropertyName("dosage")]
    public string? Dosage { get; set; }

    [JsonPropertyName("dosage_form")]
    public string? DosageForm { get; set; }

    [JsonPropertyName("frequency")]
    public string? Frequency { get; set; }

    [JsonPropertyName("as_needed")]
    public bool? AsNeeded { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
