using global::Candid.Net.Auth.Default;
using global::Candid.Net.Test.Unit.MockServer;
using global::Candid.Net.Test.Utils;
using NUnit.Framework;

namespace Candid.Net.Test.Unit.MockServer.Auth.Default;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class GetTokenTest : BaseMockServerTest
{
    [global::NUnit.Framework.Test]
    public async global::System.Threading.Tasks.Task MockServerTest()
    {
        const string requestJson = """
            {
              "client_id": "YOUR_CLIENT_ID",
              "client_secret": "YOUR_CLIENT_SECRET"
            }
            """;

        const string mockResponse = """
            {
              "access_token": "eyJz93a...k4laUWw",
              "expires_in": 86400,
              "token_type": "Bearer"
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/api/auth/v2/token")
                    .UsingPost()
                    .WithBodyAsJson(requestJson)
            )
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.Auth.Default.GetTokenAsync(
            new AuthGetTokenRequest
            {
                ClientId = "YOUR_CLIENT_ID",
                ClientSecret = "YOUR_CLIENT_SECRET",
            }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
