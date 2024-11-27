using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Candid.Net.Core;

#nullable enable

namespace Candid.Net.Encounters.V4;

[JsonConverter(typeof(EnumSerializer<BillableStatusType>))]
public enum BillableStatusType
{
    [EnumMember(Value = "BILLABLE")]
    Billable,

    [EnumMember(Value = "NOT_BILLABLE")]
    NotBillable,
}
