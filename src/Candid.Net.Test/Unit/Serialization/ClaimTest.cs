using System.Globalization;
using global::Candid.Net.Claims;
using global::Candid.Net.Commons;
using global::Candid.Net.Core;
using global::Candid.Net.Eras;
using global::Candid.Net.Invoices;
using global::Candid.Net.ServiceLines.V2;
using global::Candid.Net.Test.Utils;
using NUnit.Framework;

namespace Candid.Net.Test;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class ClaimTest
{
    [global::NUnit.Framework.Test]
    public void TestDeserialization()
    {
        var json = """
            {
              "claim_id": "DD9D7F82-37B5-449D-AA63-26925398335B",
              "status": "biller_received",
              "clearinghouse": "Change Healthcare",
              "clearinghouse_claim_id": "5BA7C3AB-2BC2-496C-8B10-6CAC73D0729D",
              "payer_claim_id": "9BB9F259-9756-4F16-8F53-9DBB9F7EB1BB",
              "service_lines": [
                {
                  "created_at": "2023-01-01T00:00:00Z",
                  "modifiers": [
                    "22"
                  ],
                  "charge_amount_cents": 10000,
                  "allowed_amount_cents": 8000,
                  "insurance_balance_cents": 0,
                  "patient_balance_cents": 2000,
                  "paid_amount_cents": 8000,
                  "patient_responsibility_cents": 2000,
                  "diagnosis_id_zero": "4AC84BCD-12F5-4F86-A57B-E06749127C98",
                  "diagnosis_id_one": "EEA5CA5A-8B43-45FD-8CBD-C6CC1103E759",
                  "diagnosis_id_two": "5C4AA029-2DB9-4202-916E-E93C708F65FF",
                  "diagnosis_id_three": "81795126-A3AC-443C-B47E-7259A16AB4A2",
                  "service_line_era_data": {
                    "service_line_adjustments": [
                      {
                        "created_at": "2023-01-01T00:00:00Z",
                        "adjustment_group_code": "CO",
                        "adjustment_reason_code": "CO",
                        "adjustment_amount_cents": 1000,
                        "adjustment_note": "test_note"
                      }
                    ],
                    "remittance_advice_remark_codes": [
                      "N362"
                    ]
                  },
                  "service_line_manual_adjustments": [
                    {
                      "created_at": "2023-01-01T00:00:00Z",
                      "adjustment_group_code": "CO",
                      "adjustment_reason_code": "CO",
                      "adjustment_amount_cents": 1000,
                      "adjustment_note": "test_note"
                    }
                  ],
                  "related_invoices": [
                    {
                      "id": "901BE2F1-41BC-456E-9987-4FE2F84F9D75",
                      "created_at": "2023-01-01T00:00:00Z",
                      "updated_at": "2023-01-01T00:00:00Z",
                      "organzation_id": "F13F73D4-4344-46EA-9D93-33BCFFBB9F36",
                      "source_id": "9B626577-8808-4F28-9ED1-F0DFF0D49BBC",
                      "source_customer_id": "624D1972-8C69-4C2F-AEFA-10856F734DB3",
                      "patient_external_id": "10FED4D6-4C5A-48DF-838A-EEF45A74788D",
                      "note": "test_note",
                      "due_date": "2023-10-10",
                      "status": "draft",
                      "url": "https://example.com",
                      "customer_invoice_url": "https://example.com",
                      "items": [
                        {
                          "service_line_id": "CED00F23-6E68-4678-9DBC-F5AA2969A565",
                          "amount_cents": 500
                        }
                      ]
                    }
                  ],
                  "denial_reason": {
                    "reason": "Authorization Required"
                  },
                  "place_of_service_code": "01",
                  "service_line_id": "CED00F23-6E68-4678-9DBC-F5AA2969A565",
                  "procedure_code": "99213",
                  "quantity": "1",
                  "units": "MJ",
                  "claim_id": "026A1FB8-748E-4859-A2D7-3EA9E07D25AE",
                  "date_of_service_range": {
                    "start_date": "2023-01-01",
                    "end_date": "2023-01-03"
                  },
                  "date_of_service": "2023-01-01",
                  "end_date_of_service": "2023-01-03",
                  "test_results": [
                    {
                      "result_type": "HEMOGLOBIN",
                      "value": 51
                    },
                    {
                      "result_type": "LDL",
                      "value": 110
                    }
                  ]
                }
              ],
              "eras": [
                {
                  "era_id": "4D844EF1-2253-43CD-A4F1-6DB7E65CB54B",
                  "check_number": "CHK12345",
                  "check_date": "2023-10-12"
                }
              ]
            }
            """;
        var expectedObject = new Claim
        {
            ClaimId = "DD9D7F82-37B5-449D-AA63-26925398335B",
            Status = ClaimStatus.BillerReceived,
            Clearinghouse = "Change Healthcare",
            ClearinghouseClaimId = "5BA7C3AB-2BC2-496C-8B10-6CAC73D0729D",
            PayerClaimId = "9BB9F259-9756-4F16-8F53-9DBB9F7EB1BB",
            ServiceLines = new List<ServiceLine>()
            {
                new ServiceLine
                {
                    CreatedAt = DateTime.Parse(
                        "2023-01-01T00:00:00.000Z",
                        null,
                        DateTimeStyles.AdjustToUniversal
                    ),
                    Modifiers = new List<ProcedureModifier>() { ProcedureModifier.TwentyTwo },
                    ChargeAmountCents = 10000,
                    AllowedAmountCents = 8000,
                    InsuranceBalanceCents = 0,
                    PatientBalanceCents = 2000,
                    PaidAmountCents = 8000,
                    PatientResponsibilityCents = 2000,
                    DiagnosisIdZero = "4AC84BCD-12F5-4F86-A57B-E06749127C98",
                    DiagnosisIdOne = "EEA5CA5A-8B43-45FD-8CBD-C6CC1103E759",
                    DiagnosisIdTwo = "5C4AA029-2DB9-4202-916E-E93C708F65FF",
                    DiagnosisIdThree = "81795126-A3AC-443C-B47E-7259A16AB4A2",
                    ServiceLineEraData = new ServiceLineEraData
                    {
                        ServiceLineAdjustments = new List<ServiceLineAdjustment>()
                        {
                            new ServiceLineAdjustment
                            {
                                CreatedAt = DateTime.Parse(
                                    "2023-01-01T00:00:00.000Z",
                                    null,
                                    DateTimeStyles.AdjustToUniversal
                                ),
                                AdjustmentGroupCode = "CO",
                                AdjustmentReasonCode = "CO",
                                AdjustmentAmountCents = 1000,
                                AdjustmentNote = "test_note",
                            },
                        },
                        RemittanceAdviceRemarkCodes = new List<string>() { "N362" },
                    },
                    ServiceLineManualAdjustments = new List<ServiceLineAdjustment>()
                    {
                        new ServiceLineAdjustment
                        {
                            CreatedAt = DateTime.Parse(
                                "2023-01-01T00:00:00.000Z",
                                null,
                                DateTimeStyles.AdjustToUniversal
                            ),
                            AdjustmentGroupCode = "CO",
                            AdjustmentReasonCode = "CO",
                            AdjustmentAmountCents = 1000,
                            AdjustmentNote = "test_note",
                        },
                    },
                    RelatedInvoices = new List<global::Candid.Net.Invoices.Invoice>()
                    {
                        new global::Candid.Net.Invoices.Invoice
                        {
                            Id = "901BE2F1-41BC-456E-9987-4FE2F84F9D75",
                            CreatedAt = DateTime.Parse(
                                "2023-01-01T00:00:00.000Z",
                                null,
                                DateTimeStyles.AdjustToUniversal
                            ),
                            UpdatedAt = DateTime.Parse(
                                "2023-01-01T00:00:00.000Z",
                                null,
                                DateTimeStyles.AdjustToUniversal
                            ),
                            OrganzationId = "F13F73D4-4344-46EA-9D93-33BCFFBB9F36",
                            SourceId = "9B626577-8808-4F28-9ED1-F0DFF0D49BBC",
                            SourceCustomerId = "624D1972-8C69-4C2F-AEFA-10856F734DB3",
                            PatientExternalId = "10FED4D6-4C5A-48DF-838A-EEF45A74788D",
                            Note = "test_note",
                            DueDate = "2023-10-10",
                            Status = global::Candid.Net.Invoices.InvoiceStatus.Draft,
                            Url = "https://example.com",
                            CustomerInvoiceUrl = "https://example.com",
                            Items = new List<InvoiceItem>()
                            {
                                new InvoiceItem
                                {
                                    ServiceLineId = "CED00F23-6E68-4678-9DBC-F5AA2969A565",
                                    AmountCents = 500,
                                },
                            },
                        },
                    },
                    DenialReason = new ServiceLineDenialReason
                    {
                        Reason = DenialReasonContent.AuthorizationRequired,
                    },
                    PlaceOfServiceCode = FacilityTypeCode.Pharmacy,
                    ServiceLineId = "CED00F23-6E68-4678-9DBC-F5AA2969A565",
                    ProcedureCode = "99213",
                    Quantity = "1",
                    Units = ServiceLineUnits.Mj,
                    ClaimId = "026A1FB8-748E-4859-A2D7-3EA9E07D25AE",
                    DateOfServiceRange = new DateRangeOptionalEnd
                    {
                        StartDate = "2023-01-01",
                        EndDate = "2023-01-03",
                    },
                    DateOfService = new DateOnly(2023, 1, 1),
                    EndDateOfService = new DateOnly(2023, 1, 3),
                    TestResults = new List<TestResult>()
                    {
                        new TestResult { ResultType = TestResultType.Hemoglobin, Value = 51 },
                        new TestResult { ResultType = TestResultType.Ldl, Value = 110 },
                    },
                },
            },
            Eras = new List<Era>()
            {
                new Era
                {
                    EraId = "4D844EF1-2253-43CD-A4F1-6DB7E65CB54B",
                    CheckNumber = "CHK12345",
                    CheckDate = "2023-10-12",
                },
            },
        };
        var deserializedObject = JsonUtils.Deserialize<Claim>(json);
        Assert.That(deserializedObject, Is.EqualTo(expectedObject).UsingDefaults());
    }

    [global::NUnit.Framework.Test]
    public void TestSerialization()
    {
        var inputJson = """
            {
              "claim_id": "DD9D7F82-37B5-449D-AA63-26925398335B",
              "status": "biller_received",
              "clearinghouse": "Change Healthcare",
              "clearinghouse_claim_id": "5BA7C3AB-2BC2-496C-8B10-6CAC73D0729D",
              "payer_claim_id": "9BB9F259-9756-4F16-8F53-9DBB9F7EB1BB",
              "service_lines": [
                {
                  "created_at": "2023-01-01T00:00:00Z",
                  "modifiers": [
                    "22"
                  ],
                  "charge_amount_cents": 10000,
                  "allowed_amount_cents": 8000,
                  "insurance_balance_cents": 0,
                  "patient_balance_cents": 2000,
                  "paid_amount_cents": 8000,
                  "patient_responsibility_cents": 2000,
                  "diagnosis_id_zero": "4AC84BCD-12F5-4F86-A57B-E06749127C98",
                  "diagnosis_id_one": "EEA5CA5A-8B43-45FD-8CBD-C6CC1103E759",
                  "diagnosis_id_two": "5C4AA029-2DB9-4202-916E-E93C708F65FF",
                  "diagnosis_id_three": "81795126-A3AC-443C-B47E-7259A16AB4A2",
                  "service_line_era_data": {
                    "service_line_adjustments": [
                      {
                        "created_at": "2023-01-01T00:00:00Z",
                        "adjustment_group_code": "CO",
                        "adjustment_reason_code": "CO",
                        "adjustment_amount_cents": 1000,
                        "adjustment_note": "test_note"
                      }
                    ],
                    "remittance_advice_remark_codes": [
                      "N362"
                    ]
                  },
                  "service_line_manual_adjustments": [
                    {
                      "created_at": "2023-01-01T00:00:00Z",
                      "adjustment_group_code": "CO",
                      "adjustment_reason_code": "CO",
                      "adjustment_amount_cents": 1000,
                      "adjustment_note": "test_note"
                    }
                  ],
                  "related_invoices": [
                    {
                      "id": "901BE2F1-41BC-456E-9987-4FE2F84F9D75",
                      "created_at": "2023-01-01T00:00:00Z",
                      "updated_at": "2023-01-01T00:00:00Z",
                      "organzation_id": "F13F73D4-4344-46EA-9D93-33BCFFBB9F36",
                      "source_id": "9B626577-8808-4F28-9ED1-F0DFF0D49BBC",
                      "source_customer_id": "624D1972-8C69-4C2F-AEFA-10856F734DB3",
                      "patient_external_id": "10FED4D6-4C5A-48DF-838A-EEF45A74788D",
                      "note": "test_note",
                      "due_date": "2023-10-10",
                      "status": "draft",
                      "url": "https://example.com",
                      "customer_invoice_url": "https://example.com",
                      "items": [
                        {
                          "service_line_id": "CED00F23-6E68-4678-9DBC-F5AA2969A565",
                          "amount_cents": 500
                        }
                      ]
                    }
                  ],
                  "denial_reason": {
                    "reason": "Authorization Required"
                  },
                  "place_of_service_code": "01",
                  "service_line_id": "CED00F23-6E68-4678-9DBC-F5AA2969A565",
                  "procedure_code": "99213",
                  "quantity": "1",
                  "units": "MJ",
                  "claim_id": "026A1FB8-748E-4859-A2D7-3EA9E07D25AE",
                  "date_of_service_range": {
                    "start_date": "2023-01-01",
                    "end_date": "2023-01-03"
                  },
                  "date_of_service": "2023-01-01",
                  "end_date_of_service": "2023-01-03",
                  "test_results": [
                    {
                      "result_type": "HEMOGLOBIN",
                      "value": 51
                    },
                    {
                      "result_type": "LDL",
                      "value": 110
                    }
                  ]
                }
              ],
              "eras": [
                {
                  "era_id": "4D844EF1-2253-43CD-A4F1-6DB7E65CB54B",
                  "check_number": "CHK12345",
                  "check_date": "2023-10-12"
                }
              ]
            }
            """;
        JsonAssert.Roundtrips<Claim>(inputJson);
    }
}
