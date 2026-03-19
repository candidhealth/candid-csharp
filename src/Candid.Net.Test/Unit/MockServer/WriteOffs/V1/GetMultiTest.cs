using global::Candid.Net.Test.Unit.MockServer;
using global::Candid.Net.Test.Utils;
using global::Candid.Net.WriteOffs.V1;
using NUnit.Framework;

namespace Candid.Net.Test.Unit.MockServer.WriteOffs.V1;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class GetMultiTest : BaseMockServerTest
{
    [global::NUnit.Framework.Test]
    public async global::System.Threading.Tasks.Task MockServerTest()
    {
        const string mockResponse = """
            {
              "items": [
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
                },
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
              ],
              "prev_page_token": "prev_page_token",
              "next_page_token": "next_page_token"
            }
            """;

        Server
            .Given(
                WireMock.RequestBuilders.Request.Create().WithPath("/api/write-offs/v1").UsingGet()
            )
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.WriteOffs.V1.GetMultiAsync(new GetMultiWriteOffsRequest());
        JsonAssert.AreEqual(response, mockResponse);
    }
}
