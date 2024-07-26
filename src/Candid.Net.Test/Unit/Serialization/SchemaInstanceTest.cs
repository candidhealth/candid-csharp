using System.Text.Json;
using System.Text.Json.Serialization;
using Candid.Net.CustomSchemas.V1;
using Newtonsoft.Json.Linq;
using NUnit.Framework;

#nullable enable

namespace Candid.Net.Test;

[TestFixture]
public class SchemaInstanceTest
{
    [Test]
    public void TestSerialization()
    {
        var inputJson =
            @"
        {
  ""schema_id"": ""ec096b13-f80a-471d-aaeb-54b021c9d582"",
  ""content"": {
    ""provider_category"": ""internist"",
    ""is_urgent_care"": true,
    ""bmi"": 24.2,
    ""age"": 38
  }
}
";

        var serializerOptions = new JsonSerializerOptions
        {
            DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull
        };

        var deserializedObject = JsonSerializer.Deserialize<SchemaInstance>(
            inputJson,
            serializerOptions
        );

        var serializedJson = JsonSerializer.Serialize(deserializedObject, serializerOptions);

        Assert.That(JToken.DeepEquals(JToken.Parse(inputJson), JToken.Parse(serializedJson)));
    }
}
