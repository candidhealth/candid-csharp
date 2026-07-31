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
                "file_type": "W9"
              },
              {
                "provider_attachment_id": "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
                "organization_provider_id": "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
                "file_name": "file_name",
                "file_type": "W9"
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
