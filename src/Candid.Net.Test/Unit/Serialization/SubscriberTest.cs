using global::Candid.Net.Commons;
using global::Candid.Net.Core;
using global::Candid.Net.InsuranceCards.V2;
using global::Candid.Net.Test.Utils;
using NUnit.Framework;

namespace Candid.Net.Test;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class SubscriberTest
{
    [global::NUnit.Framework.Test]
    public void TestDeserialization()
    {
        var json = """
            {
              "individual_id": "797348A9-E7E8-4E59-8628-95390D079C0B",
              "insurance_card": {
                "insurance_card_id": "CA5B7711-4419-4161-9B7C-3494AC40C8D4",
                "member_id": "E85313B4-0FFC-4119-8042-8161A4ECFF0A",
                "payer_name": "John Doe",
                "payer_id": "836DDAA6-863F-4020-ACCA-205A689F0002",
                "rx_bin": "610014",
                "rx_pcn": "MEDDPRIME",
                "image_url_front": "https://s3.amazonaws.com/front.jpg",
                "image_url_back": "https://s3.amazonaws.com/back.jpg",
                "group_number": "ABC12345",
                "plan_name": "Silver PPO Plan",
                "plan_type": "09",
                "insurance_type": "12"
              },
              "patient_relationship_to_subscriber_code": "01",
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
        var expectedObject = new global::Candid.Net.Individual.Subscriber
        {
            IndividualId = "797348A9-E7E8-4E59-8628-95390D079C0B",
            InsuranceCard = new InsuranceCard
            {
                InsuranceCardId = "CA5B7711-4419-4161-9B7C-3494AC40C8D4",
                MemberId = "E85313B4-0FFC-4119-8042-8161A4ECFF0A",
                PayerName = "John Doe",
                PayerId = "836DDAA6-863F-4020-ACCA-205A689F0002",
                RxBin = "610014",
                RxPcn = "MEDDPRIME",
                ImageUrlFront = "https://s3.amazonaws.com/front.jpg",
                ImageUrlBack = "https://s3.amazonaws.com/back.jpg",
                GroupNumber = "ABC12345",
                PlanName = "Silver PPO Plan",
                PlanType = SourceOfPaymentCode.SelfPay,
                InsuranceType = global::Candid.Net.Commons.InsuranceTypeCode.C12,
            },
            PatientRelationshipToSubscriberCode = PatientRelationshipToInsuredCodeAll.Spouse,
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
        var deserializedObject = JsonUtils.Deserialize<global::Candid.Net.Individual.Subscriber>(
            json
        );
        Assert.That(deserializedObject, Is.EqualTo(expectedObject).UsingDefaults());
    }

    [global::NUnit.Framework.Test]
    public void TestSerialization()
    {
        var inputJson = """
            {
              "individual_id": "797348A9-E7E8-4E59-8628-95390D079C0B",
              "insurance_card": {
                "insurance_card_id": "CA5B7711-4419-4161-9B7C-3494AC40C8D4",
                "member_id": "E85313B4-0FFC-4119-8042-8161A4ECFF0A",
                "payer_name": "John Doe",
                "payer_id": "836DDAA6-863F-4020-ACCA-205A689F0002",
                "rx_bin": "610014",
                "rx_pcn": "MEDDPRIME",
                "image_url_front": "https://s3.amazonaws.com/front.jpg",
                "image_url_back": "https://s3.amazonaws.com/back.jpg",
                "group_number": "ABC12345",
                "plan_name": "Silver PPO Plan",
                "plan_type": "09",
                "insurance_type": "12"
              },
              "patient_relationship_to_subscriber_code": "01",
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
        JsonAssert.Roundtrips<global::Candid.Net.Individual.Subscriber>(inputJson);
    }
}
