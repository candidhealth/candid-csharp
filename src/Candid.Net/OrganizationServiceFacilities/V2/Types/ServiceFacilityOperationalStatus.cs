using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Candid.Net.Core;

#nullable enable

namespace Candid.Net.OrganizationServiceFacilities.V2;

[JsonConverter(typeof(EnumSerializer<ServiceFacilityOperationalStatus>))]
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
    Unoccupied,
}
