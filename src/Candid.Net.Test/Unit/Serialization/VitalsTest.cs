using System.Text.Json;
using System.Text.Json.Serialization;
using Candid.Net.Encounters.V4;
using Newtonsoft.Json.Linq;
using NUnit.Framework;

#nullable enable

namespace Candid.Net.Test;

[TestFixture]
public class VitalsTest
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
  ""body_temperature_f"": 98
}
";

        var serializerOptions = new JsonSerializerOptions
        {
            DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull
        };

        var deserializedObject = JsonSerializer.Deserialize<Vitals>(inputJson, serializerOptions);

        var serializedJson = JsonSerializer.Serialize(deserializedObject, serializerOptions);

        Assert.That(JToken.DeepEquals(JToken.Parse(inputJson), JToken.Parse(serializedJson)));
    }
}
