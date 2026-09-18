using global::Candid.Net.Test.Unit.MockServer;
using global::Candid.Net.Test.Utils;
using NUnit.Framework;

namespace Candid.Net.Test.Unit.MockServer.PreServiceRules.V1;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class GetPipelinesTest : BaseMockServerTest
{
    [global::NUnit.Framework.Test]
    public async global::System.Threading.Tasks.Task MockServerTest()
    {
        const string mockResponse = """
            [
              {
                "id": "id",
                "name": "name",
                "run_type": "ENCOUNTER"
              },
              {
                "id": "id",
                "name": "name",
                "run_type": "ENCOUNTER"
              }
            ]
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/api/pre-service/v1/pipelines")
                    .UsingGet()
            )
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.PreServiceRules.V1.GetPipelinesAsync();
        JsonAssert.AreEqual(response, mockResponse);
    }
}
