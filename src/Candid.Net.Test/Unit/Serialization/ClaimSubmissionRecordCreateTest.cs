using System.Text.Json;
using System.Text.Json.Serialization;
using Candid.Net.ClaimSubmission.V1;
using FluentAssertions.Json;
using Newtonsoft.Json.Linq;
using NUnit.Framework;

#nullable enable

namespace Candid.Net.Test;

[TestFixture]
public class ClaimSubmissionRecordCreateTest
{
    [Test]
    public void TestSerialization_1()
    {
        var inputJson =
            @"
        {
  ""submitted_at"": ""2023-01-01T13:00:00.000000Z"",
  ""claim_frequency_code"": ""1"",
  ""payer_responsibility"": ""primary"",
  ""intended_submission_medium"": ""electronic""
}
";

        var serializerOptions = new JsonSerializerOptions
        {
            DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull
        };

        var deserializedObject = JsonSerializer.Deserialize<ClaimSubmissionRecordCreate>(
            inputJson,
            serializerOptions
        );

        var serializedJson = JsonSerializer.Serialize(deserializedObject, serializerOptions);

        JToken.Parse(inputJson).Should().BeEquivalentTo(JToken.Parse(serializedJson));
    }

    [Test]
    public void TestSerialization_2()
    {
        var inputJson =
            @"
        {
  ""submitted_at"": ""2023-01-04T12:00:00.000000Z"",
  ""claim_frequency_code"": ""7"",
  ""payer_responsibility"": ""primary"",
  ""intended_submission_medium"": ""paper""
}
";

        var serializerOptions = new JsonSerializerOptions
        {
            DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull
        };

        var deserializedObject = JsonSerializer.Deserialize<ClaimSubmissionRecordCreate>(
            inputJson,
            serializerOptions
        );

        var serializedJson = JsonSerializer.Serialize(deserializedObject, serializerOptions);

        JToken.Parse(inputJson).Should().BeEquivalentTo(JToken.Parse(serializedJson));
    }
}
