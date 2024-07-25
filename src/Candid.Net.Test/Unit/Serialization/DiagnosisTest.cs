using System.Text.Json;
using System.Text.Json.Serialization;
using Candid.Net;
using Newtonsoft.Json.Linq;
using NUnit.Framework;

#nullable enable

namespace Candid.Net.Test;

[TestFixture]
public class DiagnosisTest
{
    [Test]
    public void TestSerialization()
    {
        var inputJson =
            @"
        {
  ""diagnosis_id"": ""5C770E00-4BBF-42AF-A73F-99C5E91FC0DB"",
  ""created_at"": ""2023-01-01T00:00:00Z"",
  ""updated_at"": ""2023-01-01T00:00:00Z"",
  ""encounter_id"": ""3F63985B-51A4-4DD4-9418-7D50B2520792"",
  ""name"": ""John Doe"",
  ""code_type"": ""ABF"",
  ""code"": ""I10""
}
";

        var serializerOptions = new JsonSerializerOptions
        {
            DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull
        };

        var deserializedObject = JsonSerializer.Deserialize<Diagnosis>(
            inputJson,
            serializerOptions
        );

        var serializedJson = JsonSerializer.Serialize(deserializedObject, serializerOptions);

        Assert.That(JToken.DeepEquals(JToken.Parse(inputJson), JToken.Parse(serializedJson)));
    }
}
