using System.Text.Json.Serialization;
using Candid.Net.Core;

#nullable enable

namespace Candid.Net.ServiceLines.V2;

public record TestResultOptional
{
    [JsonPropertyName("value")]
    public double? Value { get; set; }

    [JsonPropertyName("result_type")]
    public TestResultType? ResultType { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
