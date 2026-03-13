using Candid.Net.Test.Unit.MockServer;
using Candid.Net.Test.Utils;
using NUnit.Framework;

namespace Candid.Net.Test.Unit.MockServer.FeeSchedules.V3;

[TestFixture]
public class GetRateHistoryTest : BaseMockServerTest
{
    [global::NUnit.Framework.Test]
    public async global::System.Threading.Tasks.Task MockServerTest()
    {
        const string mockResponse = """
            [
              {
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
              },
              {
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
            ]
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/api/fee-schedules/v3/d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32/history")
                    .UsingGet()
            )
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.FeeSchedules.V3.GetRateHistoryAsync(
            "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32"
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
