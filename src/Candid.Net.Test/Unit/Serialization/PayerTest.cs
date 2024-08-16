using System.Text.Json;
using System.Text.Json.Serialization;
using Candid.Net.Payers.V3;
using FluentAssertions.Json;
using Newtonsoft.Json.Linq;
using NUnit.Framework;

#nullable enable

namespace Candid.Net.Test;

[TestFixture]
public class PayerTest
{
    [Test]
    public void TestSerialization()
    {
        var inputJson =
            @"
        {
  ""payer_uuid"": ""A6431FD2-0712-4714-B1B1-DD094DAF9F42"",
  ""payer_id"": ""12345"",
  ""payer_name"": ""Payer Name""
}
";

        var serializerOptions = new JsonSerializerOptions
        {
            DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull
        };

        var deserializedObject = JsonSerializer.Deserialize<Payer>(inputJson, serializerOptions);

        var serializedJson = JsonSerializer.Serialize(deserializedObject, serializerOptions);

        JToken.Parse(inputJson).Should().BeEquivalentTo(JToken.Parse(serializedJson));
    }
}
