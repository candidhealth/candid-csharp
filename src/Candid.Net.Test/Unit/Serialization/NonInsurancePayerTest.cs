using global::Candid.Net.ClinicalTrials.V1;
using global::Candid.Net.Commons;
using global::Candid.Net.Core;
using global::Candid.Net.NonInsurancePayers.V1;
using global::Candid.Net.Test.Utils;
using NUnit.Framework;

namespace Candid.Net.Test;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class NonInsurancePayerTest
{
    [global::NUnit.Framework.Test]
    public void TestDeserialization()
    {
        var json = """
            {
              "non_insurance_payer_id": "EB7623AB-D5BC-4B25-B257-2B8FCEC578DE",
              "name": "Sunrise Foundation",
              "category": "Foundation",
              "description": "Sunrise Foundation is a non-profit organization that provides financial assistance to patients in need.",
              "enabled": true,
              "address": {
                "address1": "123 Main St",
                "city": "San Francisco",
                "state": "CA",
                "zip_code": "94105"
              },
              "clinical_trials": []
            }
            """;
        var expectedObject = new NonInsurancePayer
        {
            NonInsurancePayerId = "EB7623AB-D5BC-4B25-B257-2B8FCEC578DE",
            Name = "Sunrise Foundation",
            Category = "Foundation",
            Description =
                "Sunrise Foundation is a non-profit organization that provides financial assistance to patients in need.",
            Enabled = true,
            Address = new StreetAddressShortZip
            {
                Address1 = "123 Main St",
                City = "San Francisco",
                State = State.Ca,
                ZipCode = "94105",
            },
            ClinicalTrials = new List<ClinicalTrial>() { },
        };
        var deserializedObject = JsonUtils.Deserialize<NonInsurancePayer>(json);
        Assert.That(deserializedObject, Is.EqualTo(expectedObject).UsingDefaults());
    }

    [global::NUnit.Framework.Test]
    public void TestSerialization()
    {
        var inputJson = """
            {
              "non_insurance_payer_id": "EB7623AB-D5BC-4B25-B257-2B8FCEC578DE",
              "name": "Sunrise Foundation",
              "category": "Foundation",
              "description": "Sunrise Foundation is a non-profit organization that provides financial assistance to patients in need.",
              "enabled": true,
              "address": {
                "address1": "123 Main St",
                "city": "San Francisco",
                "state": "CA",
                "zip_code": "94105"
              },
              "clinical_trials": []
            }
            """;
        JsonAssert.Roundtrips<NonInsurancePayer>(inputJson);
    }
}
