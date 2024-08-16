using System.Text.Json;
using System.Text.Json.Serialization;
using Candid.Net;
using FluentAssertions.Json;
using Newtonsoft.Json.Linq;
using NUnit.Framework;

#nullable enable

namespace Candid.Net.Test;

[TestFixture]
public class TagTest
{
    [Test]
    public void TestSerialization()
    {
        var inputJson =
            @"
        {
  ""creator_id"": ""00EB5A46-35C6-441B-9751-AF307AEF5888"",
  ""tag_id"": ""void-claim-submitted"",
  ""description"": ""to indicate claims where a void claim has been submitted"",
  ""color"": ""black""
}
";

        var serializerOptions = new JsonSerializerOptions
        {
            DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull
        };

        var deserializedObject = JsonSerializer.Deserialize<Tag>(inputJson, serializerOptions);

        var serializedJson = JsonSerializer.Serialize(deserializedObject, serializerOptions);

        JToken.Parse(inputJson).Should().BeEquivalentTo(JToken.Parse(serializedJson));
    }
}
