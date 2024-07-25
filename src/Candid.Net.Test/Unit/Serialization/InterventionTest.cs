using System.Text.Json;
using System.Text.Json.Serialization;
using Candid.Net.Encounters.V4;
using Newtonsoft.Json.Linq;
using NUnit.Framework;

#nullable enable

namespace Candid.Net.Test;

[TestFixture]
public class InterventionTest
{
    [Test]
    public void TestSerialization()
    {
        var inputJson =
            @"
        {
  ""name"": ""Physical Therapy Session"",
  ""category"": ""lifestyle"",
  ""description"": ""A session focused on improving muscular strength, flexibility, and range of motion post-injury."",
  ""medication"": {
    ""name"": ""Lisinopril"",
    ""rx_cui"": ""860975"",
    ""dosage"": ""10mg"",
    ""dosage_form"": ""Tablet"",
    ""frequency"": ""Once Daily"",
    ""as_needed"": true
  },
  ""labs"": [
    {
      ""name"": ""Genetic Health Labs"",
      ""code"": ""GH12345"",
      ""code_type"": ""quest""
    }
  ]
}
";

        var serializerOptions = new JsonSerializerOptions
        {
            DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull
        };

        var deserializedObject = JsonSerializer.Deserialize<Intervention>(
            inputJson,
            serializerOptions
        );

        var serializedJson = JsonSerializer.Serialize(deserializedObject, serializerOptions);

        Assert.That(JToken.DeepEquals(JToken.Parse(inputJson), JToken.Parse(serializedJson)));
    }
}
