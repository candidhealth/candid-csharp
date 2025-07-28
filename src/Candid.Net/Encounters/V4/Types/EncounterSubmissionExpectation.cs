using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Candid.Net.Core;

#nullable enable

namespace Candid.Net.Encounters.V4;

[JsonConverter(typeof(EnumSerializer<EncounterSubmissionExpectation>))]
public enum EncounterSubmissionExpectation
{
    [EnumMember(Value = "TARGET_PROFESSIONAL")]
    TargetProfessional,

    [EnumMember(Value = "TARGET_INSTITUTIONAL")]
    TargetInstitutional,
}
