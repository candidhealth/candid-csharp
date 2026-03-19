using global::Candid.Net.PreEncounter.Lists.V1;
using global::Candid.Net.Test.Unit.MockServer;
using global::Candid.Net.Test.Utils;
using NUnit.Framework;

namespace Candid.Net.Test.Unit.MockServer.PreEncounter.Lists.V1;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class GetPatientListTest : BaseMockServerTest
{
    [global::NUnit.Framework.Test]
    public async global::System.Threading.Tasks.Task MockServerTest()
    {
        const string mockResponse = """
            {
              "items": [
                {
                  "patient": {
                    "id": "id",
                    "mrn": "mrn",
                    "organization_id": "organization_id",
                    "deactivated": true,
                    "version": 1,
                    "updated_at": "2024-01-15T09:30:00.000Z",
                    "updating_user_id": "updating_user_id",
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
                    "other_names": [
                      {
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
                      {
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
                      }
                    ],
                    "other_identifiers": [
                      {
                        "value": "value",
                        "system": "system",
                        "period": {
                          "start": "2023-01-15",
                          "end": "2023-01-15"
                        }
                      },
                      {
                        "value": "value",
                        "system": "system",
                        "period": {
                          "start": "2023-01-15",
                          "end": "2023-01-15"
                        }
                      }
                    ],
                    "gender": "MAN",
                    "birth_date": "2023-01-15",
                    "social_security_number": "social_security_number",
                    "biological_sex": "FEMALE",
                    "sexual_orientation": "HETEROSEXUAL",
                    "pronouns": [
                      "pronouns",
                      "pronouns"
                    ],
                    "race": "AMERICAN_INDIAN_OR_ALASKA_NATIVE",
                    "ethnicity": "HISPANIC_OR_LATINO",
                    "disability_status": "DISABLED",
                    "marital_status": "ANNULLED",
                    "deceased": "2024-01-15T09:30:00.000Z",
                    "multiple_birth": 1,
                    "primary_address": {
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
                    "other_addresses": [
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
                    "primary_telecom": {
                      "value": "value",
                      "use": "HOME",
                      "period": {
                        "start": "2023-01-15",
                        "end": "2023-01-15"
                      }
                    },
                    "other_telecoms": [
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
                    "email": "email",
                    "electronic_communication_opt_in": true,
                    "photo": "photo",
                    "language": "language",
                    "external_provenance": {
                      "external_id": "external_id",
                      "system_name": "system_name"
                    },
                    "contacts": [
                      {
                        "relationship": [
                          "SELF",
                          "SELF"
                        ],
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
                        "telecoms": [
                          {
                            "value": "value",
                            "use": "HOME",
                            "period": {}
                          },
                          {
                            "value": "value",
                            "use": "HOME",
                            "period": {}
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
                            "period": {}
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
                            "period": {}
                          }
                        ],
                        "period": {
                          "start": "2023-01-15",
                          "end": "2023-01-15"
                        },
                        "hipaa_authorization": true
                      },
                      {
                        "relationship": [
                          "SELF",
                          "SELF"
                        ],
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
                        "telecoms": [
                          {
                            "value": "value",
                            "use": "HOME",
                            "period": {}
                          },
                          {
                            "value": "value",
                            "use": "HOME",
                            "period": {}
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
                            "period": {}
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
                            "period": {}
                          }
                        ],
                        "period": {
                          "start": "2023-01-15",
                          "end": "2023-01-15"
                        },
                        "hipaa_authorization": true
                      }
                    ],
                    "general_practitioners": [
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
                            "period": {}
                          },
                          {
                            "value": "value",
                            "use": "HOME",
                            "period": {}
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
                            "period": {}
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
                            "period": {}
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
                            "period": {}
                          },
                          {
                            "value": "value",
                            "use": "HOME",
                            "period": {}
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
                            "period": {}
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
                            "period": {}
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
                    ],
                    "filing_order": {
                      "coverages": [
                        "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
                        "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32"
                      ]
                    },
                    "coverages_for_related_causes": {
                      "coverages": [
                        "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
                        "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32"
                      ]
                    },
                    "non_insurance_payers": [
                      "non_insurance_payers",
                      "non_insurance_payers"
                    ],
                    "non_insurance_payer_associations": [
                      {
                        "id": "id",
                        "member_id": "member_id",
                        "period": {
                          "start": "2023-01-15",
                          "end": "2023-01-15"
                        },
                        "clinical_trial_info": [
                          {
                            "id": "id"
                          },
                          {
                            "id": "id"
                          }
                        ]
                      },
                      {
                        "id": "id",
                        "member_id": "member_id",
                        "period": {
                          "start": "2023-01-15",
                          "end": "2023-01-15"
                        },
                        "clinical_trial_info": [
                          {
                            "id": "id"
                          },
                          {
                            "id": "id"
                          }
                        ]
                      }
                    ],
                    "guarantor": {
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
                      "telecom": {
                        "value": "value",
                        "use": "HOME",
                        "period": {}
                      },
                      "email": "email",
                      "birth_date": "2023-01-15",
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
                    "self_pay": true,
                    "authorizations": [
                      {
                        "payer_id": "payer_id",
                        "payer_name": "payer_name",
                        "additional_payer_information": {
                          "availity_eligibility_id": "availity_eligibility_id",
                          "availity_payer_id": "availity_payer_id",
                          "availity_payer_name": "availity_payer_name",
                          "availity_remittance_payer_id": "availity_remittance_payer_id"
                        },
                        "authorization_number": "authorization_number",
                        "cpt_code": "cpt_code",
                        "apply_for_all_cpt_codes": true,
                        "no_prior_authorization_required": true,
                        "units": "VISIT",
                        "quantity": 1,
                        "period": {
                          "start": "2023-01-15",
                          "end": "2023-01-15"
                        },
                        "notes": "notes",
                        "billing_provider_npi": "billing_provider_npi"
                      },
                      {
                        "payer_id": "payer_id",
                        "payer_name": "payer_name",
                        "additional_payer_information": {
                          "availity_eligibility_id": "availity_eligibility_id",
                          "availity_payer_id": "availity_payer_id",
                          "availity_payer_name": "availity_payer_name",
                          "availity_remittance_payer_id": "availity_remittance_payer_id"
                        },
                        "authorization_number": "authorization_number",
                        "cpt_code": "cpt_code",
                        "apply_for_all_cpt_codes": true,
                        "no_prior_authorization_required": true,
                        "units": "VISIT",
                        "quantity": 1,
                        "period": {
                          "start": "2023-01-15",
                          "end": "2023-01-15"
                        },
                        "notes": "notes",
                        "billing_provider_npi": "billing_provider_npi"
                      }
                    ],
                    "referrals": [
                      {
                        "provider": {
                          "name": {
                            "family": "family",
                            "given": [
                              "given",
                              "given"
                            ],
                            "use": "USUAL",
                            "period": {},
                            "suffix": "suffix"
                          },
                          "type": "PRIMARY",
                          "npi": "npi",
                          "telecoms": [
                            {
                              "value": "value",
                              "use": "HOME"
                            },
                            {
                              "value": "value",
                              "use": "HOME"
                            }
                          ],
                          "addresses": [],
                          "period": {},
                          "canonical_id": "canonical_id",
                          "fax": "fax",
                          "service_facilities": []
                        },
                        "referral_number": "referral_number",
                        "period": {
                          "start": "2023-01-15",
                          "end": "2023-01-15"
                        },
                        "notes": "notes",
                        "serviceFacility": {
                          "service_facility_id": "service_facility_id"
                        },
                        "units": "VISIT",
                        "quantity": 1,
                        "cptCodes": [
                          "cptCodes",
                          "cptCodes"
                        ],
                        "applyForAllCptCodes": true
                      },
                      {
                        "provider": {
                          "name": {
                            "family": "family",
                            "given": [
                              "given",
                              "given"
                            ],
                            "use": "USUAL",
                            "period": {},
                            "suffix": "suffix"
                          },
                          "type": "PRIMARY",
                          "npi": "npi",
                          "telecoms": [
                            {
                              "value": "value",
                              "use": "HOME"
                            },
                            {
                              "value": "value",
                              "use": "HOME"
                            }
                          ],
                          "addresses": [],
                          "period": {},
                          "canonical_id": "canonical_id",
                          "fax": "fax",
                          "service_facilities": []
                        },
                        "referral_number": "referral_number",
                        "period": {
                          "start": "2023-01-15",
                          "end": "2023-01-15"
                        },
                        "notes": "notes",
                        "serviceFacility": {
                          "service_facility_id": "service_facility_id"
                        },
                        "units": "VISIT",
                        "quantity": 1,
                        "cptCodes": [
                          "cptCodes",
                          "cptCodes"
                        ],
                        "applyForAllCptCodes": true
                      }
                    ],
                    "primary_service_facility_id": "primary_service_facility_id",
                    "service_facilities": [
                      {
                        "service_facility_id": "service_facility_id"
                      },
                      {
                        "service_facility_id": "service_facility_id"
                      }
                    ],
                    "do_not_invoice_reason": "BANKRUPTCY",
                    "note_ids": [
                      "note_ids",
                      "note_ids"
                    ],
                    "tag_ids": [
                      "tag_ids",
                      "tag_ids"
                    ],
                    "origination_detail": {
                      "referral_source": "HOSPITAL",
                      "referring_provider": {
                        "name": {
                          "family": "family",
                          "given": [
                            "given",
                            "given"
                          ],
                          "use": "USUAL",
                          "period": {},
                          "suffix": "suffix"
                        },
                        "type": "PRIMARY",
                        "npi": "npi",
                        "telecoms": [
                          {
                            "value": "value",
                            "use": "HOME"
                          },
                          {
                            "value": "value",
                            "use": "HOME"
                          }
                        ],
                        "addresses": [],
                        "period": {},
                        "canonical_id": "canonical_id",
                        "fax": "fax",
                        "service_facilities": []
                      },
                      "specialization_categories": [
                        "BEHAVIORAL_HEALTH_THERAPY",
                        "BEHAVIORAL_HEALTH_THERAPY"
                      ],
                      "referral_type": "DIRECTED"
                    },
                    "inferred_patient_metadata": {
                      "inferred_encounter_id": "inferred_encounter_id",
                      "inferred_encounter_latest_date_of_service": "2023-01-15"
                    },
                    "orcon": true
                  },
                  "primary_coverage": {
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
                        "period": {}
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
                        "period": {}
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
                    },
                    "orcon": true,
                    "auto_update_enabled": true
                  },
                  "secondary_coverage": {
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
                        "period": {}
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
                        "period": {}
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
                    },
                    "orcon": true,
                    "auto_update_enabled": true
                  },
                  "tertiary_coverage": {
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
                        "period": {}
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
                        "period": {}
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
                    },
                    "orcon": true,
                    "auto_update_enabled": true
                  },
                  "next_appointment": {
                    "patient_id": "patient_id",
                    "start_timestamp": "2024-01-15T09:30:00.000Z",
                    "status": "PENDING",
                    "service_duration": 1,
                    "services": [
                      {
                        "universal_service_identifier": "MD_Visit",
                        "start_timestamp": "2024-01-15T09:30:00.000Z"
                      },
                      {
                        "universal_service_identifier": "MD_Visit",
                        "start_timestamp": "2024-01-15T09:30:00.000Z"
                      }
                    ],
                    "placer_appointment_id": "placer_appointment_id",
                    "attending_doctor": {
                      "name": {
                        "family": "family",
                        "given": [
                          "given",
                          "given"
                        ],
                        "use": "USUAL",
                        "period": {},
                        "suffix": "suffix"
                      },
                      "type": "PRIMARY",
                      "npi": "npi",
                      "telecoms": [
                        {
                          "value": "value",
                          "use": "HOME",
                          "period": {}
                        },
                        {
                          "value": "value",
                          "use": "HOME",
                          "period": {}
                        }
                      ],
                      "addresses": [
                        {
                          "use": "HOME",
                          "line": [],
                          "city": "city",
                          "state": "state",
                          "postal_code": "postal_code",
                          "country": "country"
                        },
                        {
                          "use": "HOME",
                          "line": [],
                          "city": "city",
                          "state": "state",
                          "postal_code": "postal_code",
                          "country": "country"
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
                    "estimated_copay_cents": 1,
                    "estimated_patient_responsibility_cents": 1,
                    "patient_deposit_cents": 1,
                    "appointment_details": "appointment_details",
                    "checked_in_timestamp": "2024-01-15T09:30:00.000Z",
                    "notes": "notes",
                    "location_resource_id": "location_resource_id",
                    "automated_eligibility_check_complete": true,
                    "work_queue": "EMERGENT_ISSUE"
                  },
                  "primary_mrn": "primary_mrn",
                  "alternative_mrns": [
                    "alternative_mrns",
                    "alternative_mrns"
                  ]
                },
                {
                  "patient": {
                    "id": "id",
                    "mrn": "mrn",
                    "organization_id": "organization_id",
                    "deactivated": true,
                    "version": 1,
                    "updated_at": "2024-01-15T09:30:00.000Z",
                    "updating_user_id": "updating_user_id",
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
                    "other_names": [
                      {
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
                      {
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
                      }
                    ],
                    "other_identifiers": [
                      {
                        "value": "value",
                        "system": "system",
                        "period": {
                          "start": "2023-01-15",
                          "end": "2023-01-15"
                        }
                      },
                      {
                        "value": "value",
                        "system": "system",
                        "period": {
                          "start": "2023-01-15",
                          "end": "2023-01-15"
                        }
                      }
                    ],
                    "gender": "MAN",
                    "birth_date": "2023-01-15",
                    "social_security_number": "social_security_number",
                    "biological_sex": "FEMALE",
                    "sexual_orientation": "HETEROSEXUAL",
                    "pronouns": [
                      "pronouns",
                      "pronouns"
                    ],
                    "race": "AMERICAN_INDIAN_OR_ALASKA_NATIVE",
                    "ethnicity": "HISPANIC_OR_LATINO",
                    "disability_status": "DISABLED",
                    "marital_status": "ANNULLED",
                    "deceased": "2024-01-15T09:30:00.000Z",
                    "multiple_birth": 1,
                    "primary_address": {
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
                    "other_addresses": [
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
                    "primary_telecom": {
                      "value": "value",
                      "use": "HOME",
                      "period": {
                        "start": "2023-01-15",
                        "end": "2023-01-15"
                      }
                    },
                    "other_telecoms": [
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
                    "email": "email",
                    "electronic_communication_opt_in": true,
                    "photo": "photo",
                    "language": "language",
                    "external_provenance": {
                      "external_id": "external_id",
                      "system_name": "system_name"
                    },
                    "contacts": [
                      {
                        "relationship": [
                          "SELF",
                          "SELF"
                        ],
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
                        "telecoms": [
                          {
                            "value": "value",
                            "use": "HOME",
                            "period": {}
                          },
                          {
                            "value": "value",
                            "use": "HOME",
                            "period": {}
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
                            "period": {}
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
                            "period": {}
                          }
                        ],
                        "period": {
                          "start": "2023-01-15",
                          "end": "2023-01-15"
                        },
                        "hipaa_authorization": true
                      },
                      {
                        "relationship": [
                          "SELF",
                          "SELF"
                        ],
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
                        "telecoms": [
                          {
                            "value": "value",
                            "use": "HOME",
                            "period": {}
                          },
                          {
                            "value": "value",
                            "use": "HOME",
                            "period": {}
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
                            "period": {}
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
                            "period": {}
                          }
                        ],
                        "period": {
                          "start": "2023-01-15",
                          "end": "2023-01-15"
                        },
                        "hipaa_authorization": true
                      }
                    ],
                    "general_practitioners": [
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
                            "period": {}
                          },
                          {
                            "value": "value",
                            "use": "HOME",
                            "period": {}
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
                            "period": {}
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
                            "period": {}
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
                            "period": {}
                          },
                          {
                            "value": "value",
                            "use": "HOME",
                            "period": {}
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
                            "period": {}
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
                            "period": {}
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
                    ],
                    "filing_order": {
                      "coverages": [
                        "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
                        "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32"
                      ]
                    },
                    "coverages_for_related_causes": {
                      "coverages": [
                        "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
                        "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32"
                      ]
                    },
                    "non_insurance_payers": [
                      "non_insurance_payers",
                      "non_insurance_payers"
                    ],
                    "non_insurance_payer_associations": [
                      {
                        "id": "id",
                        "member_id": "member_id",
                        "period": {
                          "start": "2023-01-15",
                          "end": "2023-01-15"
                        },
                        "clinical_trial_info": [
                          {
                            "id": "id"
                          },
                          {
                            "id": "id"
                          }
                        ]
                      },
                      {
                        "id": "id",
                        "member_id": "member_id",
                        "period": {
                          "start": "2023-01-15",
                          "end": "2023-01-15"
                        },
                        "clinical_trial_info": [
                          {
                            "id": "id"
                          },
                          {
                            "id": "id"
                          }
                        ]
                      }
                    ],
                    "guarantor": {
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
                      "telecom": {
                        "value": "value",
                        "use": "HOME",
                        "period": {}
                      },
                      "email": "email",
                      "birth_date": "2023-01-15",
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
                    "self_pay": true,
                    "authorizations": [
                      {
                        "payer_id": "payer_id",
                        "payer_name": "payer_name",
                        "additional_payer_information": {
                          "availity_eligibility_id": "availity_eligibility_id",
                          "availity_payer_id": "availity_payer_id",
                          "availity_payer_name": "availity_payer_name",
                          "availity_remittance_payer_id": "availity_remittance_payer_id"
                        },
                        "authorization_number": "authorization_number",
                        "cpt_code": "cpt_code",
                        "apply_for_all_cpt_codes": true,
                        "no_prior_authorization_required": true,
                        "units": "VISIT",
                        "quantity": 1,
                        "period": {
                          "start": "2023-01-15",
                          "end": "2023-01-15"
                        },
                        "notes": "notes",
                        "billing_provider_npi": "billing_provider_npi"
                      },
                      {
                        "payer_id": "payer_id",
                        "payer_name": "payer_name",
                        "additional_payer_information": {
                          "availity_eligibility_id": "availity_eligibility_id",
                          "availity_payer_id": "availity_payer_id",
                          "availity_payer_name": "availity_payer_name",
                          "availity_remittance_payer_id": "availity_remittance_payer_id"
                        },
                        "authorization_number": "authorization_number",
                        "cpt_code": "cpt_code",
                        "apply_for_all_cpt_codes": true,
                        "no_prior_authorization_required": true,
                        "units": "VISIT",
                        "quantity": 1,
                        "period": {
                          "start": "2023-01-15",
                          "end": "2023-01-15"
                        },
                        "notes": "notes",
                        "billing_provider_npi": "billing_provider_npi"
                      }
                    ],
                    "referrals": [
                      {
                        "provider": {
                          "name": {
                            "family": "family",
                            "given": [
                              "given",
                              "given"
                            ],
                            "use": "USUAL",
                            "period": {},
                            "suffix": "suffix"
                          },
                          "type": "PRIMARY",
                          "npi": "npi",
                          "telecoms": [
                            {
                              "value": "value",
                              "use": "HOME"
                            },
                            {
                              "value": "value",
                              "use": "HOME"
                            }
                          ],
                          "addresses": [],
                          "period": {},
                          "canonical_id": "canonical_id",
                          "fax": "fax",
                          "service_facilities": []
                        },
                        "referral_number": "referral_number",
                        "period": {
                          "start": "2023-01-15",
                          "end": "2023-01-15"
                        },
                        "notes": "notes",
                        "serviceFacility": {
                          "service_facility_id": "service_facility_id"
                        },
                        "units": "VISIT",
                        "quantity": 1,
                        "cptCodes": [
                          "cptCodes",
                          "cptCodes"
                        ],
                        "applyForAllCptCodes": true
                      },
                      {
                        "provider": {
                          "name": {
                            "family": "family",
                            "given": [
                              "given",
                              "given"
                            ],
                            "use": "USUAL",
                            "period": {},
                            "suffix": "suffix"
                          },
                          "type": "PRIMARY",
                          "npi": "npi",
                          "telecoms": [
                            {
                              "value": "value",
                              "use": "HOME"
                            },
                            {
                              "value": "value",
                              "use": "HOME"
                            }
                          ],
                          "addresses": [],
                          "period": {},
                          "canonical_id": "canonical_id",
                          "fax": "fax",
                          "service_facilities": []
                        },
                        "referral_number": "referral_number",
                        "period": {
                          "start": "2023-01-15",
                          "end": "2023-01-15"
                        },
                        "notes": "notes",
                        "serviceFacility": {
                          "service_facility_id": "service_facility_id"
                        },
                        "units": "VISIT",
                        "quantity": 1,
                        "cptCodes": [
                          "cptCodes",
                          "cptCodes"
                        ],
                        "applyForAllCptCodes": true
                      }
                    ],
                    "primary_service_facility_id": "primary_service_facility_id",
                    "service_facilities": [
                      {
                        "service_facility_id": "service_facility_id"
                      },
                      {
                        "service_facility_id": "service_facility_id"
                      }
                    ],
                    "do_not_invoice_reason": "BANKRUPTCY",
                    "note_ids": [
                      "note_ids",
                      "note_ids"
                    ],
                    "tag_ids": [
                      "tag_ids",
                      "tag_ids"
                    ],
                    "origination_detail": {
                      "referral_source": "HOSPITAL",
                      "referring_provider": {
                        "name": {
                          "family": "family",
                          "given": [
                            "given",
                            "given"
                          ],
                          "use": "USUAL",
                          "period": {},
                          "suffix": "suffix"
                        },
                        "type": "PRIMARY",
                        "npi": "npi",
                        "telecoms": [
                          {
                            "value": "value",
                            "use": "HOME"
                          },
                          {
                            "value": "value",
                            "use": "HOME"
                          }
                        ],
                        "addresses": [],
                        "period": {},
                        "canonical_id": "canonical_id",
                        "fax": "fax",
                        "service_facilities": []
                      },
                      "specialization_categories": [
                        "BEHAVIORAL_HEALTH_THERAPY",
                        "BEHAVIORAL_HEALTH_THERAPY"
                      ],
                      "referral_type": "DIRECTED"
                    },
                    "inferred_patient_metadata": {
                      "inferred_encounter_id": "inferred_encounter_id",
                      "inferred_encounter_latest_date_of_service": "2023-01-15"
                    },
                    "orcon": true
                  },
                  "primary_coverage": {
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
                        "period": {}
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
                        "period": {}
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
                    },
                    "orcon": true,
                    "auto_update_enabled": true
                  },
                  "secondary_coverage": {
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
                        "period": {}
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
                        "period": {}
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
                    },
                    "orcon": true,
                    "auto_update_enabled": true
                  },
                  "tertiary_coverage": {
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
                        "period": {}
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
                        "period": {}
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
                    },
                    "orcon": true,
                    "auto_update_enabled": true
                  },
                  "next_appointment": {
                    "patient_id": "patient_id",
                    "start_timestamp": "2024-01-15T09:30:00.000Z",
                    "status": "PENDING",
                    "service_duration": 1,
                    "services": [
                      {
                        "universal_service_identifier": "MD_Visit",
                        "start_timestamp": "2024-01-15T09:30:00.000Z"
                      },
                      {
                        "universal_service_identifier": "MD_Visit",
                        "start_timestamp": "2024-01-15T09:30:00.000Z"
                      }
                    ],
                    "placer_appointment_id": "placer_appointment_id",
                    "attending_doctor": {
                      "name": {
                        "family": "family",
                        "given": [
                          "given",
                          "given"
                        ],
                        "use": "USUAL",
                        "period": {},
                        "suffix": "suffix"
                      },
                      "type": "PRIMARY",
                      "npi": "npi",
                      "telecoms": [
                        {
                          "value": "value",
                          "use": "HOME",
                          "period": {}
                        },
                        {
                          "value": "value",
                          "use": "HOME",
                          "period": {}
                        }
                      ],
                      "addresses": [
                        {
                          "use": "HOME",
                          "line": [],
                          "city": "city",
                          "state": "state",
                          "postal_code": "postal_code",
                          "country": "country"
                        },
                        {
                          "use": "HOME",
                          "line": [],
                          "city": "city",
                          "state": "state",
                          "postal_code": "postal_code",
                          "country": "country"
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
                    "estimated_copay_cents": 1,
                    "estimated_patient_responsibility_cents": 1,
                    "patient_deposit_cents": 1,
                    "appointment_details": "appointment_details",
                    "checked_in_timestamp": "2024-01-15T09:30:00.000Z",
                    "notes": "notes",
                    "location_resource_id": "location_resource_id",
                    "automated_eligibility_check_complete": true,
                    "work_queue": "EMERGENT_ISSUE"
                  },
                  "primary_mrn": "primary_mrn",
                  "alternative_mrns": [
                    "alternative_mrns",
                    "alternative_mrns"
                  ]
                }
              ],
              "next_page_token": "next_page_token",
              "prev_page_token": "prev_page_token",
              "total": 1
            }
            """;

        Server
            .Given(
                WireMock.RequestBuilders.Request.Create().WithPath("/lists/v1/patient").UsingGet()
            )
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.PreEncounter.Lists.V1.GetPatientListAsync(
            new PatientListRequest()
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
