using System.Text.Json.Serialization;
using Candid.Net.Core;

#nullable enable

namespace Candid.Net.HealthCareCodeInformation.V1;

public record SetOrClearPrincipalDiagnosis
{
    [JsonPropertyName("value")]
    public PrincipalDiagnosis? Value { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
