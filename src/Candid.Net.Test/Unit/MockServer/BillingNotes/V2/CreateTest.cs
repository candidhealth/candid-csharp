using Candid.Net.BillingNotes.V2;
using Candid.Net.Test.Unit.MockServer;
using Candid.Net.Test.Utils;
using NUnit.Framework;

namespace Candid.Net.Test.Unit.MockServer.BillingNotes.V2;

[TestFixture]
public class CreateTest : BaseMockServerTest
{
    [global::NUnit.Framework.Test]
    public async global::System.Threading.Tasks.Task MockServerTest()
    {
        const string requestJson = """
            {
              "encounter_id": "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
              "text": "text"
            }
            """;

        const string mockResponse = """
            {
              "billing_note_id": "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
              "encounter_id": "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
              "created_at": "2024-01-15T09:30:00.000Z",
              "author_auth0_id": "author_auth0_id",
              "author_name": "author_name",
              "text": "text"
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/api/billing_notes/v2")
                    .UsingPost()
                    .WithBodyAsJson(requestJson)
            )
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.BillingNotes.V2.CreateAsync(
            new StandaloneBillingNoteCreate
            {
                EncounterId = "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
                Text = "text",
            }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
