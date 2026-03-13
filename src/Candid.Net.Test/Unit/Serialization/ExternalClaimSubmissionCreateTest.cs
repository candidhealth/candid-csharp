using System.Globalization;
using System.Text.Json;
using Candid.Net.ClaimSubmission.V1;
using Candid.Net.Commons;
using Candid.Net.Core;
using Candid.Net.X12.V1;
using NUnit.Framework;

namespace Candid.Net.Test;

[TestFixture]
public class ExternalClaimSubmissionCreateTest
{
    [global::NUnit.Framework.Test]
    public void TestDeserialization_1()
    {
        var json = """
            {
              "claim_created_at": "2023-01-01T12:00:00.000000Z",
              "patient_control_number": "PATIENT_CONTROL_NUMBER",
              "submission_records": [
                {
                  "submitted_at": "2023-01-01T13:00:00.000000Z",
                  "claim_frequency_code": "1",
                  "payer_responsibility": "primary",
                  "intended_submission_medium": "electronic"
                },
                {
                  "submitted_at": "2023-01-04T12:00:00.000000Z",
                  "claim_frequency_code": "7",
                  "payer_responsibility": "primary",
                  "intended_submission_medium": "paper"
                }
              ]
            }
            """;
        var expectedObject = new ExternalClaimSubmissionCreate
        {
            ClaimCreatedAt = DateTime.Parse(
                "2023-01-01T12:00:00.000Z",
                null,
                DateTimeStyles.AdjustToUniversal
            ),
            PatientControlNumber = "PATIENT_CONTROL_NUMBER",
            SubmissionRecords = new List<ClaimSubmissionRecordCreate>()
            {
                new ClaimSubmissionRecordCreate
                {
                    SubmittedAt = DateTime.Parse(
                        "2023-01-01T13:00:00.000Z",
                        null,
                        DateTimeStyles.AdjustToUniversal
                    ),
                    ClaimFrequencyCode = TypeOfBillFrequencyCode.C1,
                    PayerResponsibility = ClaimSubmissionPayerResponsibilityType.Primary,
                    IntendedSubmissionMedium = IntendedSubmissionMedium.Electronic,
                },
                new ClaimSubmissionRecordCreate
                {
                    SubmittedAt = DateTime.Parse(
                        "2023-01-04T12:00:00.000Z",
                        null,
                        DateTimeStyles.AdjustToUniversal
                    ),
                    ClaimFrequencyCode = TypeOfBillFrequencyCode.C7,
                    PayerResponsibility = ClaimSubmissionPayerResponsibilityType.Primary,
                    IntendedSubmissionMedium = IntendedSubmissionMedium.Paper,
                },
            },
        };
        var deserializedObject = JsonUtils.Deserialize<ExternalClaimSubmissionCreate>(json);
        Assert.That(deserializedObject, Is.EqualTo(expectedObject).UsingDefaults());
    }

    [global::NUnit.Framework.Test]
    public void TestSerialization_1()
    {
        var expectedJson = """
            {
              "claim_created_at": "2023-01-01T12:00:00.000000Z",
              "patient_control_number": "PATIENT_CONTROL_NUMBER",
              "submission_records": [
                {
                  "submitted_at": "2023-01-01T13:00:00.000000Z",
                  "claim_frequency_code": "1",
                  "payer_responsibility": "primary",
                  "intended_submission_medium": "electronic"
                },
                {
                  "submitted_at": "2023-01-04T12:00:00.000000Z",
                  "claim_frequency_code": "7",
                  "payer_responsibility": "primary",
                  "intended_submission_medium": "paper"
                }
              ]
            }
            """;
        var actualObj = new ExternalClaimSubmissionCreate
        {
            ClaimCreatedAt = DateTime.Parse(
                "2023-01-01T12:00:00.000Z",
                null,
                DateTimeStyles.AdjustToUniversal
            ),
            PatientControlNumber = "PATIENT_CONTROL_NUMBER",
            SubmissionRecords = new List<ClaimSubmissionRecordCreate>()
            {
                new ClaimSubmissionRecordCreate
                {
                    SubmittedAt = DateTime.Parse(
                        "2023-01-01T13:00:00.000Z",
                        null,
                        DateTimeStyles.AdjustToUniversal
                    ),
                    ClaimFrequencyCode = TypeOfBillFrequencyCode.C1,
                    PayerResponsibility = ClaimSubmissionPayerResponsibilityType.Primary,
                    IntendedSubmissionMedium = IntendedSubmissionMedium.Electronic,
                },
                new ClaimSubmissionRecordCreate
                {
                    SubmittedAt = DateTime.Parse(
                        "2023-01-04T12:00:00.000Z",
                        null,
                        DateTimeStyles.AdjustToUniversal
                    ),
                    ClaimFrequencyCode = TypeOfBillFrequencyCode.C7,
                    PayerResponsibility = ClaimSubmissionPayerResponsibilityType.Primary,
                    IntendedSubmissionMedium = IntendedSubmissionMedium.Paper,
                },
            },
        };
        var actualElement = JsonUtils.SerializeToElement(actualObj);
        var expectedElement = JsonUtils.Deserialize<JsonElement>(expectedJson);
        Assert.That(actualElement, Is.EqualTo(expectedElement).UsingJsonElementComparer());
    }

    [global::NUnit.Framework.Test]
    public void TestDeserialization_2()
    {
        var json = """
            {
              "claim_created_at": "2023-01-01T12:00:00.000000Z",
              "patient_control_number": "123XYZABC",
              "submission_records": []
            }
            """;
        var expectedObject = new ExternalClaimSubmissionCreate
        {
            ClaimCreatedAt = DateTime.Parse(
                "2023-01-01T12:00:00.000Z",
                null,
                DateTimeStyles.AdjustToUniversal
            ),
            PatientControlNumber = "123XYZABC",
            SubmissionRecords = new List<ClaimSubmissionRecordCreate>() { },
        };
        var deserializedObject = JsonUtils.Deserialize<ExternalClaimSubmissionCreate>(json);
        Assert.That(deserializedObject, Is.EqualTo(expectedObject).UsingDefaults());
    }

    [global::NUnit.Framework.Test]
    public void TestSerialization_2()
    {
        var expectedJson = """
            {
              "claim_created_at": "2023-01-01T12:00:00.000000Z",
              "patient_control_number": "123XYZABC",
              "submission_records": []
            }
            """;
        var actualObj = new ExternalClaimSubmissionCreate
        {
            ClaimCreatedAt = DateTime.Parse(
                "2023-01-01T12:00:00.000Z",
                null,
                DateTimeStyles.AdjustToUniversal
            ),
            PatientControlNumber = "123XYZABC",
            SubmissionRecords = new List<ClaimSubmissionRecordCreate>() { },
        };
        var actualElement = JsonUtils.SerializeToElement(actualObj);
        var expectedElement = JsonUtils.Deserialize<JsonElement>(expectedJson);
        Assert.That(actualElement, Is.EqualTo(expectedElement).UsingJsonElementComparer());
    }
}
