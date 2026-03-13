using System.Globalization;
using Candid.Net.Test.Unit.MockServer;
using Candid.Net.Test.Utils;
using Candid.Net.WriteOffs.V1;
using NUnit.Framework;

namespace Candid.Net.Test.Unit.MockServer.WriteOffs.V1;

[TestFixture]
public class CreateTest : BaseMockServerTest
{
    [global::NUnit.Framework.Test]
    public async global::System.Threading.Tasks.Task MockServerTest()
    {
        const string requestJson = """
            {
              "write_offs": [
                {
                  "type": "patient",
                  "write_off_timestamp": "2024-01-15T09:30:00.000Z",
                  "write_off_reason": "SMALL_BALANCE",
                  "service_line_id": "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
                  "amount_cents": 1
                },
                {
                  "type": "patient",
                  "write_off_timestamp": "2024-01-15T09:30:00.000Z",
                  "write_off_reason": "SMALL_BALANCE",
                  "service_line_id": "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
                  "amount_cents": 1
                }
              ]
            }
            """;

        const string mockResponse = """
            {
              "write_offs": [
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
              ]
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/api/write-offs/v1")
                    .UsingPost()
                    .WithBodyAsJson(requestJson)
            )
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.WriteOffs.V1.CreateAsync(
            new CreateWriteOffsRequest
            {
                WriteOffs = new List<WriteOffCreate>()
                {
                    new WriteOffCreate(
                        new global::Candid.Net.WriteOffs.V1.WriteOffCreate.Patient(
                            new PatientWriteOffCreate
                            {
                                WriteOffTimestamp = DateTime.Parse(
                                    "2024-01-15T09:30:00.000Z",
                                    null,
                                    DateTimeStyles.AdjustToUniversal
                                ),
                                WriteOffReason = PatientWriteOffReason.SmallBalance,
                                ServiceLineId = "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
                                AmountCents = 1,
                            }
                        )
                    ),
                    new WriteOffCreate(
                        new global::Candid.Net.WriteOffs.V1.WriteOffCreate.Patient(
                            new PatientWriteOffCreate
                            {
                                WriteOffTimestamp = DateTime.Parse(
                                    "2024-01-15T09:30:00.000Z",
                                    null,
                                    DateTimeStyles.AdjustToUniversal
                                ),
                                WriteOffReason = PatientWriteOffReason.SmallBalance,
                                ServiceLineId = "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
                                AmountCents = 1,
                            }
                        )
                    ),
                },
            }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
