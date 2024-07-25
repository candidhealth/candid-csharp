using System.Text.Json;
using System.Text.Json.Serialization;
using Candid.Net;
using Newtonsoft.Json.Linq;
using NUnit.Framework;

#nullable enable

namespace Candid.Net.Test;

[TestFixture]
public class EraTest
{
    [Test]
    public void TestSerialization()
    {
        var inputJson =
            @"
        {
  ""era_id"": ""4D844EF1-2253-43CD-A4F1-6DB7E65CB54B"",
  ""check_number"": ""CHK12345"",
  ""check_date"": ""2023-10-12""
}
";

        var serializerOptions = new JsonSerializerOptions
        {
            DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull
        };

        var deserializedObject = JsonSerializer.Deserialize<Era>(inputJson, serializerOptions);

        var serializedJson = JsonSerializer.Serialize(deserializedObject, serializerOptions);

        Assert.That(JToken.DeepEquals(JToken.Parse(inputJson), JToken.Parse(serializedJson)));
    }
}
