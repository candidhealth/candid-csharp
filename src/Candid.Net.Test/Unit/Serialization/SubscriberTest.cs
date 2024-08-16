using System.Text.Json;
using System.Text.Json.Serialization;
using FluentAssertions.Json;
using Newtonsoft.Json.Linq;
using NUnit.Framework;

#nullable enable

namespace Candid.Net.Test;

[TestFixture]
public class SubscriberTest
{
    [Test]
    public void TestSerialization()
    {
        var inputJson =
            @"
        {
  ""individual_id"": ""797348A9-E7E8-4E59-8628-95390D079C0B"",
  ""insurance_card"": {
    ""insurance_card_id"": ""CA5B7711-4419-4161-9B7C-3494AC40C8D4"",
    ""member_id"": ""E85313B4-0FFC-4119-8042-8161A4ECFF0A"",
    ""payer_name"": ""John Doe"",
    ""payer_id"": ""836DDAA6-863F-4020-ACCA-205A689F0002"",
    ""rx_bin"": ""610014"",
    ""rx_pcn"": ""MEDDPRIME"",
    ""image_url_front"": ""https://s3.amazonaws.com/front.jpg"",
    ""image_url_back"": ""https://s3.amazonaws.com/back.jpg"",
    ""group_number"": ""ABC12345"",
    ""plan_name"": ""Silver PPO Plan"",
    ""plan_type"": ""09"",
    ""insurance_type"": ""12""
  },
  ""patient_relationship_to_subscriber_code"": ""01"",
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

        var deserializedObject = JsonSerializer.Deserialize<Subscriber>(
            inputJson,
            serializerOptions
        );

        var serializedJson = JsonSerializer.Serialize(deserializedObject, serializerOptions);

        JToken.Parse(inputJson).Should().BeEquivalentTo(JToken.Parse(serializedJson));
    }
}
