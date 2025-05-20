namespace Candid.Net.Core;

public class CandidEnvironment
{
    public static CandidEnvironment PRODUCTION = new CandidEnvironment
    {
        CandidApi = "https://api.joincandidhealth.com",
        PreEncounter = "https://pre-api.joincandidhealth.com",
    };

    public static CandidEnvironment STAGING = new CandidEnvironment
    {
        CandidApi = "https://api-staging.joincandidhealth.com",
        PreEncounter = "https://pre-api-staging.joincandidhealth.com",
    };

    public static CandidEnvironment CANDID_STAGING = new CandidEnvironment
    {
        CandidApi = "https://staging-api.joincandidhealth.com",
        PreEncounter = "https://staging-pre-api.joincandidhealth.com",
    };

    /// <summary>
    /// URL for the CandidApi service
    /// </summary>
    public string CandidApi { get; init; }

    /// <summary>
    /// URL for the PreEncounter service
    /// </summary>
    public string PreEncounter { get; init; }
}
