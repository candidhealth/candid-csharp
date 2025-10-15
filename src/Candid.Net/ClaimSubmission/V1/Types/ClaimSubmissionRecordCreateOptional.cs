using System.Text.Json;
using System.Text.Json.Serialization;
using Candid.Net;
using Candid.Net.Commons;
using Candid.Net.Core;
using Candid.Net.X12.V1;

namespace Candid.Net.ClaimSubmission.V1;

/// <summary>
/// Data about each external submission.
/// </summary>
[Serializable]
public record ClaimSubmissionRecordCreateOptional : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// When the claim was submitted to the payer.
    /// </summary>
    [JsonPropertyName("submitted_at")]
    public DateTime? SubmittedAt { get; set; }

    [JsonPropertyName("claim_frequency_code")]
    public TypeOfBillFrequencyCode? ClaimFrequencyCode { get; set; }

    [JsonPropertyName("payer_responsibility")]
    public ClaimSubmissionPayerResponsibilityType? PayerResponsibility { get; set; }

    /// <summary>
    /// The medium by which the claim was submitted to the payer: paper or electronic.
    /// If omitted, defaults to electronic.
    /// </summary>
    [JsonPropertyName("intended_submission_medium")]
    public IntendedSubmissionMedium? IntendedSubmissionMedium { get; set; }

    [JsonIgnore]
    public ReadOnlyAdditionalProperties AdditionalProperties { get; private set; } = new();

    void IJsonOnDeserialized.OnDeserialized() =>
        AdditionalProperties.CopyFromExtensionData(_extensionData);

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
