using System.Text.Json.Serialization;

#nullable enable

namespace Candid.Net.PreEncounter.Patients.V1;

public record PatientPage
{
    [JsonPropertyName("items")]
    public IEnumerable<Patient> Items { get; set; } = new List<Patient>();

    [JsonPropertyName("next_page_token")]
    public string? NextPageToken { get; set; }

    [JsonPropertyName("prev_page_token")]
    public string? PrevPageToken { get; set; }
}