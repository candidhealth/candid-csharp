using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Candid.Net.Core;

#nullable enable

namespace Candid.Net;

[JsonConverter(typeof(EnumSerializer<PhoneNumberType>))]
public enum PhoneNumberType
{
    [EnumMember(Value = "Home")]
    Home,

    [EnumMember(Value = "Mobile")]
    Mobile,

    [EnumMember(Value = "Work")]
    Work,
}
