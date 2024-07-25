using System.Text.Json;
using System.Text.Json.Serialization;
using Candid.Net.ClaimSubmission.V1;
using Newtonsoft.Json.Linq;
using NUnit.Framework;

#nullable enable

namespace Candid.Net.Test;

[TestFixture]
public class ExternalClaimSubmissionCreateTest
{
    [Test]
    public void TestSerialization_1()
    {
        var inputJson =
            @"
        {
  ""claim_created_at"": ""2023-01-01T12:00:00.000000Z"",
  ""patient_control_number"": ""PATIENT_CONTROL_NUMBER"",
  ""submission_records"": [
    {
      ""submitted_at"": ""2023-01-01T13:00:00.000000Z"",
      ""claim_frequency_code"": ""1"",
      ""payer_responsibility"": ""primary"",
      ""intended_submission_medium"": ""electronic""
    },
    {
      ""submitted_at"": ""2023-01-04T12:00:00.000000Z"",
      ""claim_frequency_code"": ""7"",
      ""payer_responsibility"": ""primary"",
      ""intended_submission_medium"": ""paper""
    }
  ]
}
";

        var serializerOptions = new JsonSerializerOptions
        {
            DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull
        };

        var deserializedObject = JsonSerializer.Deserialize<ExternalClaimSubmissionCreate>(
            inputJson,
            serializerOptions
        );

        var serializedJson = JsonSerializer.Serialize(deserializedObject, serializerOptions);

        Assert.That(JToken.DeepEquals(JToken.Parse(inputJson), JToken.Parse(serializedJson)));
    }

    [Test]
    public void TestSerialization_2()
    {
        var inputJson =
            @"
        {
  ""claim_created_at"": ""2023-01-01T12:00:00.000000Z"",
  ""patient_control_number"": ""123XYZABC"",
  ""submission_records"": []
}
";

        var serializerOptions = new JsonSerializerOptions
        {
            DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull
        };

        var deserializedObject = JsonSerializer.Deserialize<ExternalClaimSubmissionCreate>(
            inputJson,
            serializerOptions
        );

        var serializedJson = JsonSerializer.Serialize(deserializedObject, serializerOptions);

        Assert.That(JToken.DeepEquals(JToken.Parse(inputJson), JToken.Parse(serializedJson)));
    }
}
