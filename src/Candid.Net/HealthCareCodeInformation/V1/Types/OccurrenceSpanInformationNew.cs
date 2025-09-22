using System.Text.Json.Serialization;
using Candid.Net.Core;

#nullable enable

namespace Candid.Net.HealthCareCodeInformation.V1;

public record OccurrenceSpanInformationNew
{
    [JsonPropertyName("occurrence_span_code_qualifier")]
    public required OccurrenceSpanCodeQualifier OccurrenceSpanCodeQualifier { get; set; }

    [JsonPropertyName("occurrence_span_code")]
    public required OccurrenceSpanCode OccurrenceSpanCode { get; set; }

    [JsonPropertyName("occurrence_span_date")]
    public required Rd8Date OccurrenceSpanDate { get; set; }

    [JsonPropertyName("code_list_qualifier")]
    public CodeListQualifierCode? CodeListQualifier { get; set; }

    /// <summary>
    /// A code string whose interpretation depends on the code_list_qualifier being set.
    /// You do not need to set this field generally, instead it is provided as advisory
    /// context on how this HealthCareCodeInformation's data will be available in reporting.
    /// </summary>
    [JsonPropertyName("industry_code_1")]
    public string? IndustryCode1 { get; set; }

    /// <summary>
    /// A code string whose interpretation depends on the code_list_qualifier being set.
    /// You do not need to set this field generally, instead it is provided as advisory
    /// context on how this HealthCareCodeInformation's data will be available in reporting.
    /// </summary>
    [JsonPropertyName("industry_code_2")]
    public string? IndustryCode2 { get; set; }

    /// <summary>
    /// A code string whose interpretation depends on the code_list_qualifier being set.
    /// You do not need to set this field generally, instead it is provided as advisory
    /// context on how this HealthCareCodeInformation's data will be available in reporting.
    /// </summary>
    [JsonPropertyName("industry_code_3")]
    public string? IndustryCode3 { get; set; }

    /// <summary>
    /// A code string whose interpretation depends on the code_list_qualifier being set.
    /// You do not need to set this field generally, instead it is provided as advisory
    /// context on how this HealthCareCodeInformation's data will be available in reporting.
    /// </summary>
    [JsonPropertyName("industry_code_4")]
    public string? IndustryCode4 { get; set; }

    /// <summary>
    /// Controls how the date_time_period field is interpreted and is submitted
    /// as part of claim process.
    /// You do not need to set this field generally, instead it is provided as advisory
    /// context on how this HealthCareCodeInformation's data will be available in reporting.
    /// </summary>
    [JsonPropertyName("date_time_period_format_qualifier")]
    public DateTimePeriodFormatQualifier? DateTimePeriodFormatQualifier { get; set; }

    /// <summary>
    /// A string, formatted according to date_time_period_format_qualifier, which
    /// ultimately represents the date time period in which an information object
    /// is covering.
    /// You do not need to set this field generally, instead it is provided as advisory
    /// context on how this HealthCareCodeInformation's data will be available in reporting.
    /// </summary>
    [JsonPropertyName("date_time_period")]
    public string? DateTimePeriod { get; set; }

    /// <summary>
    /// A decimal used to represent ValueInformation results.
    /// You do not need to set this field generally, instead it is provided as advisory
    /// context on how this HealthCareCodeInformation's data will be available in reporting.
    /// </summary>
    [JsonPropertyName("monetary_amount")]
    public string? MonetaryAmount { get; set; }

    /// <summary>
    /// You do not need to set this field generally, instead it is provided as advisory
    /// context on how this HealthCareCodeInformation's data will be available in reporting.
    /// </summary>
    [JsonPropertyName("quantity")]
    public string? Quantity { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
