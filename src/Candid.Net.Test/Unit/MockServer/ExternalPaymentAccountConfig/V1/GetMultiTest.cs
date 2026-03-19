using global::Candid.Net.ExternalPaymentAccountConfig.V1;
using global::Candid.Net.Test.Unit.MockServer;
using global::Candid.Net.Test.Utils;
using NUnit.Framework;

namespace Candid.Net.Test.Unit.MockServer.ExternalPaymentAccountConfig.V1;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class GetMultiTest : BaseMockServerTest
{
    [global::NUnit.Framework.Test]
    public async global::System.Threading.Tasks.Task MockServerTest()
    {
        const string mockResponse = """
            {
              "items": [
                {
                  "id": "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
                  "account_name": "account_name"
                },
                {
                  "id": "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
                  "account_name": "account_name"
                }
              ],
              "prev_page_token": "prev_page_token",
              "next_page_token": "next_page_token"
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/api/external-payment-account-config/v1")
                    .UsingGet()
            )
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.ExternalPaymentAccountConfig.V1.GetMultiAsync(
            new GetExternalPaymentAccountConfigsRequest()
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
