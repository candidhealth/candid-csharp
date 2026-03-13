using System.Text.Json;
using Candid.Net.ClinicalTrials.V1;
using Candid.Net.Commons;
using Candid.Net.Core;
using Candid.Net.Individual;
using Candid.Net.NonInsurancePayers.V1;
using NUnit.Framework;

namespace Candid.Net.Test;

[TestFixture]
public class PatientTest
{
    [global::NUnit.Framework.Test]
    public void TestDeserialization()
    {
        var json = """
            {
              "individual_id": "93DDBEBF-4956-4482-9A6C-21499B7E4E5D",
              "phone_numbers": [
                {
                  "number": "1234567890",
                  "type": "Home"
                }
              ],
              "non_insurance_payers": [
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
              ],
              "non_insurance_payers_info": [
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
              ],
              "phone_consent": true,
              "email": "johndoe@joincandidhealth.com",
              "email_consent": true,
              "auto_charge_consent": true,
              "external_id": "49460F77-6456-41F1-AC6D-0AED08614D39",
              "date_of_birth": "2000-01-01",
              "address": {
                "address1": "123 Main St",
                "address2": "Apt 1",
                "city": "New York",
                "state": "NY",
                "zip_code": "10001",
                "zip_plus_four_code": "1234"
              },
              "first_name": "John",
              "last_name": "Doe",
              "gender": "male"
            }
            """;
        var expectedObject = new global::Candid.Net.Individual.Patient
        {
            IndividualId = "93DDBEBF-4956-4482-9A6C-21499B7E4E5D",
            PhoneNumbers = new List<PhoneNumber>()
            {
                new PhoneNumber { Number = "1234567890", Type = PhoneNumberType.Home },
            },
            NonInsurancePayers = new List<NonInsurancePayer>()
            {
                new NonInsurancePayer
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
            },
            NonInsurancePayersInfo = new List<PatientNonInsurancePayerInfo>()
            {
                new PatientNonInsurancePayerInfo
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
                },
            },
            PhoneConsent = true,
            Email = "johndoe@joincandidhealth.com",
            EmailConsent = true,
            AutoChargeConsent = true,
            ExternalId = "49460F77-6456-41F1-AC6D-0AED08614D39",
            DateOfBirth = new DateOnly(2000, 1, 1),
            Address = new StreetAddressShortZip
            {
                Address1 = "123 Main St",
                Address2 = "Apt 1",
                City = "New York",
                State = State.Ny,
                ZipCode = "10001",
                ZipPlusFourCode = "1234",
            },
            FirstName = "John",
            LastName = "Doe",
            Gender = global::Candid.Net.Individual.Gender.Male,
        };
        var deserializedObject = JsonUtils.Deserialize<global::Candid.Net.Individual.Patient>(json);
        Assert.That(deserializedObject, Is.EqualTo(expectedObject).UsingDefaults());
    }

    [global::NUnit.Framework.Test]
    public void TestSerialization()
    {
        var expectedJson = """
            {
              "individual_id": "93DDBEBF-4956-4482-9A6C-21499B7E4E5D",
              "phone_numbers": [
                {
                  "number": "1234567890",
                  "type": "Home"
                }
              ],
              "non_insurance_payers": [
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
              ],
              "non_insurance_payers_info": [
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
              ],
              "phone_consent": true,
              "email": "johndoe@joincandidhealth.com",
              "email_consent": true,
              "auto_charge_consent": true,
              "external_id": "49460F77-6456-41F1-AC6D-0AED08614D39",
              "date_of_birth": "2000-01-01",
              "address": {
                "address1": "123 Main St",
                "address2": "Apt 1",
                "city": "New York",
                "state": "NY",
                "zip_code": "10001",
                "zip_plus_four_code": "1234"
              },
              "first_name": "John",
              "last_name": "Doe",
              "gender": "male"
            }
            """;
        var actualObj = new global::Candid.Net.Individual.Patient
        {
            IndividualId = "93DDBEBF-4956-4482-9A6C-21499B7E4E5D",
            PhoneNumbers = new List<PhoneNumber>()
            {
                new PhoneNumber { Number = "1234567890", Type = PhoneNumberType.Home },
            },
            NonInsurancePayers = new List<NonInsurancePayer>()
            {
                new NonInsurancePayer
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
            },
            NonInsurancePayersInfo = new List<PatientNonInsurancePayerInfo>()
            {
                new PatientNonInsurancePayerInfo
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
                },
            },
            PhoneConsent = true,
            Email = "johndoe@joincandidhealth.com",
            EmailConsent = true,
            AutoChargeConsent = true,
            ExternalId = "49460F77-6456-41F1-AC6D-0AED08614D39",
            DateOfBirth = new DateOnly(2000, 1, 1),
            Address = new StreetAddressShortZip
            {
                Address1 = "123 Main St",
                Address2 = "Apt 1",
                City = "New York",
                State = State.Ny,
                ZipCode = "10001",
                ZipPlusFourCode = "1234",
            },
            FirstName = "John",
            LastName = "Doe",
            Gender = global::Candid.Net.Individual.Gender.Male,
        };
        var actualElement = JsonUtils.SerializeToElement(actualObj);
        var expectedElement = JsonUtils.Deserialize<JsonElement>(expectedJson);
        Assert.That(actualElement, Is.EqualTo(expectedElement).UsingJsonElementComparer());
    }
}
