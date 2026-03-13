using Candid.Net.PreEncounter.Coverages.V1;
using Candid.Net.PreEncounter.EligibilityChecks.V1;
using Candid.Net.Test.Unit.MockServer;
using Candid.Net.Test.Utils;
using NUnit.Framework;

namespace Candid.Net.Test.Unit.MockServer.PreEncounter.EligibilityChecks.V1;

[TestFixture]
public class PostTest : BaseMockServerTest
{
    [global::NUnit.Framework.Test]
    public async global::System.Threading.Tasks.Task MockServerTest()
    {
        const string requestJson = """
            {
              "payer_id": "payer_id",
              "provider": {
                "npi": "npi"
              },
              "subscriber": {
                "first_name": "first_name",
                "last_name": "last_name"
              }
            }
            """;

        const string mockResponse = """
            {
              "batch_id": "batch_id",
              "errors": [
                {
                  "source": "CANDID",
                  "errorDetails": {
                    "field?": "field?",
                    "description?": "description?",
                    "location?": "location?",
                    "possibleResolutions?": "possibleResolutions?",
                    "code?": "code?",
                    "followupAction?": "followupAction?"
                  }
                },
                {
                  "source": "CANDID",
                  "errorDetails": {
                    "field?": "field?",
                    "description?": "description?",
                    "location?": "location?",
                    "possibleResolutions?": "possibleResolutions?",
                    "code?": "code?",
                    "followupAction?": "followupAction?"
                  }
                }
              ],
              "request": {
                "submitter_transaction_identifier": "submitter_transaction_identifier",
                "payer_id": "payer_id",
                "provider": {
                  "first_name": "first_name",
                  "last_name": "last_name",
                  "npi": "npi"
                },
                "subscriber": {
                  "member_id": "member_id",
                  "first_name": "first_name",
                  "last_name": "last_name",
                  "date_of_birth": "2023-01-15"
                },
                "dependent": {
                  "member_id": "member_id",
                  "first_name": "first_name",
                  "last_name": "last_name",
                  "date_of_birth": "2023-01-15"
                },
                "encounter": {
                  "date_of_service": "2023-01-15",
                  "service_type_codes": [
                    "service_type_codes",
                    "service_type_codes"
                  ]
                },
                "get_existing_check_initiated_after": "2024-01-15T09:30:00.000Z",
                "source": "source"
              },
              "response": {
                "key": "value"
              },
              "parsed_response": {
                "eligibility_status": "ACTIVE",
                "plan_metadata": {
                  "payer_name": "payer_name",
                  "insurance_type": "insurance_type",
                  "insurance_type_code": "insurance_type_code",
                  "plan_name": "plan_name",
                  "member_id": "member_id",
                  "group_number": "group_number",
                  "start_date": "2023-01-15",
                  "end_date": "2023-01-15",
                  "plan_dates": [
                    {
                      "start_date": "2023-01-15",
                      "end_date": "2023-01-15",
                      "field_name": "field_name"
                    },
                    {
                      "start_date": "2023-01-15",
                      "end_date": "2023-01-15",
                      "field_name": "field_name"
                    }
                  ],
                  "subscriber": {
                    "member_id": "member_id",
                    "group_number": "group_number",
                    "first_name": "first_name",
                    "middle_name": "middle_name",
                    "last_name": "last_name",
                    "date_of_birth": "date_of_birth",
                    "gender": "gender",
                    "address": {
                      "address1": "address1",
                      "address2": "address2",
                      "city": "city",
                      "state": "state",
                      "postal_code": "postal_code",
                      "country_code": "country_code",
                      "country_sub_division_code": "country_sub_division_code"
                    }
                  },
                  "dependent": {
                    "member_id": "member_id",
                    "group_number": "group_number",
                    "first_name": "first_name",
                    "middle_name": "middle_name",
                    "last_name": "last_name",
                    "date_of_birth": "date_of_birth",
                    "gender": "gender",
                    "address": {
                      "address1": "address1",
                      "address2": "address2",
                      "city": "city",
                      "state": "state",
                      "postal_code": "postal_code",
                      "country_code": "country_code",
                      "country_sub_division_code": "country_sub_division_code"
                    }
                  }
                },
                "benefits": {
                  "plan_coverage": {
                    "in_network": {
                      "deductible": {},
                      "deductible_contract": {},
                      "deductible_remaining": {},
                      "deductible_year_to_date": {},
                      "oop_max": {},
                      "oop_max_contract": {},
                      "oop_max_remaining": {},
                      "oop_max_year_to_date": {},
                      "additional_notes": "additional_notes"
                    },
                    "in_network_flat": [
                      {
                        "type": "DEDUCTIBLE",
                        "coverageLevel": "EMPLOYEE_AND_CHILDREN",
                        "unit": "PERCENT",
                        "value": 1.1
                      },
                      {
                        "type": "DEDUCTIBLE",
                        "coverageLevel": "EMPLOYEE_AND_CHILDREN",
                        "unit": "PERCENT",
                        "value": 1.1
                      }
                    ],
                    "out_of_network": {
                      "deductible": {},
                      "deductible_contract": {},
                      "deductible_remaining": {},
                      "deductible_year_to_date": {},
                      "oop_max": {},
                      "oop_max_contract": {},
                      "oop_max_remaining": {},
                      "oop_max_year_to_date": {},
                      "additional_notes": "additional_notes"
                    },
                    "out_of_network_flat": [
                      {
                        "type": "DEDUCTIBLE",
                        "coverageLevel": "EMPLOYEE_AND_CHILDREN",
                        "unit": "PERCENT",
                        "value": 1.1
                      },
                      {
                        "type": "DEDUCTIBLE",
                        "coverageLevel": "EMPLOYEE_AND_CHILDREN",
                        "unit": "PERCENT",
                        "value": 1.1
                      }
                    ]
                  },
                  "service_specific_coverage": [
                    {
                      "service_code": "1",
                      "in_network": {},
                      "in_network_flat": [],
                      "out_of_network": {},
                      "out_of_network_flat": []
                    },
                    {
                      "service_code": "1",
                      "in_network": {},
                      "in_network_flat": [],
                      "out_of_network": {},
                      "out_of_network_flat": []
                    }
                  ],
                  "benefits_related_entities": [
                    {
                      "entityIdentifier": "entityIdentifier",
                      "entityType": "entityType",
                      "entityName": "entityName",
                      "contactInformation": [
                        {},
                        {}
                      ],
                      "serviceTypeCodes": [
                        "1",
                        "1"
                      ]
                    },
                    {
                      "entityIdentifier": "entityIdentifier",
                      "entityType": "entityType",
                      "entityName": "entityName",
                      "contactInformation": [
                        {},
                        {}
                      ],
                      "serviceTypeCodes": [
                        "1",
                        "1"
                      ]
                    }
                  ],
                  "notes": "notes",
                  "autoUpdatedEligibilityCheckId": "autoUpdatedEligibilityCheckId"
                }
              },
              "request_corrections": [
                {
                  "property": "property",
                  "request_value": "request_value",
                  "corrected_value": "corrected_value"
                },
                {
                  "property": "property",
                  "request_value": "request_value",
                  "corrected_value": "corrected_value"
                }
              ]
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/eligibility-checks/v1")
                    .UsingPost()
                    .WithBodyAsJson(requestJson)
            )
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.PreEncounter.EligibilityChecks.V1.PostAsync(
            new EligibilityRequest
            {
                PayerId = "payer_id",
                Provider = new IndividualProvider { Npi = "npi" },
                Subscriber = new MemberInfo { FirstName = "first_name", LastName = "last_name" },
            }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
