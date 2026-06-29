using global::Candid.Net.PreEncounter.Coverages.V1;
using global::Candid.Net.Test.Unit.MockServer;
using global::Candid.Net.Test.Utils;
using NUnit.Framework;

namespace Candid.Net.Test.Unit.MockServer.PreEncounter.Coverages.V1;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class GetHistoryTest : BaseMockServerTest
{
    [global::NUnit.Framework.Test]
    public async global::System.Threading.Tasks.Task MockServerTest()
    {
        const string mockResponse = """
            [
              {
                "id": "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
                "organization_id": "organization_id",
                "deactivated": true,
                "version": 1,
                "updated_at": "2024-01-15T09:30:00.000Z",
                "updating_user_id": "updating_user_id",
                "status": "ACTIVE",
                "subscriber": {
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
                  "date_of_birth": "2023-01-15",
                  "biological_sex": "FEMALE",
                  "address": {
                    "use": "HOME",
                    "line": [
                      "line",
                      "line"
                    ],
                    "city": "city",
                    "state": "state",
                    "postal_code": "postal_code",
                    "country": "country",
                    "county": "county",
                    "period": {
                      "start": "2023-01-15",
                      "end": "2023-01-15"
                    }
                  },
                  "employer_name": "employer_name"
                },
                "relationship": "SELF",
                "patient": "patient",
                "insurance_plan": {
                  "member_id": "member_id",
                  "payer_id": "payer_id",
                  "payer_name": "payer_name",
                  "additional_payer_information": {
                    "availity_eligibility_id": "availity_eligibility_id",
                    "availity_payer_id": "availity_payer_id",
                    "availity_payer_name": "availity_payer_name",
                    "availity_remittance_payer_id": "availity_remittance_payer_id"
                  },
                  "group_number": "group_number",
                  "name": "name",
                  "plan_type": "09",
                  "type": "01",
                  "period": {
                    "start": "2023-01-15",
                    "end": "2023-01-15"
                  },
                  "insurance_card_image_locator": "insurance_card_image_locator",
                  "address": {
                    "use": "HOME",
                    "line": [
                      "line",
                      "line"
                    ],
                    "city": "city",
                    "state": "state",
                    "postal_code": "postal_code",
                    "country": "country",
                    "county": "county",
                    "period": {
                      "start": "2023-01-15",
                      "end": "2023-01-15"
                    }
                  },
                  "payer_plan_group_id": "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
                  "carve_outs": [
                    {
                      "carve_out": "BEHAVIORAL",
                      "member_id": "member_id",
                      "payer_id": "payer_id",
                      "payer_name": "payer_name",
                      "group_number": "group_number",
                      "plan_type": "09",
                      "type": "01",
                      "payer_plan_group_id": "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32"
                    },
                    {
                      "carve_out": "BEHAVIORAL",
                      "member_id": "member_id",
                      "payer_id": "payer_id",
                      "payer_name": "payer_name",
                      "group_number": "group_number",
                      "plan_type": "09",
                      "type": "01",
                      "payer_plan_group_id": "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32"
                    }
                  ]
                },
                "verified": true,
                "eligibility_checks": [
                  {
                    "check_id": "check_id",
                    "service_code": "1",
                    "status": "COMPLETED",
                    "initiated_by": "initiated_by",
                    "initiated_at": "2024-01-15T09:30:00.000Z"
                  },
                  {
                    "check_id": "check_id",
                    "service_code": "1",
                    "status": "COMPLETED",
                    "initiated_by": "initiated_by",
                    "initiated_at": "2024-01-15T09:30:00.000Z"
                  }
                ],
                "latest_eligibility_check": {
                  "check_id": "check_id",
                  "status": "ACTIVE",
                  "initiated_at": "2024-01-15T09:30:00.000Z",
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
                        "value": 1.1,
                        "additional_notes": "additional_notes"
                      },
                      {
                        "type": "DEDUCTIBLE",
                        "coverageLevel": "EMPLOYEE_AND_CHILDREN",
                        "unit": "PERCENT",
                        "value": 1.1,
                        "additional_notes": "additional_notes"
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
                        "value": 1.1,
                        "additional_notes": "additional_notes"
                      },
                      {
                        "type": "DEDUCTIBLE",
                        "coverageLevel": "EMPLOYEE_AND_CHILDREN",
                        "unit": "PERCENT",
                        "value": 1.1,
                        "additional_notes": "additional_notes"
                      }
                    ]
                  },
                  "service_specific_coverage": [
                    {
                      "service_code": "1",
                      "in_network": {
                        "copay": {},
                        "coinsurance": {},
                        "visits": {},
                        "visits_remaining": {},
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
                        "copay": {},
                        "coinsurance": {},
                        "visits": {},
                        "visits_remaining": {},
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
                    {
                      "service_code": "1",
                      "in_network": {
                        "copay": {},
                        "coinsurance": {},
                        "visits": {},
                        "visits_remaining": {},
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
                        "copay": {},
                        "coinsurance": {},
                        "visits": {},
                        "visits_remaining": {},
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
                  "non_covered_details": [
                    {
                      "type": "DEDUCTIBLE",
                      "coverageLevel": "EMPLOYEE_AND_CHILDREN",
                      "unit": "PERCENT",
                      "value": 1.1,
                      "additional_notes": "additional_notes",
                      "service_type_codes": [
                        "1",
                        "1"
                      ]
                    },
                    {
                      "type": "DEDUCTIBLE",
                      "coverageLevel": "EMPLOYEE_AND_CHILDREN",
                      "unit": "PERCENT",
                      "value": 1.1,
                      "additional_notes": "additional_notes",
                      "service_type_codes": [
                        "1",
                        "1"
                      ]
                    }
                  ],
                  "notes": "notes",
                  "autoUpdatedEligibilityCheckId": "autoUpdatedEligibilityCheckId"
                },
                "orcon": true,
                "auto_update_enabled": true,
                "previous_appointment_copays": {
                  "MD_Visit": 1
                }
              },
              {
                "id": "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
                "organization_id": "organization_id",
                "deactivated": true,
                "version": 1,
                "updated_at": "2024-01-15T09:30:00.000Z",
                "updating_user_id": "updating_user_id",
                "status": "ACTIVE",
                "subscriber": {
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
                  "date_of_birth": "2023-01-15",
                  "biological_sex": "FEMALE",
                  "address": {
                    "use": "HOME",
                    "line": [
                      "line",
                      "line"
                    ],
                    "city": "city",
                    "state": "state",
                    "postal_code": "postal_code",
                    "country": "country",
                    "county": "county",
                    "period": {
                      "start": "2023-01-15",
                      "end": "2023-01-15"
                    }
                  },
                  "employer_name": "employer_name"
                },
                "relationship": "SELF",
                "patient": "patient",
                "insurance_plan": {
                  "member_id": "member_id",
                  "payer_id": "payer_id",
                  "payer_name": "payer_name",
                  "additional_payer_information": {
                    "availity_eligibility_id": "availity_eligibility_id",
                    "availity_payer_id": "availity_payer_id",
                    "availity_payer_name": "availity_payer_name",
                    "availity_remittance_payer_id": "availity_remittance_payer_id"
                  },
                  "group_number": "group_number",
                  "name": "name",
                  "plan_type": "09",
                  "type": "01",
                  "period": {
                    "start": "2023-01-15",
                    "end": "2023-01-15"
                  },
                  "insurance_card_image_locator": "insurance_card_image_locator",
                  "address": {
                    "use": "HOME",
                    "line": [
                      "line",
                      "line"
                    ],
                    "city": "city",
                    "state": "state",
                    "postal_code": "postal_code",
                    "country": "country",
                    "county": "county",
                    "period": {
                      "start": "2023-01-15",
                      "end": "2023-01-15"
                    }
                  },
                  "payer_plan_group_id": "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
                  "carve_outs": [
                    {
                      "carve_out": "BEHAVIORAL",
                      "member_id": "member_id",
                      "payer_id": "payer_id",
                      "payer_name": "payer_name",
                      "group_number": "group_number",
                      "plan_type": "09",
                      "type": "01",
                      "payer_plan_group_id": "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32"
                    },
                    {
                      "carve_out": "BEHAVIORAL",
                      "member_id": "member_id",
                      "payer_id": "payer_id",
                      "payer_name": "payer_name",
                      "group_number": "group_number",
                      "plan_type": "09",
                      "type": "01",
                      "payer_plan_group_id": "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32"
                    }
                  ]
                },
                "verified": true,
                "eligibility_checks": [
                  {
                    "check_id": "check_id",
                    "service_code": "1",
                    "status": "COMPLETED",
                    "initiated_by": "initiated_by",
                    "initiated_at": "2024-01-15T09:30:00.000Z"
                  },
                  {
                    "check_id": "check_id",
                    "service_code": "1",
                    "status": "COMPLETED",
                    "initiated_by": "initiated_by",
                    "initiated_at": "2024-01-15T09:30:00.000Z"
                  }
                ],
                "latest_eligibility_check": {
                  "check_id": "check_id",
                  "status": "ACTIVE",
                  "initiated_at": "2024-01-15T09:30:00.000Z",
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
                        "value": 1.1,
                        "additional_notes": "additional_notes"
                      },
                      {
                        "type": "DEDUCTIBLE",
                        "coverageLevel": "EMPLOYEE_AND_CHILDREN",
                        "unit": "PERCENT",
                        "value": 1.1,
                        "additional_notes": "additional_notes"
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
                        "value": 1.1,
                        "additional_notes": "additional_notes"
                      },
                      {
                        "type": "DEDUCTIBLE",
                        "coverageLevel": "EMPLOYEE_AND_CHILDREN",
                        "unit": "PERCENT",
                        "value": 1.1,
                        "additional_notes": "additional_notes"
                      }
                    ]
                  },
                  "service_specific_coverage": [
                    {
                      "service_code": "1",
                      "in_network": {
                        "copay": {},
                        "coinsurance": {},
                        "visits": {},
                        "visits_remaining": {},
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
                        "copay": {},
                        "coinsurance": {},
                        "visits": {},
                        "visits_remaining": {},
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
                    {
                      "service_code": "1",
                      "in_network": {
                        "copay": {},
                        "coinsurance": {},
                        "visits": {},
                        "visits_remaining": {},
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
                        "copay": {},
                        "coinsurance": {},
                        "visits": {},
                        "visits_remaining": {},
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
                  "non_covered_details": [
                    {
                      "type": "DEDUCTIBLE",
                      "coverageLevel": "EMPLOYEE_AND_CHILDREN",
                      "unit": "PERCENT",
                      "value": 1.1,
                      "additional_notes": "additional_notes",
                      "service_type_codes": [
                        "1",
                        "1"
                      ]
                    },
                    {
                      "type": "DEDUCTIBLE",
                      "coverageLevel": "EMPLOYEE_AND_CHILDREN",
                      "unit": "PERCENT",
                      "value": 1.1,
                      "additional_notes": "additional_notes",
                      "service_type_codes": [
                        "1",
                        "1"
                      ]
                    }
                  ],
                  "notes": "notes",
                  "autoUpdatedEligibilityCheckId": "autoUpdatedEligibilityCheckId"
                },
                "orcon": true,
                "auto_update_enabled": true,
                "previous_appointment_copays": {
                  "MD_Visit": 1
                }
              }
            ]
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/coverages/v1/d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32/history")
                    .UsingGet()
            )
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.PreEncounter.Coverages.V1.GetHistoryAsync(
            "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
            new CoveragesGetHistoryRequest()
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
