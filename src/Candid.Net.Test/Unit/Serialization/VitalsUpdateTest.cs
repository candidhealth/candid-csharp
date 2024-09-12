using System.Text.Json;
using System.Text.Json.Serialization;
using Candid.Net.Encounters.V4;
using FluentAssertions.Json;
using Newtonsoft.Json.Linq;
using NUnit.Framework;

#nullable enable

namespace Candid.Net.Test;

[TestFixture]
public class VitalsUpdateTest
{
    [Test]
    public void TestSerialization()
    {
        var inputJson =
            @"
        {
  ""height_in"": 70,
  ""weight_lbs"": 165,
  ""blood_pressure_systolic_mmhg"": 115,
  ""blood_pressure_diastolic_mmhg"": 85,
  ""body_temperature_f"": 98,
  ""hemoglobin_gdl"": 15.1,
  ""hematocrit_pct"": 51.2
}
";

        var serializerOptions = new JsonSerializerOptions
        {
            DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull
        };

        var deserializedObject = JsonSerializer.Deserialize<VitalsUpdate>(
            inputJson,
            serializerOptions
        );

        var serializedJson = JsonSerializer.Serialize(deserializedObject, serializerOptions);

        JToken.Parse(inputJson).Should().BeEquivalentTo(JToken.Parse(serializedJson));
    }
}
