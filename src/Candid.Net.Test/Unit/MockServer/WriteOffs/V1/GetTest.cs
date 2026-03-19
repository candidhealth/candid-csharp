using global::Candid.Net.Test.Unit.MockServer;
using global::Candid.Net.Test.Utils;
using NUnit.Framework;

namespace Candid.Net.Test.Unit.MockServer.WriteOffs.V1;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class GetTest : BaseMockServerTest
{
    [global::NUnit.Framework.Test]
    public async global::System.Threading.Tasks.Task MockServerTest()
    {
        const string mockResponse = """
            {
              "type": "patient",
              "write_off_id": "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
              "write_off_timestamp": "2024-01-15T09:30:00.000Z",
              "write_off_note": "write_off_note",
              "write_off_reason": "SMALL_BALANCE",
              "patient_external_id": "patient_external_id",
              "claim_id": "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
              "service_line_id": "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
              "reverts_write_off_id": "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
              "reverted_by_write_off_id": "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
              "amount_cents": 1
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/api/write-offs/v1/d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32")
                    .UsingGet()
            )
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.WriteOffs.V1.GetAsync("d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32");
        JsonAssert.AreEqual(response, mockResponse);
    }
}
