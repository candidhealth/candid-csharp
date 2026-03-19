using global::Candid.Net.Exports.V3;
using global::Candid.Net.Test.Unit.MockServer;
using global::Candid.Net.Test.Utils;
using NUnit.Framework;

namespace Candid.Net.Test.Unit.MockServer.Exports.V3;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class GetExportsTest : BaseMockServerTest
{
    [global::NUnit.Framework.Test]
    public async global::System.Threading.Tasks.Task MockServerTest()
    {
        const string mockResponse = """
            {
              "name": "John Doe",
              "created_at": "2021-10-07T00:00:00.000Z",
              "authenticated_download_url": "https://example.com",
              "authenticated_download_url_expiration": "2021-10-07T00:02:00.000Z"
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/api/exports/v3")
                    .WithParam("start_date", "2023-10-01")
                    .WithParam("end_date", "2023-10-02")
                    .UsingGet()
            )
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.Exports.V3.GetExportsAsync(
            new GetExportsRequest
            {
                StartDate = new DateOnly(2023, 10, 1),
                EndDate = new DateOnly(2023, 10, 2),
            }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
