using System.Text.Json;
using System.Text.Json.Serialization;
using Candid.Net;
using Candid.Net.Core;

namespace Candid.Net.Encounters.V4;

[Serializable]
public record VitalsUpdate : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("height_in")]
    public int? HeightIn { get; set; }

    [JsonPropertyName("weight_lbs")]
    public int? WeightLbs { get; set; }

    [JsonPropertyName("blood_pressure_systolic_mmhg")]
    public int? BloodPressureSystolicMmhg { get; set; }

    [JsonPropertyName("blood_pressure_diastolic_mmhg")]
    public int? BloodPressureDiastolicMmhg { get; set; }

    [JsonPropertyName("body_temperature_f")]
    public double? BodyTemperatureF { get; set; }

    [JsonPropertyName("hemoglobin_gdl")]
    public double? HemoglobinGdl { get; set; }

    [JsonPropertyName("hematocrit_pct")]
    public double? HematocritPct { get; set; }

    [JsonIgnore]
    public ReadOnlyAdditionalProperties AdditionalProperties { get; private set; } = new();

    void IJsonOnDeserialized.OnDeserialized() =>
        AdditionalProperties.CopyFromExtensionData(_extensionData);

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
