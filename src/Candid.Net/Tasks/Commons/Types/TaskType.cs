using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Candid.Net.Core;
using Candid.Net.Tasks;

#nullable enable

namespace Candid.Net.Tasks;

[JsonConverter(typeof(StringEnumSerializer<TaskType>))]
public enum TaskType
{
    [EnumMember(Value = "CUSTOMER_DATA_REQUEST")]
    CustomerDataRequest,

    [EnumMember(Value = "CLAIM_SUBMISSION_RUN_VALIDATIONS_FAILURE")]
    ClaimSubmissionRunValidationsFailure,

    [EnumMember(Value = "CLAIM_SUBMISSION_SUBMIT_CLAIM_FAILURE")]
    ClaimSubmissionSubmitClaimFailure,

    [EnumMember(Value = "CLAIM_SUBMISSION_TRANSFORM_FAILURE")]
    ClaimSubmissionTransformFailure,

    [EnumMember(Value = "CODE_CLAIM")]
    CodeClaim,

    [EnumMember(Value = "CODE_CLAIM_REVIEW")]
    CodeClaimReview,

    [EnumMember(Value = "ELIGIBILITY")]
    Eligibility,

    [EnumMember(Value = "CLAIM_FOLLOW_UP")]
    ClaimFollowUp,

    [EnumMember(Value = "REJECTION_RESOLUTION")]
    RejectionResolution,

    [EnumMember(Value = "PAYER_CONFIGURATION_ERROR")]
    PayerConfigurationError,

    [EnumMember(Value = "DENIAL_RESOLUTION")]
    DenialResolution,

    [EnumMember(Value = "MISSING_ENROLLMENT")]
    MissingEnrollment
}
