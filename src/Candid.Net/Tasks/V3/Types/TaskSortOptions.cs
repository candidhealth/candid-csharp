using System.Text.Json.Serialization;
using Candid.Net.Core;

namespace Candid.Net.Tasks.V3;

[JsonConverter(typeof(StringEnumSerializer<TaskSortOptions>))]
[Serializable]
public readonly record struct TaskSortOptions : IStringEnum
{
    public static readonly TaskSortOptions UpdatedAtAsc = new(Values.UpdatedAtAsc);

    public static readonly TaskSortOptions UpdatedAtDesc = new(Values.UpdatedAtDesc);

    public static readonly TaskSortOptions PatientNameAsc = new(Values.PatientNameAsc);

    public static readonly TaskSortOptions PatientNameDesc = new(Values.PatientNameDesc);

    public static readonly TaskSortOptions PatientExternalIdAsc = new(Values.PatientExternalIdAsc);

    public static readonly TaskSortOptions PatientExternalIdDesc = new(
        Values.PatientExternalIdDesc
    );

    public static readonly TaskSortOptions PayerNameAsc = new(Values.PayerNameAsc);

    public static readonly TaskSortOptions PayerNameDesc = new(Values.PayerNameDesc);

    public static readonly TaskSortOptions PayerIdAsc = new(Values.PayerIdAsc);

    public static readonly TaskSortOptions PayerIdDesc = new(Values.PayerIdDesc);

    public static readonly TaskSortOptions StatusAsc = new(Values.StatusAsc);

    public static readonly TaskSortOptions StatusDesc = new(Values.StatusDesc);

    public static readonly TaskSortOptions TaskTypeAsc = new(Values.TaskTypeAsc);

    public static readonly TaskSortOptions TaskTypeDesc = new(Values.TaskTypeDesc);

    public static readonly TaskSortOptions CategoryAsc = new(Values.CategoryAsc);

    public static readonly TaskSortOptions CategoryDesc = new(Values.CategoryDesc);

    public static readonly TaskSortOptions AggUpdatedAtAsc = new(Values.AggUpdatedAtAsc);

    public static readonly TaskSortOptions AggUpdatedAtDesc = new(Values.AggUpdatedAtDesc);

    public static readonly TaskSortOptions DateOfServiceAsc = new(Values.DateOfServiceAsc);

    public static readonly TaskSortOptions DateOfServiceDesc = new(Values.DateOfServiceDesc);

    public static readonly TaskSortOptions BlocksClaimSubmissionAsc = new(
        Values.BlocksClaimSubmissionAsc
    );

    public static readonly TaskSortOptions BlocksClaimSubmissionDesc = new(
        Values.BlocksClaimSubmissionDesc
    );

    public TaskSortOptions(string value)
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
    public static TaskSortOptions FromCustom(string value)
    {
        return new TaskSortOptions(value);
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

    public static bool operator ==(TaskSortOptions value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(TaskSortOptions value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(TaskSortOptions value) => value.Value;

    public static explicit operator TaskSortOptions(string value) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string UpdatedAtAsc = "updated_at:asc";

        public const string UpdatedAtDesc = "updated_at:desc";

        public const string PatientNameAsc = "patient_name:asc";

        public const string PatientNameDesc = "patient_name:desc";

        public const string PatientExternalIdAsc = "patient_external_id:asc";

        public const string PatientExternalIdDesc = "patient_external_id:desc";

        public const string PayerNameAsc = "payer_name:asc";

        public const string PayerNameDesc = "payer_name:desc";

        public const string PayerIdAsc = "payer_id:asc";

        public const string PayerIdDesc = "payer_id:desc";

        public const string StatusAsc = "status:asc";

        public const string StatusDesc = "status:desc";

        public const string TaskTypeAsc = "task_type:asc";

        public const string TaskTypeDesc = "task_type:desc";

        public const string CategoryAsc = "category:asc";

        public const string CategoryDesc = "category:desc";

        public const string AggUpdatedAtAsc = "agg_updated_at:asc";

        public const string AggUpdatedAtDesc = "agg_updated_at:desc";

        public const string DateOfServiceAsc = "date_of_service:asc";

        public const string DateOfServiceDesc = "date_of_service:desc";

        public const string BlocksClaimSubmissionAsc = "blocks_claim_submission:asc";

        public const string BlocksClaimSubmissionDesc = "blocks_claim_submission:desc";
    }
}
