using System.Text.Json.Serialization;
using Candid.Net.Core;

#nullable enable

namespace Candid.Net.ChargeCapture.V1;

public record ChargeExternalIdConflictErrorMessage
{
    [JsonPropertyName("message")]
    public string? Message { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
