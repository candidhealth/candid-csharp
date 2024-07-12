using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Candid.Net;
using Candid.Net.Core;

#nullable enable

namespace Candid.Net;

[JsonConverter(typeof(StringEnumSerializer<SortDirection>))]
public enum SortDirection
{
    [EnumMember(Value = "asc")]
    Asc,

    [EnumMember(Value = "desc")]
    Desc
}
