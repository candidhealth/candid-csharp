using Candid.Net.Contracts.V3;
using Candid.Net.Test.Unit.MockServer;
using Candid.Net.Test.Utils;
using NUnit.Framework;

namespace Candid.Net.Test.Unit.MockServer.Contracts.V3;

[TestFixture]
public class UpdateTest : BaseMockServerTest
{
    [global::NUnit.Framework.Test]
    public async global::System.Threading.Tasks.Task MockServerTest()
    {
        const string requestJson = """
            {
              "type": "professional"
            }
            """;

        const string mockResponse = """
            {
              "type": "professional",
              "rendering_provider_ids": [
                "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32"
              ],
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
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/api/contracts/v3/d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32")
                    .UsingPatch()
                    .WithBodyAsJson(requestJson)
            )
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.Contracts.V3.UpdateAsync(
            "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
            new ContractUpdateUnion(
                new ContractUpdateUnion.Professional(new ProfessionalContractUpdate())
            )
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
