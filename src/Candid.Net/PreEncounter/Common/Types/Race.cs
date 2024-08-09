using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Candid.Net.Core;

#nullable enable

namespace Candid.Net.PreEncounter;

[JsonConverter(typeof(StringEnumSerializer<Race>))]
public enum Race
{
    [EnumMember(Value = "AMERICAN_INDIAN_OR_ALASKA_NATIVE")]
    AmericanIndianOrAlaskaNative,

    [EnumMember(Value = "WHITE")]
    White,

    [EnumMember(Value = "BLACK")]
    Black,

    [EnumMember(Value = "ASIAN")]
    Asian,

    [EnumMember(Value = "NATIVE_HAWAIIAN_OR_OTHER_PACIFIC_ISLANDER")]
    NativeHawaiianOrOtherPacificIslander,

    [EnumMember(Value = "MIDDLE_EASTERN_OR_NORTH_AFRICAN")]
    MiddleEasternOrNorthAfrican,

    [EnumMember(Value = "OTHER")]
    Other,

    [EnumMember(Value = "UNKNOWN")]
    Unknown,

    [EnumMember(Value = "REFUSED")]
    Refused
}
