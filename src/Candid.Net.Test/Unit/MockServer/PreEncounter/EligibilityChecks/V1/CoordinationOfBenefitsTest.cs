using global::Candid.Net.PreEncounter.EligibilityChecks.V1;
using global::Candid.Net.Test.Unit.MockServer;
using global::Candid.Net.Test.Utils;
using NUnit.Framework;

namespace Candid.Net.Test.Unit.MockServer.PreEncounter.EligibilityChecks.V1;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class CoordinationOfBenefitsTest : BaseMockServerTest
{
    [global::NUnit.Framework.Test]
    public async global::System.Threading.Tasks.Task MockServerTest()
    {
        const string requestJson = """
            {
              "trading_partner_service_id": "trading_partner_service_id",
              "provider": {
                "npi": "npi"
              },
              "subscriber": {
                "first_name": "first_name",
                "last_name": "last_name",
                "date_of_birth": "date_of_birth"
              },
              "encounter": {}
            }
            """;

        const string mockResponse = """
            {
              "provider": {
                "provider_name": "provider_name",
                "provider_first_name": "provider_first_name",
                "provider_org_name": "provider_org_name",
                "npi": "npi",
                "aaa_errors": [
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
              "subscriber": {
                "member_id": "member_id",
                "first_name": "first_name",
                "last_name": "last_name",
                "middle_name": "middle_name",
                "gender": "gender",
                "date_of_birth": "date_of_birth",
                "ssn": "ssn",
                "group_number": "group_number",
                "birth_sequence_number": "birth_sequence_number",
                "address": {
                  "address_1": "address_1",
                  "address_2": "address_2",
                  "city": "city",
                  "state": "state",
                  "postal_code": "postal_code",
                  "country_code": "country_code",
                  "country_sub_division_code": "country_sub_division_code"
                },
                "aaa_errors": [
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
              "dependent": {
                "member_id": "member_id",
                "first_name": "first_name",
                "last_name": "last_name",
                "middle_name": "middle_name",
                "gender": "gender",
                "date_of_birth": "date_of_birth",
                "ssn": "ssn",
                "group_number": "group_number",
                "relation_to_subscriber": "relation_to_subscriber",
                "relation_to_subscriber_code": "relation_to_subscriber_code",
                "birth_sequence_number": "birth_sequence_number",
                "address": {
                  "address_1": "address_1",
                  "address_2": "address_2",
                  "city": "city",
                  "state": "state",
                  "postal_code": "postal_code",
                  "country_code": "country_code",
                  "country_sub_division_code": "country_sub_division_code"
                },
                "aaa_errors": [
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
              "payer": {
                "name": "name",
                "payer_identification": "payer_identification"
              },
              "plan_date_information": {
                "plan_begin": "plan_begin",
                "plan_end": "plan_end"
              },
              "benefits_information": [
                {
                  "key": "value"
                },
                {
                  "key": "value"
                }
              ],
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
              ],
              "coordination_of_benefits": {
                "classification": "classification",
                "instance_exists": true,
                "primacy_determined": true,
                "coverage_overlap": true,
                "benefit_overlap": true
              }
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/eligibility-checks/v1/coordination-of-benefits")
                    .UsingPost()
                    .WithBodyAsJson(requestJson)
            )
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.PreEncounter.EligibilityChecks.V1.CoordinationOfBenefitsAsync(
            new CoordinationOfBenefitsRequest
            {
                TradingPartnerServiceId = "trading_partner_service_id",
                Provider = new CobProvider { Npi = "npi" },
                Subscriber = new CobSubscriber
                {
                    FirstName = "first_name",
                    LastName = "last_name",
                    DateOfBirth = "date_of_birth",
                },
                Encounter = new CobEncounter(),
            }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
