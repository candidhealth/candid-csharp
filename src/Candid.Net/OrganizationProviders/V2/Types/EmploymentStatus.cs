using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Candid.Net.Core;

#nullable enable

namespace Candid.Net.OrganizationProviders.V2;

[JsonConverter(typeof(StringEnumSerializer<EmploymentStatus>))]
public enum EmploymentStatus
{
    [EnumMember(Value = "ACTIVE")]
    Active,

    [EnumMember(Value = "TERMINATED")]
    Terminated,
}
