using global::Candid.Net.PayerGroups.V1;
using global::Candid.Net.Test.Unit.MockServer;
using global::Candid.Net.Test.Utils;
using NUnit.Framework;

namespace Candid.Net.Test.Unit.MockServer.PayerGroups.V1;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class GetMultiTest : BaseMockServerTest
{
    [global::NUnit.Framework.Test]
    public async global::System.Threading.Tasks.Task MockServerTest()
    {
        const string mockResponse = """
            {
              "items": [
                {
                  "payer_group_id": "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
                  "payer_plan_group_count": 1,
                  "name": "name"
                },
                {
                  "payer_group_id": "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
                  "payer_plan_group_count": 1,
                  "name": "name"
                }
              ],
              "prev_page_token": "prev_page_token",
              "next_page_token": "next_page_token"
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/api/payer-groups/v1")
                    .UsingGet()
            )
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.PayerGroups.V1.GetMultiAsync(new PayerGroupGetMultiRequest());
        JsonAssert.AreEqual(response, mockResponse);
    }
}
