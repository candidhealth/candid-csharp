using Candid.Net.Financials;
using Candid.Net.InsuranceRefunds.V1;
using Candid.Net.Payers.V3;
using Candid.Net.Test.Unit.MockServer;
using Candid.Net.Test.Utils;
using NUnit.Framework;

namespace Candid.Net.Test.Unit.MockServer.InsuranceRefunds.V1;

[TestFixture]
public class CreateTest : BaseMockServerTest
{
    [global::NUnit.Framework.Test]
    public async global::System.Threading.Tasks.Task MockServerTest()
    {
        const string requestJson = """
            {
              "payer_identifier": {
                "type": "payer_info",
                "payer_id": "payer_id",
                "payer_name": "payer_name"
              },
              "amount_cents": 1,
              "allocations": [
                {
                  "amount_cents": 1,
                  "target": {
                    "type": "service_line_by_id",
                    "value": "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32"
                  }
                },
                {
                  "amount_cents": 1,
                  "target": {
                    "type": "service_line_by_id",
                    "value": "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32"
                  }
                }
              ]
            }
            """;

        const string mockResponse = """
            {
              "insurance_refund_id": "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
              "payer": {
                "payer_uuid": "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
                "payer_id": "payer_id",
                "payer_name": "payer_name",
                "availity_payer_name": "availity_payer_name",
                "availity_claims_payer_id": "availity_claims_payer_id",
                "availity_eligibility_id": "availity_eligibility_id",
                "availity_remittance_payer_id": "availity_remittance_payer_id",
                "street_address": {
                  "zip_plus_four_code": "zip_plus_four_code",
                  "address1": "address1",
                  "address2": "address2",
                  "city": "city",
                  "state": "AA",
                  "zip_code": "zip_code"
                }
              },
              "amount_cents": 1,
              "refund_timestamp": "2024-01-15T09:30:00.000Z",
              "refund_note": "refund_note",
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
              "refund_reason": "OVERCHARGED"
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/api/insurance-refunds/v1")
                    .UsingPost()
                    .WithBodyAsJson(requestJson)
            )
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.InsuranceRefunds.V1.CreateAsync(
            new InsuranceRefundCreate
            {
                PayerIdentifier = new PayerIdentifier(
                    new PayerIdentifier.PayerInfo(
                        new PayerInfo { PayerId = "payer_id", PayerName = "payer_name" }
                    )
                ),
                AmountCents = 1,
                Allocations = new List<AllocationCreate>()
                {
                    new AllocationCreate
                    {
                        AmountCents = 1,
                        Target = new AllocationTargetCreate(
                            new AllocationTargetCreate.ServiceLineById(
                                "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32"
                            )
                        ),
                    },
                    new AllocationCreate
                    {
                        AmountCents = 1,
                        Target = new AllocationTargetCreate(
                            new AllocationTargetCreate.ServiceLineById(
                                "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32"
                            )
                        ),
                    },
                },
            }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
