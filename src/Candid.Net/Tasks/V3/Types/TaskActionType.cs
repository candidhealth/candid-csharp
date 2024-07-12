using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Candid.Net.Core;
using Candid.Net.Tasks.V3;

#nullable enable

namespace Candid.Net.Tasks.V3;

[JsonConverter(typeof(StringEnumSerializer<TaskActionType>))]
public enum TaskActionType
{
    [EnumMember(Value = "close_task")]
    CloseTask,

    [EnumMember(Value = "close_task_and_reprocess")]
    CloseTaskAndReprocess
}
