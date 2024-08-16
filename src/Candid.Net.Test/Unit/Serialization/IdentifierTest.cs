using System.Text.Json;
using System.Text.Json.Serialization;
using Candid.Net;
using FluentAssertions.Json;
using Newtonsoft.Json.Linq;
using NUnit.Framework;

#nullable enable

namespace Candid.Net.Test;

[TestFixture]
public class IdentifierTest
{
    [Test]
    public void TestSerialization()
    {
        var inputJson =
            @"
        {
  ""identifier_id"": ""123e4567-e89b-12d3-a456-426614174000"",
  ""identifier_code"": ""MCR"",
  ""identifier_value"": {
    ""type"": ""medicare_provider_identifier"",
    ""state"": ""CA"",
    ""provider_number"": ""1234567890""
  }
}
";

        var serializerOptions = new JsonSerializerOptions
        {
            DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull
        };

        var deserializedObject = JsonSerializer.Deserialize<Identifier>(
            inputJson,
            serializerOptions
        );

        var serializedJson = JsonSerializer.Serialize(deserializedObject, serializerOptions);

        JToken.Parse(inputJson).Should().BeEquivalentTo(JToken.Parse(serializedJson));
    }
}
