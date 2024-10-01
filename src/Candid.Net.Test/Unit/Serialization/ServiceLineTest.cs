using System.Text.Json;
using System.Text.Json.Serialization;
using Candid.Net.ServiceLines.V2;
using FluentAssertions.Json;
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
  ""insurance_balance_cents"": 0,
  ""patient_balance_cents"": 2000,
  ""paid_amount_cents"": 8000,
  ""patient_responsibility_cents"": 2000,
  ""diagnosis_id_zero"": ""4AC84BCD-12F5-4F86-A57B-E06749127C98"",
  ""diagnosis_id_one"": ""EEA5CA5A-8B43-45FD-8CBD-C6CC1103E759"",
  ""diagnosis_id_two"": ""5C4AA029-2DB9-4202-916E-E93C708F65FF"",
  ""diagnosis_id_three"": ""81795126-A3AC-443C-B47E-7259A16AB4A2"",
  ""service_line_era_data"": {
    ""service_line_adjustments"": [
      {
        ""created_at"": ""2023-01-01T00:00:00Z"",
        ""adjustment_group_code"": ""CO"",
        ""adjustment_reason_code"": ""CO"",
        ""adjustment_amount_cents"": 1000,
        ""adjustment_note"": ""test_note""
      }
    ],
    ""remittance_advice_remark_codes"": [
      ""N362""
    ]
  },
  ""service_line_manual_adjustments"": [
    {
      ""created_at"": ""2023-01-01T00:00:00Z"",
      ""adjustment_group_code"": ""CO"",
      ""adjustment_reason_code"": ""CO"",
      ""adjustment_amount_cents"": 1000,
      ""adjustment_note"": ""test_note""
    }
  ],
  ""related_invoices"": [
    {
      ""id"": ""901BE2F1-41BC-456E-9987-4FE2F84F9D75"",
      ""created_at"": ""2023-01-01T00:00:00Z"",
      ""updated_at"": ""2023-01-01T00:00:00Z"",
      ""organzation_id"": ""F13F73D4-4344-46EA-9D93-33BCFFBB9F36"",
      ""source_id"": ""9B626577-8808-4F28-9ED1-F0DFF0D49BBC"",
      ""source_customer_id"": ""624D1972-8C69-4C2F-AEFA-10856F734DB3"",
      ""patient_external_id"": ""10FED4D6-4C5A-48DF-838A-EEF45A74788D"",
      ""note"": ""test_note"",
      ""due_date"": ""2023-10-10"",
      ""status"": ""draft"",
      ""url"": ""https://example.com"",
      ""customer_invoice_url"": ""https://example.com"",
      ""items"": [
        {
          ""service_line_id"": ""CED00F23-6E68-4678-9DBC-F5AA2969A565"",
          ""amount_cents"": 500
        }
      ]
    }
  ],
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
  ""end_date_of_service"": ""2023-01-03"",
  ""test_result"": {
    ""type"": ""hemoglobin"",
    ""value"": 2.4
  }
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

        JToken.Parse(inputJson).Should().BeEquivalentTo(JToken.Parse(serializedJson));
    }
}
