using Candid.Net.FeeSchedules.V3;
using Candid.Net.Test.Unit.MockServer;
using Candid.Net.Test.Utils;
using NUnit.Framework;

namespace Candid.Net.Test.Unit.MockServer.FeeSchedules.V3;

[TestFixture]
public class GetPayerThresholdsTest : BaseMockServerTest
{
    [global::NUnit.Framework.Test]
    public async global::System.Threading.Tasks.Task MockServerTest()
    {
        const string mockResponse = """
            {
              "payer_thresholds": {
                "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32": {
                  "upper_threshold_cents": 1,
                  "lower_threshold_cents": 1,
                  "disable_paid_incorrectly": true
                }
              },
              "prev_page_token": "prev_page_token",
              "next_page_token": "next_page_token"
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/api/fee-schedules/v3/payer-threshold")
                    .WithParam("payer_uuids", "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32")
                    .UsingGet()
            )
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.FeeSchedules.V3.GetPayerThresholdsAsync(
            new PayerThresholdGetRequest { PayerUuids = ["d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32"] }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
