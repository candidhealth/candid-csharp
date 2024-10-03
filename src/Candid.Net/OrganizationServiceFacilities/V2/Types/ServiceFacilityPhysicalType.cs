using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Candid.Net.Core;

#nullable enable

namespace Candid.Net.OrganizationServiceFacilities.V2;

[JsonConverter(typeof(StringEnumSerializer<ServiceFacilityPhysicalType>))]
public enum ServiceFacilityPhysicalType
{
    [EnumMember(Value = "si")]
    Site,

    [EnumMember(Value = "bu")]
    Building,

    [EnumMember(Value = "wi")]
    Wing,

    [EnumMember(Value = "wa")]
    Ward,

    [EnumMember(Value = "lvl")]
    Level,

    [EnumMember(Value = "co")]
    Corridor,

    [EnumMember(Value = "ro")]
    Room,

    [EnumMember(Value = "bd")]
    Bed,

    [EnumMember(Value = "ve")]
    Vehicle,

    [EnumMember(Value = "ho")]
    House,

    [EnumMember(Value = "ca")]
    Cabinet,

    [EnumMember(Value = "rd")]
    Road,

    [EnumMember(Value = "area")]
    Area,

    [EnumMember(Value = "jdn")]
    Jurisdiction,
}
