using global::Candid.Net.FeeSchedules.V3;
using global::Candid.Net.Test.Unit.MockServer;
using global::Candid.Net.Test.Utils;
using NUnit.Framework;

namespace Candid.Net.Test.Unit.MockServer.FeeSchedules.V3;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class BatchMatchTest : BaseMockServerTest
{
    [global::NUnit.Framework.Test]
    public async global::System.Threading.Tasks.Task MockServerTest()
    {
        const string requestJson = """
            [
              {
                "payer_uuid": "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
                "organization_billing_provider_id": "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
                "cpt_code": "cpt_code",
                "date_of_service": "2023-01-15"
              },
              {
                "payer_uuid": "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
                "organization_billing_provider_id": "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
                "cpt_code": "cpt_code",
                "date_of_service": "2023-01-15"
              }
            ]
            """;

        const string mockResponse = """
            [
              {
                "point": {
                  "payer_uuid": "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
                  "organization_billing_provider_id": "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
                  "cpt_code": "cpt_code",
                  "date_of_service": "2023-01-15",
                  "modifiers": [
                    "AV",
                    "AV"
                  ],
                  "facility_type_code": "01",
                  "state": "AA",
                  "zip_code": "zip_code",
                  "license_type": "MD",
                  "network_types": [
                    "12",
                    "12"
                  ],
                  "payer_plan_group_id": "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
                  "quantity": "quantity"
                },
                "match": {
                  "matched_entry": {
                    "start_date": "2023-01-15",
                    "end_date": "2023-01-15",
                    "rate_cents": 1,
                    "is_deactivated": true
                  },
                  "total_cents": 1,
                  "rate_id": "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
                  "dimensions": {
                    "payer_uuid": "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
                    "organization_billing_provider_id": "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
                    "states": [
                      "AA"
                    ],
                    "zip_codes": [
                      "zip_codes"
                    ],
                    "license_types": [
                      "MD"
                    ],
                    "facility_type_codes": [
                      "01"
                    ],
                    "network_types": [
                      "12"
                    ],
                    "payer_plan_group_ids": [
                      "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32"
                    ],
                    "cpt_code": "cpt_code",
                    "modifiers": [
                      "AV"
                    ]
                  },
                  "version": 1,
                  "updated_at": "2023-01-15",
                  "updated_by": "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
                  "entries": [
                    {
                      "start_date": "2023-01-15",
                      "end_date": "2023-01-15",
                      "rate_cents": 1,
                      "is_deactivated": true
                    },
                    {
                      "start_date": "2023-01-15",
                      "end_date": "2023-01-15",
                      "rate_cents": 1,
                      "is_deactivated": true
                    }
                  ]
                }
              },
              {
                "point": {
                  "payer_uuid": "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
                  "organization_billing_provider_id": "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
                  "cpt_code": "cpt_code",
                  "date_of_service": "2023-01-15",
                  "modifiers": [
                    "AV",
                    "AV"
                  ],
                  "facility_type_code": "01",
                  "state": "AA",
                  "zip_code": "zip_code",
                  "license_type": "MD",
                  "network_types": [
                    "12",
                    "12"
                  ],
                  "payer_plan_group_id": "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
                  "quantity": "quantity"
                },
                "match": {
                  "matched_entry": {
                    "start_date": "2023-01-15",
                    "end_date": "2023-01-15",
                    "rate_cents": 1,
                    "is_deactivated": true
                  },
                  "total_cents": 1,
                  "rate_id": "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
                  "dimensions": {
                    "payer_uuid": "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
                    "organization_billing_provider_id": "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
                    "states": [
                      "AA"
                    ],
                    "zip_codes": [
                      "zip_codes"
                    ],
                    "license_types": [
                      "MD"
                    ],
                    "facility_type_codes": [
                      "01"
                    ],
                    "network_types": [
                      "12"
                    ],
                    "payer_plan_group_ids": [
                      "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32"
                    ],
                    "cpt_code": "cpt_code",
                    "modifiers": [
                      "AV"
                    ]
                  },
                  "version": 1,
                  "updated_at": "2023-01-15",
                  "updated_by": "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
                  "entries": [
                    {
                      "start_date": "2023-01-15",
                      "end_date": "2023-01-15",
                      "rate_cents": 1,
                      "is_deactivated": true
                    },
                    {
                      "start_date": "2023-01-15",
                      "end_date": "2023-01-15",
                      "rate_cents": 1,
                      "is_deactivated": true
                    }
                  ]
                }
              }
            ]
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/api/fee-schedules/v3/batch-match")
                    .UsingPost()
                    .WithBodyAsJson(requestJson)
            )
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.FeeSchedules.V3.BatchMatchAsync(
            new List<BatchMatchPoint>()
            {
                new BatchMatchPoint
                {
                    PayerUuid = "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
                    OrganizationBillingProviderId = "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
                    CptCode = "cpt_code",
                    DateOfService = new DateOnly(2023, 1, 15),
                },
                new BatchMatchPoint
                {
                    PayerUuid = "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
                    OrganizationBillingProviderId = "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
                    CptCode = "cpt_code",
                    DateOfService = new DateOnly(2023, 1, 15),
                },
            }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
