using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Candid.Net.Core;

#nullable enable

namespace Candid.Net.Tasks.Commons;

[JsonConverter(typeof(EnumSerializer<TaskStatus>))]
public enum TaskStatus
{
    [EnumMember(Value = "finished")]
    Finished,

    [EnumMember(Value = "addressed_by_provider_group")]
    AddressedByProviderGroup,

    [EnumMember(Value = "sent_to_provider_group")]
    SentToProviderGroup,

    [EnumMember(Value = "open")]
    OpenTask,

    [EnumMember(Value = "blocked")]
    Blocked,

    [EnumMember(Value = "waiting_for_review")]
    WaitingForReview,

    [EnumMember(Value = "in_progress")]
    InProgress,
}
