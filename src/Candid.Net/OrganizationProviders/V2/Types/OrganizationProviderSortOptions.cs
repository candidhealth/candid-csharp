using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Candid.Net.Core;
using Candid.Net.OrganizationProviders.V2;

#nullable enable

namespace Candid.Net.OrganizationProviders.V2;

[JsonConverter(typeof(StringEnumSerializer<OrganizationProviderSortOptions>))]
public enum OrganizationProviderSortOptions
{
    [EnumMember(Value = "provider_name:asc")]
    ProviderNameAsc,

    [EnumMember(Value = "provider_name:desc")]
    ProviderNameDesc,

    [EnumMember(Value = "npi:asc")]
    NpiAsc,

    [EnumMember(Value = "npi:desc")]
    NpiDesc
}
