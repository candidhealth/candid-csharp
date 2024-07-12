using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Candid.Net.Core;
using Candid.Net.Encounters.V4;

#nullable enable

namespace Candid.Net.Encounters.V4;

[JsonConverter(typeof(StringEnumSerializer<BillableStatusType>))]
public enum BillableStatusType
{
    [EnumMember(Value = "BILLABLE")]
    Billable,

    [EnumMember(Value = "NOT_BILLABLE")]
    NotBillable
}
