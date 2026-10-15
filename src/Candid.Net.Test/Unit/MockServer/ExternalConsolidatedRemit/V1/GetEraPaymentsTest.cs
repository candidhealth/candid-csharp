using global::Candid.Net.Test.Unit.MockServer;
using global::Candid.Net.Test.Utils;
using NUnit.Framework;

namespace Candid.Net.Test.Unit.MockServer.ExternalConsolidatedRemit.V1;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class GetEraPaymentsTest : BaseMockServerTest
{
    [global::NUnit.Framework.Test]
    public async global::System.Threading.Tasks.Task MockServerTest()
    {
        const string mockResponse = """
            {
              "consolidated_remit_id": "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
              "era_payments": [
                {
                  "era_payment": {
                    "id": "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
                    "era_document": {
                      "id": "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
                      "source": "source",
                      "storage_path": "storage_path",
                      "status": "queued"
                    },
                    "posted_at": "2024-01-15T09:30:00.000Z",
                    "payer": {
                      "id": "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
                      "payer_name": "payer_name",
                      "payer_identifier": "payer_identifier"
                    },
                    "payment_method_code": "ACH",
                    "check_eft_trace_number": "check_eft_trace_number",
                    "check_issued_or_eft_effective_date": "check_issued_or_eft_effective_date",
                    "total_payment_amount_cents": 1
                  },
                  "is_primary": true
                },
                {
                  "era_payment": {
                    "id": "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
                    "era_document": {
                      "id": "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
                      "source": "source",
                      "storage_path": "storage_path",
                      "status": "queued"
                    },
                    "posted_at": "2024-01-15T09:30:00.000Z",
                    "payer": {
                      "id": "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
                      "payer_name": "payer_name",
                      "payer_identifier": "payer_identifier"
                    },
                    "payment_method_code": "ACH",
                    "check_eft_trace_number": "check_eft_trace_number",
                    "check_issued_or_eft_effective_date": "check_issued_or_eft_effective_date",
                    "total_payment_amount_cents": 1
                  },
                  "is_primary": true
                }
              ]
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath(
                        "/api/external-consolidated-remit/v1/d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32/era-payments"
                    )
                    .UsingGet()
            )
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.ExternalConsolidatedRemit.V1.GetEraPaymentsAsync(
            "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32"
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
