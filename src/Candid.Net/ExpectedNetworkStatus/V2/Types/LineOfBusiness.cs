using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Candid.Net.Core;

#nullable enable

namespace Candid.Net.ExpectedNetworkStatus.V2;

[JsonConverter(typeof(EnumSerializer<LineOfBusiness>))]
public enum LineOfBusiness
{
    [EnumMember(Value = "medicare")]
    Medicare,

    [EnumMember(Value = "medicaid")]
    Medicaid,

    [EnumMember(Value = "commercial")]
    Commercial,
}
