using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Candid.Net.Core;
using Candid.Net.OrganizationServiceFacilities.V2;

#nullable enable

namespace Candid.Net.OrganizationServiceFacilities.V2;

[JsonConverter(typeof(StringEnumSerializer<ServiceFacilityMode>))]
public enum ServiceFacilityMode
{
    [EnumMember(Value = "instance")]
    Instance,

    [EnumMember(Value = "kind")]
    Kind
}
