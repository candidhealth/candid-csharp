using System.Text.Json.Serialization;
using Candid.Net.Core;

#nullable enable

namespace Candid.Net.Diagnoses;

public record DiagnosisCreate
{
    /// <summary>
    /// Empty string not allowed.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// Typically, providers submitting claims to Candid are using ICD-10 diagnosis codes. If you are using ICD-10 codes, the primary diagnosis code listed on the claim should use the ABK code_type. If more than one diagnosis is being submitted on a claim, please use ABF for the rest of the listed diagnoses. If you are using ICD-9 diagnosis codes, use BK and BF for the principal and following diagnosis code(s) respectively.
    /// </summary>
    [JsonPropertyName("code_type")]
    public required DiagnosisTypeCode CodeType { get; set; }

    /// <summary>
    /// Empty string not allowed.
    /// Should be of the appropriate format for the provided `code_type`.
    /// Must obey the ICD-10 format if an ICD-10 code_type is provided, specifically:
    ///   - Letter
    ///   - Digit
    ///   - Digit or the letter `A` or `B`
    ///   - (Optional) Period `.`
    ///   - Up to 4 (or as few as 0) letters and digits
    /// </summary>
    [JsonPropertyName("code")]
    public required string Code { get; set; }

    /// <summary>
    /// For Institutional claims only.
    /// A "Y" indicates that the onset occurred prior to admission to the hospital.
    /// An "N" indicates that the onset did NOT occur prior to admission to the hospital.
    /// A "U" indicates that it is unknown whether the onset occurred prior to admission to the hospital or not.
    /// </summary>
    [JsonPropertyName("present_on_admission_indicator")]
    public YesNoIndicator.YesNoIndicator? PresentOnAdmissionIndicator { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
