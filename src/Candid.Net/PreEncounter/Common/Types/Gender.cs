using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Candid.Net.Core;

#nullable enable

namespace Candid.Net.PreEncounter;

[JsonConverter(typeof(EnumSerializer<Gender>))]
public enum Gender
{
    [EnumMember(Value = "MAN")]
    Man,

    [EnumMember(Value = "WOMAN")]
    Woman,

    [EnumMember(Value = "NON_BINARY")]
    NonBinary,

    [EnumMember(Value = "TWO_SPIRIT")]
    TwoSpirit,

    [EnumMember(Value = "FEMALE_TO_MALE")]
    FemaleToMale,

    [EnumMember(Value = "MALE_TO_FEMALE")]
    MaleToFemale,

    [EnumMember(Value = "OTHER")]
    Other,

    [EnumMember(Value = "UNKNOWN")]
    Unknown,

    [EnumMember(Value = "REFUSED")]
    Refused,
}
