using System.Text.Json.Serialization;
using Candid.Net.Core;

#nullable enable

namespace Candid.Net.ClaimSubmission.V1;

public record ExternalClaimSubmissionCreateOptional
{
    /// <summary>
    /// When the claim was created in the external system.
    /// </summary>
    [JsonPropertyName("claim_created_at")]
    public DateTime? ClaimCreatedAt { get; set; }

    /// <summary>
    /// The Patient Control Number sent on the claim to the payer. To guarantee compatibility with all payers, this field must consist
    /// only of uppercase letters and numbers and be no more than 14 characters long.
    /// </summary>
    [JsonPropertyName("patient_control_number")]
    public string? PatientControlNumber { get; set; }

    /// <summary>
    /// A successful claim submission record will be created for each value provided.
    /// An empty list may be provided for cases where the claim originated in an external system but was never submitted to a payer.
    /// </summary>
    [JsonPropertyName("submission_records")]
    public IEnumerable<ClaimSubmissionRecordCreateOptional> SubmissionRecords { get; set; } =
        new List<ClaimSubmissionRecordCreateOptional>();

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
