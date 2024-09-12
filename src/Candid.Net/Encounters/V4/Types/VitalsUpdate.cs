using System.Text.Json.Serialization;

#nullable enable

namespace Candid.Net.Encounters.V4;

public record VitalsUpdate
{
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
}
