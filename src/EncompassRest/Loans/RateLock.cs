using System;
using System.Collections.Generic;

namespace EncompassRest.Loans
{
    public sealed class RateLock
    {
        public decimal? TotalSubordinateFinancing { get; set; }
        public string CurrentRateSheetID { get; set; }
        public string CurrentComments { get; set; }
        public decimal? CurrentRate { get; set; }
        public List<PriceAdjustment> CurrentAdjustments { get; set; }
        public decimal? CurrentRateTotalAdjustment { get; set; }
        public decimal? CurrentRateRequested { get; set; }
        public decimal? CurrentPriceRate { get; set; }
        public decimal? CurrentPriceTotalAdjustment { get; set; }
        public decimal? CurrentPriceRateRequested { get; set; }
        public decimal? CurrentMarginRate { get; set; }
        public decimal? CurrentMarginTotalAdjustment { get; set; }
        public decimal? CurrentMarginRateRequested { get; set; }
        public string RequestRateSheetID { get; set; }
        public string DeliveryType { get; set; }
        public bool? IsDeliveryType { get; set; }
        public DateTime? RequestLockDate { get; set; }
        public int? RequestNumberOfDays { get; set; }
        public DateTime? RequestLockExpires { get; set; }
        public decimal? RequestRate { get; set; }
        public List<PriceAdjustment> LockRequestAdjustments { get; set; }
        public decimal? RequestRateTotalAdjustment { get; set; }
        public decimal? RequestRateRequested { get; set; }
        public decimal? RequestPriceRate { get; set; }
        public decimal? RequestPriceTotalAdjustment { get; set; }
        public decimal? RequestPriceRateRequested { get; set; }
        public string RequestComments { get; set; }
        public decimal? RequestMarginRate { get; set; }
        public decimal? RequestMarginTotalAdjustment { get; set; }
        public decimal? RequestMarginRateRequested { get; set; }
        public decimal? RequestMarginSRPPaidOut { get; set; }
        public string RequestOnrpLockTime { get; set; }
        public bool? RequestOnrpEligible { get; set; }
        public DateTime? RequestOnrpLockDate { get; set; }
        public DateTime? BuySideOnrpLockDate { get; set; }
        public DateTime? CurrentLockDate { get; set; }
        public int? CurrentNumberOfDays { get; set; }
        public DateTime? CurrentLockExpires { get; set; }
        public string BuySideRequestedBy { get; set; }
        public string BuySideRateSheetID { get; set; }
        public DateTime? BuySideLockDate { get; set; }
        public int? BuySideNumberOfDays { get; set; }
        public DateTime? BuySideLockExpires { get; set; }
        public decimal? BuySideRate { get; set; }
        public List<PriceAdjustment> BuySideAdjustments { get; set; }
        public decimal? BuySideRateTotalAdjustment { get; set; }
        public decimal? BuySideRateNetBuyRate { get; set; }
        public decimal? BuySidePriceRate { get; set; }
        public decimal? BuySidePriceTotalAdjustment { get; set; }
        public decimal? BuySidePriceNetBuyPrice { get; set; }
        public string BuySideComments { get; set; }
        public decimal? BuySideSRPPaidOut { get; set; }
        public string Commitment { get; set; }
        public decimal? BuySideMarginRate { get; set; }
        public decimal? BuySideMarginTotalAdjustment { get; set; }
        public decimal? BuySideMarginNetBuyRate { get; set; }
        public string BuySideOnrpLockTime { get; set; }
        public bool? BuySideOnrpEligible { get; set; }
        public decimal? SellSideMarginRate { get; set; }
        public List<PriceAdjustment> SellSideAdjustments { get; set; }
        public decimal? SellSideMarginTotalAdjustment { get; set; }
        public decimal? SellSideMarginNetSellRate { get; set; }
        public string SellSideCommitmentContractNumber { get; set; }
        public string SellSideProductName { get; set; }
        public decimal? SellSideMSRValue { get; set; }
        public decimal? NetSellPrice { get; set; }
        public decimal? ActualSellPrice { get; set; }
        public decimal? DiffSellPrice { get; set; }
        public bool? UsePoint { get; set; }
        public decimal? NetSellAmount { get; set; }
        public decimal? ActualSellAmount { get; set; }
        public decimal? DiffSellAmount { get; set; }
        public DateTime? DateFirstPaymentToInvestor { get; set; }
        public decimal? SellSideSRP { get; set; }
        public decimal? ActualSellSideSRP { get; set; }
        public decimal? DiffSellSideSRP { get; set; }
        public decimal? SRPAmount { get; set; }
        public decimal? ActualSRPAmount { get; set; }
        public decimal? DiffSRPAmount { get; set; }
        public decimal? Principle { get; set; }
        public decimal? Premium { get; set; }
        public decimal? SRP { get; set; }
        public decimal? AmountReceived { get; set; }
        public DateTime? NextPaymentDate { get; set; }
        public decimal? ExpectedPrinciple { get; set; }
        public decimal? ExpectedPremium { get; set; }
        public decimal? ExpectedSRP { get; set; }
        public List<PurchaseAdvicePayout> PurchaseAdvicePayouts { get; set; }
        public decimal? ExpectedAmountReceived { get; set; }
        public decimal? DiffPrinciple { get; set; }
        public decimal? DiffPremium { get; set; }
        public decimal? DiffSRP { get; set; }
        public decimal? DiffAmountReceived { get; set; }
        public string PrepayPenalty { get; set; }
        public string PenaltyTerm { get; set; }
        public decimal? TotalBuyPrice { get; set; }
        public string SellSideRequestedBy { get; set; }
        public string SellSideRateSheetID { get; set; }
        public DateTime? SellSideLockDate { get; set; }
        public int? SellSideNumberOfDays { get; set; }
        public DateTime? SellSideLockExpires { get; set; }
        public decimal? SellSideRate { get; set; }
        public decimal? SellSideRateTotalAdjustment { get; set; }
        public decimal? SellSideNetSellRate { get; set; }
        public decimal? SellSidePriceRate { get; set; }
        public decimal? SellSidePriceTotalAdjustment { get; set; }
        public decimal? SellSideNetSellPrice { get; set; }
        public string SellSideComments { get; set; }
        public decimal? SellSideSRPPaidOut { get; set; }
        public decimal? SellSideDiscountYSP { get; set; }
        public string InvestorName { get; set; }
        public string InvestorContact { get; set; }
        public string InvestorPhone { get; set; }
        public string InvestorEmail { get; set; }
        public string InvestorAddress { get; set; }
        public string InvestorCity { get; set; }
        public string InvestorState { get; set; }
        public string InvestorPostalCode { get; set; }
        public string InvestorWebsite { get; set; }
        public string InvestorCommitment { get; set; }
        public string InvestorLockType { get; set; }
        public string InvestorLoanNumber { get; set; }
        public string InvestorProgramCode { get; set; }
        public string InvestorMERSNumber { get; set; }
        public DateTime? DateLockedWithInvestor { get; set; }
        public string TimeLockedWithInvestor { get; set; }
        public string SellSideLoanProgram { get; set; }
        public DateTime? SellSideCommitmentDate { get; set; }
        public string ImpoundWavied { get; set; }
        public string ImpoundType { get; set; }
        public decimal? GainLossTotalBuyPrice { get; set; }
        public decimal? GainLossPercentage { get; set; }
        public DateTime? InvestorDeliveryDate { get; set; }
        public DateTime? InvestorTargetDeliveryDate { get; set; }
        public decimal? GainLossPrice { get; set; }
        public string SellSideInvestorStatus { get; set; }
        public string SellSideTradeNumber { get; set; }
        public string SellSideTradeGuid { get; set; }
        public string SellSideMasterContractNumber { get; set; }
        public string SellSideInvestorTradeNumber { get; set; }
        public DateTime? SellSideInvestorStatusDate { get; set; }
        public DateTime? Date { get; set; }
        public string FirstPaymenTo { get; set; }
        public string ConfirmedBy { get; set; }
        public string AmountDueTo { get; set; }
        public string AmountPaidTo { get; set; }
        public decimal? ReconciledDiff { get; set; }
        public DateTime? ConfirmedDate { get; set; }
        public decimal? AmountDue { get; set; }
        public decimal? AmountPaid { get; set; }
        public string Hedging { get; set; }
        public string RequestFullfilledDateTime { get; set; }
        public decimal? Interest { get; set; }
        public decimal? Impounds { get; set; }
        public decimal? ExpectedInterest { get; set; }
        public int? PurchaseAdviceNumberOfDays { get; set; }
        public string PerDiemInterestRoundingType { get; set; }
        public decimal? ExpectedImpounds { get; set; }
        public decimal? DiffInterest { get; set; }
        public decimal? DiffImpounds { get; set; }
        public string Comments { get; set; }
        public bool? LoanFor203K { get; set; }
        public decimal? TotalForLesserOfSumAsIs { get; set; }
        public string HELOCActualBalance { get; set; }
        public decimal? RequestUnDiscountedRate { get; set; }
        public decimal? BuySideUnDiscountedRate { get; set; }
        public string LoanProgram { get; set; }
        public string LoanDocumentationType { get; set; }
        public List<LockRequestBorrower> LockRequestBorrowers { get; set; }
        public bool? EmploymentBorrowerSelfEmployedIndicator1 { get; set; }
        public bool? EmploymentBorrowerSelfEmployedIndicator2 { get; set; }
        public bool? EmploymentBorrowerSelfEmployedIndicator3 { get; set; }
        public bool? EmploymentBorrowerSelfEmployedIndicator4 { get; set; }
        public bool? EmploymentBorrowerSelfEmployedIndicator5 { get; set; }
        public bool? EmploymentBorrowerSelfEmployedIndicator6 { get; set; }
        public bool? EmploymentBorrowerSelfEmployedIndicator7 { get; set; }
        public bool? EmploymentBorrowerSelfEmployedIndicator8 { get; set; }
        public bool? EmploymentBorrowerSelfEmployedIndicator9 { get; set; }
        public bool? EmploymentBorrowerSelfEmployedIndicator10 { get; set; }
        public bool? EmploymentBorrowerSelfEmployedIndicator11 { get; set; }
        public bool? EmploymentBorrowerSelfEmployedIndicator12 { get; set; }
        public string MinFICO { get; set; }
        public string MinFICO2 { get; set; }
        public string SubjectPropertyStreetAddress { get; set; }
        public string SubjectPropertyCity { get; set; }
        public string SubjectPropertyCounty { get; set; }
        public string SubjectPropertyState { get; set; }
        public string SubjectPropertyPostalCode { get; set; }
        public string GSEPropertyType { get; set; }
        public int? PropertyEstimatedValueAmount { get; set; }
        public int? PropertyAppraisedValueAmount { get; set; }
        public string PropertyUsageType { get; set; }
        public string LockRequestLoanPurposeType { get; set; }
        public string MortgageType { get; set; }
        public string LoanAmortizationType { get; set; }
        public decimal? GPMRate { get; set; }
        public int? GPMYears { get; set; }
        public string FNMProductPlanIdentifier { get; set; }
        public string OtherAmortizationTypeDescription { get; set; }
        public string LienPriorityType { get; set; }
        public int? LoanAmortizationTermMonths { get; set; }
        public int? BalloonLoanMaturityTermMonths { get; set; }
        public string RequestImpoundWavied { get; set; }
        public string RequestImpoundType { get; set; }
        public string RequestPrepayPenalty { get; set; }
        public string RequestPenaltyTerm { get; set; }
        public decimal? BorrowerRequestedLoanAmount { get; set; }
        public DateTime? LoanScheduledClosingDate { get; set; }
        public string LoanProgramFile { get; set; }
        public string PlanCode { get; set; }
        public decimal? BaseLoanAmount { get; set; }
        public decimal? FHAUpfrontMIPremiumPercent { get; set; }
        public decimal? FundingAmount { get; set; }
        public bool? LockField { get; set; }
        public bool? RoundToNearest50 { get; set; }
        public decimal? MIPPaidInCash { get; set; }
        public decimal? SellerPaidMIPremium { get; set; }
        public bool? FirstTimeHomebuyersIndicator { get; set; }
        public int? FinancedNumberOfUnits { get; set; }
        public bool? TwelveMonthMortgageRentalHistoryIndicator { get; set; }
        public bool? LenderPaidMortgageInsuranceIndicator { get; set; }
        public bool? SubjectPropertyCondotelIndicator { get; set; }
        public bool? SubjectPropertyNonWarrantableProjectIndicator { get; set; }
        public string CompSideLoanProgram { get; set; }
        public string CompSideComparisonedBy { get; set; }
        public string CompSideRateSheetID { get; set; }
        public DateTime? CompSideCurrentRateSetDate { get; set; }
        public DateTime? CompSideLockDate { get; set; }
        public int? CompSideNumberOfDays { get; set; }
        public DateTime? CompSideLockExpires { get; set; }
        public decimal? CompSideRate { get; set; }
        public List<PriceAdjustment> CompSideAdjustments { get; set; }
        public decimal? CompSideRateTotalAdjustment { get; set; }
        public decimal? CompSideNetCompRate { get; set; }
        public decimal? CompSidePriceRate { get; set; }
        public decimal? CompSidePriceTotalAdjustment { get; set; }
        public decimal? CompSideNetCompPrice { get; set; }
        public decimal? CompSideMarginRate { get; set; }
        public decimal? CompSideMarginTotalAdjustment { get; set; }
        public decimal? CompSideMarginNetCompRate { get; set; }
        public decimal? CompSideSRPPaidOut { get; set; }
        public decimal? CompSideDiscountYSP { get; set; }
        public string CompInvestorName { get; set; }
        public string CompInvestorContact { get; set; }
        public string CompInvestorPhone { get; set; }
        public string CompInvestorEmail { get; set; }
        public string CompInvestorAddress { get; set; }
        public string CompInvestorCity { get; set; }
        public string CompInvestorState { get; set; }
        public string CompInvestorPostalCode { get; set; }
        public string CompInvestorWebsite { get; set; }
        public string CompSideServicingType { get; set; }
        public string CompInvestorProgramCode { get; set; }
        public string CompInvestorLockType { get; set; }
        public string CompSideComments { get; set; }
        public decimal? CompGainLossTotalCompPrice { get; set; }
        public decimal? CompGainLossPercentage { get; set; }
        public decimal? CompGainLossPrice { get; set; }
        public string CompInvestorTemplateName { get; set; }
        public string SellSideTradeMgmtPrevConfirmedLockGuid { get; set; }
        public decimal? FirstSubordinateAmount { get; set; }
        public decimal? SecondSubordinateAmount { get; set; }
        public decimal? OtherSubordinateAmount { get; set; }
        public decimal? PurchasePriceAmount { get; set; }
        public string PricingUpdated { get; set; }
        public decimal? ExpectedRemainingBuydownFunds { get; set; }
        public decimal? RemainingBuydownFunds { get; set; }
        public decimal? DiffRemainingBuydownFunds { get; set; }
        public decimal? LTV { get; set; }
        public decimal? CombinedLTV { get; set; }
        public DateTime? RequestCurrentRateSetDate { get; set; }
        public DateTime? CurrentRateSetDate { get; set; }
        public DateTime? BuySideCurrentRateSetDate { get; set; }
        public DateTime? SellSideCurrentRateSetDate { get; set; }
        public string InvestorTemplateName { get; set; }
        public DateTime? DateSold { get; set; }
        public bool? ServicingReleaseIndicator { get; set; }
        public DateTime? DateWarehoused { get; set; }
        public DateTime? BuySideOriginalLockExpires { get; set; }
        public DateTime? SellSideOriginalLockExpires { get; set; }
        public int? RequestDaystoExtend { get; set; }
        public DateTime? RequestExtendedLockExpires { get; set; }
        public decimal? RequestLockExtendPriceAdjustment { get; set; }
        public int? BuySideDaystoExtend { get; set; }
        public DateTime? BuySideExtendedLockExpires { get; set; }
        public decimal? BuySideLockExtendPriceAdjustment { get; set; }
        public int? SellSideDaystoExtend { get; set; }
        public DateTime? SellSideExtendedLockExpires { get; set; }
        public decimal? SellSideLockExtendPriceAdjustment { get; set; }
        public DateTime? RequestOriginalLockExpires { get; set; }
        public string RequestLockExtendComment { get; set; }
        public decimal? CorporatePrice { get; set; }
        public DateTime? CorporateApprovalDate { get; set; }
        public string CorporateApprovedby { get; set; }
        public string ReasonforCorporateApproval { get; set; }
        public decimal? BranchPrice { get; set; }
        public DateTime? BranchApprovalDate { get; set; }
        public string BranchApprovedby { get; set; }
        public string ReasonforBranchApproval { get; set; }
        public decimal? TotalPrice { get; set; }
        public int? CumulatedDaystoExtend { get; set; }
        public int? ExtensionSequenceNumber { get; set; }
        public decimal? ProfitMarginAdjustedBuyPrice { get; set; }
        public DateTime? RequestLockCancellationDate { get; set; }
        public string RequestLockCancellationComment { get; set; }
        public string RequestLockType { get; set; }
        public string SellSideServicingType { get; set; }
        public string SellSideServicer { get; set; }
        public decimal? SellSideServicingFee { get; set; }
        public decimal? SellSideGuaranteeFee { get; set; }
        public decimal? SellSideGuarantyBaseFee { get; set; }
        public string SellSidePoolNumber { get; set; }
        public string SellSidePoolID { get; set; }
        public DateTime? CorrespondentDate { get; set; }
        public decimal? CorrespondentCurrentImpounds { get; set; }
        public DateTime? CorrespondentPaidToDate { get; set; }
        public DateTime? CorrespondentFirstPaymentDate { get; set; }
        public decimal? CorrespondentCurrentPrincipal { get; set; }
        public string CorrespondentAdjusterDescription1 { get; set; }
        public decimal? CorrespondentAdjusterAmount1 { get; set; }
        public string CorrespondentAdjusterDescription2 { get; set; }
        public decimal? CorrespondentAdjusterAmount2 { get; set; }
        public string CorrespondentAdjusterDescription3 { get; set; }
        public decimal? CorrespondentAdjusterAmount3 { get; set; }
        public decimal? CorrespondentFinalBuyPrice { get; set; }
        public decimal? CorrespondentPurchasedPrincipal { get; set; }
        public decimal? CorrespondentInterest { get; set; }
        public int? CorrespondentInterestDays { get; set; }
        public decimal? CorrespondentImpounds { get; set; }
        public decimal? CorrespondentFinalBuyAmount { get; set; }
        public decimal? CorrespondentSRPAmount { get; set; }
        public decimal? CorrespondentRemainingBuydownAmount { get; set; }
        public string CorrespondentReconcilationComments { get; set; }
        public string CorrespondentAdditionalLineDescription1 { get; set; }
        public decimal? CorrespondentAdditionalLineAmount1 { get; set; }
        public string CorrespondentAdditionalLineDescription2 { get; set; }
        public decimal? CorrespondentAdditionalLineAmount2 { get; set; }
        public string CorrespondentAdditionalLineDescription3 { get; set; }
        public decimal? CorrespondentAdditionalLineAmount3 { get; set; }
        public string CorrespondentAdditionalLineDescription4 { get; set; }
        public decimal? CorrespondentAdditionalLineAmount4 { get; set; }
        public string CorrespondentAdditionalLineDescription5 { get; set; }
        public decimal? CorrespondentAdditionalLineAmount5 { get; set; }
        public string CorrespondentAdditionalLineDescription6 { get; set; }
        public decimal? CorrespondentAdditionalLineAmount6 { get; set; }
        public string CorrespondentAdditionalLineDescription7 { get; set; }
        public decimal? CorrespondentAdditionalLineAmount7 { get; set; }
        public string CorrespondentAdditionalLineDescription8 { get; set; }
        public decimal? CorrespondentAdditionalLineAmount8 { get; set; }
        public string CorrespondentAdditionalLineDescription9 { get; set; }
        public decimal? CorrespondentAdditionalLineAmount9 { get; set; }
        public string CorrespondentAdditionalLineDescription10 { get; set; }
        public decimal? CorrespondentAdditionalLineAmount10 { get; set; }
        public string CorrespondentAdditionalLineDescription11 { get; set; }
        public decimal? CorrespondentAdditionalLineAmount11 { get; set; }
        public string CorrespondentAdditionalLineDescription12 { get; set; }
        public decimal? CorrespondentAdditionalLineAmount12 { get; set; }
        public decimal? CorrespondentAdditionalLineAmount13 { get; set; }
        public decimal? CorrespondentAdditionalLineTotalAmount { get; set; }
        public string CorrespondentConfirmedBy { get; set; }
        public DateTime? CorrespondentConfirmedDate { get; set; }
        public string CorrespondentWarehouseBankName { get; set; }
        public string CorrespondentWarehouseBankAcctNum { get; set; }
        public string CorrespondentWarehouseBankABANum { get; set; }
        public bool? CorrespondentWarehouseBankWireInstructionsReceivedIndicator { get; set; }
        public bool? CorrespondentWarehouseBankBaileeLetterReceivedIndicator { get; set; }
        public string CorrespondentWarehouseBankAddress { get; set; }
        public string CorrespondentWarehouseBankAddress1 { get; set; }
        public string CorrespondentWarehouseBankCity { get; set; }
        public string CorrespondentWarehouseBankState { get; set; }
        public string CorrespondentWarehouseBankZip { get; set; }
        public string CorrespondentWarehouseBankDescription { get; set; }
        public bool? CorrespondentWarehouseBankSelfFunderIndicator { get; set; }
        public bool? CorrespondentWarehouseBankBaileeLetterReqIndicator { get; set; }
        public DateTime? CorrespondentWarehouseBankBaileeExpirationDate { get; set; }
        public bool? CorrespondentWarehouseBankTriPartyContractIndicator { get; set; }
        public string CorrespondentWarehouseBankContactName { get; set; }
        public string CorrespondentWarehouseBankContactEmail { get; set; }
        public string CorrespondentWarehouseBankContactPhone { get; set; }
        public string CorrespondentWarehouseBankContactFax { get; set; }
        public string CorrespondentWarehouseBankNotes { get; set; }
        public bool? CorrespondentWarehouseBankUseDefaultContactIndicator { get; set; }
        public int? CorrespondentWarehouseBankId { get; set; }
        public decimal? RequestStartingAdjRate { get; set; }
        public decimal? BuySideStartingAdjRate { get; set; }
        public decimal? RequestStartingAdjPoint { get; set; }
        public decimal? BuySideStartingAdjPoint { get; set; }
        public bool? NoClosingCostOption { get; set; }
        public string BuySideCommitmentNumber { get; set; }
        public string BuySideMasterCommitmentNumber { get; set; }
        public string BuySideTPOName { get; set; }
        public string BuySideTPOID { get; set; }
        public string BuySideOrgID { get; set; }
        public DateTime? BuySideCommitmentDate { get; set; }
        public string BuySideCommitmentType { get; set; }
        public string BuySideDeliveryType { get; set; }
        public DateTime? BuySideExpirationDate { get; set; }
        public DateTime? BuySideDeliveryExpirationDate { get; set; }
        public string BuySideTradeGuid { get; set; }
        public string BuySideTradeNumber { get; set; }
        public decimal? CorrespondentLateFeePriceAdjustment { get; set; }
        public decimal? CorrespondentLateFeeAmount { get; set; }
        public string ONRPLock { get; set; }
        public string CreditScoreToUse { get; set; }
        public string PricingHistoryData { get; set; }
        public string Id { get; set; }
        public List<PriceAdjustment> PriceAdjustments { get; set; }
        public string Type { get; set; }
        public int? DaysToExtend { get; set; }
        public decimal? PriceAdjustment { get; set; }
        public string RateRequestStatus { get; set; }
        public decimal? BuySideStartingAdjPrice { get; set; }
        public int? CompSideDaystoExtend { get; set; }
        public DateTime? CompSideExtendedLockExpires { get; set; }
        public string CompSideInvestorStatus { get; set; }
        public DateTime? CompSideInvestorStatusDate { get; set; }
        public string CompSideInvestorTradeNumber { get; set; }
        public decimal? CompSideLockExtendPriceAdjustment { get; set; }
        public string CompSideMasterContractNumber { get; set; }
        public DateTime? CompSideOriginalLockExpires { get; set; }
        public string CompSideRequestedBy { get; set; }
        public string CompSideTradeGuid { get; set; }
        public string CompSideTradeNumber { get; set; }
        public decimal? CompGainLossTotalBuyPrice { get; set; }
        public string CompInvestorCommitment { get; set; }
        public string IsCancelled { get; set; }
        public string RateStatus { get; set; }
        public string RequestPending { get; set; }
        public string RequestType { get; set; }
        public string ExtensionRequestPending { get; set; }
        public string CancellationRequestPending { get; set; }
        public string ReLockRequestPending { get; set; }
    }
}