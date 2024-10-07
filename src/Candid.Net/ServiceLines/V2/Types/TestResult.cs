using System.Text.Json.Serialization;
using Candid.Net.Core;

#nullable enable

namespace Candid.Net.ServiceLines.V2;

public record TestResult
{
    [JsonPropertyName("value")]
    public required double Value { get; set; }

    [JsonPropertyName("result_type")]
    public required TestResultType ResultType { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
