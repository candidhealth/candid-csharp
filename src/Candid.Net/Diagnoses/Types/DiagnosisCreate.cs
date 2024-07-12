using System.Text.Json.Serialization;
using Candid.Net;

#nullable enable

namespace Candid.Net;

public record DiagnosisCreate
{
    /// <summary>
    /// Empty string not allowed.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; init; }

    /// <summary>
    /// Typically, providers submitting claims to Candid are using ICD-10 diagnosis codes. If you are using ICD-10 codes, the primary diagnosis code listed on the claim should use the ABK code_type. If more than one diagnosis is being submitted on a claim, please use ABF for the rest of the listed diagnoses. If you are using ICD-9 diagnosis codes, use BK and BF for the principal and following diagnosis code(s) respectively.
    /// </summary>
    [JsonPropertyName("code_type")]
    public required DiagnosisTypeCode CodeType { get; init; }

    /// <summary>
    /// Empty string not allowed.
    /// Should be of the appropriate format for the provided `code_type`.
    /// Must obey the ICD-10 format if an ICD-10 code_type is provided, specifically:
    ///
    /// - Letter
    /// - Digit
    /// - Digit or the letter `A` or `B`
    /// - (Optional) Period `.`
    /// - Up to 4 (or as few as 0) letters and digits
    /// </summary>
    [JsonPropertyName("code")]
    public required string Code { get; init; }
}
