using System.Text.Json;
using System.Text.Json.Serialization;
using Candid.Net.ServiceLines.V2;
using Newtonsoft.Json.Linq;
using NUnit.Framework;

#nullable enable

namespace Candid.Net.Test;

[TestFixture]
public class ServiceLineTest
{
    [Test]
    public void TestSerialization()
    {
        var inputJson =
            @"
        {
  ""modifiers"": [
    ""22""
  ],
  ""charge_amount_cents"": 10000,
  ""allowed_amount_cents"": 8000,
  ""paid_amount_cents"": 8000,
  ""patient_responsibility_cents"": 2000,
  ""diagnosis_id_zero"": ""4AC84BCD-12F5-4F86-A57B-E06749127C98"",
  ""diagnosis_id_one"": ""EEA5CA5A-8B43-45FD-8CBD-C6CC1103E759"",
  ""diagnosis_id_two"": ""5C4AA029-2DB9-4202-916E-E93C708F65FF"",
  ""diagnosis_id_three"": ""81795126-A3AC-443C-B47E-7259A16AB4A2"",
  ""denial_reason"": {
    ""reason"": ""Authorization Required""
  },
  ""place_of_service_code"": ""01"",
  ""service_line_id"": ""CED00F23-6E68-4678-9DBC-F5AA2969A565"",
  ""procedure_code"": ""99213"",
  ""quantity"": ""1"",
  ""units"": ""MJ"",
  ""claim_id"": ""026A1FB8-748E-4859-A2D7-3EA9E07D25AE"",
  ""date_of_service_range"": {
    ""start_date"": ""2023-01-01"",
    ""end_date"": ""2023-01-03""
  },
  ""date_of_service"": ""2023-01-01"",
  ""end_date_of_service"": ""2023-01-03""
}
";

        var serializerOptions = new JsonSerializerOptions
        {
            DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull
        };

        var deserializedObject = JsonSerializer.Deserialize<ServiceLine>(
            inputJson,
            serializerOptions
        );

        var serializedJson = JsonSerializer.Serialize(deserializedObject, serializerOptions);

        Assert.That(JToken.DeepEquals(JToken.Parse(inputJson), JToken.Parse(serializedJson)));
    }
}
