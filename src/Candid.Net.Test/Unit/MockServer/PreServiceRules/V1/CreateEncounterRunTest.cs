using global::Candid.Net.Commons;
using global::Candid.Net.EncounterProviders.V2;
using global::Candid.Net.Encounters.V4;
using global::Candid.Net.HealthCareCodeInformation.V1;
using global::Candid.Net.Individual;
using global::Candid.Net.InsuranceCards.V2;
using global::Candid.Net.PreServiceRules.V1;
using global::Candid.Net.ServiceLines.V2;
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
                "external_id": "enc-123",
                "patient_authorized_release": true,
                "benefits_assigned_to_provider": true,
                "provider_accepts_assignment": true,
                "responsible_party": "INSURANCE_PAY",
                "submission_expectation": "TARGET_PROFESSIONAL",
                "date_of_service": "2026-10-15",
                "patient": {
                  "external_id": "p-456",
                  "first_name": "Jane",
                  "last_name": "Doe",
                  "gender": "female",
                  "date_of_birth": "1960-01-01",
                  "address": {
                    "address1": "1 Main St",
                    "city": "Fairfax",
                    "state": "VA",
                    "zip_code": "22031"
                  }
                },
                "rendering_provider": {
                  "first_name": "Ada",
                  "last_name": "Lovelace",
                  "npi": "1234567893"
                },
                "billing_provider": {
                  "npi": "1558375857",
                  "tax_id": "202265068",
                  "organization_name": "Example Clinic",
                  "address": {
                    "address1": "1 Main St",
                    "city": "Fairfax",
                    "state": "VA",
                    "zip_code": "22031",
                    "zip_plus_four_code": "4634"
                  }
                },
                "subscriber_primary": {
                  "first_name": "Jane",
                  "last_name": "Doe",
                  "gender": "female",
                  "patient_relationship_to_subscriber_code": "18",
                  "insurance_card": {
                    "member_id": "123456789",
                    "payer_name": "Example Payer",
                    "payer_id": "12345"
                  }
                },
                "health_care_code_information": {
                  "principal_diagnosis": {
                    "primary_diagnosis_code": "Z01.411",
                    "principal_diagnosis_code_qualifier": "ABK"
                  }
                },
                "service_lines": [
                  {
                    "procedure_code": "99213",
                    "quantity": "1",
                    "units": "UN",
                    "charge_amount_cents": 20600,
                    "diagnosis_pointers": [
                      0
                    ]
                  }
                ]
              },
              "pipeline_id": "pre-service-claim-athena",
              "enabled_rule_ids": [],
              "disabled_rule_ids": [],
              "idempotency_key": "enc-123-run-1"
            }
            """;

        const string mockResponse = """
            "0192a6f4-7c1e-7b3a-9d2e-5f8a1c3b4d6e"
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
                    ExternalId = "enc-123",
                    PatientAuthorizedRelease = true,
                    BenefitsAssignedToProvider = true,
                    ProviderAcceptsAssignment = true,
                    ResponsibleParty = ResponsiblePartyType.InsurancePay,
                    SubmissionExpectation = EncounterSubmissionExpectation.TargetProfessional,
                    DateOfService = new DateOnly(2026, 10, 15),
                    Patient = new PatientCreate
                    {
                        ExternalId = "p-456",
                        FirstName = "Jane",
                        LastName = "Doe",
                        Gender = global::Candid.Net.Individual.Gender.Female,
                        DateOfBirth = new DateOnly(1960, 1, 1),
                        Address = new StreetAddressShortZip
                        {
                            Address1 = "1 Main St",
                            City = "Fairfax",
                            State = State.Va,
                            ZipCode = "22031",
                        },
                    },
                    RenderingProvider = new RenderingProvider
                    {
                        FirstName = "Ada",
                        LastName = "Lovelace",
                        Npi = "1234567893",
                    },
                    BillingProvider = new BillingProvider
                    {
                        Npi = "1558375857",
                        TaxId = "202265068",
                        OrganizationName = "Example Clinic",
                        Address = new StreetAddressLongZip
                        {
                            Address1 = "1 Main St",
                            City = "Fairfax",
                            State = State.Va,
                            ZipCode = "22031",
                            ZipPlusFourCode = "4634",
                        },
                    },
                    SubscriberPrimary = new SubscriberCreate
                    {
                        FirstName = "Jane",
                        LastName = "Doe",
                        Gender = global::Candid.Net.Individual.Gender.Female,
                        PatientRelationshipToSubscriberCode =
                            PatientRelationshipToInsuredCodeAll.Self,
                        InsuranceCard = new InsuranceCardCreate
                        {
                            MemberId = "123456789",
                            PayerName = "Example Payer",
                            PayerId = "12345",
                        },
                    },
                    HealthCareCodeInformation = new HealthCareCodeInformationCreate
                    {
                        PrincipalDiagnosis = new PrincipalDiagnosisNew
                        {
                            PrimaryDiagnosisCode = "Z01.411",
                            PrincipalDiagnosisCodeQualifier = PrincipalDiagnosisCodeQualifier.Cabk,
                        },
                    },
                    ServiceLines = new List<UniversalServiceLineCreate>()
                    {
                        new UniversalServiceLineCreate
                        {
                            ProcedureCode = "99213",
                            Quantity = "1",
                            Units = ServiceLineUnits.Un,
                            ChargeAmountCents = 20600,
                            DiagnosisPointers = new List<int>() { 0 },
                        },
                    },
                },
                PipelineId = "pre-service-claim-athena",
                EnabledRuleIds = new List<string>() { },
                DisabledRuleIds = new List<string>() { },
                IdempotencyKey = "enc-123-run-1",
            }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
