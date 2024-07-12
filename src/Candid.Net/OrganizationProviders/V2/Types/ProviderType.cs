using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Candid.Net.Core;
using Candid.Net.OrganizationProviders.V2;

#nullable enable

namespace Candid.Net.OrganizationProviders.V2;

[JsonConverter(typeof(StringEnumSerializer<ProviderType>))]
public enum ProviderType
{
    [EnumMember(Value = "INDIVIDUAL")]
    Individual,

    [EnumMember(Value = "ORGANIZATION")]
    Organization
}
