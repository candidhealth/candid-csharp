using Candid.Net.Test.Unit.MockServer;
using NUnit.Framework;

namespace Candid.Net.Test.Unit.MockServer.EncounterProviders.V2;

[TestFixture]
public class DeleteReferringProviderTest : BaseMockServerTest
{
    [global::NUnit.Framework.Test]
    public void MockServerTest()
    {
        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath(
                        "/api/encounter-providers/v2/d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32/referring-provider"
                    )
                    .UsingDelete()
            )
            .RespondWith(WireMock.ResponseBuilders.Response.Create().WithStatusCode(200));

        Assert.DoesNotThrowAsync(async () =>
            await Client.EncounterProviders.V2.DeleteReferringProviderAsync(
                "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32"
            )
        );
    }
}
