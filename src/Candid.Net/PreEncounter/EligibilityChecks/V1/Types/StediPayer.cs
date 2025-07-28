using System.Text.Json.Serialization;
using Candid.Net.Core;

#nullable enable

namespace Candid.Net.PreEncounter.EligibilityChecks.V1;

public record StediPayer
{
    [JsonPropertyName("stedi_id")]
    public required string StediId { get; set; }

    [JsonPropertyName("display_name")]
    public required string DisplayName { get; set; }

    [JsonPropertyName("primary_payer_id")]
    public required string PrimaryPayerId { get; set; }

    [JsonPropertyName("aliases")]
    public IEnumerable<string> Aliases { get; set; } = new List<string>();

    [JsonPropertyName("names")]
    public IEnumerable<string> Names { get; set; } = new List<string>();

    [JsonPropertyName("transaction_support")]
    public required object TransactionSupport { get; set; }

    [JsonPropertyName("employer_identification_numbers")]
    public IEnumerable<string>? EmployerIdentificationNumbers { get; set; }

    [JsonPropertyName("payer_enrollment")]
    public required object PayerEnrollment { get; set; }

    [JsonPropertyName("parent_payer_group")]
    public string? ParentPayerGroup { get; set; }

    [JsonPropertyName("coverage_types")]
    public IEnumerable<string>? CoverageTypes { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
