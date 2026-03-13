using Candid.Net.Test.Unit.MockServer;
using Candid.Net.Test.Utils;
using NUnit.Framework;

namespace Candid.Net.Test.Unit.MockServer.EncounterAttachments.V1;

[TestFixture]
public class GetTest : BaseMockServerTest
{
    [global::NUnit.Framework.Test]
    public async global::System.Threading.Tasks.Task MockServerTest()
    {
        const string mockResponse = """
            [
              {
                "encounter_id": "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
                "attachment_type": "DOCUMENTATION",
                "created_at": "2024-01-15T09:30:00.000Z",
                "created_by": {
                  "user_id": "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
                  "idp_metadata": [
                    {
                      "type": "auth_zero_metadata",
                      "auth0_id": "auth0_id"
                    },
                    {
                      "type": "auth_zero_metadata",
                      "auth0_id": "auth0_id"
                    }
                  ],
                  "primary_organization_id": "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
                  "user_metadata": {
                    "type": "machine_user_metadata",
                    "name": "name"
                  }
                },
                "attachment_id": "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
                "file_name": "file_name",
                "description": "description",
                "content_type": "content_type",
                "authed_url": "authed_url"
              },
              {
                "encounter_id": "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
                "attachment_type": "DOCUMENTATION",
                "created_at": "2024-01-15T09:30:00.000Z",
                "created_by": {
                  "user_id": "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
                  "idp_metadata": [
                    {
                      "type": "auth_zero_metadata",
                      "auth0_id": "auth0_id"
                    },
                    {
                      "type": "auth_zero_metadata",
                      "auth0_id": "auth0_id"
                    }
                  ],
                  "primary_organization_id": "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
                  "user_metadata": {
                    "type": "machine_user_metadata",
                    "name": "name"
                  }
                },
                "attachment_id": "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
                "file_name": "file_name",
                "description": "description",
                "content_type": "content_type",
                "authed_url": "authed_url"
              }
            ]
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/api/encounter-attachments/v1/d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32")
                    .UsingGet()
            )
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.EncounterAttachments.V1.GetAsync(
            "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32"
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
