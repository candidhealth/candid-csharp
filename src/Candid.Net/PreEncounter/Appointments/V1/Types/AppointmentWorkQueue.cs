using System.Text.Json.Serialization;
using Candid.Net.Core;

namespace Candid.Net.PreEncounter.Appointments.V1;

[JsonConverter(typeof(StringEnumSerializer<AppointmentWorkQueue>))]
[Serializable]
public readonly record struct AppointmentWorkQueue : IStringEnum
{
    public static readonly AppointmentWorkQueue EmergentIssue = new(Values.EmergentIssue);

    public static readonly AppointmentWorkQueue NewPatient = new(Values.NewPatient);

    public static readonly AppointmentWorkQueue ReturningPatient = new(Values.ReturningPatient);

    public static readonly AppointmentWorkQueue ManualEscalation = new(Values.ManualEscalation);

    public AppointmentWorkQueue(string value)
    {
        Value = value;
    }

    /// <summary>
    /// The string value of the enum.
    /// </summary>
    public string Value { get; }

    /// <summary>
    /// Create a string enum with the given value.
    /// </summary>
    public static AppointmentWorkQueue FromCustom(string value)
    {
        return new AppointmentWorkQueue(value);
    }

    public bool Equals(string? other)
    {
        return Value.Equals(other);
    }

    /// <summary>
    /// Returns the string value of the enum.
    /// </summary>
    public override string ToString()
    {
        return Value;
    }

    public static bool operator ==(AppointmentWorkQueue value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(AppointmentWorkQueue value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(AppointmentWorkQueue value) => value.Value;

    public static explicit operator AppointmentWorkQueue(string value) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string EmergentIssue = "EMERGENT_ISSUE";

        public const string NewPatient = "NEW_PATIENT";

        public const string ReturningPatient = "RETURNING_PATIENT";

        public const string ManualEscalation = "MANUAL_ESCALATION";
    }
}
