using global::Candid.Net.Test.Unit.MockServer;
using global::Candid.Net.Test.Utils;
using NUnit.Framework;

namespace Candid.Net.Test.Unit.MockServer.Payers.V3;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class GetTest : BaseMockServerTest
{
    [global::NUnit.Framework.Test]
    public async global::System.Threading.Tasks.Task MockServerTest()
    {
        const string mockResponse = """
            {
              "payer_uuid": "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
              "payer_id": "payer_id",
              "payer_name": "payer_name",
              "availity_payer_name": "availity_payer_name",
              "availity_claims_payer_id": "availity_claims_payer_id",
              "availity_eligibility_id": "availity_eligibility_id",
              "availity_remittance_payer_id": "availity_remittance_payer_id",
              "street_address": {
                "zip_plus_four_code": "zip_plus_four_code",
                "address1": "address1",
                "address2": "address2",
                "city": "city",
                "state": "AA",
                "zip_code": "zip_code"
              }
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/api/payers/v3/d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32")
                    .UsingGet()
            )
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.Payers.V3.GetAsync("d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32");
        JsonAssert.AreEqual(response, mockResponse);
    }
}
