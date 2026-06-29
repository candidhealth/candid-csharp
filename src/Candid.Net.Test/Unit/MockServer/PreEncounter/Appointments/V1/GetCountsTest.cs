using global::Candid.Net.PreEncounter.Appointments.V1;
using global::Candid.Net.Test.Unit.MockServer;
using global::Candid.Net.Test.Utils;
using NUnit.Framework;

namespace Candid.Net.Test.Unit.MockServer.PreEncounter.Appointments.V1;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class GetCountsTest : BaseMockServerTest
{
    [global::NUnit.Framework.Test]
    public async global::System.Threading.Tasks.Task MockServerTest()
    {
        const string mockResponse = """
            {
              "not_ready_reason_counts": {
                "INACTIVE_PRIMARY": 1
              }
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/appointments/v1/visits/counts")
                    .UsingGet()
            )
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.PreEncounter.Appointments.V1.GetCountsAsync(
            new CountsRequest()
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
