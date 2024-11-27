using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Candid.Net.Core;

#nullable enable

namespace Candid.Net.OrganizationProviders.V2;

[JsonConverter(typeof(EnumSerializer<AddressType>))]
public enum AddressType
{
    [EnumMember(Value = "DEFAULT")]
    Default,
}
