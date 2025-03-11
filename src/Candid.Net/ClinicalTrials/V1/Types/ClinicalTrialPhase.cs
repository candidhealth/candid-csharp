using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Candid.Net.Core;

#nullable enable

namespace Candid.Net.ClinicalTrials.V1;

[JsonConverter(typeof(EnumSerializer<ClinicalTrialPhase>))]
public enum ClinicalTrialPhase
{
    [EnumMember(Value = "Phase 1")]
    PhaseOne,

    [EnumMember(Value = "Phase 2")]
    PhaseTwo,

    [EnumMember(Value = "Phase 3")]
    PhaseThree,
}
