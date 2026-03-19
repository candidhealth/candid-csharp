using global::Candid.Net.Test.Unit.MockServer;
using global::Candid.Net.Test.Utils;
using NUnit.Framework;

namespace Candid.Net.Test.Unit.MockServer.InsuranceAdjudications.V1;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class GetTest : BaseMockServerTest
{
    [global::NUnit.Framework.Test]
    public async global::System.Threading.Tasks.Task MockServerTest()
    {
        const string mockResponse = """
            {
              "insurance_adjudication_id": "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
              "payer_uuid": "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
              "post_date": "2023-01-15",
              "check_number": "check_number",
              "check_date": "2023-01-15",
              "note": "note",
              "claims": {
                "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32": [
                  {
                    "claim_id": "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
                    "insurance_allowed_amount_cents": 1,
                    "insurance_paid_amount_cents": 1,
                    "charge_amount_cents": 1,
                    "service_lines": {
                      "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32": [
                        {
                          "service_line_adjudication_id": "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
                          "denial_reason": "Authorization Required",
                          "insurance_allowed_amount_cents": 1,
                          "insurance_paid_amount_cents": 1,
                          "deductible_amount_cents": 1,
                          "coinsurance_amount_cents": 1,
                          "copay_amount_cents": 1,
                          "carcs": [
                            {
                              "group_code": "CO",
                              "reason_code": "1",
                              "amount_cents": 1
                            },
                            {
                              "group_code": "CO",
                              "reason_code": "1",
                              "amount_cents": 1
                            }
                          ],
                          "rarcs": [
                            {
                              "reason_code": "M1"
                            },
                            {
                              "reason_code": "M1"
                            }
                          ]
                        },
                        {
                          "service_line_adjudication_id": "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
                          "denial_reason": "Authorization Required",
                          "insurance_allowed_amount_cents": 1,
                          "insurance_paid_amount_cents": 1,
                          "deductible_amount_cents": 1,
                          "coinsurance_amount_cents": 1,
                          "copay_amount_cents": 1,
                          "carcs": [
                            {
                              "group_code": "CO",
                              "reason_code": "1",
                              "amount_cents": 1
                            },
                            {
                              "group_code": "CO",
                              "reason_code": "1",
                              "amount_cents": 1
                            }
                          ],
                          "rarcs": [
                            {
                              "reason_code": "M1"
                            },
                            {
                              "reason_code": "M1"
                            }
                          ]
                        }
                      ]
                    },
                    "payer_claim_number": "payer_claim_number",
                    "carcs": [
                      {
                        "group_code": "CO",
                        "reason_code": "1",
                        "amount_cents": 1
                      },
                      {
                        "group_code": "CO",
                        "reason_code": "1",
                        "amount_cents": 1
                      }
                    ]
                  },
                  {
                    "claim_id": "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
                    "insurance_allowed_amount_cents": 1,
                    "insurance_paid_amount_cents": 1,
                    "charge_amount_cents": 1,
                    "service_lines": {
                      "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32": [
                        {
                          "service_line_adjudication_id": "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
                          "denial_reason": "Authorization Required",
                          "insurance_allowed_amount_cents": 1,
                          "insurance_paid_amount_cents": 1,
                          "deductible_amount_cents": 1,
                          "coinsurance_amount_cents": 1,
                          "copay_amount_cents": 1,
                          "carcs": [
                            {
                              "group_code": "CO",
                              "reason_code": "1",
                              "amount_cents": 1
                            },
                            {
                              "group_code": "CO",
                              "reason_code": "1",
                              "amount_cents": 1
                            }
                          ],
                          "rarcs": [
                            {
                              "reason_code": "M1"
                            },
                            {
                              "reason_code": "M1"
                            }
                          ]
                        },
                        {
                          "service_line_adjudication_id": "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
                          "denial_reason": "Authorization Required",
                          "insurance_allowed_amount_cents": 1,
                          "insurance_paid_amount_cents": 1,
                          "deductible_amount_cents": 1,
                          "coinsurance_amount_cents": 1,
                          "copay_amount_cents": 1,
                          "carcs": [
                            {
                              "group_code": "CO",
                              "reason_code": "1",
                              "amount_cents": 1
                            },
                            {
                              "group_code": "CO",
                              "reason_code": "1",
                              "amount_cents": 1
                            }
                          ],
                          "rarcs": [
                            {
                              "reason_code": "M1"
                            },
                            {
                              "reason_code": "M1"
                            }
                          ]
                        }
                      ]
                    },
                    "payer_claim_number": "payer_claim_number",
                    "carcs": [
                      {
                        "group_code": "CO",
                        "reason_code": "1",
                        "amount_cents": 1
                      },
                      {
                        "group_code": "CO",
                        "reason_code": "1",
                        "amount_cents": 1
                      }
                    ]
                  }
                ]
              }
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath(
                        "/api/insurance-adjudications/v1/d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32"
                    )
                    .UsingGet()
            )
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.InsuranceAdjudications.V1.GetAsync(
            "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32"
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
