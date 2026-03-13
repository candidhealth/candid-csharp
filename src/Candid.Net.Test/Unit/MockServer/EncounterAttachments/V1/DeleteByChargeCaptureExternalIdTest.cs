using Candid.Net.EncounterAttachments.V1;
using Candid.Net.Test.Unit.MockServer;
using NUnit.Framework;

namespace Candid.Net.Test.Unit.MockServer.EncounterAttachments.V1;

[TestFixture]
public class DeleteByChargeCaptureExternalIdTest : BaseMockServerTest
{
    [global::NUnit.Framework.Test]
    public void MockServerTest()
    {
        const string requestJson = """
            {
              "attachment_id": "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32"
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath(
                        "/api/encounter-attachments/v1/by-charge-capture-external-id/charge_capture_external_id"
                    )
                    .UsingDelete()
                    .WithBodyAsJson(requestJson)
            )
            .RespondWith(WireMock.ResponseBuilders.Response.Create().WithStatusCode(200));

        Assert.DoesNotThrowAsync(async () =>
            await Client.EncounterAttachments.V1.DeleteByChargeCaptureExternalIdAsync(
                "charge_capture_external_id",
                new DeleteExternalAttachmentRequest
                {
                    AttachmentId = "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
                }
            )
        );
    }
}
