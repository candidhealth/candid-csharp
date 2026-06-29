using global::Candid.Net.Commons;
using global::Candid.Net.Core;
using global::Candid.Net.OrganizationServiceFacilities.V2;
using global::Candid.Net.Test.Utils;
using NUnit.Framework;

namespace Candid.Net.Test;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class OrganizationServiceFacilityCreateTest
{
    [global::NUnit.Framework.Test]
    public void TestDeserialization()
    {
        var json = """
            {
              "name": "Test Service Facility",
              "aliases": [
                "Test Service Facility Alias"
              ],
              "description": "Test Service Facility Description",
              "status": "active",
              "operational_status": "C",
              "mode": "instance",
              "type": "DX",
              "physical_type": "si",
              "telecoms": [
                "555-555-5555"
              ],
              "address": {
                "address1": "123 Main St",
                "address2": "Apt 1",
                "city": "New York",
                "state": "NY",
                "zip_code": "10001",
                "zip_plus_four_code": "1234"
              }
            }
            """;
        var expectedObject = new OrganizationServiceFacilityCreate
        {
            Name = "Test Service Facility",
            Aliases = new List<string>() { "Test Service Facility Alias" },
            Description = "Test Service Facility Description",
            Status = ServiceFacilityStatus.Active,
            OperationalStatus = ServiceFacilityOperationalStatus.Closed,
            Mode = ServiceFacilityMode.Instance,
            Type = ServiceFacilityType.DiagnosticsOrTherapeuticsUnit,
            PhysicalType = ServiceFacilityPhysicalType.Site,
            Telecoms = new List<string>() { "555-555-5555" },
            Address = new StreetAddressLongZip
            {
                Address1 = "123 Main St",
                Address2 = "Apt 1",
                City = "New York",
                State = State.Ny,
                ZipCode = "10001",
                ZipPlusFourCode = "1234",
            },
        };
        var deserializedObject = JsonUtils.Deserialize<OrganizationServiceFacilityCreate>(json);
        Assert.That(deserializedObject, Is.EqualTo(expectedObject).UsingDefaults());
    }

    [global::NUnit.Framework.Test]
    public void TestSerialization()
    {
        var inputJson = """
            {
              "name": "Test Service Facility",
              "aliases": [
                "Test Service Facility Alias"
              ],
              "description": "Test Service Facility Description",
              "status": "active",
              "operational_status": "C",
              "mode": "instance",
              "type": "DX",
              "physical_type": "si",
              "telecoms": [
                "555-555-5555"
              ],
              "address": {
                "address1": "123 Main St",
                "address2": "Apt 1",
                "city": "New York",
                "state": "NY",
                "zip_code": "10001",
                "zip_plus_four_code": "1234"
              }
            }
            """;
        JsonAssert.Roundtrips<OrganizationServiceFacilityCreate>(inputJson);
    }
}
