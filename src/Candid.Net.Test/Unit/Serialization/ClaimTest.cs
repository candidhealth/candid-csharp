using System.Text.Json;
using System.Text.Json.Serialization;
using Candid.Net;
using Newtonsoft.Json.Linq;
using NUnit.Framework;

#nullable enable

namespace Candid.Net.Test;

[TestFixture]
public class ClaimTest
{
    [Test]
    public void TestSerialization()
    {
        var inputJson =
            @"
        {
  ""claim_id"": ""DD9D7F82-37B5-449D-AA63-26925398335B"",
  ""status"": ""biller_received"",
  ""clearinghouse"": ""Change Healthcare"",
  ""clearinghouse_claim_id"": ""5BA7C3AB-2BC2-496C-8B10-6CAC73D0729D"",
  ""payer_claim_id"": ""9BB9F259-9756-4F16-8F53-9DBB9F7EB1BB"",
  ""service_lines"": [
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
  ],
  ""eras"": [
    {
      ""era_id"": ""4D844EF1-2253-43CD-A4F1-6DB7E65CB54B"",
      ""check_number"": ""CHK12345"",
      ""check_date"": ""2023-10-12""
    }
  ]
}
";

        var serializerOptions = new JsonSerializerOptions
        {
            DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull
        };

        var deserializedObject = JsonSerializer.Deserialize<Claim>(inputJson, serializerOptions);

        var serializedJson = JsonSerializer.Serialize(deserializedObject, serializerOptions);

        Assert.That(JToken.DeepEquals(JToken.Parse(inputJson), JToken.Parse(serializedJson)));
    }
}
