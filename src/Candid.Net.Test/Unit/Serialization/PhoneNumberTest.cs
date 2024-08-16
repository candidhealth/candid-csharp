using System.Text.Json;
using System.Text.Json.Serialization;
using Candid.Net;
using FluentAssertions.Json;
using Newtonsoft.Json.Linq;
using NUnit.Framework;

#nullable enable

namespace Candid.Net.Test;

[TestFixture]
public class PhoneNumberTest
{
    [Test]
    public void TestSerialization()
    {
        var inputJson =
            @"
        {
  ""number"": ""1234567890"",
  ""type"": ""Home""
}
";

        var serializerOptions = new JsonSerializerOptions
        {
            DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull
        };

        var deserializedObject = JsonSerializer.Deserialize<PhoneNumber>(
            inputJson,
            serializerOptions
        );

        var serializedJson = JsonSerializer.Serialize(deserializedObject, serializerOptions);

        JToken.Parse(inputJson).Should().BeEquivalentTo(JToken.Parse(serializedJson));
    }
}
