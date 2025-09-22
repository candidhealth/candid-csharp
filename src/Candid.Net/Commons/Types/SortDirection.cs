using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Candid.Net.Core;

#nullable enable

namespace Candid.Net.Commons;

[JsonConverter(typeof(EnumSerializer<SortDirection>))]
public enum SortDirection
{
    [EnumMember(Value = "asc")]
    Asc,

    [EnumMember(Value = "desc")]
    Desc,
}
