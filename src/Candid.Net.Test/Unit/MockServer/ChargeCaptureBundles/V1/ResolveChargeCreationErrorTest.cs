using Candid.Net.ChargeCaptureBundles.V1;
using Candid.Net.Test.Unit.MockServer;
using NUnit.Framework;

namespace Candid.Net.Test.Unit.MockServer.ChargeCaptureBundles.V1;

[TestFixture]
public class ResolveChargeCreationErrorTest : BaseMockServerTest
{
    [global::NUnit.Framework.Test]
    public void MockServerTest()
    {
        const string requestJson = """
            {}
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath(
                        "/api/charge_capture_claim_creation/v1/error/d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32"
                    )
                    .UsingPatch()
                    .WithBodyAsJson(requestJson)
            )
            .RespondWith(WireMock.ResponseBuilders.Response.Create().WithStatusCode(200));

        Assert.DoesNotThrowAsync(async () =>
            await Client.ChargeCaptureBundles.V1.ResolveChargeCreationErrorAsync(
                "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
                new ChargeCaptureBundleErrorResolution()
            )
        );
    }
}
