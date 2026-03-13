using Candid.Net.Test.Unit.MockServer;
using Candid.Net.Test.Utils;
using NUnit.Framework;

namespace Candid.Net.Test.Unit.MockServer.Payers.V4;

[TestFixture]
public class GetTest : BaseMockServerTest
{
    [global::NUnit.Framework.Test]
    public async global::System.Threading.Tasks.Task MockServerTest()
    {
        const string mockResponse = """
            {
              "payer_uuid": "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
              "payer_ids": {
                "claims_payer_id": "claims_payer_id",
                "eligibility_payer_id": "eligibility_payer_id",
                "remittance_payer_id": "remittance_payer_id"
              },
              "payer_name": "payer_name",
              "alternate_payer_names": [
                "alternate_payer_names",
                "alternate_payer_names"
              ],
              "clearinghouse_payer_info": {
                "CHANGE_HEALTHCARE": {
                  "payer_name": "payer_name",
                  "professional_payer_ids": {
                    "claims_payer_id": "claims_payer_id",
                    "eligibility_payer_id": "eligibility_payer_id",
                    "remittance_payer_id": "remittance_payer_id"
                  },
                  "institutional_payer_ids": {
                    "claims_payer_id": "claims_payer_id",
                    "eligibility_payer_id": "eligibility_payer_id",
                    "remittance_payer_id": "remittance_payer_id"
                  },
                  "professional_claims_support": "NOT_SUPPORTED",
                  "institutional_claims_support": "NOT_SUPPORTED",
                  "eligibility_support": "NOT_SUPPORTED",
                  "remittance_support": "NOT_SUPPORTED",
                  "claim_attachment_support": "NOT_SUPPORTED"
                }
              },
              "street_address": {
                "zip_plus_four_code": "zip_plus_four_code",
                "address1": "address1",
                "address2": "address2",
                "city": "city",
                "state": "AA",
                "zip_code": "zip_code"
              },
              "alternate_payer_addresses": [
                {
                  "zip_plus_four_code": "zip_plus_four_code",
                  "address1": "address1",
                  "address2": "address2",
                  "city": "city",
                  "state": "AA",
                  "zip_code": "zip_code"
                },
                {
                  "zip_plus_four_code": "zip_plus_four_code",
                  "address1": "address1",
                  "address2": "address2",
                  "city": "city",
                  "state": "AA",
                  "zip_code": "zip_code"
                }
              ]
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/api/payers/v4/d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32")
                    .UsingGet()
            )
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.Payers.V4.GetAsync("d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32");
        JsonAssert.AreEqual(response, mockResponse);
    }
}
