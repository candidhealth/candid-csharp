using global::Candid.Net.Events.V1;
using global::Candid.Net.Test.Unit.MockServer;
using global::Candid.Net.Test.Utils;
using NUnit.Framework;

namespace Candid.Net.Test.Unit.MockServer.Events.V1;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class ScanTest : BaseMockServerTest
{
    [global::NUnit.Framework.Test]
    public async global::System.Threading.Tasks.Task MockServerTest()
    {
        const string mockResponse = """
            {
              "next_page_token": "next_page_token",
              "items": [
                {
                  "id": "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
                  "created_at": "2024-01-15T09:30:00.000Z",
                  "timestamp": "2024-01-15T09:30:00.000Z",
                  "event_type": "event_type",
                  "schema_version": "schema_version",
                  "payload": {
                    "key": "value"
                  }
                },
                {
                  "id": "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
                  "created_at": "2024-01-15T09:30:00.000Z",
                  "timestamp": "2024-01-15T09:30:00.000Z",
                  "event_type": "event_type",
                  "schema_version": "schema_version",
                  "payload": {
                    "key": "value"
                  }
                }
              ]
            }
            """;

        Server
            .Given(WireMock.RequestBuilders.Request.Create().WithPath("/api/events/v1/").UsingGet())
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.Events.V1.ScanAsync(new GetEventScanRequest());
        JsonAssert.AreEqual(response, mockResponse);
    }
}
