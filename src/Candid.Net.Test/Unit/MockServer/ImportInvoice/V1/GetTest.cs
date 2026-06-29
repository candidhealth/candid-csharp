using global::Candid.Net.Test.Unit.MockServer;
using global::Candid.Net.Test.Utils;
using NUnit.Framework;

namespace Candid.Net.Test.Unit.MockServer.ImportInvoice.V1;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class GetTest : BaseMockServerTest
{
    [global::NUnit.Framework.Test]
    public async global::System.Threading.Tasks.Task MockServerTest()
    {
        const string mockResponse = """
            {
              "id": "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
              "created_at": "2024-01-15T09:30:00.000Z",
              "updated_at": "2024-01-15T09:30:00.000Z",
              "items": {
                "claim_invoice_items": {
                  "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32": {
                    "claim_invoice_item": {
                      "claim_id": "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
                      "amount_cents": 1
                    },
                    "service_line_invoice_items": {
                      "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32": {
                        "service_line_id": "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
                        "amount_cents": 1
                      }
                    }
                  }
                },
                "unattributed_items": [
                  {
                    "amount_cents": 1
                  },
                  {
                    "amount_cents": 1
                  }
                ]
              },
              "patient_external_id": "patient_external_id",
              "external_customer_identifier": "external_customer_identifier",
              "status": "DRAFT",
              "external_identifier": "external_identifier",
              "note": "note",
              "customer_invoice_url": "customer_invoice_url",
              "due_date": "2023-01-15",
              "amount_cents": 1
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/api/import-invoice/v1/d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32")
                    .UsingGet()
            )
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.ImportInvoice.V1.GetAsync(
            "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32"
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
