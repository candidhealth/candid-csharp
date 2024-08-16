using System.Text.Json;
using System.Text.Json.Serialization;
using FluentAssertions.Json;
using Newtonsoft.Json.Linq;
using NUnit.Framework;

#nullable enable

namespace Candid.Net.Test;

[TestFixture]
public class PatientTest
{
    [Test]
    public void TestSerialization()
    {
        var inputJson =
            @"
        {
  ""individual_id"": ""93DDBEBF-4956-4482-9A6C-21499B7E4E5D"",
  ""phone_numbers"": [
    {
      ""number"": ""1234567890"",
      ""type"": ""Home""
    }
  ],
  ""phone_consent"": true,
  ""email"": ""johndoe@joincandidhealth.com"",
  ""email_consent"": true,
  ""external_id"": ""49460F77-6456-41F1-AC6D-0AED08614D39"",
  ""date_of_birth"": ""2000-01-01"",
  ""address"": {
    ""address1"": ""123 Main St"",
    ""address2"": ""Apt 1"",
    ""city"": ""New York"",
    ""state"": ""NY"",
    ""zip_code"": ""10001"",
    ""zip_plus_four_code"": ""1234""
  },
  ""first_name"": ""John"",
  ""last_name"": ""Doe"",
  ""gender"": ""male""
}
";

        var serializerOptions = new JsonSerializerOptions
        {
            DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull
        };

        var deserializedObject = JsonSerializer.Deserialize<Patient>(inputJson, serializerOptions);

        var serializedJson = JsonSerializer.Serialize(deserializedObject, serializerOptions);

        JToken.Parse(inputJson).Should().BeEquivalentTo(JToken.Parse(serializedJson));
    }
}
