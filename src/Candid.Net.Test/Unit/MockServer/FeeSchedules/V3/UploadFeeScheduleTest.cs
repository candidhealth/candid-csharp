using global::Candid.Net.Commons;
using global::Candid.Net.FeeSchedules.V3;
using global::Candid.Net.OrganizationProviders.V2;
using global::Candid.Net.Test.Unit.MockServer;
using global::Candid.Net.Test.Utils;
using NUnit.Framework;

namespace Candid.Net.Test.Unit.MockServer.FeeSchedules.V3;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class UploadFeeScheduleTest : BaseMockServerTest
{
    [global::NUnit.Framework.Test]
    public async global::System.Threading.Tasks.Task MockServerTest()
    {
        const string requestJson = """
            {
              "dry_run": true,
              "rates": [
                {
                  "type": "new_rate",
                  "dimensions": {
                    "payer_uuid": "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
                    "organization_billing_provider_id": "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
                    "states": [
                      "AA"
                    ],
                    "zip_codes": [
                      "zip_codes"
                    ],
                    "license_types": [
                      "MD"
                    ],
                    "facility_type_codes": [
                      "01"
                    ],
                    "network_types": [
                      "12"
                    ],
                    "payer_plan_group_ids": [
                      "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32"
                    ],
                    "cpt_code": "cpt_code",
                    "modifiers": [
                      "AV"
                    ]
                  },
                  "entries": [
                    {
                      "start_date": "2023-01-15",
                      "rate_cents": 1,
                      "is_deactivated": true
                    },
                    {
                      "start_date": "2023-01-15",
                      "rate_cents": 1,
                      "is_deactivated": true
                    }
                  ]
                },
                {
                  "type": "new_rate",
                  "dimensions": {
                    "payer_uuid": "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
                    "organization_billing_provider_id": "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
                    "states": [
                      "AA"
                    ],
                    "zip_codes": [
                      "zip_codes"
                    ],
                    "license_types": [
                      "MD"
                    ],
                    "facility_type_codes": [
                      "01"
                    ],
                    "network_types": [
                      "12"
                    ],
                    "payer_plan_group_ids": [
                      "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32"
                    ],
                    "cpt_code": "cpt_code",
                    "modifiers": [
                      "AV"
                    ]
                  },
                  "entries": [
                    {
                      "start_date": "2023-01-15",
                      "rate_cents": 1,
                      "is_deactivated": true
                    },
                    {
                      "start_date": "2023-01-15",
                      "rate_cents": 1,
                      "is_deactivated": true
                    }
                  ]
                }
              ]
            }
            """;

        const string mockResponse = """
            [
              {
                "rate_id": "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
                "dimensions": {
                  "payer_uuid": "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
                  "organization_billing_provider_id": "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
                  "states": [
                    "AA"
                  ],
                  "zip_codes": [
                    "zip_codes"
                  ],
                  "license_types": [
                    "MD"
                  ],
                  "facility_type_codes": [
                    "01"
                  ],
                  "network_types": [
                    "12"
                  ],
                  "payer_plan_group_ids": [
                    "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32"
                  ],
                  "cpt_code": "cpt_code",
                  "modifiers": [
                    "AV"
                  ]
                },
                "version": 1,
                "updated_at": "2023-01-15",
                "updated_by": "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
                "entries": [
                  {
                    "start_date": "2023-01-15",
                    "end_date": "2023-01-15",
                    "rate_cents": 1,
                    "is_deactivated": true
                  },
                  {
                    "start_date": "2023-01-15",
                    "end_date": "2023-01-15",
                    "rate_cents": 1,
                    "is_deactivated": true
                  }
                ]
              },
              {
                "rate_id": "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
                "dimensions": {
                  "payer_uuid": "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
                  "organization_billing_provider_id": "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
                  "states": [
                    "AA"
                  ],
                  "zip_codes": [
                    "zip_codes"
                  ],
                  "license_types": [
                    "MD"
                  ],
                  "facility_type_codes": [
                    "01"
                  ],
                  "network_types": [
                    "12"
                  ],
                  "payer_plan_group_ids": [
                    "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32"
                  ],
                  "cpt_code": "cpt_code",
                  "modifiers": [
                    "AV"
                  ]
                },
                "version": 1,
                "updated_at": "2023-01-15",
                "updated_by": "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
                "entries": [
                  {
                    "start_date": "2023-01-15",
                    "end_date": "2023-01-15",
                    "rate_cents": 1,
                    "is_deactivated": true
                  },
                  {
                    "start_date": "2023-01-15",
                    "end_date": "2023-01-15",
                    "rate_cents": 1,
                    "is_deactivated": true
                  }
                ]
              }
            ]
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/api/fee-schedules/v3")
                    .UsingPost()
                    .WithBodyAsJson(requestJson)
            )
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.FeeSchedules.V3.UploadFeeScheduleAsync(
            new FeeScheduleUploadRequest
            {
                DryRun = true,
                Rates = new List<RateUpload>()
                {
                    new RateUpload(
                        new RateUpload.NewRate(
                            new NewRate
                            {
                                Dimensions = new Dimensions
                                {
                                    PayerUuid = "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
                                    OrganizationBillingProviderId =
                                        "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
                                    States = new HashSet<State>() { State.Aa },
                                    ZipCodes = new HashSet<string>() { "zip_codes" },
                                    LicenseTypes = new HashSet<LicenseType>() { LicenseType.Md },
                                    FacilityTypeCodes = new HashSet<FacilityTypeCode>()
                                    {
                                        FacilityTypeCode.Pharmacy,
                                    },
                                    NetworkTypes =
                                        new HashSet<global::Candid.Net.Commons.NetworkType>()
                                        {
                                            global::Candid.Net.Commons.NetworkType.Ppo,
                                        },
                                    PayerPlanGroupIds = new HashSet<string>()
                                    {
                                        "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
                                    },
                                    CptCode = "cpt_code",
                                    Modifiers = new HashSet<ProcedureModifier>()
                                    {
                                        ProcedureModifier.Av,
                                    },
                                },
                                Entries = new List<RateEntry>()
                                {
                                    new RateEntry
                                    {
                                        StartDate = new DateOnly(2023, 1, 15),
                                        RateCents = 1,
                                        IsDeactivated = true,
                                    },
                                    new RateEntry
                                    {
                                        StartDate = new DateOnly(2023, 1, 15),
                                        RateCents = 1,
                                        IsDeactivated = true,
                                    },
                                },
                            }
                        )
                    ),
                    new RateUpload(
                        new RateUpload.NewRate(
                            new NewRate
                            {
                                Dimensions = new Dimensions
                                {
                                    PayerUuid = "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
                                    OrganizationBillingProviderId =
                                        "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
                                    States = new HashSet<State>() { State.Aa },
                                    ZipCodes = new HashSet<string>() { "zip_codes" },
                                    LicenseTypes = new HashSet<LicenseType>() { LicenseType.Md },
                                    FacilityTypeCodes = new HashSet<FacilityTypeCode>()
                                    {
                                        FacilityTypeCode.Pharmacy,
                                    },
                                    NetworkTypes =
                                        new HashSet<global::Candid.Net.Commons.NetworkType>()
                                        {
                                            global::Candid.Net.Commons.NetworkType.Ppo,
                                        },
                                    PayerPlanGroupIds = new HashSet<string>()
                                    {
                                        "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
                                    },
                                    CptCode = "cpt_code",
                                    Modifiers = new HashSet<ProcedureModifier>()
                                    {
                                        ProcedureModifier.Av,
                                    },
                                },
                                Entries = new List<RateEntry>()
                                {
                                    new RateEntry
                                    {
                                        StartDate = new DateOnly(2023, 1, 15),
                                        RateCents = 1,
                                        IsDeactivated = true,
                                    },
                                    new RateEntry
                                    {
                                        StartDate = new DateOnly(2023, 1, 15),
                                        RateCents = 1,
                                        IsDeactivated = true,
                                    },
                                },
                            }
                        )
                    ),
                },
            }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
