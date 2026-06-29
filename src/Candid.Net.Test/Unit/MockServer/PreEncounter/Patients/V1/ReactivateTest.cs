using global::Candid.Net.Test.Unit.MockServer;
using NUnit.Framework;

namespace Candid.Net.Test.Unit.MockServer.PreEncounter.Patients.V1;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class ReactivateTest : BaseMockServerTest
{
    [global::NUnit.Framework.Test]
    public void MockServerTest()
    {
        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/patients/v1/id/version")
                    .UsingPatch()
            )
            .RespondWith(WireMock.ResponseBuilders.Response.Create().WithStatusCode(200));

        Assert.DoesNotThrowAsync(async () =>
            await Client.PreEncounter.Patients.V1.ReactivateAsync("id", "version")
        );
    }
}
