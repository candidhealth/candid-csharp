using System.Text.Json;
using System.Text.Json.Serialization;
using Candid.Net.NonInsurancePayers.V1;
using FluentAssertions.Json;
using Newtonsoft.Json.Linq;
using NUnit.Framework;

#nullable enable

namespace Candid.Net.Test;

[TestFixture]
public class NonInsurancePayerTest
{
    [Test]
    public void TestSerialization()
    {
        var inputJson =
            @"
        {
  ""non_insurance_payer_id"": ""EB7623AB-D5BC-4B25-B257-2B8FCEC578DE"",
  ""name"": ""Sunrise Foundation"",
  ""category"": ""Foundation"",
  ""description"": ""Sunrise Foundation is a non-profit organization that provides financial assistance to patients in need."",
  ""enabled"": true
}
";

        var serializerOptions = new JsonSerializerOptions
        {
            DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull
        };

        var deserializedObject = JsonSerializer.Deserialize<NonInsurancePayer>(
            inputJson,
            serializerOptions
        );

        var serializedJson = JsonSerializer.Serialize(deserializedObject, serializerOptions);

        JToken.Parse(inputJson).Should().BeEquivalentTo(JToken.Parse(serializedJson));
    }
}
