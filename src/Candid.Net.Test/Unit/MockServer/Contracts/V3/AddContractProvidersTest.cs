using global::Candid.Net.Contracts.V3;
using global::Candid.Net.Test.Unit.MockServer;
using global::Candid.Net.Test.Utils;
using NUnit.Framework;

namespace Candid.Net.Test.Unit.MockServer.Contracts.V3;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class AddContractProvidersTest : BaseMockServerTest
{
    [global::NUnit.Framework.Test]
    public async global::System.Threading.Tasks.Task MockServerTest()
    {
        const string requestJson = """
            {
              "rendering_provider_ids": [
                "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32"
              ]
            }
            """;

        const string mockResponse = """
            {
              "provider_count": 1,
              "added_count": 1,
              "ignored_count": 1
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/api/contracts/v3/d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32/providers")
                    .UsingPost()
                    .WithBodyAsJson(requestJson)
            )
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.Contracts.V3.AddContractProvidersAsync(
            "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
            new AddContractProvidersRequest
            {
                RenderingProviderIds = new HashSet<string>()
                {
                    "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
                },
            }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
