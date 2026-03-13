using System.Globalization;
using System.Text.Json;
using Candid.Net.Core;
using Candid.Net.Encounters.V4;
using NUnit.Framework;

namespace Candid.Net.Test;

[TestFixture]
public class ClinicalNoteCategoryTest
{
    [global::NUnit.Framework.Test]
    public void TestDeserialization()
    {
        var json = """
            {
              "category": "clinical",
              "notes": [
                "Patient complained of mild chest pain."
              ],
              "notes_structured": [
                {
                  "text": "Mild chest pain since morning.",
                  "author_name": "John Doe",
                  "author_npi": "1234567890",
                  "timestamp": "2023-01-01T00:00:00Z"
                }
              ]
            }
            """;
        var expectedObject = new ClinicalNoteCategory
        {
            Category = NoteCategory.Clinical,
            Notes = new List<string>() { "Patient complained of mild chest pain." },
            NotesStructured = new List<ClinicalNote>()
            {
                new ClinicalNote
                {
                    Text = "Mild chest pain since morning.",
                    AuthorName = "John Doe",
                    AuthorNpi = "1234567890",
                    Timestamp = DateTime.Parse(
                        "2023-01-01T00:00:00.000Z",
                        null,
                        DateTimeStyles.AdjustToUniversal
                    ),
                },
            },
        };
        var deserializedObject = JsonUtils.Deserialize<ClinicalNoteCategory>(json);
        Assert.That(deserializedObject, Is.EqualTo(expectedObject).UsingDefaults());
    }

    [global::NUnit.Framework.Test]
    public void TestSerialization()
    {
        var expectedJson = """
            {
              "category": "clinical",
              "notes": [
                "Patient complained of mild chest pain."
              ],
              "notes_structured": [
                {
                  "text": "Mild chest pain since morning.",
                  "author_name": "John Doe",
                  "author_npi": "1234567890",
                  "timestamp": "2023-01-01T00:00:00Z"
                }
              ]
            }
            """;
        var actualObj = new ClinicalNoteCategory
        {
            Category = NoteCategory.Clinical,
            Notes = new List<string>() { "Patient complained of mild chest pain." },
            NotesStructured = new List<ClinicalNote>()
            {
                new ClinicalNote
                {
                    Text = "Mild chest pain since morning.",
                    AuthorName = "John Doe",
                    AuthorNpi = "1234567890",
                    Timestamp = DateTime.Parse(
                        "2023-01-01T00:00:00.000Z",
                        null,
                        DateTimeStyles.AdjustToUniversal
                    ),
                },
            },
        };
        var actualElement = JsonUtils.SerializeToElement(actualObj);
        var expectedElement = JsonUtils.Deserialize<JsonElement>(expectedJson);
        Assert.That(actualElement, Is.EqualTo(expectedElement).UsingJsonElementComparer());
    }
}
