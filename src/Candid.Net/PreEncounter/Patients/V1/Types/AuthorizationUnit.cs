using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Candid.Net.Core;

#nullable enable

namespace Candid.Net.PreEncounter.Patients.V1;

[JsonConverter(typeof(EnumSerializer<AuthorizationUnit>))]
public enum AuthorizationUnit
{
    [EnumMember(Value = "VISIT")]
    Visit,

    [EnumMember(Value = "UNIT")]
    Unit,
}
