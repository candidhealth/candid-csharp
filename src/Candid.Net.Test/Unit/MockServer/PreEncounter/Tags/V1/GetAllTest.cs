using Candid.Net.PreEncounter.Tags.V1;
using Candid.Net.Test.Unit.MockServer;
using Candid.Net.Test.Utils;
using NUnit.Framework;

namespace Candid.Net.Test.Unit.MockServer.PreEncounter.Tags.V1;

[TestFixture]
public class GetAllTest : BaseMockServerTest
{
    [global::NUnit.Framework.Test]
    public async global::System.Threading.Tasks.Task MockServerTest()
    {
        const string mockResponse = """
            {
              "items": [
                {
                  "id": "id",
                  "organization_id": "organization_id",
                  "deactivated": true,
                  "version": 1,
                  "updated_at": "2024-01-15T09:30:00.000Z",
                  "updating_user_id": "updating_user_id",
                  "value": "value",
                  "description": "description",
                  "alert": true
                },
                {
                  "id": "id",
                  "organization_id": "organization_id",
                  "deactivated": true,
                  "version": 1,
                  "updated_at": "2024-01-15T09:30:00.000Z",
                  "updating_user_id": "updating_user_id",
                  "value": "value",
                  "description": "description",
                  "alert": true
                }
              ],
              "next_page_token": "next_page_token",
              "prev_page_token": "prev_page_token",
              "total": 1
            }
            """;

        Server
            .Given(WireMock.RequestBuilders.Request.Create().WithPath("/tags/v1").UsingGet())
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.PreEncounter.Tags.V1.GetAllAsync(new GetAllTagsRequest());
        JsonAssert.AreEqual(response, mockResponse);
    }
}
