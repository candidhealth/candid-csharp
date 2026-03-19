using System.Globalization;
using global::Candid.Net.PreEncounter.Appointments.V1;
using global::Candid.Net.Test.Unit.MockServer;
using global::Candid.Net.Test.Utils;
using NUnit.Framework;

namespace Candid.Net.Test.Unit.MockServer.PreEncounter.Appointments.V1;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class ScanTest : BaseMockServerTest
{
    [global::NUnit.Framework.Test]
    public async global::System.Threading.Tasks.Task MockServerTest()
    {
        const string mockResponse = """
            [
              {
                "id": "id",
                "organization_id": "organization_id",
                "deactivated": true,
                "version": 1,
                "updated_at": "2024-01-15T09:30:00.000Z",
                "updating_user_id": "updating_user_id",
                "patient_id": "patient_id",
                "start_timestamp": "2024-01-15T09:30:00.000Z",
                "status": "PENDING",
                "service_duration": 1,
                "services": [
                  {
                    "universal_service_identifier": "MD_Visit",
                    "start_timestamp": "2024-01-15T09:30:00.000Z"
                  },
                  {
                    "universal_service_identifier": "MD_Visit",
                    "start_timestamp": "2024-01-15T09:30:00.000Z"
                  }
                ],
                "placer_appointment_id": "placer_appointment_id",
                "attending_doctor": {
                  "name": {
                    "family": "family",
                    "given": [
                      "given",
                      "given"
                    ],
                    "use": "USUAL",
                    "period": {
                      "start": "2023-01-15",
                      "end": "2023-01-15"
                    },
                    "suffix": "suffix"
                  },
                  "type": "PRIMARY",
                  "npi": "npi",
                  "telecoms": [
                    {
                      "value": "value",
                      "use": "HOME",
                      "period": {
                        "start": "2023-01-15",
                        "end": "2023-01-15"
                      }
                    },
                    {
                      "value": "value",
                      "use": "HOME",
                      "period": {
                        "start": "2023-01-15",
                        "end": "2023-01-15"
                      }
                    }
                  ],
                  "addresses": [
                    {
                      "use": "HOME",
                      "line": [
                        "line",
                        "line"
                      ],
                      "city": "city",
                      "state": "state",
                      "postal_code": "postal_code",
                      "country": "country",
                      "period": {
                        "start": "2023-01-15",
                        "end": "2023-01-15"
                      }
                    },
                    {
                      "use": "HOME",
                      "line": [
                        "line",
                        "line"
                      ],
                      "city": "city",
                      "state": "state",
                      "postal_code": "postal_code",
                      "country": "country",
                      "period": {
                        "start": "2023-01-15",
                        "end": "2023-01-15"
                      }
                    }
                  ],
                  "period": {
                    "start": "2023-01-15",
                    "end": "2023-01-15"
                  },
                  "canonical_id": "canonical_id",
                  "fax": "fax",
                  "service_facilities": [
                    {
                      "service_facility_id": "service_facility_id"
                    },
                    {
                      "service_facility_id": "service_facility_id"
                    }
                  ]
                },
                "estimated_copay_cents": 1,
                "estimated_patient_responsibility_cents": 1,
                "patient_deposit_cents": 1,
                "appointment_details": "appointment_details",
                "checked_in_timestamp": "2024-01-15T09:30:00.000Z",
                "notes": "notes",
                "location_resource_id": "location_resource_id",
                "automated_eligibility_check_complete": true,
                "work_queue": "EMERGENT_ISSUE"
              },
              {
                "id": "id",
                "organization_id": "organization_id",
                "deactivated": true,
                "version": 1,
                "updated_at": "2024-01-15T09:30:00.000Z",
                "updating_user_id": "updating_user_id",
                "patient_id": "patient_id",
                "start_timestamp": "2024-01-15T09:30:00.000Z",
                "status": "PENDING",
                "service_duration": 1,
                "services": [
                  {
                    "universal_service_identifier": "MD_Visit",
                    "start_timestamp": "2024-01-15T09:30:00.000Z"
                  },
                  {
                    "universal_service_identifier": "MD_Visit",
                    "start_timestamp": "2024-01-15T09:30:00.000Z"
                  }
                ],
                "placer_appointment_id": "placer_appointment_id",
                "attending_doctor": {
                  "name": {
                    "family": "family",
                    "given": [
                      "given",
                      "given"
                    ],
                    "use": "USUAL",
                    "period": {
                      "start": "2023-01-15",
                      "end": "2023-01-15"
                    },
                    "suffix": "suffix"
                  },
                  "type": "PRIMARY",
                  "npi": "npi",
                  "telecoms": [
                    {
                      "value": "value",
                      "use": "HOME",
                      "period": {
                        "start": "2023-01-15",
                        "end": "2023-01-15"
                      }
                    },
                    {
                      "value": "value",
                      "use": "HOME",
                      "period": {
                        "start": "2023-01-15",
                        "end": "2023-01-15"
                      }
                    }
                  ],
                  "addresses": [
                    {
                      "use": "HOME",
                      "line": [
                        "line",
                        "line"
                      ],
                      "city": "city",
                      "state": "state",
                      "postal_code": "postal_code",
                      "country": "country",
                      "period": {
                        "start": "2023-01-15",
                        "end": "2023-01-15"
                      }
                    },
                    {
                      "use": "HOME",
                      "line": [
                        "line",
                        "line"
                      ],
                      "city": "city",
                      "state": "state",
                      "postal_code": "postal_code",
                      "country": "country",
                      "period": {
                        "start": "2023-01-15",
                        "end": "2023-01-15"
                      }
                    }
                  ],
                  "period": {
                    "start": "2023-01-15",
                    "end": "2023-01-15"
                  },
                  "canonical_id": "canonical_id",
                  "fax": "fax",
                  "service_facilities": [
                    {
                      "service_facility_id": "service_facility_id"
                    },
                    {
                      "service_facility_id": "service_facility_id"
                    }
                  ]
                },
                "estimated_copay_cents": 1,
                "estimated_patient_responsibility_cents": 1,
                "patient_deposit_cents": 1,
                "appointment_details": "appointment_details",
                "checked_in_timestamp": "2024-01-15T09:30:00.000Z",
                "notes": "notes",
                "location_resource_id": "location_resource_id",
                "automated_eligibility_check_complete": true,
                "work_queue": "EMERGENT_ISSUE"
              }
            ]
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/appointments/v1/updates/scan")
                    .WithParam("since", "2024-01-15T09:30:00.000Z")
                    .UsingGet()
            )
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.PreEncounter.Appointments.V1.ScanAsync(
            new AppointmentScanRequest
            {
                Since = DateTime.Parse(
                    "2024-01-15T09:30:00.000Z",
                    null,
                    DateTimeStyles.AdjustToUniversal
                ),
            }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
