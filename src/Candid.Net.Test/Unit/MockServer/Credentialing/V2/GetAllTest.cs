using global::Candid.Net.Credentialing.V2;
using global::Candid.Net.Test.Unit.MockServer;
using global::Candid.Net.Test.Utils;
using NUnit.Framework;

namespace Candid.Net.Test.Unit.MockServer.Credentialing.V2;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class GetAllTest : BaseMockServerTest
{
    [global::NUnit.Framework.Test]
    public async global::System.Threading.Tasks.Task MockServerTest()
    {
        const string mockResponse = """
            {
              "items": [
                {
                  "provider_credentialing_span_id": "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
                  "rendering_provider": {
                    "npi": "npi",
                    "is_rendering": true,
                    "is_billing": true,
                    "first_name": "first_name",
                    "last_name": "last_name",
                    "organization_name": "organization_name",
                    "provider_type": "INDIVIDUAL",
                    "tax_id": "tax_id",
                    "taxonomy_code": "taxonomy_code",
                    "license_type": "MD",
                    "addresses": [
                      {
                        "address": {
                          "zip_plus_four_code": "zip_plus_four_code",
                          "address1": "address1",
                          "address2": "address2",
                          "city": "city",
                          "state": "AA",
                          "zip_code": "zip_code"
                        },
                        "address_type": "DEFAULT"
                      },
                      {
                        "address": {
                          "zip_plus_four_code": "zip_plus_four_code",
                          "address1": "address1",
                          "address2": "address2",
                          "city": "city",
                          "state": "AA",
                          "zip_code": "zip_code"
                        },
                        "address_type": "DEFAULT"
                      }
                    ],
                    "employment_start_date": "2023-01-15",
                    "employment_termination_date": "2023-01-15",
                    "organization_provider_id": "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
                    "qualifications": [
                      {
                        "identifier_id": "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
                        "period": {
                          "start_date": "start_date",
                          "end_date": "end_date"
                        },
                        "identifier_code": "MCR",
                        "identifier_value": {
                          "type": "medicare_provider_identifier",
                          "state": "AA",
                          "provider_number": "provider_number"
                        }
                      },
                      {
                        "identifier_id": "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
                        "period": {
                          "start_date": "start_date",
                          "end_date": "end_date"
                        },
                        "identifier_code": "MCR",
                        "identifier_value": {
                          "type": "medicare_provider_identifier",
                          "state": "AA",
                          "provider_number": "provider_number"
                        }
                      }
                    ]
                  },
                  "regions": {
                    "type": "states",
                    "states": [
                      "AA",
                      "AA"
                    ]
                  },
                  "medallion_payer_enrollment_id": "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
                  "source": "source",
                  "contracting_provider": {
                    "npi": "npi",
                    "is_rendering": true,
                    "is_billing": true,
                    "first_name": "first_name",
                    "last_name": "last_name",
                    "organization_name": "organization_name",
                    "provider_type": "INDIVIDUAL",
                    "tax_id": "tax_id",
                    "taxonomy_code": "taxonomy_code",
                    "license_type": "MD",
                    "addresses": [
                      {
                        "address": {
                          "zip_plus_four_code": "zip_plus_four_code",
                          "address1": "address1",
                          "address2": "address2",
                          "city": "city",
                          "state": "AA",
                          "zip_code": "zip_code"
                        },
                        "address_type": "DEFAULT"
                      },
                      {
                        "address": {
                          "zip_plus_four_code": "zip_plus_four_code",
                          "address1": "address1",
                          "address2": "address2",
                          "city": "city",
                          "state": "AA",
                          "zip_code": "zip_code"
                        },
                        "address_type": "DEFAULT"
                      }
                    ],
                    "employment_start_date": "2023-01-15",
                    "employment_termination_date": "2023-01-15",
                    "organization_provider_id": "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
                    "qualifications": [
                      {
                        "identifier_id": "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
                        "period": {
                          "start_date": "start_date",
                          "end_date": "end_date"
                        },
                        "identifier_code": "MCR",
                        "identifier_value": {
                          "type": "medicare_provider_identifier",
                          "state": "AA",
                          "provider_number": "provider_number"
                        }
                      },
                      {
                        "identifier_id": "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
                        "period": {
                          "start_date": "start_date",
                          "end_date": "end_date"
                        },
                        "identifier_code": "MCR",
                        "identifier_value": {
                          "type": "medicare_provider_identifier",
                          "state": "AA",
                          "provider_number": "provider_number"
                        }
                      }
                    ]
                  },
                  "payer": {
                    "payer_uuid": "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
                    "payer_id": "payer_id",
                    "payer_name": "payer_name",
                    "availity_payer_name": "availity_payer_name",
                    "availity_claims_payer_id": "availity_claims_payer_id",
                    "availity_eligibility_id": "availity_eligibility_id",
                    "availity_remittance_payer_id": "availity_remittance_payer_id",
                    "street_address": {
                      "zip_plus_four_code": "zip_plus_four_code",
                      "address1": "address1",
                      "address2": "address2",
                      "city": "city",
                      "state": "AA",
                      "zip_code": "zip_code"
                    }
                  },
                  "start_date": "2023-01-15",
                  "end_date": "2023-01-15",
                  "submitted_date": "2023-01-15",
                  "credentialing_status": "work_in_progress",
                  "payer_loaded_date": "2023-01-15",
                  "is_enabled": true
                },
                {
                  "provider_credentialing_span_id": "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
                  "rendering_provider": {
                    "npi": "npi",
                    "is_rendering": true,
                    "is_billing": true,
                    "first_name": "first_name",
                    "last_name": "last_name",
                    "organization_name": "organization_name",
                    "provider_type": "INDIVIDUAL",
                    "tax_id": "tax_id",
                    "taxonomy_code": "taxonomy_code",
                    "license_type": "MD",
                    "addresses": [
                      {
                        "address": {
                          "zip_plus_four_code": "zip_plus_four_code",
                          "address1": "address1",
                          "address2": "address2",
                          "city": "city",
                          "state": "AA",
                          "zip_code": "zip_code"
                        },
                        "address_type": "DEFAULT"
                      },
                      {
                        "address": {
                          "zip_plus_four_code": "zip_plus_four_code",
                          "address1": "address1",
                          "address2": "address2",
                          "city": "city",
                          "state": "AA",
                          "zip_code": "zip_code"
                        },
                        "address_type": "DEFAULT"
                      }
                    ],
                    "employment_start_date": "2023-01-15",
                    "employment_termination_date": "2023-01-15",
                    "organization_provider_id": "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
                    "qualifications": [
                      {
                        "identifier_id": "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
                        "period": {
                          "start_date": "start_date",
                          "end_date": "end_date"
                        },
                        "identifier_code": "MCR",
                        "identifier_value": {
                          "type": "medicare_provider_identifier",
                          "state": "AA",
                          "provider_number": "provider_number"
                        }
                      },
                      {
                        "identifier_id": "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
                        "period": {
                          "start_date": "start_date",
                          "end_date": "end_date"
                        },
                        "identifier_code": "MCR",
                        "identifier_value": {
                          "type": "medicare_provider_identifier",
                          "state": "AA",
                          "provider_number": "provider_number"
                        }
                      }
                    ]
                  },
                  "regions": {
                    "type": "states",
                    "states": [
                      "AA",
                      "AA"
                    ]
                  },
                  "medallion_payer_enrollment_id": "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
                  "source": "source",
                  "contracting_provider": {
                    "npi": "npi",
                    "is_rendering": true,
                    "is_billing": true,
                    "first_name": "first_name",
                    "last_name": "last_name",
                    "organization_name": "organization_name",
                    "provider_type": "INDIVIDUAL",
                    "tax_id": "tax_id",
                    "taxonomy_code": "taxonomy_code",
                    "license_type": "MD",
                    "addresses": [
                      {
                        "address": {
                          "zip_plus_four_code": "zip_plus_four_code",
                          "address1": "address1",
                          "address2": "address2",
                          "city": "city",
                          "state": "AA",
                          "zip_code": "zip_code"
                        },
                        "address_type": "DEFAULT"
                      },
                      {
                        "address": {
                          "zip_plus_four_code": "zip_plus_four_code",
                          "address1": "address1",
                          "address2": "address2",
                          "city": "city",
                          "state": "AA",
                          "zip_code": "zip_code"
                        },
                        "address_type": "DEFAULT"
                      }
                    ],
                    "employment_start_date": "2023-01-15",
                    "employment_termination_date": "2023-01-15",
                    "organization_provider_id": "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
                    "qualifications": [
                      {
                        "identifier_id": "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
                        "period": {
                          "start_date": "start_date",
                          "end_date": "end_date"
                        },
                        "identifier_code": "MCR",
                        "identifier_value": {
                          "type": "medicare_provider_identifier",
                          "state": "AA",
                          "provider_number": "provider_number"
                        }
                      },
                      {
                        "identifier_id": "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
                        "period": {
                          "start_date": "start_date",
                          "end_date": "end_date"
                        },
                        "identifier_code": "MCR",
                        "identifier_value": {
                          "type": "medicare_provider_identifier",
                          "state": "AA",
                          "provider_number": "provider_number"
                        }
                      }
                    ]
                  },
                  "payer": {
                    "payer_uuid": "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
                    "payer_id": "payer_id",
                    "payer_name": "payer_name",
                    "availity_payer_name": "availity_payer_name",
                    "availity_claims_payer_id": "availity_claims_payer_id",
                    "availity_eligibility_id": "availity_eligibility_id",
                    "availity_remittance_payer_id": "availity_remittance_payer_id",
                    "street_address": {
                      "zip_plus_four_code": "zip_plus_four_code",
                      "address1": "address1",
                      "address2": "address2",
                      "city": "city",
                      "state": "AA",
                      "zip_code": "zip_code"
                    }
                  },
                  "start_date": "2023-01-15",
                  "end_date": "2023-01-15",
                  "submitted_date": "2023-01-15",
                  "credentialing_status": "work_in_progress",
                  "payer_loaded_date": "2023-01-15",
                  "is_enabled": true
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
                    .WithPath("/api/provider-credentialing-span/v2")
                    .UsingGet()
            )
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.Credentialing.V2.GetAllAsync(
            new GetAllProviderCredentialingSpansRequest()
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
