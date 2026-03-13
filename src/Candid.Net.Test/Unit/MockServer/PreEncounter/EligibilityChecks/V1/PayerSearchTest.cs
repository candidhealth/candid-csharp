using Candid.Net.PreEncounter.EligibilityChecks.V1;
using Candid.Net.Test.Unit.MockServer;
using Candid.Net.Test.Utils;
using NUnit.Framework;

namespace Candid.Net.Test.Unit.MockServer.PreEncounter.EligibilityChecks.V1;

[TestFixture]
public class PayerSearchTest : BaseMockServerTest
{
    [global::NUnit.Framework.Test]
    public async global::System.Threading.Tasks.Task MockServerTest()
    {
        const string mockResponse = """
            {
              "items": [
                {
                  "score": 1,
                  "payer": {
                    "stedi_id": "stedi_id",
                    "display_name": "display_name",
                    "primary_payer_id": "primary_payer_id",
                    "aliases": [
                      "aliases",
                      "aliases"
                    ],
                    "names": [
                      "names",
                      "names"
                    ],
                    "transaction_support": {
                      "key": "value"
                    },
                    "employer_identification_numbers": [
                      "employer_identification_numbers",
                      "employer_identification_numbers"
                    ],
                    "payer_enrollment": {
                      "key": "value"
                    },
                    "parent_payer_group": "parent_payer_group",
                    "coverage_types": [
                      "coverage_types",
                      "coverage_types"
                    ]
                  }
                },
                {
                  "score": 1,
                  "payer": {
                    "stedi_id": "stedi_id",
                    "display_name": "display_name",
                    "primary_payer_id": "primary_payer_id",
                    "aliases": [
                      "aliases",
                      "aliases"
                    ],
                    "names": [
                      "names",
                      "names"
                    ],
                    "transaction_support": {
                      "key": "value"
                    },
                    "employer_identification_numbers": [
                      "employer_identification_numbers",
                      "employer_identification_numbers"
                    ],
                    "payer_enrollment": {
                      "key": "value"
                    },
                    "parent_payer_group": "parent_payer_group",
                    "coverage_types": [
                      "coverage_types",
                      "coverage_types"
                    ]
                  }
                }
              ],
              "stats": {
                "key": "value"
              },
              "next_page_token": "next_page_token",
              "prev_page_token": "prev_page_token",
              "total": 1
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/eligibility-checks/v1/payer/search")
                    .UsingGet()
            )
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.PreEncounter.EligibilityChecks.V1.PayerSearchAsync(
            new PayerSearchRequest()
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
