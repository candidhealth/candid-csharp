using System.Text.Json;
using System.Text.Json.Serialization;
using Candid.Net.Encounters.V4;
using FluentAssertions.Json;
using Newtonsoft.Json.Linq;
using NUnit.Framework;

#nullable enable

namespace Candid.Net.Test;

[TestFixture]
public class IntakeQuestionTest
{
    [Test]
    public void TestSerialization()
    {
        var inputJson =
            @"
        {
  ""id"": ""6E7FBCE4-A8EA-46D0-A8D8-FF83CA3BB176"",
  ""text"": ""Do you have any allergies?"",
  ""responses"": [
    {
      ""response"": ""No allergies"",
      ""follow_ups"": [
        {
          ""id"": ""4F3D57F9-AC94-49D6-87E4-E804B709917A"",
          ""text"": ""Do you have any allergies?"",
          ""response"": ""No allergies""
        }
      ]
    }
  ]
}
";

        var serializerOptions = new JsonSerializerOptions
        {
            DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull
        };

        var deserializedObject = JsonSerializer.Deserialize<IntakeQuestion>(
            inputJson,
            serializerOptions
        );

        var serializedJson = JsonSerializer.Serialize(deserializedObject, serializerOptions);

        JToken.Parse(inputJson).Should().BeEquivalentTo(JToken.Parse(serializedJson));
    }
}
