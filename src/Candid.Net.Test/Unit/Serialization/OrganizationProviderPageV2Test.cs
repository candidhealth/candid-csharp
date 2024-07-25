using System.Text.Json;
using System.Text.Json.Serialization;
using Candid.Net.OrganizationProviders.V3;
using Newtonsoft.Json.Linq;
using NUnit.Framework;

#nullable enable

namespace Candid.Net.Test;

[TestFixture]
public class OrganizationProviderPageV2Test
{
    [Test]
    public void TestSerialization()
    {
        var inputJson =
            @"
        {
  ""items"": [
    {
      ""npi"": ""1234567890"",
      ""is_rendering"": true,
      ""is_billing"": true,
      ""first_name"": ""John"",
      ""last_name"": ""Doe"",
      ""organization_name"": ""Acme Medical"",
      ""provider_type"": ""INDIVIDUAL"",
      ""tax_id"": ""123456789"",
      ""taxonomy_code"": ""1234567890"",
      ""license_type"": ""MD"",
      ""employment_start_date"": ""2020-10-07"",
      ""employment_termination_date"": ""2021-10-07"",
      ""organization_provider_id"": ""965A563A-0285-4910-9569-E3739C0F6EAB"",
      ""qualifications"": [
        {
          ""identifier_id"": ""123e4567-e89b-12d3-a456-426614174000"",
          ""identifier_code"": ""MCR"",
          ""identifier_value"": {
            ""type"": ""medicare_provider_identifier"",
            ""state"": ""CA"",
            ""provider_number"": ""1234567890""
          }
        }
      ]
    }
  ]
}
";

        var serializerOptions = new JsonSerializerOptions
        {
            DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull
        };

        var deserializedObject = JsonSerializer.Deserialize<OrganizationProviderPageV2>(
            inputJson,
            serializerOptions
        );

        var serializedJson = JsonSerializer.Serialize(deserializedObject, serializerOptions);

        Assert.That(JToken.DeepEquals(JToken.Parse(inputJson), JToken.Parse(serializedJson)));
    }
}
