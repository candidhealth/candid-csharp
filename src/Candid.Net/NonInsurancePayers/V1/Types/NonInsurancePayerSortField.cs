using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Candid.Net.Core;

#nullable enable

namespace Candid.Net.NonInsurancePayers.V1;

[JsonConverter(typeof(StringEnumSerializer<NonInsurancePayerSortField>))]
public enum NonInsurancePayerSortField
{
    [EnumMember(Value = "NAME")]
    Name,

    [EnumMember(Value = "CATEGORY")]
    Category,

    [EnumMember(Value = "ENABLED")]
    Enabled,

    [EnumMember(Value = "UPDATED_AT")]
    UpdatedAt,
}
