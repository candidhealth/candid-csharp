using Candid.Net.Core;
using Candid.Net.EncounterProviders.V2;
using Candid.Net.Encounters.V4;
using Candid.Net.PreEncounter;
using Candid.Net.PreEncounter.Patients.V1;
using NUnit.Framework;

namespace Candid.Net.Test.Integration;

[Explicit]
public class ManualIntegrationTest
{
    private CandidClient candid;

    [SetUp]
    public void Setup()
    {
        // To run this test, fill in your client id and secret below and run the following from the root of the repo:
        // dotnet test src --filter "FullyQualifiedName~ManualIntegrationTest"
        candid = new CandidClient(
            "YOUR_CLIENT_ID",
            "YOUR_CLIENT_SECRET",
            new ClientOptions { Environment = CandidClientEnvironment.STAGING }
        );
    }

    [Test]
    public void TestPatient()
    {
        var patient = candid
            .PreEncounter.Patients.V1.CreateAsync(
                new MutablePatient
                {
                    Name = new HumanName
                    {
                        Family = "Johnson",
                        Given = new[] { "Jim" },
                        Use = NameUse.Usual,
                    },
                    Gender = PreEncounter.Gender.Man,
                    BirthDate = default,
                    PrimaryAddress = new Address
                    {
                        Use = AddressUse.Home,
                        City = "New York",
                        State = "NY",
                        PostalCode = "10001",
                        Country = "USA",
                    },
                    PrimaryTelecom = new ContactPoint
                    {
                        Value = "+19526868945",
                        Use = ContactPointUse.Home,
                    },
                    FilingOrder = new FilingOrder()
                }
            )
            .Result;

        var getPatient = candid.PreEncounter.Patients.V1.GetAsync(patient.Id).Result;

        Assert.That(patient.Id, Is.EqualTo(getPatient.Id));
    }

    [Test]
    public void TestEncounter()
    {
        var encounter = candid
            .Encounters.V4.CreateAsync(
                new EncounterCreate
                {
                    Patient = new PatientCreate
                    {
                        DateOfBirth = default,
                        Address = new StreetAddressShortZip
                        {
                            Address1 = "1460 Broadway",
                            City = "New York",
                            State = State.Ny,
                            ZipCode = "10036"
                        },
                        FirstName = "Jim",
                        LastName = "Johnson",
                        Gender = Gender.Male,
                        ExternalId = Guid.NewGuid().ToString(),
                    },
                    BillingProvider = new BillingProvider
                    {
                        Address = new StreetAddressLongZip
                        {
                            ZipPlusFourCode = "1001",
                            Address1 = "1460 Broadway",
                            City = "New York",
                            State = State.Ny,
                            ZipCode = "10036"
                        },
                        TaxId = "123456782",
                        Npi = "Npi",
                        OrganizationName = "SomeName",
                    },
                    RenderingProvider = new RenderingProvider
                    {
                        Npi = "Npi",
                        OrganizationName = "RenderingProviderName",
                    },
                    PlaceOfServiceCode = FacilityTypeCode.Pharmacy,
                    ExternalId = Guid.NewGuid().ToString(),
                    PatientAuthorizedRelease = false,
                    BenefitsAssignedToProvider = false,
                    ProviderAcceptsAssignment = false,
                    BillableStatus = BillableStatusType.Billable,
                    ResponsibleParty = ResponsiblePartyType.InsurancePay,
                    DateOfService = DateOnly.MaxValue,
                    ServiceFacility = new EncounterServiceFacilityBase
                    {
                        OrganizationName = "ServiceFacilityName",
                        Address = new StreetAddressLongZip
                        {
                            ZipPlusFourCode = "1001",
                            Address1 = "1460 Broadway",
                            City = "New York",
                            State = State.Ny,
                            ZipCode = "10036"
                        }
                    }
                }
            )
            .Result;

        var getEncounter = candid.Encounters.V4.GetAsync(encounter.EncounterId).Result;

        Assert.That(encounter.EncounterId, Is.EqualTo(getEncounter.EncounterId));
    }
}

