using System.Globalization;
using global::Candid.Net.ClaimSubmission.V1;
using global::Candid.Net.Commons;
using global::Candid.Net.Core;
using global::Candid.Net.Test.Utils;
using global::Candid.Net.X12.V1;
using NUnit.Framework;

namespace Candid.Net.Test;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class ClaimSubmissionRecordCreateOptionalTest
{
    [global::NUnit.Framework.Test]
    public void TestDeserialization_1()
    {
        var json = """
            {
              "submitted_at": "2023-01-01T13:00:00.000000Z",
              "claim_frequency_code": "1",
              "payer_responsibility": "primary",
              "intended_submission_medium": "electronic"
            }
            """;
        var expectedObject = new ClaimSubmissionRecordCreateOptional
        {
            SubmittedAt = DateTime.Parse(
                "2023-01-01T13:00:00.000Z",
                null,
                DateTimeStyles.AdjustToUniversal
            ),
            ClaimFrequencyCode = TypeOfBillFrequencyCode.C1,
            PayerResponsibility = ClaimSubmissionPayerResponsibilityType.Primary,
            IntendedSubmissionMedium = IntendedSubmissionMedium.Electronic,
        };
        var deserializedObject = JsonUtils.Deserialize<ClaimSubmissionRecordCreateOptional>(json);
        Assert.That(deserializedObject, Is.EqualTo(expectedObject).UsingDefaults());
    }

    [global::NUnit.Framework.Test]
    public void TestSerialization_1()
    {
        var inputJson = """
            {
              "submitted_at": "2023-01-01T13:00:00.000000Z",
              "claim_frequency_code": "1",
              "payer_responsibility": "primary",
              "intended_submission_medium": "electronic"
            }
            """;
        JsonAssert.Roundtrips<ClaimSubmissionRecordCreateOptional>(inputJson);
    }

    [global::NUnit.Framework.Test]
    public void TestDeserialization_2()
    {
        var json = """
            {
              "submitted_at": "2023-01-04T12:00:00.000000Z",
              "claim_frequency_code": "7",
              "payer_responsibility": "primary",
              "intended_submission_medium": "paper"
            }
            """;
        var expectedObject = new ClaimSubmissionRecordCreateOptional
        {
            SubmittedAt = DateTime.Parse(
                "2023-01-04T12:00:00.000Z",
                null,
                DateTimeStyles.AdjustToUniversal
            ),
            ClaimFrequencyCode = TypeOfBillFrequencyCode.C7,
            PayerResponsibility = ClaimSubmissionPayerResponsibilityType.Primary,
            IntendedSubmissionMedium = IntendedSubmissionMedium.Paper,
        };
        var deserializedObject = JsonUtils.Deserialize<ClaimSubmissionRecordCreateOptional>(json);
        Assert.That(deserializedObject, Is.EqualTo(expectedObject).UsingDefaults());
    }

    [global::NUnit.Framework.Test]
    public void TestSerialization_2()
    {
        var inputJson = """
            {
              "submitted_at": "2023-01-04T12:00:00.000000Z",
              "claim_frequency_code": "7",
              "payer_responsibility": "primary",
              "intended_submission_medium": "paper"
            }
            """;
        JsonAssert.Roundtrips<ClaimSubmissionRecordCreateOptional>(inputJson);
    }
}
