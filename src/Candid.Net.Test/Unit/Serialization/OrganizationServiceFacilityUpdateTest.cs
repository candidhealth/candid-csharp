using System.Text.Json;
using System.Text.Json.Serialization;
using Candid.Net.OrganizationServiceFacilities.V2;
using Newtonsoft.Json.Linq;
using NUnit.Framework;

#nullable enable

namespace Candid.Net.Test;

[TestFixture]
public class OrganizationServiceFacilityUpdateTest
{
    [Test]
    public void TestSerialization()
    {
        var inputJson =
            @"
        {
  ""name"": ""Test Service Facility"",
  ""aliases"": [
    ""Test Service Facility Alias""
  ],
  ""description"": ""Test Service Facility Description"",
  ""status"": ""active"",
  ""operational_status"": ""C"",
  ""mode"": ""instance"",
  ""type"": ""DX"",
  ""physical_type"": ""si"",
  ""telecoms"": [
    ""555-555-5555""
  ],
  ""address"": {
    ""address1"": ""123 Main St"",
    ""address2"": ""Apt 1"",
    ""city"": ""New York"",
    ""state"": ""NY"",
    ""zip_code"": ""10001"",
    ""zip_plus_four_code"": ""1234""
  }
}
";

        var serializerOptions = new JsonSerializerOptions
        {
            DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull
        };

        var deserializedObject = JsonSerializer.Deserialize<OrganizationServiceFacilityUpdate>(
            inputJson,
            serializerOptions
        );

        var serializedJson = JsonSerializer.Serialize(deserializedObject, serializerOptions);

        Assert.That(JToken.DeepEquals(JToken.Parse(inputJson), JToken.Parse(serializedJson)));
    }
}
