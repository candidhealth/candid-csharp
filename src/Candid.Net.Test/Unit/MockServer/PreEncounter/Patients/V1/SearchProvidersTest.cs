using global::Candid.Net.PreEncounter.Patients.V1;
using global::Candid.Net.Test.Unit.MockServer;
using global::Candid.Net.Test.Utils;
using NUnit.Framework;

namespace Candid.Net.Test.Unit.MockServer.PreEncounter.Patients.V1;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class SearchProvidersTest : BaseMockServerTest
{
    [global::NUnit.Framework.Test]
    public async global::System.Threading.Tasks.Task MockServerTest()
    {
        const string mockResponse = """
            [
              {
                "name": {
                  "family": "family",
                  "given": [
                    "given",
                    "given"
                  ],
                  "use": "USUAL",
                  "period": {
                    "start": "2023-01-15",
                    "end": "2023-01-15"
                  },
                  "suffix": "suffix"
                },
                "type": "PRIMARY",
                "npi": "npi",
                "telecoms": [
                  {
                    "value": "value",
                    "use": "HOME",
                    "period": {
                      "start": "2023-01-15",
                      "end": "2023-01-15"
                    }
                  },
                  {
                    "value": "value",
                    "use": "HOME",
                    "period": {
                      "start": "2023-01-15",
                      "end": "2023-01-15"
                    }
                  }
                ],
                "addresses": [
                  {
                    "use": "HOME",
                    "line": [
                      "line",
                      "line"
                    ],
                    "city": "city",
                    "state": "state",
                    "postal_code": "postal_code",
                    "country": "country",
                    "period": {
                      "start": "2023-01-15",
                      "end": "2023-01-15"
                    }
                  },
                  {
                    "use": "HOME",
                    "line": [
                      "line",
                      "line"
                    ],
                    "city": "city",
                    "state": "state",
                    "postal_code": "postal_code",
                    "country": "country",
                    "period": {
                      "start": "2023-01-15",
                      "end": "2023-01-15"
                    }
                  }
                ],
                "period": {
                  "start": "2023-01-15",
                  "end": "2023-01-15"
                },
                "canonical_id": "canonical_id",
                "fax": "fax",
                "service_facilities": [
                  {
                    "service_facility_id": "service_facility_id"
                  },
                  {
                    "service_facility_id": "service_facility_id"
                  }
                ]
              },
              {
                "name": {
                  "family": "family",
                  "given": [
                    "given",
                    "given"
                  ],
                  "use": "USUAL",
                  "period": {
                    "start": "2023-01-15",
                    "end": "2023-01-15"
                  },
                  "suffix": "suffix"
                },
                "type": "PRIMARY",
                "npi": "npi",
                "telecoms": [
                  {
                    "value": "value",
                    "use": "HOME",
                    "period": {
                      "start": "2023-01-15",
                      "end": "2023-01-15"
                    }
                  },
                  {
                    "value": "value",
                    "use": "HOME",
                    "period": {
                      "start": "2023-01-15",
                      "end": "2023-01-15"
                    }
                  }
                ],
                "addresses": [
                  {
                    "use": "HOME",
                    "line": [
                      "line",
                      "line"
                    ],
                    "city": "city",
                    "state": "state",
                    "postal_code": "postal_code",
                    "country": "country",
                    "period": {
                      "start": "2023-01-15",
                      "end": "2023-01-15"
                    }
                  },
                  {
                    "use": "HOME",
                    "line": [
                      "line",
                      "line"
                    ],
                    "city": "city",
                    "state": "state",
                    "postal_code": "postal_code",
                    "country": "country",
                    "period": {
                      "start": "2023-01-15",
                      "end": "2023-01-15"
                    }
                  }
                ],
                "period": {
                  "start": "2023-01-15",
                  "end": "2023-01-15"
                },
                "canonical_id": "canonical_id",
                "fax": "fax",
                "service_facilities": [
                  {
                    "service_facility_id": "service_facility_id"
                  },
                  {
                    "service_facility_id": "service_facility_id"
                  }
                ]
              }
            ]
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/patients/v1/search_providers")
                    .WithParam("search_criteria", "search_criteria")
                    .UsingGet()
            )
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.PreEncounter.Patients.V1.SearchProvidersAsync(
            new SearchProvidersRequest { SearchCriteria = "search_criteria" }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
