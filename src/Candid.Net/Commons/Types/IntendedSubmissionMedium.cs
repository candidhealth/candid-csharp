using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Candid.Net.Core;

#nullable enable

namespace Candid.Net;

[JsonConverter(typeof(StringEnumSerializer<IntendedSubmissionMedium>))]
public enum IntendedSubmissionMedium
{
    [EnumMember(Value = "paper")]
    Paper,

    [EnumMember(Value = "electronic")]
    Electronic,
}
