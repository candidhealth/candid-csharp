using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Candid.Net.Core;

#nullable enable

namespace Candid.Net.PreEncounter.Patients.V1;

[JsonConverter(typeof(EnumSerializer<ReferralType>))]
public enum ReferralType
{
    [EnumMember(Value = "DIRECTED")]
    Directed,

    [EnumMember(Value = "ROTATION")]
    Rotation,

    [EnumMember(Value = "OVERNIGHT")]
    Overnight,
}
