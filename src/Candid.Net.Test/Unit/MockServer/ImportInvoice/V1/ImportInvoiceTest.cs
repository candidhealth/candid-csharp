using global::Candid.Net.ImportInvoice.V1;
using global::Candid.Net.Invoices.V2;
using global::Candid.Net.Test.Unit.MockServer;
using global::Candid.Net.Test.Utils;
using NUnit.Framework;

namespace Candid.Net.Test.Unit.MockServer.ImportInvoice.V1;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class ImportInvoiceTest : BaseMockServerTest
{
    [global::NUnit.Framework.Test]
    public async global::System.Threading.Tasks.Task MockServerTest()
    {
        const string requestJson = """
            {
              "external_payment_account_config_id": "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
              "patient_external_id": "patient_external_id",
              "external_customer_identifier": "external_customer_identifier",
              "items": [
                {
                  "attribution": {
                    "type": "service_line_id",
                    "value": "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32"
                  },
                  "amount_cents": 1
                },
                {
                  "attribution": {
                    "type": "service_line_id",
                    "value": "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32"
                  },
                  "amount_cents": 1
                }
              ],
              "status": "DRAFT",
              "external_identifier": "external_identifier"
            }
            """;

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
                    .WithPath("/api/import-invoice/v1")
                    .UsingPost()
                    .WithBodyAsJson(requestJson)
            )
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.ImportInvoice.V1.ImportInvoiceAsync(
            new CreateImportInvoiceRequest
            {
                ExternalPaymentAccountConfigId = "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
                PatientExternalId = "patient_external_id",
                ExternalCustomerIdentifier = "external_customer_identifier",
                Items = new List<InvoiceItemCreate>()
                {
                    new InvoiceItemCreate
                    {
                        Attribution = new InvoiceItemAttributionCreate(
                            new InvoiceItemAttributionCreate.ServiceLineId(
                                "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32"
                            )
                        ),
                        AmountCents = 1,
                    },
                    new InvoiceItemCreate
                    {
                        Attribution = new InvoiceItemAttributionCreate(
                            new InvoiceItemAttributionCreate.ServiceLineId(
                                "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32"
                            )
                        ),
                        AmountCents = 1,
                    },
                },
                Status = global::Candid.Net.Invoices.V2.InvoiceStatus.Draft,
                ExternalIdentifier = "external_identifier",
            }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
