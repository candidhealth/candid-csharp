using global::Candid.Net.FeeSchedules.V3;
using global::Candid.Net.Test.Unit.MockServer;
using global::Candid.Net.Test.Utils;
using NUnit.Framework;

namespace Candid.Net.Test.Unit.MockServer.FeeSchedules.V3;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class SetPayerThresholdTest : BaseMockServerTest
{
    [global::NUnit.Framework.Test]
    public async global::System.Threading.Tasks.Task MockServerTest()
    {
        const string requestJson = """
            {
              "disable_paid_incorrectly": true
            }
            """;

        const string mockResponse = """
            {
              "upper_threshold_cents": 1,
              "lower_threshold_cents": 1,
              "disable_paid_incorrectly": true
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath(
                        "/api/fee-schedules/v3/payer-threshold/d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32"
                    )
                    .UsingPut()
                    .WithBodyAsJson(requestJson)
            )
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.FeeSchedules.V3.SetPayerThresholdAsync(
            "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
            new PayerThreshold { DisablePaidIncorrectly = true }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
