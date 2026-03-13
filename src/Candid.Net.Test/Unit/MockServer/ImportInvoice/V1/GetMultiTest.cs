using Candid.Net.ImportInvoice.V1;
using Candid.Net.Test.Unit.MockServer;
using Candid.Net.Test.Utils;
using NUnit.Framework;

namespace Candid.Net.Test.Unit.MockServer.ImportInvoice.V1;

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
                },
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
              ],
              "prev_page_token": "prev_page_token",
              "next_page_token": "next_page_token"
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/api/import-invoice/v1")
                    .UsingGet()
            )
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.ImportInvoice.V1.GetMultiAsync(
            new SearchImportedInvoicesRequest()
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
