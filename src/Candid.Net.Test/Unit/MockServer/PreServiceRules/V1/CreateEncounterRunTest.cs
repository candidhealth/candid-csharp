using global::Candid.Net.Commons;
using global::Candid.Net.EncounterProviders.V2;
using global::Candid.Net.Encounters.V4;
using global::Candid.Net.Individual;
using global::Candid.Net.PreServiceRules.V1;
using global::Candid.Net.Test.Unit.MockServer;
using global::Candid.Net.Test.Utils;
using NUnit.Framework;

namespace Candid.Net.Test.Unit.MockServer.PreServiceRules.V1;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class CreateEncounterRunTest : BaseMockServerTest
{
    [global::NUnit.Framework.Test]
    public async global::System.Threading.Tasks.Task MockServerTest()
    {
        const string requestJson = """
            {
              "entity": {
                "external_id": "external_id",
                "patient_authorized_release": true,
                "benefits_assigned_to_provider": true,
                "provider_accepts_assignment": true,
                "patient": {
                  "external_id": "external_id",
                  "date_of_birth": "2023-01-15",
                  "address": {
                    "address1": "address1",
                    "city": "city",
                    "state": "AA",
                    "zip_code": "zip_code"
                  },
                  "first_name": "first_name",
                  "last_name": "last_name",
                  "gender": "male"
                },
                "responsible_party": "INSURANCE_PAY",
                "billing_provider": {
                  "address": {
                    "zip_plus_four_code": "zip_plus_four_code",
                    "address1": "address1",
                    "city": "city",
                    "state": "AA",
                    "zip_code": "zip_code"
                  },
                  "tax_id": "tax_id",
                  "npi": "npi"
                },
                "submission_expectation": "TARGET_PROFESSIONAL"
              },
              "pipeline_id": "pipeline_id",
              "enabled_rule_ids": [
                "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
                "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32"
              ],
              "disabled_rule_ids": [
                "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
                "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32"
              ],
              "idempotency_key": "idempotency_key"
            }
            """;

        const string mockResponse = """
            {
              "run_id": "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32"
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/api/pre-service/v1/runs/encounter")
                    .UsingPost()
                    .WithBodyAsJson(requestJson)
            )
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.PreServiceRules.V1.CreateEncounterRunAsync(
            new PreServiceEncounterRunCreate
            {
                Entity = new PreServiceEncounterCreate
                {
                    ExternalId = "external_id",
                    PatientAuthorizedRelease = true,
                    BenefitsAssignedToProvider = true,
                    ProviderAcceptsAssignment = true,
                    Patient = new PatientCreate
                    {
                        ExternalId = "external_id",
                        DateOfBirth = new DateOnly(2023, 1, 15),
                        Address = new StreetAddressShortZip
                        {
                            Address1 = "address1",
                            City = "city",
                            State = State.Aa,
                            ZipCode = "zip_code",
                        },
                        FirstName = "first_name",
                        LastName = "last_name",
                        Gender = global::Candid.Net.Individual.Gender.Male,
                    },
                    ResponsibleParty = ResponsiblePartyType.InsurancePay,
                    BillingProvider = new BillingProvider
                    {
                        Address = new StreetAddressLongZip
                        {
                            ZipPlusFourCode = "zip_plus_four_code",
                            Address1 = "address1",
                            City = "city",
                            State = State.Aa,
                            ZipCode = "zip_code",
                        },
                        TaxId = "tax_id",
                        Npi = "npi",
                    },
                    SubmissionExpectation = EncounterSubmissionExpectation.TargetProfessional,
                },
                PipelineId = "pipeline_id",
                EnabledRuleIds = new List<string>()
                {
                    "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
                    "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
                },
                DisabledRuleIds = new List<string>()
                {
                    "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
                    "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
                },
                IdempotencyKey = "idempotency_key",
            }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
