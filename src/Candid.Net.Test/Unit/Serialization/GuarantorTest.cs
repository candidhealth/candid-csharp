using System.Text.Json;
using Candid.Net.Commons;
using Candid.Net.Core;
using NUnit.Framework;

namespace Candid.Net.Test;

[TestFixture]
public class GuarantorTest
{
    [global::NUnit.Framework.Test]
    public void TestDeserialization()
    {
        var json = """
            {
              "guarantor_id": "8BBDBE63-58D3-4D40-98C9-40403C050977",
              "phone_numbers": [
                {
                  "number": "1234567890",
                  "type": "Home"
                }
              ],
              "phone_consent": true,
              "email": "johndoe@joincandidhealth.com",
              "email_consent": true,
              "auto_charge_consent": true,
              "first_name": "John",
              "last_name": "Doe",
              "external_id": "49460F77-6456-41F1-AC6D-0AED08614D39",
              "date_of_birth": "2000-01-01",
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
        var expectedObject = new global::Candid.Net.Guarantor.V1.Guarantor
        {
            GuarantorId = "8BBDBE63-58D3-4D40-98C9-40403C050977",
            PhoneNumbers = new List<PhoneNumber>()
            {
                new PhoneNumber { Number = "1234567890", Type = PhoneNumberType.Home },
            },
            PhoneConsent = true,
            Email = "johndoe@joincandidhealth.com",
            EmailConsent = true,
            AutoChargeConsent = true,
            FirstName = "John",
            LastName = "Doe",
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
        };
        var deserializedObject = JsonUtils.Deserialize<global::Candid.Net.Guarantor.V1.Guarantor>(
            json
        );
        Assert.That(deserializedObject, Is.EqualTo(expectedObject).UsingDefaults());
    }

    [global::NUnit.Framework.Test]
    public void TestSerialization()
    {
        var expectedJson = """
            {
              "guarantor_id": "8BBDBE63-58D3-4D40-98C9-40403C050977",
              "phone_numbers": [
                {
                  "number": "1234567890",
                  "type": "Home"
                }
              ],
              "phone_consent": true,
              "email": "johndoe@joincandidhealth.com",
              "email_consent": true,
              "auto_charge_consent": true,
              "first_name": "John",
              "last_name": "Doe",
              "external_id": "49460F77-6456-41F1-AC6D-0AED08614D39",
              "date_of_birth": "2000-01-01",
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
        var actualObj = new global::Candid.Net.Guarantor.V1.Guarantor
        {
            GuarantorId = "8BBDBE63-58D3-4D40-98C9-40403C050977",
            PhoneNumbers = new List<PhoneNumber>()
            {
                new PhoneNumber { Number = "1234567890", Type = PhoneNumberType.Home },
            },
            PhoneConsent = true,
            Email = "johndoe@joincandidhealth.com",
            EmailConsent = true,
            AutoChargeConsent = true,
            FirstName = "John",
            LastName = "Doe",
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
        };
        var actualElement = JsonUtils.SerializeToElement(actualObj);
        var expectedElement = JsonUtils.Deserialize<JsonElement>(expectedJson);
        Assert.That(actualElement, Is.EqualTo(expectedElement).UsingJsonElementComparer());
    }
}
