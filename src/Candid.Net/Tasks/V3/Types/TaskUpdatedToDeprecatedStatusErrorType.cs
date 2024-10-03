using System.Text.Json.Serialization;
using Candid.Net.Core;
using Candid.Net.Tasks;

#nullable enable

namespace Candid.Net.Tasks.V3;

public record TaskUpdatedToDeprecatedStatusErrorType
{
    [JsonPropertyName("deprecated_status")]
    public TaskStatus? DeprecatedStatus { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
