using Candid.Net.Test.Unit.MockServer;
using Candid.Net.Test.Utils;
using NUnit.Framework;

namespace Candid.Net.Test.Unit.MockServer.Tasks.V3;

[TestFixture]
public class GetActionsTest : BaseMockServerTest
{
    [global::NUnit.Framework.Test]
    public async global::System.Threading.Tasks.Task MockServerTest()
    {
        const string mockResponse = """
            {
              "actions": [
                {
                  "display_name": "display_name",
                  "execution_method": {
                    "type": "close_task"
                  },
                  "type": "close_task"
                },
                {
                  "display_name": "display_name",
                  "execution_method": {
                    "type": "close_task"
                  },
                  "type": "close_task"
                }
              ]
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/api/tasks/v3/d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32/actions")
                    .UsingGet()
            )
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.Tasks.V3.GetActionsAsync(
            "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32"
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
