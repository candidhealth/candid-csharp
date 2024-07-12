using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Candid.Net.Core;
using Candid.Net.OrganizationServiceFacilities.V2;

#nullable enable

namespace Candid.Net.OrganizationServiceFacilities.V2;

[JsonConverter(typeof(StringEnumSerializer<ServiceFacilityOperationalStatus>))]
public enum ServiceFacilityOperationalStatus
{
    [EnumMember(Value = "C")]
    Closed,

    [EnumMember(Value = "H")]
    Housekeeping,

    [EnumMember(Value = "I")]
    Isolated,

    [EnumMember(Value = "K")]
    Contaminated,

    [EnumMember(Value = "O")]
    Occupied,

    [EnumMember(Value = "U")]
    Unoccupied
}
