using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Candid.Net.Core;

#nullable enable

namespace Candid.Net.ServiceLines.V2;

[JsonConverter(typeof(EnumSerializer<TestResultType>))]
public enum TestResultType
{
    [EnumMember(Value = "HEMATOCRIT")]
    Hematocrit,

    [EnumMember(Value = "HEMOGLOBIN")]
    Hemoglobin,

    [EnumMember(Value = "LDL")]
    Ldl,
}
