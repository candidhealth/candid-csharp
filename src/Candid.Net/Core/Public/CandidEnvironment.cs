namespace Candid.Net.Core;

[Serializable]
public class CandidEnvironment
{
    public static readonly CandidEnvironment PRODUCTION = new CandidEnvironment
    {
        CandidApi = "https://api.joincandidhealth.com",
        PreEncounter = "https://pre-api.joincandidhealth.com",
    };

    public static readonly CandidEnvironment STAGING = new CandidEnvironment
    {
        CandidApi = "https://api-staging.joincandidhealth.com",
        PreEncounter = "https://pre-api-staging.joincandidhealth.com",
    };

    public static readonly CandidEnvironment CANDID_SANDBOX = new CandidEnvironment
    {
        CandidApi = "https://sandbox-api.joincandidhealth.com",
        PreEncounter = "https://sandbox-pre-api.joincandidhealth.com",
    };

    public static readonly CandidEnvironment CANDID_STAGING = new CandidEnvironment
    {
        CandidApi = "https://staging-api.joincandidhealth.com",
        PreEncounter = "https://staging-pre-api.joincandidhealth.com",
    };

    public static readonly CandidEnvironment LOCAL = new CandidEnvironment
    {
        CandidApi = "http://localhost:5050",
        PreEncounter = "http://localhost:4000",
    };

    /// <summary>
    /// URL for the CandidApi service
    /// </summary>
    public string CandidApi { get;
#if NET5_0_OR_GREATER
        init;
#else
        set;
#endif
    }

    /// <summary>
    /// URL for the PreEncounter service
    /// </summary>
    public string PreEncounter { get;
#if NET5_0_OR_GREATER
        init;
#else
        set;
#endif
    }
}
