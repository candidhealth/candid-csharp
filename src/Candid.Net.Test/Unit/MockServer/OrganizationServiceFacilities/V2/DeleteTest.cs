using Candid.Net.Test.Unit.MockServer;
using NUnit.Framework;

namespace Candid.Net.Test.Unit.MockServer.OrganizationServiceFacilities.V2;

[TestFixture]
public class DeleteTest : BaseMockServerTest
{
    [global::NUnit.Framework.Test]
    public void MockServerTest()
    {
        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath(
                        "/api/organization-service-facilities/v2/30F55EE6-8C0E-43FC-A7FC-DAC00D5BF569"
                    )
                    .UsingDelete()
            )
            .RespondWith(WireMock.ResponseBuilders.Response.Create().WithStatusCode(200));

        Assert.DoesNotThrowAsync(async () =>
            await Client.OrganizationServiceFacilities.V2.DeleteAsync(
                "30F55EE6-8C0E-43FC-A7FC-DAC00D5BF569"
            )
        );
    }
}
