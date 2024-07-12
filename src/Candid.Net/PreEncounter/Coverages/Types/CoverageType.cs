using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Candid.Net.Core;
using Candid.Net.PreEncounter;

#nullable enable

namespace Candid.Net.PreEncounter;

[JsonConverter(typeof(StringEnumSerializer<CoverageType>))]
public enum CoverageType
{
    [EnumMember(Value = "PPO")]
    Ppo,

    [EnumMember(Value = "HMO")]
    Hmo
}
