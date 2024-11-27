using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Candid.Net.Core;

#nullable enable

namespace Candid.Net.Tasks.V3;

[JsonConverter(typeof(EnumSerializer<TaskSortOptions>))]
public enum TaskSortOptions
{
    [EnumMember(Value = "updated_at:asc")]
    UpdatedAtAsc,

    [EnumMember(Value = "updated_at:desc")]
    UpdatedAtDesc,

    [EnumMember(Value = "patient_name:asc")]
    PatientNameAsc,

    [EnumMember(Value = "patient_name:desc")]
    PatientNameDesc,

    [EnumMember(Value = "patient_external_id:asc")]
    PatientExternalIdAsc,

    [EnumMember(Value = "patient_external_id:desc")]
    PatientExternalIdDesc,

    [EnumMember(Value = "payer_name:asc")]
    PayerNameAsc,

    [EnumMember(Value = "payer_name:desc")]
    PayerNameDesc,

    [EnumMember(Value = "payer_id:asc")]
    PayerIdAsc,

    [EnumMember(Value = "payer_id:desc")]
    PayerIdDesc,

    [EnumMember(Value = "status:asc")]
    StatusAsc,

    [EnumMember(Value = "status:desc")]
    StatusDesc,

    [EnumMember(Value = "task_type:asc")]
    TaskTypeAsc,

    [EnumMember(Value = "task_type:desc")]
    TaskTypeDesc,

    [EnumMember(Value = "category:asc")]
    CategoryAsc,

    [EnumMember(Value = "category:desc")]
    CategoryDesc,

    [EnumMember(Value = "agg_updated_at:asc")]
    AggUpdatedAtAsc,

    [EnumMember(Value = "agg_updated_at:desc")]
    AggUpdatedAtDesc,

    [EnumMember(Value = "date_of_service:asc")]
    DateOfServiceAsc,

    [EnumMember(Value = "date_of_service:desc")]
    DateOfServiceDesc,

    [EnumMember(Value = "blocks_claim_submission:asc")]
    BlocksClaimSubmissionAsc,

    [EnumMember(Value = "blocks_claim_submission:desc")]
    BlocksClaimSubmissionDesc,
}
