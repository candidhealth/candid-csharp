using System.Globalization;
using global::Candid.Net.Core;
using global::Candid.Net.PatientPayments.V3;
using global::Candid.Net.Test.Utils;
using NUnit.Framework;

namespace Candid.Net.Test;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class PatientPaymentTest
{
    [global::NUnit.Framework.Test]
    public void TestDeserialization()
    {
        var json = """
            {
              "patient_payment_id": "CF237BE1-E793-4BBF-8958-61D5179D1D0D",
              "organization_id": "0788CA2A-B20D-4B8E-B8D4-07FA0B3B4907",
              "source_internal_id": "D1A76039-D5C5-4323-A2FC-B7C8B6AEF6A4",
              "source": "MANUAL_ENTRY",
              "amount_cents": 2000,
              "payment_timestamp": "2023-01-01T00:00:00Z",
              "status": "PENDING",
              "payment_name": "John Doe",
              "payment_note": "test payment note",
              "patient_external_id": "B7437260-D6B4-48CF-B9D7-753C09F34E76",
              "encounter_external_id": "0F26B9C3-199F-4CBB-A166-B87EA7C631BB",
              "service_line_id": "B557DC86-C629-478C-850A-02D45AC11783"
            }
            """;
        var expectedObject = new global::Candid.Net.PatientPayments.V3.PatientPayment
        {
            PatientPaymentId = "CF237BE1-E793-4BBF-8958-61D5179D1D0D",
            OrganizationId = "0788CA2A-B20D-4B8E-B8D4-07FA0B3B4907",
            SourceInternalId = "D1A76039-D5C5-4323-A2FC-B7C8B6AEF6A4",
            Source = PatientPaymentSource.ManualEntry,
            AmountCents = 2000,
            PaymentTimestamp = DateTime.Parse(
                "2023-01-01T00:00:00.000Z",
                null,
                DateTimeStyles.AdjustToUniversal
            ),
            Status = PatientPaymentStatus.Pending,
            PaymentName = "John Doe",
            PaymentNote = "test payment note",
            PatientExternalId = "B7437260-D6B4-48CF-B9D7-753C09F34E76",
            EncounterExternalId = "0F26B9C3-199F-4CBB-A166-B87EA7C631BB",
            ServiceLineId = "B557DC86-C629-478C-850A-02D45AC11783",
        };
        var deserializedObject =
            JsonUtils.Deserialize<global::Candid.Net.PatientPayments.V3.PatientPayment>(json);
        Assert.That(deserializedObject, Is.EqualTo(expectedObject).UsingDefaults());
    }

    [global::NUnit.Framework.Test]
    public void TestSerialization()
    {
        var inputJson = """
            {
              "patient_payment_id": "CF237BE1-E793-4BBF-8958-61D5179D1D0D",
              "organization_id": "0788CA2A-B20D-4B8E-B8D4-07FA0B3B4907",
              "source_internal_id": "D1A76039-D5C5-4323-A2FC-B7C8B6AEF6A4",
              "source": "MANUAL_ENTRY",
              "amount_cents": 2000,
              "payment_timestamp": "2023-01-01T00:00:00Z",
              "status": "PENDING",
              "payment_name": "John Doe",
              "payment_note": "test payment note",
              "patient_external_id": "B7437260-D6B4-48CF-B9D7-753C09F34E76",
              "encounter_external_id": "0F26B9C3-199F-4CBB-A166-B87EA7C631BB",
              "service_line_id": "B557DC86-C629-478C-850A-02D45AC11783"
            }
            """;
        JsonAssert.Roundtrips<global::Candid.Net.PatientPayments.V3.PatientPayment>(inputJson);
    }
}
