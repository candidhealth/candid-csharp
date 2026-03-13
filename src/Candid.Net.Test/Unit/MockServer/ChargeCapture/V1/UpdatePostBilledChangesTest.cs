using Candid.Net.ChargeCapture.V1;
using Candid.Net.Test.Unit.MockServer;
using Candid.Net.Test.Utils;
using NUnit.Framework;

namespace Candid.Net.Test.Unit.MockServer.ChargeCapture.V1;

[TestFixture]
public class UpdatePostBilledChangesTest : BaseMockServerTest
{
    [global::NUnit.Framework.Test]
    public async global::System.Threading.Tasks.Task MockServerTest()
    {
        const string requestJson = """
            {
              "charge_capture_change_ids": [
                "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
                "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32"
              ],
              "resolved": true
            }
            """;

        const string mockResponse = """
            [
              {
                "id": "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
                "message": "message",
                "resolved": true
              },
              {
                "id": "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
                "message": "message",
                "resolved": true
              }
            ]
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/api/charge_captures/v1/changes")
                    .UsingPatch()
                    .WithBodyAsJson(requestJson)
            )
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.ChargeCapture.V1.UpdatePostBilledChangesAsync(
            new ChargeCapturePostBilledChangeUpdate
            {
                ChargeCaptureChangeIds = new List<string>()
                {
                    "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
                    "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
                },
                Resolved = true,
            }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
