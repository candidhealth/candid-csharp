using global::Candid.Net.Test.Unit.MockServer;
using NUnit.Framework;

namespace Candid.Net.Test.Unit.MockServer.PreEncounter.Tags.V1;

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
                    .WithPath("/tags/v1/id/version")
                    .UsingDelete()
            )
            .RespondWith(WireMock.ResponseBuilders.Response.Create().WithStatusCode(200));

        Assert.DoesNotThrowAsync(async () =>
            await Client.PreEncounter.Tags.V1.DeactivateAsync("id", "version")
        );
    }
}
