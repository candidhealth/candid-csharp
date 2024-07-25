using System.Text.Json;
using System.Text.Json.Serialization;
using Candid.Net.PatientPayments.V3;
using Newtonsoft.Json.Linq;
using NUnit.Framework;

#nullable enable

namespace Candid.Net.Test;

[TestFixture]
public class PatientPaymentTest
{
    [Test]
    public void TestSerialization()
    {
        var inputJson =
            @"
        {
  ""patient_payment_id"": ""CF237BE1-E793-4BBF-8958-61D5179D1D0D"",
  ""organization_id"": ""0788CA2A-B20D-4B8E-B8D4-07FA0B3B4907"",
  ""source_internal_id"": ""D1A76039-D5C5-4323-A2FC-B7C8B6AEF6A4"",
  ""source"": ""MANUAL_ENTRY"",
  ""amount_cents"": 2000,
  ""payment_timestamp"": ""2023-01-01T00:00:00Z"",
  ""status"": ""PENDING"",
  ""payment_name"": ""John Doe"",
  ""payment_note"": ""test payment note"",
  ""patient_external_id"": ""B7437260-D6B4-48CF-B9D7-753C09F34E76"",
  ""encounter_external_id"": ""0F26B9C3-199F-4CBB-A166-B87EA7C631BB"",
  ""service_line_id"": ""B557DC86-C629-478C-850A-02D45AC11783""
}
";

        var serializerOptions = new JsonSerializerOptions
        {
            DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull
        };

        var deserializedObject = JsonSerializer.Deserialize<PatientPayment>(
            inputJson,
            serializerOptions
        );

        var serializedJson = JsonSerializer.Serialize(deserializedObject, serializerOptions);

        Assert.That(JToken.DeepEquals(JToken.Parse(inputJson), JToken.Parse(serializedJson)));
    }
}
