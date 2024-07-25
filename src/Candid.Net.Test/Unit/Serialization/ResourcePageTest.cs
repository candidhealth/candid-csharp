using System.Text.Json;
using System.Text.Json.Serialization;
using Candid.Net;
using Newtonsoft.Json.Linq;
using NUnit.Framework;

#nullable enable

namespace Candid.Net.Test;

[TestFixture]
public class ResourcePageTest
{
    [Test]
    public void TestSerialization()
    {
        var inputJson =
            @"
        {
  ""prev_page_token"": ""eyJ0b2tlbiI6IjEiLCJwYWdlX3Rva2VuIjoiMiJ9"",
  ""next_page_token"": ""eyAiZm9vIjogImJhciJ9o8dj3FU83fFJe8dalz4A""
}
";

        var serializerOptions = new JsonSerializerOptions
        {
            DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull
        };

        var deserializedObject = JsonSerializer.Deserialize<ResourcePage>(
            inputJson,
            serializerOptions
        );

        var serializedJson = JsonSerializer.Serialize(deserializedObject, serializerOptions);

        Assert.That(JToken.DeepEquals(JToken.Parse(inputJson), JToken.Parse(serializedJson)));
    }
}
