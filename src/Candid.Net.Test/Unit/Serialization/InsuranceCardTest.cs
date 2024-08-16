using System.Text.Json;
using System.Text.Json.Serialization;
using Candid.Net.InsuranceCards.V2;
using FluentAssertions.Json;
using Newtonsoft.Json.Linq;
using NUnit.Framework;

#nullable enable

namespace Candid.Net.Test;

[TestFixture]
public class InsuranceCardTest
{
    [Test]
    public void TestSerialization()
    {
        var inputJson =
            @"
        {
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
}
";

        var serializerOptions = new JsonSerializerOptions
        {
            DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull
        };

        var deserializedObject = JsonSerializer.Deserialize<InsuranceCard>(
            inputJson,
            serializerOptions
        );

        var serializedJson = JsonSerializer.Serialize(deserializedObject, serializerOptions);

        JToken.Parse(inputJson).Should().BeEquivalentTo(JToken.Parse(serializedJson));
    }
}
