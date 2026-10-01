using global::Candid.Net.PreEncounter.EligibilityChecks.V1;
using global::Candid.Net.Test.Unit.MockServer;
using global::Candid.Net.Test.Utils;
using NUnit.Framework;

namespace Candid.Net.Test.Unit.MockServer.PreEncounter.EligibilityChecks.V1;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class InsuranceDiscoveryTest : BaseMockServerTest
{
    [global::NUnit.Framework.Test]
    public async global::System.Threading.Tasks.Task MockServerTest()
    {
        const string requestJson = """
            {
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
              "discovery_id": "discovery_id",
              "status": "PENDING",
              "items": [
                {
                  "key": "value"
                },
                {
                  "key": "value"
                }
              ],
              "parsed_items": [
                {
                  "confidence": {
                    "level": "REVIEW_NEEDED",
                    "reason": "reason"
                  },
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
                      "address": {}
                    },
                    "dependent": {
                      "member_id": "member_id",
                      "group_number": "group_number",
                      "first_name": "first_name",
                      "middle_name": "middle_name",
                      "last_name": "last_name",
                      "date_of_birth": "date_of_birth",
                      "gender": "gender",
                      "address": {}
                    },
                    "trading_partner": "trading_partner"
                  },
                  "benefits": {
                    "plan_coverage": {
                      "in_network": {},
                      "in_network_flat": [],
                      "out_of_network": {},
                      "out_of_network_flat": []
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
                        "contactInformation": [],
                        "serviceTypeCodes": []
                      },
                      {
                        "entityIdentifier": "entityIdentifier",
                        "entityType": "entityType",
                        "entityName": "entityName",
                        "contactInformation": [],
                        "serviceTypeCodes": []
                      }
                    ],
                    "non_covered_details": [
                      {
                        "type": "DEDUCTIBLE",
                        "coverageLevel": "EMPLOYEE_AND_CHILDREN",
                        "unit": "PERCENT",
                        "value": 1.1,
                        "additional_notes": "additional_notes",
                        "service_type_codes": []
                      },
                      {
                        "type": "DEDUCTIBLE",
                        "coverageLevel": "EMPLOYEE_AND_CHILDREN",
                        "unit": "PERCENT",
                        "value": 1.1,
                        "additional_notes": "additional_notes",
                        "service_type_codes": []
                      }
                    ],
                    "notes": "notes",
                    "autoUpdatedEligibilityCheckId": "autoUpdatedEligibilityCheckId"
                  }
                },
                {
                  "confidence": {
                    "level": "REVIEW_NEEDED",
                    "reason": "reason"
                  },
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
                      "address": {}
                    },
                    "dependent": {
                      "member_id": "member_id",
                      "group_number": "group_number",
                      "first_name": "first_name",
                      "middle_name": "middle_name",
                      "last_name": "last_name",
                      "date_of_birth": "date_of_birth",
                      "gender": "gender",
                      "address": {}
                    },
                    "trading_partner": "trading_partner"
                  },
                  "benefits": {
                    "plan_coverage": {
                      "in_network": {},
                      "in_network_flat": [],
                      "out_of_network": {},
                      "out_of_network_flat": []
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
                        "contactInformation": [],
                        "serviceTypeCodes": []
                      },
                      {
                        "entityIdentifier": "entityIdentifier",
                        "entityType": "entityType",
                        "entityName": "entityName",
                        "contactInformation": [],
                        "serviceTypeCodes": []
                      }
                    ],
                    "non_covered_details": [
                      {
                        "type": "DEDUCTIBLE",
                        "coverageLevel": "EMPLOYEE_AND_CHILDREN",
                        "unit": "PERCENT",
                        "value": 1.1,
                        "additional_notes": "additional_notes",
                        "service_type_codes": []
                      },
                      {
                        "type": "DEDUCTIBLE",
                        "coverageLevel": "EMPLOYEE_AND_CHILDREN",
                        "unit": "PERCENT",
                        "value": 1.1,
                        "additional_notes": "additional_notes",
                        "service_type_codes": []
                      }
                    ],
                    "notes": "notes",
                    "autoUpdatedEligibilityCheckId": "autoUpdatedEligibilityCheckId"
                  }
                }
              ],
              "coverages_found": 1,
              "errors": [
                {
                  "field?": "field?",
                  "description?": "description?",
                  "location?": "location?",
                  "possibleResolutions?": "possibleResolutions?",
                  "code?": "code?",
                  "followupAction?": "followupAction?"
                },
                {
                  "field?": "field?",
                  "description?": "description?",
                  "location?": "location?",
                  "possibleResolutions?": "possibleResolutions?",
                  "code?": "code?",
                  "followupAction?": "followupAction?"
                }
              ]
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/eligibility-checks/v1/insurance-discovery")
                    .UsingPost()
                    .WithBodyAsJson(requestJson)
            )
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.PreEncounter.EligibilityChecks.V1.InsuranceDiscoveryAsync(
            new InsuranceDiscoveryRequest
            {
                Provider = new InsuranceDiscoveryProvider { Npi = "npi" },
                Subscriber = new InsuranceDiscoverySubscriber
                {
                    FirstName = "first_name",
                    LastName = "last_name",
                },
            }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
