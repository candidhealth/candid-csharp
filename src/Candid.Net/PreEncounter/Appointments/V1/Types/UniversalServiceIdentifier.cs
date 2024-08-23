using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Candid.Net.Core;

#nullable enable

namespace Candid.Net.PreEncounter.Appointments.V1;

[JsonConverter(typeof(StringEnumSerializer<UniversalServiceIdentifier>))]
public enum UniversalServiceIdentifier
{
    [EnumMember(Value = "MD_Visit")]
    MdVisit,

    [EnumMember(Value = "Treatment")]
    Treatment,

    [EnumMember(Value = "Tests")]
    Tests,

    [EnumMember(Value = "Activity")]
    Activity
}
