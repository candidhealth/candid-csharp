using System.Text.Json;
using Candid.Net.Core;
using Candid.Net.Encounters.V4;
using NUnit.Framework;

namespace Candid.Net.Test;

[TestFixture]
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
        var expectedJson = """
            {
              "name": "Lisinopril",
              "rx_cui": "860975",
              "dosage": "10mg",
              "dosage_form": "Tablet",
              "frequency": "Once Daily",
              "as_needed": true
            }
            """;
        var actualObj = new Medication
        {
            Name = "Lisinopril",
            RxCui = "860975",
            Dosage = "10mg",
            DosageForm = "Tablet",
            Frequency = "Once Daily",
            AsNeeded = true,
        };
        var actualElement = JsonUtils.SerializeToElement(actualObj);
        var expectedElement = JsonUtils.Deserialize<JsonElement>(expectedJson);
        Assert.That(actualElement, Is.EqualTo(expectedElement).UsingJsonElementComparer());
    }
}
