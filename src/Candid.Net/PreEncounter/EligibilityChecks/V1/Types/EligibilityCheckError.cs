using System.Text.Json.Serialization;
using Candid.Net.Core;

#nullable enable

namespace Candid.Net.PreEncounter.EligibilityChecks.V1;

public record EligibilityCheckError
{
    [JsonPropertyName("source")]
    public required EligibilityCheckErrorSource Source { get; set; }

    [JsonPropertyName("errorDetails")]
    public required EligibilityCheckErrorDetails ErrorDetails { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
