using global::Candid.Net.Test.Unit.MockServer;
using global::Candid.Net.Test.Utils;
using NUnit.Framework;

namespace Candid.Net.Test.Unit.MockServer.OrganizationProviders.V3;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class ListAttachmentsTest : BaseMockServerTest
{
    [global::NUnit.Framework.Test]
    public async global::System.Threading.Tasks.Task MockServerTest()
    {
        const string mockResponse = """
            [
              {
                "provider_attachment_id": "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
                "organization_provider_id": "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
                "file_name": "file_name",
                "file_type": "W9",
                "description": "description",
                "content_type": "content_type",
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
                }
              },
              {
                "provider_attachment_id": "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
                "organization_provider_id": "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
                "file_name": "file_name",
                "file_type": "W9",
                "description": "description",
                "content_type": "content_type",
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
                }
              }
            ]
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath(
                        "/api/organization-providers/v3/d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32/attachments"
                    )
                    .UsingGet()
            )
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.OrganizationProviders.V3.ListAttachmentsAsync(
            "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32"
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
