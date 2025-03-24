using System.Text.Json.Serialization;
using Candid.Net.Core;
using Candid.Net.PreEncounter;

#nullable enable

namespace Candid.Net.PreEncounter.Patients.V1;

public record Authorization
{
    [JsonPropertyName("payer_id")]
    public required string PayerId { get; set; }

    [JsonPropertyName("payer_name")]
    public required string PayerName { get; set; }

    [JsonPropertyName("additional_payer_information")]
    public AdditionalPayerInformation? AdditionalPayerInformation { get; set; }

    [JsonPropertyName("authorization_number")]
    public required string AuthorizationNumber { get; set; }

    [JsonPropertyName("cpt_code")]
    public required string CptCode { get; set; }

    /// <summary>
    /// If true, then the authorization will apply for all claims for the payer that fall in range the `period`.
    /// </summary>
    [JsonPropertyName("apply_for_all_cpt_codes")]
    public bool? ApplyForAllCptCodes { get; set; }

    [JsonPropertyName("units")]
    public required AuthorizationUnit Units { get; set; }

    [JsonPropertyName("quantity")]
    public int? Quantity { get; set; }

    [JsonPropertyName("period")]
    public Period? Period { get; set; }

    [JsonPropertyName("notes")]
    public string? Notes { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
