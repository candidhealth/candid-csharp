using System.Text.Json;
using Candid.Net.ClinicalTrials.V1;
using Candid.Net.Commons;
using Candid.Net.Core;
using Candid.Net.Individual;
using Candid.Net.NonInsurancePayers.V1;
using NUnit.Framework;

namespace Candid.Net.Test;

[TestFixture]
public class PatientNonInsurancePayerInfoTest
{
    [global::NUnit.Framework.Test]
    public void TestDeserialization()
    {
        var json = """
            {
              "non_insurance_payer": {
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
              },
              "member_id": "123456789",
              "clinical_trial_info": []
            }
            """;
        var expectedObject = new PatientNonInsurancePayerInfo
        {
            NonInsurancePayer = new NonInsurancePayer
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
            },
            MemberId = "123456789",
            ClinicalTrialInfo = new List<PatientClinicalTrialInfo>() { },
        };
        var deserializedObject = JsonUtils.Deserialize<PatientNonInsurancePayerInfo>(json);
        Assert.That(deserializedObject, Is.EqualTo(expectedObject).UsingDefaults());
    }

    [global::NUnit.Framework.Test]
    public void TestSerialization()
    {
        var expectedJson = """
            {
              "non_insurance_payer": {
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
              },
              "member_id": "123456789",
              "clinical_trial_info": []
            }
            """;
        var actualObj = new PatientNonInsurancePayerInfo
        {
            NonInsurancePayer = new NonInsurancePayer
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
            },
            MemberId = "123456789",
            ClinicalTrialInfo = new List<PatientClinicalTrialInfo>() { },
        };
        var actualElement = JsonUtils.SerializeToElement(actualObj);
        var expectedElement = JsonUtils.Deserialize<JsonElement>(expectedJson);
        Assert.That(actualElement, Is.EqualTo(expectedElement).UsingJsonElementComparer());
    }
}
