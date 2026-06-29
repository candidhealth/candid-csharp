using global::Candid.Net.Test.Unit.MockServer;
using NUnit.Framework;

namespace Candid.Net.Test.Unit.MockServer.Credentialing.V2;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class DeleteFacilityTest : BaseMockServerTest
{
    [global::NUnit.Framework.Test]
    public void MockServerTest()
    {
        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath(
                        "/api/provider-credentialing-span/v2/facility/d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32"
                    )
                    .UsingDelete()
            )
            .RespondWith(WireMock.ResponseBuilders.Response.Create().WithStatusCode(200));

        Assert.DoesNotThrowAsync(async () =>
            await Client.Credentialing.V2.DeleteFacilityAsync(
                "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32"
            )
        );
    }
}
