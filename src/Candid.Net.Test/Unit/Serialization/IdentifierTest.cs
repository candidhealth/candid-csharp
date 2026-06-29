using global::Candid.Net.Commons;
using global::Candid.Net.Core;
using global::Candid.Net.Identifiers;
using global::Candid.Net.Test.Utils;
using NUnit.Framework;

namespace Candid.Net.Test;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class IdentifierTest
{
    [global::NUnit.Framework.Test]
    public void TestDeserialization()
    {
        var json = """
            {
              "identifier_id": "123e4567-e89b-12d3-a456-426614174000",
              "identifier_code": "MCR",
              "identifier_value": {
                "type": "medicare_provider_identifier",
                "state": "CA",
                "provider_number": "1234567890"
              }
            }
            """;
        var expectedObject = new Identifier
        {
            IdentifierId = "123e4567-e89b-12d3-a456-426614174000",
            IdentifierCode = IdentifierCode.Mcr,
            IdentifierValue = new IdentifierValue(
                new IdentifierValue.MedicareProviderIdentifier(
                    new MedicareProviderIdentifier
                    {
                        State = State.Ca,
                        ProviderNumber = "1234567890",
                    }
                )
            ),
        };
        var deserializedObject = JsonUtils.Deserialize<Identifier>(json);
        Assert.That(deserializedObject, Is.EqualTo(expectedObject).UsingDefaults());
    }

    [global::NUnit.Framework.Test]
    public void TestSerialization()
    {
        var inputJson = """
            {
              "identifier_id": "123e4567-e89b-12d3-a456-426614174000",
              "identifier_code": "MCR",
              "identifier_value": {
                "type": "medicare_provider_identifier",
                "state": "CA",
                "provider_number": "1234567890"
              }
            }
            """;
        JsonAssert.Roundtrips<Identifier>(inputJson);
    }
}
