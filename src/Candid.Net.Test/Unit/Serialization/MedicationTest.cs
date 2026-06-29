using global::Candid.Net.Core;
using global::Candid.Net.Encounters.V4;
using global::Candid.Net.Test.Utils;
using NUnit.Framework;

namespace Candid.Net.Test;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class MedicationTest
{
    [global::NUnit.Framework.Test]
    public void TestDeserialization()
    {
        var json = """
            {
              "name": "Lisinopril",
              "rx_cui": "860975",
              "dosage": "10mg",
              "dosage_form": "Tablet",
              "frequency": "Once Daily",
              "as_needed": true
            }
            """;
        var expectedObject = new Medication
        {
            Name = "Lisinopril",
            RxCui = "860975",
            Dosage = "10mg",
            DosageForm = "Tablet",
            Frequency = "Once Daily",
            AsNeeded = true,
        };
        var deserializedObject = JsonUtils.Deserialize<Medication>(json);
        Assert.That(deserializedObject, Is.EqualTo(expectedObject).UsingDefaults());
    }

    [global::NUnit.Framework.Test]
    public void TestSerialization()
    {
        var inputJson = """
            {
              "name": "Lisinopril",
              "rx_cui": "860975",
              "dosage": "10mg",
              "dosage_form": "Tablet",
              "frequency": "Once Daily",
              "as_needed": true
            }
            """;
        JsonAssert.Roundtrips<Medication>(inputJson);
    }
}
