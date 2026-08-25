using global::Candid.Net.Test.Unit.MockServer;
using NUnit.Framework;

namespace Candid.Net.Test.Unit.MockServer.PreEncounter.MetadataSchemas.V1;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class DeactivateTest : BaseMockServerTest
{
    [global::NUnit.Framework.Test]
    public void MockServerTest()
    {
        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/metadata-schemas/v1/d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32/version")
                    .UsingDelete()
            )
            .RespondWith(WireMock.ResponseBuilders.Response.Create().WithStatusCode(200));

        Assert.DoesNotThrowAsync(async () =>
            await Client.PreEncounter.MetadataSchemas.V1.DeactivateAsync(
                "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
                "version"
            )
        );
    }
}
