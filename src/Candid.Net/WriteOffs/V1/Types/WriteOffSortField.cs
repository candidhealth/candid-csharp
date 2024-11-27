using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Candid.Net.Core;

#nullable enable

namespace Candid.Net.WriteOffs.V1;

[JsonConverter(typeof(EnumSerializer<WriteOffSortField>))]
public enum WriteOffSortField
{
    [EnumMember(Value = "amount_cents")]
    AmountCents,

    [EnumMember(Value = "write_off_timestamp")]
    WriteOffTimestamp,

    [EnumMember(Value = "write_off_note")]
    WriteOffNote,
}
