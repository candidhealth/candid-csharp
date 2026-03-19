using global::Candid.Net.Test.Unit.MockServer;
using NUnit.Framework;

namespace Candid.Net.Test.Unit.MockServer.PatientPayments.V4;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class DeleteTest : BaseMockServerTest
{
    [global::NUnit.Framework.Test]
    public void MockServerTest()
    {
        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/api/patient-payments/v4/d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32")
                    .UsingDelete()
            )
            .RespondWith(WireMock.ResponseBuilders.Response.Create().WithStatusCode(200));

        Assert.DoesNotThrowAsync(async () =>
            await Client.PatientPayments.V4.DeleteAsync("d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32")
        );
    }
}
