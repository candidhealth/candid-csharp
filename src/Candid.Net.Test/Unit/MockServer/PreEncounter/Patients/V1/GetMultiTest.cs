using Candid.Net.PreEncounter.Patients.V1;
using Candid.Net.Test.Unit.MockServer;
using Candid.Net.Test.Utils;
using NUnit.Framework;

namespace Candid.Net.Test.Unit.MockServer.PreEncounter.Patients.V1;

[TestFixture]
public class GetMultiTest : BaseMockServerTest
{
    [global::NUnit.Framework.Test]
    public async global::System.Threading.Tasks.Task MockServerTest()
    {
        const string mockResponse = """
            {
              "items": [
                {
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
                          "id": "id",
                          "clinical_trial_arm": "clinical_trial_arm",
                          "period": {}
                        },
                        {
                          "id": "id",
                          "clinical_trial_arm": "clinical_trial_arm",
                          "period": {}
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
                          "id": "id",
                          "clinical_trial_arm": "clinical_trial_arm",
                          "period": {}
                        },
                        {
                          "id": "id",
                          "clinical_trial_arm": "clinical_trial_arm",
                          "period": {}
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
                      "period": {
                        "start": "2023-01-15",
                        "end": "2023-01-15"
                      }
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
                {
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
                          "id": "id",
                          "clinical_trial_arm": "clinical_trial_arm",
                          "period": {}
                        },
                        {
                          "id": "id",
                          "clinical_trial_arm": "clinical_trial_arm",
                          "period": {}
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
                          "id": "id",
                          "clinical_trial_arm": "clinical_trial_arm",
                          "period": {}
                        },
                        {
                          "id": "id",
                          "clinical_trial_arm": "clinical_trial_arm",
                          "period": {}
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
                      "period": {
                        "start": "2023-01-15",
                        "end": "2023-01-15"
                      }
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
                }
              ],
              "next_page_token": "next_page_token",
              "prev_page_token": "prev_page_token",
              "total": 1
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/patients/v1/get_multi")
                    .UsingGet()
            )
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.PreEncounter.Patients.V1.GetMultiAsync(
            new PatientsSearchRequestPaginated()
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
