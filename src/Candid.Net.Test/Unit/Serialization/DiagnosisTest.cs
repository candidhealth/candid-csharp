using System.Globalization;
using System.Text.Json;
using Candid.Net.Core;
using Candid.Net.Diagnoses;
using NUnit.Framework;

namespace Candid.Net.Test;

[TestFixture]
public class DiagnosisTest
{
    [global::NUnit.Framework.Test]
    public void TestDeserialization()
    {
        var json = """
            {
              "diagnosis_id": "5C770E00-4BBF-42AF-A73F-99C5E91FC0DB",
              "created_at": "2023-01-01T00:00:00Z",
              "updated_at": "2023-01-01T00:00:00Z",
              "encounter_id": "3F63985B-51A4-4DD4-9418-7D50B2520792",
              "name": "John Doe",
              "code_type": "ABF",
              "code": "I10"
            }
            """;
        var expectedObject = new Diagnosis
        {
            DiagnosisId = "5C770E00-4BBF-42AF-A73F-99C5E91FC0DB",
            CreatedAt = DateTime.Parse(
                "2023-01-01T00:00:00.000Z",
                null,
                DateTimeStyles.AdjustToUniversal
            ),
            UpdatedAt = DateTime.Parse(
                "2023-01-01T00:00:00.000Z",
                null,
                DateTimeStyles.AdjustToUniversal
            ),
            EncounterId = "3F63985B-51A4-4DD4-9418-7D50B2520792",
            Name = "John Doe",
            CodeType = DiagnosisTypeCode.Abf,
            Code = "I10",
        };
        var deserializedObject = JsonUtils.Deserialize<Diagnosis>(json);
        Assert.That(deserializedObject, Is.EqualTo(expectedObject).UsingDefaults());
    }

    [global::NUnit.Framework.Test]
    public void TestSerialization()
    {
        var expectedJson = """
            {
              "diagnosis_id": "5C770E00-4BBF-42AF-A73F-99C5E91FC0DB",
              "created_at": "2023-01-01T00:00:00Z",
              "updated_at": "2023-01-01T00:00:00Z",
              "encounter_id": "3F63985B-51A4-4DD4-9418-7D50B2520792",
              "name": "John Doe",
              "code_type": "ABF",
              "code": "I10"
            }
            """;
        var actualObj = new Diagnosis
        {
            DiagnosisId = "5C770E00-4BBF-42AF-A73F-99C5E91FC0DB",
            CreatedAt = DateTime.Parse(
                "2023-01-01T00:00:00.000Z",
                null,
                DateTimeStyles.AdjustToUniversal
            ),
            UpdatedAt = DateTime.Parse(
                "2023-01-01T00:00:00.000Z",
                null,
                DateTimeStyles.AdjustToUniversal
            ),
            EncounterId = "3F63985B-51A4-4DD4-9418-7D50B2520792",
            Name = "John Doe",
            CodeType = DiagnosisTypeCode.Abf,
            Code = "I10",
        };
        var actualElement = JsonUtils.SerializeToElement(actualObj);
        var expectedElement = JsonUtils.Deserialize<JsonElement>(expectedJson);
        Assert.That(actualElement, Is.EqualTo(expectedElement).UsingJsonElementComparer());
    }
}
