using System.Text.Json;
using System.Text.Json.Serialization;
using Candid.Net.EncounterProviders.V2;
using FluentAssertions.Json;
using Newtonsoft.Json.Linq;
using NUnit.Framework;

#nullable enable

namespace Candid.Net.Test;

[TestFixture]
public class EncounterProviderTest
{
    [Test]
    public void TestSerialization()
    {
        var inputJson =
            @"
        {
  ""provider_id"": ""d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32"",
  ""address"": {
    ""address1"": ""123 Main St"",
    ""address2"": ""Apt 1"",
    ""city"": ""New York"",
    ""state"": ""NY"",
    ""zip_code"": ""10001"",
    ""zip_plus_four_code"": ""1234""
  },
  ""tax_id"": ""123456789"",
  ""npi"": ""1234567890"",
  ""taxonomy_code"": ""207Q00000X"",
  ""first_name"": ""John"",
  ""last_name"": ""Doe"",
  ""organization_name"": ""Organization Name""
}
";

        var serializerOptions = new JsonSerializerOptions
        {
            DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull
        };

        var deserializedObject = JsonSerializer.Deserialize<EncounterProvider>(
            inputJson,
            serializerOptions
        );

        var serializedJson = JsonSerializer.Serialize(deserializedObject, serializerOptions);

        JToken.Parse(inputJson).Should().BeEquivalentTo(JToken.Parse(serializedJson));
    }
}
