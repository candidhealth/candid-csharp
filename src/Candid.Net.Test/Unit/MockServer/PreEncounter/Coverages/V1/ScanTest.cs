using System.Globalization;
using global::Candid.Net.PreEncounter.Coverages.V1;
using global::Candid.Net.Test.Unit.MockServer;
using global::Candid.Net.Test.Utils;
using NUnit.Framework;

namespace Candid.Net.Test.Unit.MockServer.PreEncounter.Coverages.V1;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class ScanTest : BaseMockServerTest
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
                    "period": {
                      "start": "2023-01-15",
                      "end": "2023-01-15"
                    }
                  }
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
                    "period": {
                      "start": "2023-01-15",
                      "end": "2023-01-15"
                    }
                  },
                  "payer_plan_group_id": "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32"
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
                  "initiated_at": "2024-01-15T09:30:00.000Z"
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
                  "notes": "notes",
                  "autoUpdatedEligibilityCheckId": "autoUpdatedEligibilityCheckId"
                },
                "orcon": true,
                "auto_update_enabled": true
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
                    "period": {
                      "start": "2023-01-15",
                      "end": "2023-01-15"
                    }
                  }
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
                    "period": {
                      "start": "2023-01-15",
                      "end": "2023-01-15"
                    }
                  },
                  "payer_plan_group_id": "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32"
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
                  "initiated_at": "2024-01-15T09:30:00.000Z"
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
                  "notes": "notes",
                  "autoUpdatedEligibilityCheckId": "autoUpdatedEligibilityCheckId"
                },
                "orcon": true,
                "auto_update_enabled": true
              }
            ]
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/coverages/v1/updates/scan")
                    .WithParam("since", "2024-01-15T09:30:00.000Z")
                    .UsingGet()
            )
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.PreEncounter.Coverages.V1.ScanAsync(
            new CoverageScanRequest
            {
                Since = DateTime.Parse(
                    "2024-01-15T09:30:00.000Z",
                    null,
                    DateTimeStyles.AdjustToUniversal
                ),
            }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
