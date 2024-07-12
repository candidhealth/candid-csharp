using System.Text.Json.Serialization;

#nullable enable

namespace Candid.Net.Encounters.V4;

public record Vitals
{
    [JsonPropertyName("height_in")]
    public int? HeightIn { get; init; }

    [JsonPropertyName("weight_lbs")]
    public int? WeightLbs { get; init; }

    [JsonPropertyName("blood_pressure_systolic_mmhg")]
    public int? BloodPressureSystolicMmhg { get; init; }

    [JsonPropertyName("blood_pressure_diastolic_mmhg")]
    public int? BloodPressureDiastolicMmhg { get; init; }

    [JsonPropertyName("body_temperature_f")]
    public double? BodyTemperatureF { get; init; }
}
