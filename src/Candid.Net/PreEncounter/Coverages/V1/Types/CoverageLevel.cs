using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Candid.Net.Core;

#nullable enable

namespace Candid.Net.PreEncounter.Coverages.V1;

[JsonConverter(typeof(EnumSerializer<CoverageLevel>))]
public enum CoverageLevel
{
    [EnumMember(Value = "EMPLOYEE_AND_CHILDREN")]
    EmployeeAndChildren,

    [EnumMember(Value = "EMPLOYEE_ONLY")]
    EmployeeOnly,

    [EnumMember(Value = "EMPLOYEE_AND_SPOUSE")]
    EmployeeAndSpouse,

    [EnumMember(Value = "FAMILY")]
    Family,

    [EnumMember(Value = "INDIVIDUAL")]
    Individual,
}
