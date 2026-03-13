using Candid.Net.Test.Unit.MockServer;
using Candid.Net.Test.Utils;
using NUnit.Framework;

namespace Candid.Net.Test.Unit.MockServer.Tasks.V3;

[TestFixture]
public class GetTest : BaseMockServerTest
{
    [global::NUnit.Framework.Test]
    public async global::System.Threading.Tasks.Task MockServerTest()
    {
        const string mockResponse = """
            {
              "task_id": "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
              "encounter_id": "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
              "task_type": "CUSTOMER_DATA_REQUEST",
              "description": "description",
              "blocks_claim_submission": true,
              "external_id": "external_id",
              "patient_name": "patient_name",
              "patient_external_id": "patient_external_id",
              "payer_name": "payer_name",
              "payer_id": "payer_id",
              "status": "finished",
              "notes": [
                {
                  "task_note_id": "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
                  "text": "text",
                  "created_at": "2024-01-15T09:30:00.000Z",
                  "author_name": "author_name",
                  "author_organization_name": "author_organization_name"
                },
                {
                  "task_note_id": "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
                  "text": "text",
                  "created_at": "2024-01-15T09:30:00.000Z",
                  "author_name": "author_name",
                  "author_organization_name": "author_organization_name"
                }
              ],
              "created_at": "2024-01-15T09:30:00.000Z",
              "updated_at": "2024-01-15T09:30:00.000Z",
              "agg_updated_at": "2024-01-15T09:30:00.000Z",
              "date_of_service": "2023-01-15",
              "assignments": [
                {
                  "task_assignment_id": "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
                  "assignee_user_id": "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32"
                },
                {
                  "task_assignment_id": "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
                  "assignee_user_id": "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32"
                }
              ],
              "category": "other",
              "configurable_rule_id": "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32"
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/api/tasks/v3/d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32")
                    .UsingGet()
            )
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.Tasks.V3.GetAsync("d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32");
        JsonAssert.AreEqual(response, mockResponse);
    }
}
