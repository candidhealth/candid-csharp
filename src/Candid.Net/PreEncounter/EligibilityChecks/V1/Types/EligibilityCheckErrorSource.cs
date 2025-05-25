using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Candid.Net.Core;

#nullable enable

namespace Candid.Net.PreEncounter.EligibilityChecks.V1;

[JsonConverter(typeof(EnumSerializer<EligibilityCheckErrorSource>))]
public enum EligibilityCheckErrorSource
{
    [EnumMember(Value = "CANDID")]
    Candid,

    [EnumMember(Value = "STEDI")]
    Stedi,
}
