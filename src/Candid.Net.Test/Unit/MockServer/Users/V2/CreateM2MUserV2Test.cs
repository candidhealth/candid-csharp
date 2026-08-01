using global::Candid.Net.Test.Unit.MockServer;
using global::Candid.Net.Test.Utils;
using global::Candid.Net.Users.V2;
using NUnit.Framework;

namespace Candid.Net.Test.Unit.MockServer.Users.V2;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class CreateM2MUserV2Test : BaseMockServerTest
{
    [global::NUnit.Framework.Test]
    public async global::System.Threading.Tasks.Task MockServerTest()
    {
        const string requestJson = """
            {
              "name": "name",
              "organization_id": "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32"
            }
            """;

        const string mockResponse = """
            {
              "client_id": "client_id",
              "client_secret": "client_secret",
              "created_at": "2024-01-15T09:30:00.000Z",
              "created_by": "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
              "auth0_user_id": "auth0_user_id"
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/api/users/v2/m2m/client")
                    .UsingPost()
                    .WithBodyAsJson(requestJson)
            )
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.Users.V2.CreateM2MUserV2Async(
            new M2MUserCreateV2
            {
                Name = "name",
                OrganizationId = "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
            }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
