using global::Candid.Net.Test.Unit.MockServer;
using global::Candid.Net.Test.Utils;
using NUnit.Framework;

namespace Candid.Net.Test.Unit.MockServer.Contracts.V4;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class GetMultiTest : BaseMockServerTest
{
    [global::NUnit.Framework.Test]
    public async global::System.Threading.Tasks.Task MockServerTest()
    {
        const string mockResponse = """
            {
              "items": [
                {
                  "type": "professional",
                  "contract_id": "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
                  "contracting_provider": {
                    "organization_provider_id": "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
                    "employment_status": "ACTIVE",
                    "employment_start_date": "employment_start_date",
                    "employment_termination_date": "employment_termination_date",
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
                    "ptan": "ptan",
                    "medicaid_provider_id": "medicaid_provider_id",
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
                    ]
                  },
                  "provider_count": 1,
                  "contract_payer": {
                    "type": "payer",
                    "payer_uuid": "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
                    "payer_ids": {
                      "claims_payer_id": "claims_payer_id",
                      "eligibility_payer_id": "eligibility_payer_id",
                      "remittance_payer_id": "remittance_payer_id"
                    },
                    "payer_name": "payer_name",
                    "payer_category": "BCBS",
                    "alternate_payer_names": [
                      "alternate_payer_names",
                      "alternate_payer_names"
                    ],
                    "clearinghouse_payer_info": {
                      "CHANGE_HEALTHCARE": {
                        "payer_name": "payer_name",
                        "professional_payer_ids": {
                          "claims_payer_id": "claims_payer_id",
                          "eligibility_payer_id": "eligibility_payer_id",
                          "remittance_payer_id": "remittance_payer_id"
                        },
                        "institutional_payer_ids": {
                          "claims_payer_id": "claims_payer_id",
                          "eligibility_payer_id": "eligibility_payer_id",
                          "remittance_payer_id": "remittance_payer_id"
                        },
                        "professional_claims_support": "NOT_SUPPORTED",
                        "institutional_claims_support": "NOT_SUPPORTED",
                        "eligibility_support": "NOT_SUPPORTED",
                        "remittance_support": "NOT_SUPPORTED",
                        "claim_attachment_support": "NOT_SUPPORTED"
                      }
                    },
                    "street_address": {
                      "zip_plus_four_code": "zip_plus_four_code",
                      "address1": "address1",
                      "address2": "address2",
                      "city": "city",
                      "state": "AA",
                      "zip_code": "zip_code"
                    },
                    "alternate_payer_addresses": [
                      {
                        "zip_plus_four_code": "zip_plus_four_code",
                        "address1": "address1",
                        "address2": "address2",
                        "city": "city",
                        "state": "AA",
                        "zip_code": "zip_code"
                      },
                      {
                        "zip_plus_four_code": "zip_plus_four_code",
                        "address1": "address1",
                        "address2": "address2",
                        "city": "city",
                        "state": "AA",
                        "zip_code": "zip_code"
                      }
                    ]
                  },
                  "effective_date": "effective_date",
                  "expiration_date": "expiration_date",
                  "regions": {
                    "type": "states",
                    "states": [
                      "AA",
                      "AA"
                    ]
                  },
                  "contract_status": "pending",
                  "authorized_signatory": {
                    "first_name": "first_name",
                    "last_name": "last_name",
                    "title": "title",
                    "email": "email",
                    "phone": "phone",
                    "fax": "fax"
                  },
                  "commercial_insurance_types": {
                    "type": "allApply"
                  },
                  "medicare_insurance_types": {
                    "type": "allApply"
                  },
                  "medicaid_insurance_types": {
                    "type": "allApply"
                  }
                },
                {
                  "type": "professional",
                  "contract_id": "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
                  "contracting_provider": {
                    "organization_provider_id": "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
                    "employment_status": "ACTIVE",
                    "employment_start_date": "employment_start_date",
                    "employment_termination_date": "employment_termination_date",
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
                    "ptan": "ptan",
                    "medicaid_provider_id": "medicaid_provider_id",
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
                    ]
                  },
                  "provider_count": 1,
                  "contract_payer": {
                    "type": "payer",
                    "payer_uuid": "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
                    "payer_ids": {
                      "claims_payer_id": "claims_payer_id",
                      "eligibility_payer_id": "eligibility_payer_id",
                      "remittance_payer_id": "remittance_payer_id"
                    },
                    "payer_name": "payer_name",
                    "payer_category": "BCBS",
                    "alternate_payer_names": [
                      "alternate_payer_names",
                      "alternate_payer_names"
                    ],
                    "clearinghouse_payer_info": {
                      "CHANGE_HEALTHCARE": {
                        "payer_name": "payer_name",
                        "professional_payer_ids": {
                          "claims_payer_id": "claims_payer_id",
                          "eligibility_payer_id": "eligibility_payer_id",
                          "remittance_payer_id": "remittance_payer_id"
                        },
                        "institutional_payer_ids": {
                          "claims_payer_id": "claims_payer_id",
                          "eligibility_payer_id": "eligibility_payer_id",
                          "remittance_payer_id": "remittance_payer_id"
                        },
                        "professional_claims_support": "NOT_SUPPORTED",
                        "institutional_claims_support": "NOT_SUPPORTED",
                        "eligibility_support": "NOT_SUPPORTED",
                        "remittance_support": "NOT_SUPPORTED",
                        "claim_attachment_support": "NOT_SUPPORTED"
                      }
                    },
                    "street_address": {
                      "zip_plus_four_code": "zip_plus_four_code",
                      "address1": "address1",
                      "address2": "address2",
                      "city": "city",
                      "state": "AA",
                      "zip_code": "zip_code"
                    },
                    "alternate_payer_addresses": [
                      {
                        "zip_plus_four_code": "zip_plus_four_code",
                        "address1": "address1",
                        "address2": "address2",
                        "city": "city",
                        "state": "AA",
                        "zip_code": "zip_code"
                      },
                      {
                        "zip_plus_four_code": "zip_plus_four_code",
                        "address1": "address1",
                        "address2": "address2",
                        "city": "city",
                        "state": "AA",
                        "zip_code": "zip_code"
                      }
                    ]
                  },
                  "effective_date": "effective_date",
                  "expiration_date": "expiration_date",
                  "regions": {
                    "type": "states",
                    "states": [
                      "AA",
                      "AA"
                    ]
                  },
                  "contract_status": "pending",
                  "authorized_signatory": {
                    "first_name": "first_name",
                    "last_name": "last_name",
                    "title": "title",
                    "email": "email",
                    "phone": "phone",
                    "fax": "fax"
                  },
                  "commercial_insurance_types": {
                    "type": "allApply"
                  },
                  "medicare_insurance_types": {
                    "type": "allApply"
                  },
                  "medicaid_insurance_types": {
                    "type": "allApply"
                  }
                }
              ],
              "prev_page_token": "prev_page_token",
              "next_page_token": "next_page_token"
            }
            """;

        Server
            .Given(
                WireMock.RequestBuilders.Request.Create().WithPath("/api/contracts/v4").UsingGet()
            )
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.Contracts.V4.GetMultiAsync(
            new global::Candid.Net.Contracts.V4.GetMultiContractsRequest()
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
