using global::Candid.Net.Test.Unit.MockServer;
using global::Candid.Net.Test.Utils;
using NUnit.Framework;

namespace Candid.Net.Test.Unit.MockServer.Eligibility.V2;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class GetByIdTest : BaseMockServerTest
{
    [global::NUnit.Framework.Test]
    public async global::System.Threading.Tasks.Task MockServerTest()
    {
        const string mockResponse = """
            {
              "id": "id",
              "dateOfService": "2024-01-15T09:30:00.000Z",
              "payerId": "payerId",
              "providerNPI": "providerNPI",
              "dependent": "dependent",
              "status": "ACTIVE"
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/api/eligibility/v2/d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32")
                    .UsingGet()
            )
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.Eligibility.V2.GetByIdAsync(
            "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32"
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
