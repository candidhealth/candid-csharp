using System.Text.Json;
using Candid.Net.Core;
using Candid.Net.Encounters.V4;
using NUnit.Framework;

namespace Candid.Net.Test;

[TestFixture]
public class InterventionTest
{
    [global::NUnit.Framework.Test]
    public void TestDeserialization()
    {
        var json = """
            {
              "name": "Physical Therapy Session",
              "category": "lifestyle",
              "description": "A session focused on improving muscular strength, flexibility, and range of motion post-injury.",
              "medication": {
                "name": "Lisinopril",
                "rx_cui": "860975",
                "dosage": "10mg",
                "dosage_form": "Tablet",
                "frequency": "Once Daily",
                "as_needed": true
              },
              "labs": [
                {
                  "name": "Genetic Health Labs",
                  "code": "GH12345",
                  "code_type": "quest"
                }
              ]
            }
            """;
        var expectedObject = new Intervention
        {
            Name = "Physical Therapy Session",
            Category = InterventionCategory.Lifestyle,
            Description =
                "A session focused on improving muscular strength, flexibility, and range of motion post-injury.",
            Medication = new Medication
            {
                Name = "Lisinopril",
                RxCui = "860975",
                Dosage = "10mg",
                DosageForm = "Tablet",
                Frequency = "Once Daily",
                AsNeeded = true,
            },
            Labs = new List<Lab>()
            {
                new Lab
                {
                    Name = "Genetic Health Labs",
                    Code = "GH12345",
                    CodeType = LabCodeType.Quest,
                },
            },
        };
        var deserializedObject = JsonUtils.Deserialize<Intervention>(json);
        Assert.That(deserializedObject, Is.EqualTo(expectedObject).UsingDefaults());
    }

    [global::NUnit.Framework.Test]
    public void TestSerialization()
    {
        var expectedJson = """
            {
              "name": "Physical Therapy Session",
              "category": "lifestyle",
              "description": "A session focused on improving muscular strength, flexibility, and range of motion post-injury.",
              "medication": {
                "name": "Lisinopril",
                "rx_cui": "860975",
                "dosage": "10mg",
                "dosage_form": "Tablet",
                "frequency": "Once Daily",
                "as_needed": true
              },
              "labs": [
                {
                  "name": "Genetic Health Labs",
                  "code": "GH12345",
                  "code_type": "quest"
                }
              ]
            }
            """;
        var actualObj = new Intervention
        {
            Name = "Physical Therapy Session",
            Category = InterventionCategory.Lifestyle,
            Description =
                "A session focused on improving muscular strength, flexibility, and range of motion post-injury.",
            Medication = new Medication
            {
                Name = "Lisinopril",
                RxCui = "860975",
                Dosage = "10mg",
                DosageForm = "Tablet",
                Frequency = "Once Daily",
                AsNeeded = true,
            },
            Labs = new List<Lab>()
            {
                new Lab
                {
                    Name = "Genetic Health Labs",
                    Code = "GH12345",
                    CodeType = LabCodeType.Quest,
                },
            },
        };
        var actualElement = JsonUtils.SerializeToElement(actualObj);
        var expectedElement = JsonUtils.Deserialize<JsonElement>(expectedJson);
        Assert.That(actualElement, Is.EqualTo(expectedElement).UsingJsonElementComparer());
    }
}
