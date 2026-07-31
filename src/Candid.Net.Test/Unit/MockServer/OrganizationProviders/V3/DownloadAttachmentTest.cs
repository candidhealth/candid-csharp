using global::Candid.Net.OrganizationProviders.V3;
using global::Candid.Net.Test.Unit.MockServer;
using global::Candid.Net.Test.Utils;
using NUnit.Framework;

namespace Candid.Net.Test.Unit.MockServer.OrganizationProviders.V3;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class DownloadAttachmentTest : BaseMockServerTest
{
    [global::NUnit.Framework.Test]
    public async global::System.Threading.Tasks.Task MockServerTest()
    {
        const string mockResponse = """
            {
              "signed_download_url": "signed_download_url"
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/api/organization-providers/v3/attachments/download")
                    .WithParam("attachment_id", "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32")
                    .UsingGet()
            )
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.OrganizationProviders.V3.DownloadAttachmentAsync(
            new DownloadProviderAttachmentRequest
            {
                AttachmentId = "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
            }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
