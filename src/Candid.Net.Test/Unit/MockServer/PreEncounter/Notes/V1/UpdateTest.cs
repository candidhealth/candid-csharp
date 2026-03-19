using global::Candid.Net.PreEncounter.Notes.V1;
using global::Candid.Net.Test.Unit.MockServer;
using global::Candid.Net.Test.Utils;
using NUnit.Framework;

namespace Candid.Net.Test.Unit.MockServer.PreEncounter.Notes.V1;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class UpdateTest : BaseMockServerTest
{
    [global::NUnit.Framework.Test]
    public async global::System.Threading.Tasks.Task MockServerTest()
    {
        const string requestJson = """
            {
              "value": "value"
            }
            """;

        const string mockResponse = """
            {
              "id": "id",
              "created_at": "2024-01-15T09:30:00.000Z",
              "organization_id": "organization_id",
              "deactivated": true,
              "version": 1,
              "updated_at": "2024-01-15T09:30:00.000Z",
              "updating_user_id": "updating_user_id",
              "value": "value",
              "author_email": "author_email",
              "author_name": "author_name"
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/notes/v1/id/version")
                    .UsingPut()
                    .WithBodyAsJson(requestJson)
            )
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.PreEncounter.Notes.V1.UpdateAsync(
            "id",
            "version",
            new MutableNote { Value = "value" }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
