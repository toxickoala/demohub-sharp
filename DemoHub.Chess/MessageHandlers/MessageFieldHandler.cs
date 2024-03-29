﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoHub.Chess.MessageHandlers
{
    public class MessageFieldHandler
    {
        /// <Summary>
        /// Represents a message field.
        /// </Summary>
        #region CHESS Message Fields
        public enum MessageField
        {
            #region Group 1-64
            /// <Summary>
            /// 12 characters
            /// </Summary>
            #region Bitmap Position 2-16
            SecurityCode = 2,
            FundCode = 2,
            PreviousSecurityCode = 2,
            RedemptionFundCode = 2,
            ReducingSecurityCode = 2,
            SecurityCodeParameter = 2,
            AuthorisedAmount = 3,
            ExcessCashStandingInstruction = 3,
            FundAmount = 3,
            GrossDRPAmount = 3,
            GrossIncomeAmount = 3,
            InterestAmount = 3,
            LoanConsideration = 3,
            NewSettlementAmount = 3,
            PreviousLoanConsideration = 3,
            PreviousSettlementAmount = 3,
            ProjectedFundsPosition = 3,
            SettlementAmount = 3,
            ShortfallValuation = 3,
            CashBalanceBoughtForward = 4,
            LevyValue = 4,
            NewResultantExcess = 4,
            OutstandingSettlementAmount = 4,
            ReversedLevyValue = 4,
            RevisedLoanConsideration = 4,
            RevisedSettlementAmount = 4,
            BalanceInstruction = 5,
            PriceRunType = 5,
            RegistryRejectReason = 6,
            CorporateActionTypeId = 7,
            CorporateActionTypeIdParameter = 7,
            CertificateNumber = 8,
            MarkingNumber = 8,
            Contact = 9,
            ApplicationFundCode = 10,
            IncreasingSecurityCode = 10,
            ISIN = 10,
            RevisedSecurityCode = 10,
            ForeignResidencyIndicator = 11,
            FullRedemption = 11,
            FullSwitch = 11,
            IncomeNotificationFlag = 11,
            InitialApplication = 11,
            TransactionBasis = 11,
            PreviousTransactionBasis = 11,
            Date = 12,
            DateofEvent = 12,
            DispatchDate = 12,
            ETCSettlementDate = 12,
            FirstListedDate = 12,
            MarginPaymentDate = 12,
            OpeningBalanceDate = 12,
            OriginalSettlementDate = 12,
            PreviousSettlementDate = 12,
            PriceRunDate = 12,
            RemovalDate = 12,
            ReportingStartDate = 12,
            SettlementDate = 12,
            ClosingBalanceDate = 13,
            LastDateTraded = 13,
            LastListedDate = 13,
            ReportingEndDate = 13,
            RevisedSettlementDate = 13,
            TradeDate = 13,
            TransactionDate = 13,
            Account = 14,
            PaymentSetTransactionId = 14,
            HIN = 16,
            DefaultSettlementHIN = 16,
            HINParameter = 16,
            PaymentHIN = 16,
            PreviousDeliveringHIN = 16,
            PreviousHIN = 16,
            ReceivingHIN = 16,
            #endregion

            #region Bitmap Position 17-32
            DefaultDemandHIN = 17,
            DeliveringHIN = 17,
            PreviousReceivingHIN = 17,
            RevisedHIN = 17,
            HolderType = 18,
            DRPPreference = 18,
            PID = 19,
            PIDParameter = 19,
            TargetUIC = 19,
            ControllingPID = 19,
            BankUIC = 19,
            ETCSourceUIC = 19,
            ETCTargetUIC = 19,
            OldControllingPID = 19,
            PayerPID = 19,
            PayingPID = 19,
            ReceivingPID = 19,
            RequestingParticipant = 19,
            UIC = 19,
            DeliveringPID = 20,
            MasterUIC = 20,
            NewControllingPID = 20,
            PayeePID = 20,
            SettlementCounterpartyPID = 20,
            ProcessingTimestamp = 21,
            AddressType = 22,
            HoldingTransactionStatus = 22,
            IncomeStatementReportFrequency = 22,
            IncomeStatementStatus = 22,
            MarginLender = 22,
            TransactionStatus = 22,
            ASXClearAccount = 23,
            ASXClearingMember = 24,
            CashAccountIdentifier = 24,
            LastTradedTime = 24,
            TotalMessagesinSet = 24,
            TradeExecutionTime = 24,
            HolderDRPPreference = 25,
            IncomeStatementReportType = 25,
            MovementReason = 25,
            RegistrationDetailsIndicator = 26,
            SettlementInstructionStatus = 27,
            RevisedStatus = 27,
            LocationofRegister = 28,
            PaymentFacilityId = 29,
            PaymentFacilityParameter = 29,
            PreviousStatus = 30,
            ASXClearLodgementNumber = 31,
            Issuer = 32,
            #endregion

            #region Bitmap Position 33-48
            CancelReason = 33,
            Exchange = 33,
            FundReason = 33,
            HoldReason = 33,
            Reason = 33,
            BankReference = 34,
            ContactReference = 34,
            ParticipantReference = 34,
            Reference = 34,
            RegistryReference = 34,
            ReceivingSupplementaryReference = 35,
            SupplementaryReference = 35,
            BrokerNonBrokerIndicator = 36,
            HolderRPPPreference = 36,
            ChangeCashSubrecordRejectReason = 37,
            CollateralRejectedReason = 37,
            CreateCashSubrecordRejectReason = 37,
            IncomeStatementCancellation = 37,
            RejectedIncomeStatementSetReason = 37,
            RejectedNetPositionReason = 37,
            RejectedMovementReason = 37,
            RejectedRegistryReason = 37,
            BasisOfMovement1 = 38,
            OverrideBasisOfMovement1 = 38,
            PreviousOverrideBasisOfMove1 = 38,
            BasisOfMovement2 = 39,
            OverrideBasisOfMovement2 = 39,
            PreviousOverrideBasisOfMove2 = 39,
            BasisOfMovement3 = 40,
            OverrideBasisOfMovement3 = 40,
            PreviousOverrideBasisOfMove3 = 40,
            BasisOfMovement4 = 41,
            OverrideBasisOfMovement4 = 41,
            PreviousOverrideBasisOfMove4 = 41,
            BasisOfMovement5 = 42,
            OverrideBasisOfMovement5 = 42,
            PreviousOverrideBasisOfMove5 = 42,
            IncreaseorDecrease = 43,
            Sign = 43,
            PayReceiveIndicator = 44,
            StatementType = 45,
            SubpositionType = 45,
            SubpositionTypeParameter = 45,
            PIN = 46,
            TakeoverCode = 47,
            TakeoverCodeParameter = 47,
            TransactionId = 48,
            #endregion

            #region Bitmap Position 49-64
            TargetTransactionId = 49,
            LinkingTransactionId = 49,
            ParentTransactionId = 49,
            Part_SettledTransactionId = 49,
            SetTransactionId = 49,
            TransactionIdParameter = 49,
            VerificationName = 50,
            SecurityholderReferenceNumber = 51,
            AllocationQuantity = 52,
            EntitlementBalance = 52,
            FailingUnitQuantity = 52,
            GuaranteedForeignNetOffs = 52,
            NetOffs = 52,
            PreviousUnitQuantity = 52,
            ProjectedSecurityPosition = 52,
            ReducingUnitQuantity = 52,
            SecuritiesShortfall = 52,
            TotalMovementsOff = 52,
            TotalUnitsOnSub_Register = 52,
            UnitQuantity = 52,
            UnitQuantityAccepted = 52,
            GuaranteedForeignNetOns = 53,
            HoldingBalance = 53,
            IncreasingUnitQuantity = 53,
            NetOns = 53,
            NewHoldingBalance = 53,
            NewSubpositionBalance = 53,
            OutstandingUnitQuantity = 53,
            RevisedUnitQuantity = 53,
            TotalMarginCover = 53,
            TotalMovementsOn = 53,
            TotalOptionsCover = 53,
            TotalUnitBalance = 53,
            TransferorHoldingBalance = 53,
            CertificateQuantity = 54,
            ClosingBalance = 54,
            GuaranteedForeignClosingBalance = 54,
            On_MarketVolume = 54,
            ReducingHoldingBalance = 54,
            TransfereeHoldingBalance = 54,
            GuaranteedMovementfromRegistry = 55,
            IncreasingHoldingBalance = 55,
            MovementfromRegistry = 55,
            Off_MarketVolume = 55,
            OpeningBalance = 55,
            TakeoverAcceptanceBalance = 55,
            TransferorMarginCover = 55,
            TransferorOptionsCover = 55,
            AuthorisationRequired = 56,
            DefaultPaymentFacilityIndicator = 56,
            DistinctPortionIndicator = 56,
            Part_Settlement = 56,
            SpecificCover = 56,
            StatementRequired = 56,
            NumberHoldersAffected = 57,
            TotalMessageCount = 57,
            TotalReminderCount = 57,
            TotalStatementCount = 57,
            DeliveringSupplementaryReference = 58,
            RevisedUnderlyingReference = 58,
            RegistrationDetails = 59,
            AddressDetails1 = 59,
            DeliveringRegistrationDetails = 59,
            InitiatorNameandAddress = 59,
            ReceivingRegistrationDetails = 59,
            RescheduleReason = 60,
            RejectedOrderReason = 61,
            RejectedReason = 61,
            OriginTransactionId = 62,
            Market = 63,
            TaxResidence1 = 63,
            GuaranteedMovementtoRegistry = 64,
            MovementtoRegistry = 64,
            #endregion
            #endregion Group 1-64

            #region Group 65-128
            #region Bitmap Position 66-80
            DefaultAccumulationHIN = 66,
            RevisedDeliveringHIN = 66,
            Amount = 67,
            Balance = 67,
            FaceValue = 67,
            PreviousStampingConsideration = 67,
            Principal = 67,
            StampingConsideration = 67,
            TradeAmount = 67,
            DutyPayable = 68,
            MarketValue = 68,
            RevisedStampingConsideration = 68,
            DutyType = 69,
            PreviousDutyType = 69,
            RemoveExcessCashStandingInstruction = 69,
            PreviousUnderlyingReference = 70,
            UnderlyingReference = 70,
            EntrepotType = 71,
            ReportingRequestStatus = 72,
            CashPaymentWithdrawal = 73,
            OutstandingLoanConsideration = 73,
            TrustAmount = 73,
            LoanTransactionId = 74,
            SuspensionReason = 75,
            PaymentFacilityChangeReason = 76,
            ParticipantType = 77,
            Currency = 78,
            PaymentType = 78,
            ReportingId = 78,
            TaxResidence2 = 78,
            MessageType = 79,
            ProcessingFrequency = 79,
            ExDate = 80,
            ExDateParameter = 80,
            #endregion

            #region Bitmap Position 81-96
            DiaryAdjustmentType = 81,
            SubregisterStatus = 81,
            NumberOfDaysParameter = 82,
            ESAStatus = 83,
            PositionTypeParameter = 83,
            ProcessingPoint = 84,
            CreditStatus = 85,
            NotificationType = 85,
            ProcessingPeriod = 85,
            DiaryAdjustmentNumber = 86,
            AllocationCancellationTimestamp = 87,
            AllocationTimestamp = 87,
            ApprovedTimestamp = 87,
            ContractNoteTimestamp = 87,
            DvPDeclarationTimestamp = 87,
            HoldingBalanceTimestamp = 87,
            InitialTimestamp = 87,
            RejectionTimestamp = 87,
            SettlementAdviceTimestamp = 87,
            TradeTimestamp = 87,
            EffectedTimestamp = 88,
            ResponseTimestamp = 88,
            Timestamp = 88,
            BlockingTransactionId = 89,
            CancellingTransactionId = 89,
            MatchingTransactionId = 90,
            UnblockingTransactionId = 90,
            MatchedTimestamp = 91,
            SettledTimestamp = 91,
            AdvisorMobile = 92,
            ReceivingNetMovementTransactionId = 92,
            ApprovedTransactionId = 92,
            UpdatingTransactionId = 92,
            ScheduledTimestamp = 93,
            AsAtDate = 94,
            DateofBirth1 = 94,
            StartDateParameter = 94,
            DateofBirth2 = 95,
            EndDateParameter = 95,
            Name = 96,
            ParticipantName = 96,
            #endregion

            #region Bitmap Position 97-112
            Address = 97,
            AsAtDateParameter = 98,
            DateofBirth3 = 98,
            ExpiryDate = 98,
            CollateralType = 99,
            ReportingIdParameter = 99,
            TaxResidence3 = 99,
            TFN_ABN_1 = 100,
            TFN_ABN_2 = 101,
            TFN_ABN_3 = 102,
            SecurityCodePreference = 103,
            UserStatus = 104,
            ControllingPIDStatus = 104,
            UserType = 105,
            PriceRunTime = 106,
            AdjustmentHistoryStatus = 107,
            AccrualNumber = 108,
            AdjustmentReason = 109,
            InvalidReason = 110,
            InvalidMessageHeader = 111,
            DeliveringNetMovementTransactionId = 112,
            #endregion

            #region Bitmap Position 113-128
            NettedObligationTransactionId = 113,
            NetFundsTransactionId = 114,
            ConditionCode1 = 115,
            ConditionCode2 = 116,
            ConditionCode3 = 117,
            ConditionCode4 = 118,
            ConditionCode5 = 119,
            ConditionCode6 = 120,
            ConditionCode7 = 121,
            ConditionCode8 = 122,
            BuyerId = 123,
            SellerId = 124,
            CancellationTimestamp = 125,
            CancelledTimestamp = 125,
            ETCSettlementCancelTimestamp = 125,
            AuthorisationReason = 126,
            CancellationReason = 127,
            RejectedTransferReason = 128,
            #endregion
            #endregion Group 65-128

            #region Group 129-192
            #region Bitmap Position 130-144
            RevisedOverrideBasisOfMove1 = 130,
            RevisedOverrideBasisOfMove2 = 131,
            RevisedOverrideBasisOfMove3 = 132,
            RevisedOverrideBasisOfMove4 = 133,
            RevisedOverrideBasisOfMove5 = 134,
            RevisedDutyType = 135,
            AIDividendsFrankedAmountCash = 136,
            CapitalGainDiscount = 136,
            CGDiscountCash = 136,
            FIAssessableIncomeCash = 136,
            NATaxExemptedAmountsCash = 136,
            NonPrimaryIncome = 136,
            ODTFNAmountsWithheld = 136,
            PreviousDutyPayable = 136,
            AIDividendsFrankedAmountTax = 137,
            CapitalGainOther = 137,
            CGDiscountTax = 137,
            FIAssessableIncomeTax = 137,
            NATaxDeferredAmountsCash = 137,
            ODOtherExpenses = 137,
            RevisedDutyPayable = 137,
            RevisedReceivingHIN = 138,
            RevisedTransactionBasis = 139,
            RejectedRegistrationUpdateReason = 140,
            SLSLoanInstructionStatus = 141,
            CHESSEventType = 142,
            RegistrationNameUpdateReason1 = 142,
            SettlementStep = 143,
            Pre_SettlementAdvice_ESALevel = 144,
            TransactionClassParameter = 144,
            #endregion

            #region Bitmap Position 145-160
            LevyType = 145,
            RegistrationNameUpdateReason2 = 145,
            BasisOfQuotation1 = 146,
            BasisOfQuotation2 = 147,
            BasisOfQuotation3 = 148,
            BasisOfQuotation4 = 149,
            BasisOfQuotation5 = 150,
            TradeReason = 151,
            AdditionalReportingParameter = 152,
            Pre_SettlementAdvice_CreditLevel = 152,
            RejectedChangeReason = 153,
            AdviceReason = 154,
            RemovalReason = 154,
            RedemptionUnitPrice = 155,
            UnitPrice = 155,
            BuySellIndicator = 156,
            InvestorMobileContact = 157,
            OrderReference = 157,
            TradingBroker = 158,
            CrossingIndicator = 159,
            PrincipalIndicator = 160,
            #endregion

            #region Bitmap Position 161-176
            AccountId = 161,
            Issue = 161,
            AllocationStatus = 162,
            ContractNoteStatus = 162,
            Post_SettlementAdvice = 162,
            ETCRejectionReason = 163,
            SettlementMatchingDate = 164,
            AIDividendsFrankedAmountTaxable = 165,
            AnnualCapitalGainTotal = 165,
            Brokerage = 165,
            CGDiscountTaxable = 165,
            FIAssessableIncomeTaxable = 165,
            FrankingCredit = 165,
            NAGrossCash = 165,
            ODNetCash = 165,
            AIDividendsUnfrankedAmountCash = 166,
            CGTaxConcessionCash = 166,
            CGTConcession = 166,
            FICashDistributionCash = 166,
            NATaxFreeAmountsCash = 166,
            OtherAmount = 166,
            TFNWithholding = 166,
            RecipientName = 167,
            MemberASXIndicator = 168,
            AllocationCancellationLevel = 169,
            ContractNoteRejectionLevel = 169,
            Deliver_ReceiveUnitsIndicator = 170,
            Remarks = 172,
            HolderStatusChange = 173,
            HolderStatus = 174,
            ResidencyIndicator = 175,
            ReceivingResidencyIndicator = 175,
            GuaranteedForeignIndicator = 176,
            PreviousGuaranteedForeignIndicator = 176,
            #endregion

            #region Bitmap Position 177-192
            RevisedGuaranteedForeignIndicator = 177,
            TakeoverAcceptanceRemovalReason = 178,
            HolderLockReleaseReason = 179,
            RegistrationDetailsUpdateReason = 179,
            NetPositionActivityFlag = 180,
            UpdateGuaranteedForeignIndicator = 180,
            AIDividendsUnfrankedAmountTaxable = 181,
            AnnualCapitalGain = 181,
            CGTaxConcessionTaxable = 181,
            CurrentorNewDebitCapLimit = 181,
            DebitCapLimit = 181,
            FICashDistributionTax = 181,
            TaxDeferred = 181,
            DebitCapActivityFlag = 182,
            BIC = 184,
            CashSubrecordID = 185,
            CashSubrecordType = 186,
            DebitCapExclusionFlag = 187,
            MovementType = 188,
            ScheduleTransactionforSettlement = 189,
            DestinationSettlementSystem = 190,
            NettorGross = 190,
            PreviousDestinationSettlementSystem = 190,
            RevisedDestinationSettlementSystem = 190,
            RedemptionRequestReason = 191,
            #endregion
            #endregion Group 129-192

            #region Group 193-256
            #region Bitmap Position 194-208
            BidTime = 194,
            PayerClearingMember = 194,
            PayerPaymentCategory = 195,
            SerialTradeQualifier = 195,
            AskTime = 196,
            PayeeClearingMember = 196,
            TradeSerialNumber = 196,
            PayeePaymentCategory = 197,
            TotalPaymentRecords = 198,
            BidPrice = 199,
            TradePrice = 199,
            EmailAddress = 200,
            ApplicationProductName = 200,
            InvestorEmailAddress = 200,
            BSBNumber = 201,
            FICode = 202,
            AccountNumber = 203,
            AccountName = 204,
            AccountPurpose = 205,
            AccountCancellation = 206,
            RPPFrequency = 206,
            InterestDescription = 207,
            EmailPurpose = 208,
            InvestorEmailPurpose = 208,
            #endregion

            #region Bitmap Position 209-224
            EmailCancellation = 209,
            AML_CTFFlag = 209,
            RejectedHoldingAdviceReason = 210,
            FATCAQuestions = 210,
            NovationIndicator = 210,
            AskPrice = 211,
            FirstTradePrice = 212,
            HighestTradePrice = 213,
            LowestTradePrice = 214,
            LastTradePrice = 215,
            BuyerOrderReferenceNumber = 216,
            DealerGroupAFSLNumber = 217,
            SellerOrderReferenceNumber = 217,
            ParticipantAdvisorName = 218,
            ParticipantAdvisorCode = 219,
            AdditionalUnits = 220,
            FundNetOffs = 220,
            TotalFundMovementsOff = 220,
            HaircutRate = 221,
            IncomeAmountperUnit = 221,
            OrderType = 222,
            On_MarketValue = 223,
            TaxDeducted = 223,
            Income = 224,
            NettDRPAmount = 224,
            Off_MarketValue = 224,
            #endregion

            #region Bitmap Position 225-240
            ClosingFundBalance = 225,
            TotalFundUnitBalance = 225,
            AddressDetails2 = 226,
            AddressDetails3 = 227,
            FundNetOns = 230,
            TotalFundMovementsOn = 230,
            CurrentPDSProvided = 231,
            AdjustmentUnits = 232,
            FundMovementfromRegistry = 232,
            NumberofUnits = 232,
            TotalFundUnitsonRegister = 232,
            UnitsParticipating = 232,
            UnitsRedeemed = 232,
            FundHoldingBalance = 233,
            FundMovementtoRegistry = 233,
            NewFundHoldingBalance = 233,
            OpeningFundBalance = 233,
            ProductName = 234,
            RedemptionProductName = 234,
            ApplicationUnitPrice = 235,
            ApplicationUnitPricingDate = 236,
            LodgementDate = 236,
            PDSIssueDate = 236,
            UnitPricingDate = 236,
            Fees = 237,
            RPPAmount = 237,
            ApplicationUnits = 238,
            UnitAllotmentDate = 239,
            ParticipantAdvisorEmail = 240,
            #endregion

            #region Bitmap Position 241-256
            RedemptionUnitPricingDate = 241,
            PaymentDate = 242,
            AdvisorEmail = 243,
            DealerGroupAdvisorEmail = 243,
            RecordDate = 244,
            APIRCode = 245,
            RedemptionAPIRCode = 245,
            ApplicationAPIRCode = 246,
            DealerGroupName = 247,
            AdvisorName = 248,
            DealerGroupAdvisorName = 248,
            AdvisorCode = 249,
            DealerGroupAdvisorCode = 249,
            TaxCreditAmount = 250,
            InterestRate = 251,
            Yield = 251,
            CashBalanceCarriedForward = 252,
            CollateralValue = 252,
            InitialMargin = 253,
            OtherMargin = 254,
            UtilisedNon_CashCollateral = 255,
            Excess_Shortage = 256,
            #endregion
            #endregion Group 193-256

            #region Group 257-320
            #region Bitmap Position 258-272
            ResultantCashBalance = 259,
            ResultantExcess = 260,
            AccountType = 265,
            EntityType = 266,
            AIInterestCash = 268,
            CGOtherMethodCash = 268,
            FICashDistributionCashSubTotal = 268,
            NetCapitalGain = 268,
            AIInterestTaxable = 269,
            AssessableForeignIncome = 269,
            CGOtherMethodTax = 269,
            AIOtherIncomeCash = 270,
            CGOtherMethodTaxable = 270,
            OtherForeignIncome = 270,
            AIOtherIncomeTaxable = 271,
            CGDistributedCash = 271,
            ForeignIncomeTaxOffsets = 271,
            AITrustDeductionsCash = 272,
            CGDistributedTax = 272,
            NonPrimaryDistributionDeductions = 272,
            #endregion

            #region Bitmap Position 273-288
            AITrustDeductionsTaxable = 273,
            CGTrustDeductionsTaxable = 273,
            AINonPrimaryIncomeCash = 274,
            CGNet = 274,
            AINonPrimaryIncomeTaxable = 275,
            ForeignPerson1 = 276,
            ForeignPersonDateofBirth1 = 277,
            ForeignCountryCode1A = 278,
            ForeignCountryCode1B = 279,
            ForeignCountryCode1C = 280,
            ForeignTIN1A = 281,
            ForeignTIN1B = 282,
            ForeignTIN1C = 283,
            TINAbsent1A = 284,
            TINAbsent1B = 285,
            TINAbsent1C = 286,
            ForeignPerson2 = 287,
            ForeignPersonDateofBirth2 = 288,
            #endregion

            #region Bitmap Position 289-304
            ForeignCountryCode2A = 289,
            ForeignCountryCode2B = 290,
            ForeignCountryCode2C = 291,
            ForeignTIN2A = 292,
            ForeignTIN2B = 293,
            ForeignTIN2C = 294,
            TINAbsent2A = 295,
            TINAbsent2B = 296,
            TINAbsent2C = 297,
            ForeignPerson3 = 298,
            ForeignPersonDateofBirth3 = 299,
            ForeignCountryCode3A = 300,
            ForeignCountryCode3B = 301,
            ForeignCountryCode3C = 302,
            ForeignTIN3A = 303,
            ForeignTIN3B = 304,
            #endregion

            #region Bitmap Position 305-320
            ForeignTIN3C = 305,
            TINAbsent3A = 306,
            TINAbsent3B = 307,
            TINAbsent3C = 308,
            AdditionalForeignParties = 309
            #endregion
            #endregion Group 257-320
        }
        #endregion CHESS Message Fields
    }
}
