using global::Candid.Net.Test.Unit.MockServer;
using global::Candid.Net.Test.Utils;
using NUnit.Framework;

namespace Candid.Net.Test.Unit.MockServer.Credentialing.V3;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class GetTest : BaseMockServerTest
{
    [global::NUnit.Framework.Test]
    public async global::System.Threading.Tasks.Task MockServerTest()
    {
        const string mockResponse = """
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
                      "provider_number": "provider_number",
                      "organization_service_facility_id": "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32"
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
                      "provider_number": "provider_number",
                      "organization_service_facility_id": "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32"
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
                      "provider_number": "provider_number",
                      "organization_service_facility_id": "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32"
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
                      "provider_number": "provider_number",
                      "organization_service_facility_id": "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32"
                    }
                  }
                ]
              },
              "credentialing_payer": {
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
              "start_date": "2023-01-15",
              "end_date": "2023-01-15",
              "submitted_date": "2023-01-15",
              "credentialing_status": "work_in_progress",
              "payer_loaded_date": "2023-01-15",
              "is_enabled": true
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath(
                        "/api/provider-credentialing-span/v3/d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32"
                    )
                    .UsingGet()
            )
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.Credentialing.V3.GetAsync(
            "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32"
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
