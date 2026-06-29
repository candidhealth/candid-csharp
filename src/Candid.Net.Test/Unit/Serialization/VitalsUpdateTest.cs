using global::Candid.Net.Core;
using global::Candid.Net.Encounters.V4;
using global::Candid.Net.Test.Utils;
using NUnit.Framework;

namespace Candid.Net.Test;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class VitalsUpdateTest
{
    [global::NUnit.Framework.Test]
    public void TestDeserialization()
    {
        var json = """
            {
              "height_in": 70,
              "weight_lbs": 165,
              "blood_pressure_systolic_mmhg": 115,
              "blood_pressure_diastolic_mmhg": 85,
              "body_temperature_f": 98,
              "hemoglobin_gdl": 15.1,
              "hematocrit_pct": 51.2
            }
            """;
        var expectedObject = new VitalsUpdate
        {
            HeightIn = 70,
            WeightLbs = 165,
            BloodPressureSystolicMmhg = 115,
            BloodPressureDiastolicMmhg = 85,
            BodyTemperatureF = 98,
            HemoglobinGdl = 15.1,
            HematocritPct = 51.2,
        };
        var deserializedObject = JsonUtils.Deserialize<VitalsUpdate>(json);
        Assert.That(deserializedObject, Is.EqualTo(expectedObject).UsingDefaults());
    }

    [global::NUnit.Framework.Test]
    public void TestSerialization()
    {
        var inputJson = """
            {
              "height_in": 70,
              "weight_lbs": 165,
              "blood_pressure_systolic_mmhg": 115,
              "blood_pressure_diastolic_mmhg": 85,
              "body_temperature_f": 98,
              "hemoglobin_gdl": 15.1,
              "hematocrit_pct": 51.2
            }
            """;
        JsonAssert.Roundtrips<VitalsUpdate>(inputJson);
    }
}
