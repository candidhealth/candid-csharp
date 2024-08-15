using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Candid.Net.Core;

#nullable enable

namespace Candid.Net.ThirdPartyPayers.V1;

[JsonConverter(typeof(StringEnumSerializer<ThirdPartyPayerSortField>))]
public enum ThirdPartyPayerSortField
{
    [EnumMember(Value = "NAME")]
    Name,

    [EnumMember(Value = "CATEGORY")]
    Category,

    [EnumMember(Value = "ENABLED")]
    Enabled,

    [EnumMember(Value = "UPDATED_AT")]
    UpdatedAt
}
