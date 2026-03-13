using System.Text.Json;
using Candid.Net.Commons;
using Candid.Net.Core;
using Candid.Net.InsuranceCards.V2;
using NUnit.Framework;

namespace Candid.Net.Test;

[TestFixture]
public class InsuranceCardTest
{
    [global::NUnit.Framework.Test]
    public void TestDeserialization()
    {
        var json = """
            {
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
            }
            """;
        var expectedObject = new InsuranceCard
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
        };
        var deserializedObject = JsonUtils.Deserialize<InsuranceCard>(json);
        Assert.That(deserializedObject, Is.EqualTo(expectedObject).UsingDefaults());
    }

    [global::NUnit.Framework.Test]
    public void TestSerialization()
    {
        var expectedJson = """
            {
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
            }
            """;
        var actualObj = new InsuranceCard
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
        };
        var actualElement = JsonUtils.SerializeToElement(actualObj);
        var expectedElement = JsonUtils.Deserialize<JsonElement>(expectedJson);
        Assert.That(actualElement, Is.EqualTo(expectedElement).UsingJsonElementComparer());
    }
}
