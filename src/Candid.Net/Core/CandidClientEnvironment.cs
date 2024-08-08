namespace Candid.Net.Core;

public class CandidClientEnvironment
{
    public static CandidClientEnvironment PRODUCTION = new CandidClientEnvironment
    {
        CandidApi = "https://api.joincandidhealth.com",
        PreEncounter = "https://pre-api.joincandidhealth.com"
    };

    public static CandidClientEnvironment STAGING = new CandidClientEnvironment
    {
        CandidApi = "https://api-staging.joincandidhealth.com",
        PreEncounter = "https://pre-api-staging.joincandidhealth.com"
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
