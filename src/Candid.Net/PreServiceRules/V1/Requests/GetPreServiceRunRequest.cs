using global::Candid.Net.Core;
using global::System.Text.Json.Serialization;

namespace Candid.Net.PreServiceRules.V1;

[Serializable]
public record GetPreServiceRunRequest
{
    /// <summary>
    /// If true, the run result includes the entity exactly as it was submitted. Default = False
    /// </summary>
    [JsonIgnore]
    public bool? IncludeInitialEntityState { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
