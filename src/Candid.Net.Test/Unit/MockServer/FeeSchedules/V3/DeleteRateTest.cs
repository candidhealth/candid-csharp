using global::Candid.Net.Test.Unit.MockServer;
using NUnit.Framework;

namespace Candid.Net.Test.Unit.MockServer.FeeSchedules.V3;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class DeleteRateTest : BaseMockServerTest
{
    [global::NUnit.Framework.Test]
    public void MockServerTest()
    {
        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/api/fee-schedules/v3/d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32/1")
                    .UsingDelete()
            )
            .RespondWith(WireMock.ResponseBuilders.Response.Create().WithStatusCode(200));

        Assert.DoesNotThrowAsync(async () =>
            await Client.FeeSchedules.V3.DeleteRateAsync("d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32", 1)
        );
    }
}
