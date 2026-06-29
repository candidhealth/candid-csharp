using global::Candid.Net.Test.Unit.MockServer;
using NUnit.Framework;

namespace Candid.Net.Test.Unit.MockServer.EncounterProviders.V2;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class DeleteInitialReferringProviderTest : BaseMockServerTest
{
    [global::NUnit.Framework.Test]
    public void MockServerTest()
    {
        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath(
                        "/api/encounter-providers/v2/d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32/initial-referring-provider"
                    )
                    .UsingDelete()
            )
            .RespondWith(WireMock.ResponseBuilders.Response.Create().WithStatusCode(200));

        Assert.DoesNotThrowAsync(async () =>
            await Client.EncounterProviders.V2.DeleteInitialReferringProviderAsync(
                "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32"
            )
        );
    }
}
