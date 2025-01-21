using System.Text.Json.Serialization;
using Candid.Net.Core;

#nullable enable

namespace Candid.Net.PreEncounter.Coverages.V1;

public record CoverageValue
{
    [JsonPropertyName("family")]
    public double? Family { get; set; }

    [JsonPropertyName("individual")]
    public double? Individual { get; set; }

    [JsonPropertyName("employeeAndSpouse")]
    public double? EmployeeAndSpouse { get; set; }

    [JsonPropertyName("employeeAndChildren")]
    public double? EmployeeAndChildren { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
