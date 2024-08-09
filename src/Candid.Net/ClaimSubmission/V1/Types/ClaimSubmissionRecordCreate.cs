using System.Text.Json.Serialization;
using Candid.Net;

#nullable enable

namespace Candid.Net.ClaimSubmission.V1;

public record ClaimSubmissionRecordCreate
{
    /// <summary>
    /// When the claim was submitted to the payer.
    /// </summary>
    [JsonPropertyName("submitted_at")]
    public required DateTime SubmittedAt { get; set; }

    [JsonPropertyName("claim_frequency_code")]
    public ClaimFrequencyTypeCode? ClaimFrequencyCode { get; set; }

    [JsonPropertyName("payer_responsibility")]
    public ClaimSubmissionPayerResponsibilityType? PayerResponsibility { get; set; }

    /// <summary>
    /// The medium by which the claim was submitted to the payer: paper or electronic.
    /// If omitted, defaults to electronic.
    /// </summary>
    [JsonPropertyName("intended_submission_medium")]
    public IntendedSubmissionMedium? IntendedSubmissionMedium { get; set; }
}
