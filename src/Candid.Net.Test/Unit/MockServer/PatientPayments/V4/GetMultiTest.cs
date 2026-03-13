using Candid.Net.PatientPayments.V4;
using Candid.Net.Test.Unit.MockServer;
using Candid.Net.Test.Utils;
using NUnit.Framework;

namespace Candid.Net.Test.Unit.MockServer.PatientPayments.V4;

[TestFixture]
public class GetMultiTest : BaseMockServerTest
{
    [global::NUnit.Framework.Test]
    public async global::System.Threading.Tasks.Task MockServerTest()
    {
        const string mockResponse = """
            {
              "items": [
                {
                  "patient_payment_id": "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
                  "organization_id": "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
                  "source_internal_id": "source_internal_id",
                  "payment_source": "MANUAL_ENTRY",
                  "amount_cents": 1,
                  "patient_external_id": "patient_external_id",
                  "payment_timestamp": "2024-01-15T09:30:00.000Z",
                  "payment_note": "payment_note",
                  "allocations": [
                    {
                      "amount_cents": 1,
                      "target": {
                        "type": "service_line",
                        "service_line_id": "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
                        "claim_id": "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
                        "encounter_id": "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32"
                      },
                      "earmark": {
                        "id": "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
                        "target": {
                          "type": "date_of_service",
                          "value": "target"
                        },
                        "amount_earmarked_cents": 1,
                        "created_by_allocation_id": "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32"
                      },
                      "allocated_on": "2024-01-15T09:30:00.000Z"
                    },
                    {
                      "amount_cents": 1,
                      "target": {
                        "type": "service_line",
                        "service_line_id": "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
                        "claim_id": "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
                        "encounter_id": "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32"
                      },
                      "earmark": {
                        "id": "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
                        "target": {
                          "type": "date_of_service",
                          "value": "target"
                        },
                        "amount_earmarked_cents": 1,
                        "created_by_allocation_id": "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32"
                      },
                      "allocated_on": "2024-01-15T09:30:00.000Z"
                    }
                  ],
                  "invoice": "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
                  "payment_method_detail": {
                    "payment_method": {
                      "type": "cash"
                    },
                    "collected_at_address": {
                      "zip_plus_four_code": "zip_plus_four_code",
                      "address1": "address1",
                      "address2": "address2",
                      "city": "city",
                      "state": "AA",
                      "zip_code": "zip_code"
                    }
                  }
                },
                {
                  "patient_payment_id": "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
                  "organization_id": "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
                  "source_internal_id": "source_internal_id",
                  "payment_source": "MANUAL_ENTRY",
                  "amount_cents": 1,
                  "patient_external_id": "patient_external_id",
                  "payment_timestamp": "2024-01-15T09:30:00.000Z",
                  "payment_note": "payment_note",
                  "allocations": [
                    {
                      "amount_cents": 1,
                      "target": {
                        "type": "service_line",
                        "service_line_id": "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
                        "claim_id": "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
                        "encounter_id": "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32"
                      },
                      "earmark": {
                        "id": "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
                        "target": {
                          "type": "date_of_service",
                          "value": "target"
                        },
                        "amount_earmarked_cents": 1,
                        "created_by_allocation_id": "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32"
                      },
                      "allocated_on": "2024-01-15T09:30:00.000Z"
                    },
                    {
                      "amount_cents": 1,
                      "target": {
                        "type": "service_line",
                        "service_line_id": "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
                        "claim_id": "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
                        "encounter_id": "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32"
                      },
                      "earmark": {
                        "id": "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
                        "target": {
                          "type": "date_of_service",
                          "value": "target"
                        },
                        "amount_earmarked_cents": 1,
                        "created_by_allocation_id": "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32"
                      },
                      "allocated_on": "2024-01-15T09:30:00.000Z"
                    }
                  ],
                  "invoice": "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
                  "payment_method_detail": {
                    "payment_method": {
                      "type": "cash"
                    },
                    "collected_at_address": {
                      "zip_plus_four_code": "zip_plus_four_code",
                      "address1": "address1",
                      "address2": "address2",
                      "city": "city",
                      "state": "AA",
                      "zip_code": "zip_code"
                    }
                  }
                }
              ],
              "prev_page_token": "prev_page_token",
              "next_page_token": "next_page_token"
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/api/patient-payments/v4")
                    .UsingGet()
            )
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.PatientPayments.V4.GetMultiAsync(
            new GetMultiPatientPaymentsRequest()
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
