// ReSharper disable NullableWarningSuppressionIsUsed
// ReSharper disable InconsistentNaming

using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;
using Candid.Net.Core;

namespace Candid.Net.Tasks.V3;

[JsonConverter(typeof(TaskActionExecutionMethod.JsonConverter))]
[Serializable]
public record TaskActionExecutionMethod
{
    internal TaskActionExecutionMethod(string type, object? value)
    {
        Type = type;
        Value = value;
    }

    /// <summary>
    /// Create an instance of TaskActionExecutionMethod with <see cref="TaskActionExecutionMethod.CloseTask"/>.
    /// </summary>
    public TaskActionExecutionMethod(TaskActionExecutionMethod.CloseTask value)
    {
        Type = "close_task";
        Value = value.Value;
    }

    /// <summary>
    /// Discriminant value
    /// </summary>
    [JsonPropertyName("type")]
    public string Type { get; internal set; }

    /// <summary>
    /// Discriminated union value
    /// </summary>
    public object? Value { get; internal set; }

    /// <summary>
    /// Returns true if <see cref="Type"/> is "close_task"
    /// </summary>
    public bool IsCloseTask => Type == "close_task";

    /// <summary>
    /// Returns the value as a <see cref="object"/> if <see cref="Type"/> is 'close_task', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Type"/> is not 'close_task'.</exception>
    public object AsCloseTask() =>
        IsCloseTask
            ? Value!
            : throw new Exception("TaskActionExecutionMethod.Type is not 'close_task'");

    public T Match<T>(Func<object, T> onCloseTask, Func<string, object?, T> onUnknown_)
    {
        return Type switch
        {
            "close_task" => onCloseTask(AsCloseTask()),
            _ => onUnknown_(Type, Value),
        };
    }

    public void Visit(Action<object> onCloseTask, Action<string, object?> onUnknown_)
    {
        switch (Type)
        {
            case "close_task":
                onCloseTask(AsCloseTask());
                break;
            default:
                onUnknown_(Type, Value);
                break;
        }
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="object"/> and returns true if successful.
    /// </summary>
    public bool TryAsCloseTask(out object? value)
    {
        if (Type == "close_task")
        {
            value = Value!;
            return true;
        }
        value = null;
        return false;
    }

    public override string ToString() => JsonUtils.Serialize(this);

    [Serializable]
    internal sealed class JsonConverter : JsonConverter<TaskActionExecutionMethod>
    {
        public override bool CanConvert(global::System.Type typeToConvert) =>
            typeof(TaskActionExecutionMethod).IsAssignableFrom(typeToConvert);

        public override TaskActionExecutionMethod Read(
            ref Utf8JsonReader reader,
            global::System.Type typeToConvert,
            JsonSerializerOptions options
        )
        {
            var json = JsonElement.ParseValue(ref reader);
            if (!json.TryGetProperty("type", out var discriminatorElement))
            {
                throw new JsonException("Missing discriminator property 'type'");
            }
            if (discriminatorElement.ValueKind != JsonValueKind.String)
            {
                if (discriminatorElement.ValueKind == JsonValueKind.Null)
                {
                    throw new JsonException("Discriminator property 'type' is null");
                }

                throw new JsonException(
                    $"Discriminator property 'type' is not a string, instead is {discriminatorElement.ToString()}"
                );
            }

            var discriminator =
                discriminatorElement.GetString()
                ?? throw new JsonException("Discriminator property 'type' is null");

            var value = discriminator switch
            {
                "close_task" => new { },
                _ => json.Deserialize<object?>(options),
            };
            return new TaskActionExecutionMethod(discriminator, value);
        }

        public override void Write(
            Utf8JsonWriter writer,
            TaskActionExecutionMethod value,
            JsonSerializerOptions options
        )
        {
            JsonNode json =
                value.Type switch
                {
                    "close_task" => null,
                    _ => JsonSerializer.SerializeToNode(value.Value, options),
                } ?? new JsonObject();
            json["type"] = value.Type;
            json.WriteTo(writer, options);
        }
    }

    /// <summary>
    /// Discriminated union type for close_task
    /// </summary>
    [Serializable]
    public record CloseTask
    {
        internal object Value => new { };

        public override string ToString() => Value.ToString();
    }
}
