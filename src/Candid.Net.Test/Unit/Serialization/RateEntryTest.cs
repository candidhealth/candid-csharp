using System.Text.Json;
using System.Text.Json.Serialization;
using Candid.Net.FeeSchedules.V3;
using Newtonsoft.Json.Linq;
using NUnit.Framework;

#nullable enable

namespace Candid.Net.Test;

[TestFixture]
public class RateEntryTest
{
    [Test]
    public void TestSerialization()
    {
        var inputJson =
            @"
        {
  ""start_date"": ""2024-04-11"",
  ""rate_cents"": 33000,
  ""is_deactivated"": false
}
";

        var serializerOptions = new JsonSerializerOptions
        {
            DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull
        };

        var deserializedObject = JsonSerializer.Deserialize<RateEntry>(
            inputJson,
            serializerOptions
        );

        var serializedJson = JsonSerializer.Serialize(deserializedObject, serializerOptions);

        Assert.That(JToken.DeepEquals(JToken.Parse(inputJson), JToken.Parse(serializedJson)));
    }
}
