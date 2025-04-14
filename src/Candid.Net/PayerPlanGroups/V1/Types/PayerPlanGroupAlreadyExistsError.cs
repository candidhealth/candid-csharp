using System.Text.Json.Serialization;
using Candid.Net.Core;

#nullable enable

namespace Candid.Net.PayerPlanGroups.V1;

public record PayerPlanGroupAlreadyExistsError
{
    [JsonPropertyName("message")]
    public required string Message { get; set; }

    [JsonPropertyName("id")]
    public required string Id { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
