using Candid.Net.Test.Unit.MockServer;
using Candid.Net.Test.Utils;
using NUnit.Framework;

namespace Candid.Net.Test.Unit.MockServer.Payers.V3;

[TestFixture]
public class GetAllTest : BaseMockServerTest
{
    [global::NUnit.Framework.Test]
    public async global::System.Threading.Tasks.Task MockServerTest()
    {
        const string mockResponse = """
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

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/api/payers/v3")
                    .WithParam("limit", "100")
                    .WithParam("search_term", "john")
                    .WithParam("page_token", "eyJ0b2tlbiI6IjEiLCJwYWdlX3Rva2VuIjoiMiJ9")
                    .UsingGet()
            )
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.Payers.V3.GetAllAsync(
            new global::Candid.Net.Payers.V3.GetAllPayersRequest
            {
                Limit = 100,
                SearchTerm = "john",
                PageToken = "eyJ0b2tlbiI6IjEiLCJwYWdlX3Rva2VuIjoiMiJ9",
            }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
