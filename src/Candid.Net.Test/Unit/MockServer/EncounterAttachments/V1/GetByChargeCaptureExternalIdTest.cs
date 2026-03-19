using global::Candid.Net.Test.Unit.MockServer;
using global::Candid.Net.Test.Utils;
using NUnit.Framework;

namespace Candid.Net.Test.Unit.MockServer.EncounterAttachments.V1;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class GetByChargeCaptureExternalIdTest : BaseMockServerTest
{
    [global::NUnit.Framework.Test]
    public async global::System.Threading.Tasks.Task MockServerTest()
    {
        const string mockResponse = """
            [
              {
                "attachment_type": "DOCUMENTATION",
                "attachment_id": "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
                "file_name": "file_name",
                "description": "description",
                "content_type": "content_type",
                "authed_url": "authed_url"
              },
              {
                "attachment_type": "DOCUMENTATION",
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
                    .WithPath(
                        "/api/encounter-attachments/v1/by-charge-capture-external-id/charge_capture_external_id"
                    )
                    .UsingGet()
            )
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.EncounterAttachments.V1.GetByChargeCaptureExternalIdAsync(
            "charge_capture_external_id"
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
