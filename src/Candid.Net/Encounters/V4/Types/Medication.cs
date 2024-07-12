using System.Text.Json.Serialization;

#nullable enable

namespace Candid.Net.Encounters.V4;

public record Medication
{
    [JsonPropertyName("name")]
    public required string Name { get; init; }

    [JsonPropertyName("rx_cui")]
    public string? RxCui { get; init; }

    [JsonPropertyName("dosage")]
    public string? Dosage { get; init; }

    [JsonPropertyName("dosage_form")]
    public string? DosageForm { get; init; }

    [JsonPropertyName("frequency")]
    public string? Frequency { get; init; }

    [JsonPropertyName("as_needed")]
    public bool? AsNeeded { get; init; }
}
