using System.Text.Json.Serialization;
using Candid.Net.Core;

namespace Candid.Net.Tasks.Commons;

[JsonConverter(typeof(StringEnumSerializer<TaskType>))]
[Serializable]
public readonly record struct TaskType : IStringEnum
{
    public static readonly TaskType CustomerDataRequest = new(Values.CustomerDataRequest);

    public static readonly TaskType ClaimSubmissionRunValidationsFailure = new(
        Values.ClaimSubmissionRunValidationsFailure
    );

    public static readonly TaskType ClaimSubmissionSubmitClaimFailure = new(
        Values.ClaimSubmissionSubmitClaimFailure
    );

    public static readonly TaskType ClaimSubmissionTransformFailure = new(
        Values.ClaimSubmissionTransformFailure
    );

    public static readonly TaskType CodeClaim = new(Values.CodeClaim);

    public static readonly TaskType CodeClaimReview = new(Values.CodeClaimReview);

    public static readonly TaskType Eligibility = new(Values.Eligibility);

    public static readonly TaskType ClaimFollowUp = new(Values.ClaimFollowUp);

    public static readonly TaskType RejectionResolution = new(Values.RejectionResolution);

    public static readonly TaskType PayerConfigurationError = new(Values.PayerConfigurationError);

    public static readonly TaskType DenialResolution = new(Values.DenialResolution);

    public static readonly TaskType MissingEnrollment = new(Values.MissingEnrollment);

    public static readonly TaskType ChargeCaptureUpdate = new(Values.ChargeCaptureUpdate);

    public TaskType(string value)
    {
        Value = value;
    }

    /// <summary>
    /// The string value of the enum.
    /// </summary>
    public string Value { get; }

    /// <summary>
    /// Create a string enum with the given value.
    /// </summary>
    public static TaskType FromCustom(string value)
    {
        return new TaskType(value);
    }

    public bool Equals(string? other)
    {
        return Value.Equals(other);
    }

    /// <summary>
    /// Returns the string value of the enum.
    /// </summary>
    public override string ToString()
    {
        return Value;
    }

    public static bool operator ==(TaskType value1, string value2) => value1.Value.Equals(value2);

    public static bool operator !=(TaskType value1, string value2) => !value1.Value.Equals(value2);

    public static explicit operator string(TaskType value) => value.Value;

    public static explicit operator TaskType(string value) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string CustomerDataRequest = "CUSTOMER_DATA_REQUEST";

        public const string ClaimSubmissionRunValidationsFailure =
            "CLAIM_SUBMISSION_RUN_VALIDATIONS_FAILURE";

        public const string ClaimSubmissionSubmitClaimFailure =
            "CLAIM_SUBMISSION_SUBMIT_CLAIM_FAILURE";

        public const string ClaimSubmissionTransformFailure = "CLAIM_SUBMISSION_TRANSFORM_FAILURE";

        public const string CodeClaim = "CODE_CLAIM";

        public const string CodeClaimReview = "CODE_CLAIM_REVIEW";

        public const string Eligibility = "ELIGIBILITY";

        public const string ClaimFollowUp = "CLAIM_FOLLOW_UP";

        public const string RejectionResolution = "REJECTION_RESOLUTION";

        public const string PayerConfigurationError = "PAYER_CONFIGURATION_ERROR";

        public const string DenialResolution = "DENIAL_RESOLUTION";

        public const string MissingEnrollment = "MISSING_ENROLLMENT";

        public const string ChargeCaptureUpdate = "CHARGE_CAPTURE_UPDATE";
    }
}
