using Candid.Net.FeeSchedules.V3;
using Candid.Net.Test.Unit.MockServer;
using Candid.Net.Test.Utils;
using NUnit.Framework;

namespace Candid.Net.Test.Unit.MockServer.FeeSchedules.V3;

[TestFixture]
public class HardDeleteRatesByIdsTest : BaseMockServerTest
{
    [global::NUnit.Framework.Test]
    public async global::System.Threading.Tasks.Task MockServerTest()
    {
        const string requestJson = """
            {
              "rate_ids": [
                "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
                "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32"
              ]
            }
            """;

        const string mockResponse = """
            1
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/api/fee-schedules/v3/hard-delete-by-ids")
                    .UsingPost()
                    .WithBodyAsJson(requestJson)
            )
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.FeeSchedules.V3.HardDeleteRatesByIdsAsync(
            new HardDeleteRatesByIdsRequest
            {
                RateIds = new List<string>()
                {
                    "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
                    "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
                },
            }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
