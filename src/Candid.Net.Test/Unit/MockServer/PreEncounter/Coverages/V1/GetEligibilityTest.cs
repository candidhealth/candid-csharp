using Candid.Net.Test.Unit.MockServer;
using Candid.Net.Test.Utils;
using NUnit.Framework;

namespace Candid.Net.Test.Unit.MockServer.PreEncounter.Coverages.V1;

[TestFixture]
public class GetEligibilityTest : BaseMockServerTest
{
    [global::NUnit.Framework.Test]
    public async global::System.Threading.Tasks.Task MockServerTest()
    {
        const string mockResponse = """
            {
              "metadata": {
                "check_id": "check_id",
                "service_code": "1",
                "status": "COMPLETED",
                "initiated_by": "initiated_by",
                "initiated_at": "2024-01-15T09:30:00.000Z"
              },
              "check": {
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
                        "field_name": "field_name"
                      },
                      {
                        "start_date": "2023-01-15",
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
                    }
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
                        "service_code": "1"
                      },
                      {
                        "service_code": "1"
                      }
                    ],
                    "benefits_related_entities": [
                      {},
                      {}
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
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath(
                        "/coverages/v1/d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32/eligibility/check_id"
                    )
                    .UsingGet()
            )
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.PreEncounter.Coverages.V1.GetEligibilityAsync(
            "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
            "check_id"
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
