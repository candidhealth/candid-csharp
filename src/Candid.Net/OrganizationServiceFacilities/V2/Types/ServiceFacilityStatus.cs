using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Candid.Net.Core;

#nullable enable

namespace Candid.Net.OrganizationServiceFacilities.V2;

[JsonConverter(typeof(EnumSerializer<ServiceFacilityStatus>))]
public enum ServiceFacilityStatus
{
    [EnumMember(Value = "active")]
    Active,

    [EnumMember(Value = "inactive")]
    Inactive,

    [EnumMember(Value = "suspended")]
    Suspended,
}
