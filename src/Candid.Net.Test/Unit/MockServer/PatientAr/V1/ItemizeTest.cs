using global::Candid.Net.Test.Unit.MockServer;
using global::Candid.Net.Test.Utils;
using NUnit.Framework;

namespace Candid.Net.Test.Unit.MockServer.PatientAr.V1;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class ItemizeTest : BaseMockServerTest
{
    [global::NUnit.Framework.Test]
    public async global::System.Threading.Tasks.Task MockServerTest()
    {
        const string mockResponse = """
            {
              "claim_id": "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
              "patient_balance_cents": 1,
              "claim_level_patient_payments": {
                "total_payment_cents": 1,
                "items": [
                  {
                    "source_id": "source_id",
                    "amount_cents": 1
                  },
                  {
                    "source_id": "source_id",
                    "amount_cents": 1
                  }
                ]
              },
              "service_line_itemization": [
                {
                  "service_line_id": "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
                  "procedure_code": "procedure_code",
                  "date_of_service": "2023-01-15",
                  "patient_balance_cents": 1,
                  "charge_amount_cents": 1,
                  "insurance_adjustments": {
                    "total_adjustment_cents": 1
                  },
                  "insurance_payments": {
                    "total_payment_cents": 1
                  },
                  "non_insurance_adjustments": {
                    "total_adjustment_cents": 1
                  },
                  "non_insurance_payments": {
                    "total_payment_cents": 1
                  },
                  "patient_adjustments": {
                    "total_adjustment_cents": 1
                  },
                  "patient_payments": {
                    "total_payment_cents": 1,
                    "items": [
                      {
                        "source_id": "source_id",
                        "amount_cents": 1
                      },
                      {
                        "source_id": "source_id",
                        "amount_cents": 1
                      }
                    ]
                  },
                  "copay_cents": 1,
                  "coinsurance_cents": 1,
                  "deductible_cents": 1
                },
                {
                  "service_line_id": "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
                  "procedure_code": "procedure_code",
                  "date_of_service": "2023-01-15",
                  "patient_balance_cents": 1,
                  "charge_amount_cents": 1,
                  "insurance_adjustments": {
                    "total_adjustment_cents": 1
                  },
                  "insurance_payments": {
                    "total_payment_cents": 1
                  },
                  "non_insurance_adjustments": {
                    "total_adjustment_cents": 1
                  },
                  "non_insurance_payments": {
                    "total_payment_cents": 1
                  },
                  "patient_adjustments": {
                    "total_adjustment_cents": 1
                  },
                  "patient_payments": {
                    "total_payment_cents": 1,
                    "items": [
                      {
                        "source_id": "source_id",
                        "amount_cents": 1
                      },
                      {
                        "source_id": "source_id",
                        "amount_cents": 1
                      }
                    ]
                  },
                  "copay_cents": 1,
                  "coinsurance_cents": 1,
                  "deductible_cents": 1
                }
              ]
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath(
                        "/api/patient-ar/v1/invoice-itemization/d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32"
                    )
                    .UsingGet()
            )
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.PatientAr.V1.ItemizeAsync(
            "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32"
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
