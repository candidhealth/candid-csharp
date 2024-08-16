using System.Text.Json;
using System.Text.Json.Serialization;
using Candid.Net.Encounters.V4;
using FluentAssertions.Json;
using Newtonsoft.Json.Linq;
using NUnit.Framework;

#nullable enable

namespace Candid.Net.Test;

[TestFixture]
public class ClinicalNoteCategoryTest
{
    [Test]
    public void TestSerialization()
    {
        var inputJson =
            @"
        {
  ""category"": ""clinical"",
  ""notes"": [
    ""Patient complained of mild chest pain.""
  ],
  ""notes_structured"": [
    {
      ""text"": ""Mild chest pain since morning."",
      ""author_name"": ""John Doe"",
      ""author_npi"": ""1234567890"",
      ""timestamp"": ""2023-01-01T00:00:00Z""
    }
  ]
}
";

        var serializerOptions = new JsonSerializerOptions
        {
            DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull
        };

        var deserializedObject = JsonSerializer.Deserialize<ClinicalNoteCategory>(
            inputJson,
            serializerOptions
        );

        var serializedJson = JsonSerializer.Serialize(deserializedObject, serializerOptions);

        JToken.Parse(inputJson).Should().BeEquivalentTo(JToken.Parse(serializedJson));
    }
}
