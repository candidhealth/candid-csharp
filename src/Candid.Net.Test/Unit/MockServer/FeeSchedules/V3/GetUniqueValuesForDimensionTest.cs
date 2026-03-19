using global::Candid.Net.FeeSchedules.V3;
using global::Candid.Net.Test.Unit.MockServer;
using global::Candid.Net.Test.Utils;
using NUnit.Framework;

namespace Candid.Net.Test.Unit.MockServer.FeeSchedules.V3;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class GetUniqueValuesForDimensionTest : BaseMockServerTest
{
    [global::NUnit.Framework.Test]
    public async global::System.Threading.Tasks.Task MockServerTest()
    {
        const string mockResponse = """
            {
              "dimensions": [
                {
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
                {
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
                    .WithPath("/api/fee-schedules/v3/unique-dimension-values")
                    .WithParam("pivot_dimension", "payer_uuid")
                    .UsingGet()
            )
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.FeeSchedules.V3.GetUniqueValuesForDimensionAsync(
            new GetUniqueDimensionValuesRequest { PivotDimension = DimensionName.PayerUuid }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
