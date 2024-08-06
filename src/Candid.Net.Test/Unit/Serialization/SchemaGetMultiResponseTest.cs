using System.Text.Json;
using System.Text.Json.Serialization;
using Candid.Net.CustomSchemas.V1;
using Newtonsoft.Json.Linq;
using NUnit.Framework;

#nullable enable

namespace Candid.Net.Test;

[TestFixture]
public class SchemaGetMultiResponseTest
{
    [Test]
    public void TestSerialization()
    {
        var inputJson =
            @"
        {
  ""schemas"": [
    {
      ""id"": ""ec096b13-f80a-471d-aaeb-54b021c9d582"",
      ""name"": ""General Medicine"",
      ""description"": ""Values associated with a generic visit"",
      ""fields"": [
        {
          ""key"": ""provider_category"",
          ""type"": ""STRING""
        },
        {
          ""key"": ""is_urgent_care"",
          ""type"": ""BOOLEAN""
        },
        {
          ""key"": ""bmi"",
          ""type"": ""DOUBLE""
        },
        {
          ""key"": ""age"",
          ""type"": ""INTEGER""
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

        var deserializedObject = JsonSerializer.Deserialize<SchemaGetMultiResponse>(
            inputJson,
            serializerOptions
        );

        var serializedJson = JsonSerializer.Serialize(deserializedObject, serializerOptions);

        Assert.That(JToken.DeepEquals(JToken.Parse(inputJson), JToken.Parse(serializedJson)));
    }
}
