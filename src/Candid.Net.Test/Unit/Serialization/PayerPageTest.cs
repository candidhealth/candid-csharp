using System.Text.Json;
using Candid.Net.Core;
using NUnit.Framework;

namespace Candid.Net.Test;

[TestFixture]
public class PayerPageTest
{
    [global::NUnit.Framework.Test]
    public void TestDeserialization()
    {
        var json = """
            {
              "items": [
                {
                  "payer_uuid": "A6431FD2-0712-4714-B1B1-DD094DAF9F42",
                  "payer_id": "12345",
                  "payer_name": "Payer Name",
                  "availity_payer_name": "Availity Payer Name",
                  "availity_claims_payer_id": "54321",
                  "availity_eligibility_id": "54321",
                  "availity_remittance_payer_id": "54321"
                }
              ]
            }
            """;
        var expectedObject = new global::Candid.Net.Payers.V3.PayerPage
        {
            Items = new List<global::Candid.Net.Payers.V3.Payer>()
            {
                new global::Candid.Net.Payers.V3.Payer
                {
                    PayerUuid = "A6431FD2-0712-4714-B1B1-DD094DAF9F42",
                    PayerId = "12345",
                    PayerName = "Payer Name",
                    AvailityPayerName = "Availity Payer Name",
                    AvailityClaimsPayerId = "54321",
                    AvailityEligibilityId = "54321",
                    AvailityRemittancePayerId = "54321",
                },
            },
        };
        var deserializedObject = JsonUtils.Deserialize<global::Candid.Net.Payers.V3.PayerPage>(
            json
        );
        Assert.That(deserializedObject, Is.EqualTo(expectedObject).UsingDefaults());
    }

    [global::NUnit.Framework.Test]
    public void TestSerialization()
    {
        var expectedJson = """
            {
              "items": [
                {
                  "payer_uuid": "A6431FD2-0712-4714-B1B1-DD094DAF9F42",
                  "payer_id": "12345",
                  "payer_name": "Payer Name",
                  "availity_payer_name": "Availity Payer Name",
                  "availity_claims_payer_id": "54321",
                  "availity_eligibility_id": "54321",
                  "availity_remittance_payer_id": "54321"
                }
              ]
            }
            """;
        var actualObj = new global::Candid.Net.Payers.V3.PayerPage
        {
            Items = new List<global::Candid.Net.Payers.V3.Payer>()
            {
                new global::Candid.Net.Payers.V3.Payer
                {
                    PayerUuid = "A6431FD2-0712-4714-B1B1-DD094DAF9F42",
                    PayerId = "12345",
                    PayerName = "Payer Name",
                    AvailityPayerName = "Availity Payer Name",
                    AvailityClaimsPayerId = "54321",
                    AvailityEligibilityId = "54321",
                    AvailityRemittancePayerId = "54321",
                },
            },
        };
        var actualElement = JsonUtils.SerializeToElement(actualObj);
        var expectedElement = JsonUtils.Deserialize<JsonElement>(expectedJson);
        Assert.That(actualElement, Is.EqualTo(expectedElement).UsingJsonElementComparer());
    }
}
