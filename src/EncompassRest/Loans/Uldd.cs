using System;
using System.Collections.Generic;

namespace EncompassRest.Loans
{
    public sealed class Uldd
    {
        public decimal? UPBAmount { get; set; }
        public bool? AdditionalPrincipalAmountIndicator { get; set; }
        public decimal? AggregateLoanCurtailmentAmount { get; set; }
        public bool? MortgageModificationIndicator { get; set; }
        public DateTime? LoanModificationEffectiveDate { get; set; }
        public int? InitialFixedPeriodEffectiveMonthsCount { get; set; }
        public bool? CapitalizedLoanIndicator { get; set; }
        public bool? RelocationLoanIndicator { get; set; }
        public bool? SharedEquityIndicator { get; set; }
        public int? InterestAndPaymentAdjustmentIndexLeadDaysCount { get; set; }
        public string InterestCalculationType { get; set; }
        public string InterestAccrualType { get; set; }
        public string InterestCalculationBasisType { get; set; }
        public int? InterestCalculationEffectiveMonthsCount { get; set; }
        public decimal? CurrentAccruedInterestAmount { get; set; }
        public DateTime? LoanInterestAccrualStartDate { get; set; }
        public DateTime? PriceLockDatetime { get; set; }
        public string RefinanceCashOutDeterminationType { get; set; }
        public int? LoanAmortizationMaximumTermMonthsCount { get; set; }
        public string SellerLoanIdentifier { get; set; }
        public string FNMHomeImprovementProductType { get; set; }
        public string CounselingFormatType { get; set; }
        public string CounselingFormatTypeOtherDescription { get; set; }
        public bool? BorrowerMailToAddressSameasPropertyIndicator { get; set; }
        public string CountryCode { get; set; }
        public string CondominiumProjectStatusType { get; set; }
        public string PropertyValuationMethodType { get; set; }
        public DateTime? PropertyValuationEffectiveDate { get; set; }
        public string AppraisalIdentifier { get; set; }
        public string AVMModelNameType { get; set; }
        public bool? MortgageBackedSecurityIndicator { get; set; }
        public bool? MBSWeightedMarginIndicator { get; set; }
        public string InvestorProductPlanIdentifier { get; set; }
        public string InvestorFeatureIdentifier { get; set; }
        public string InvestorCommitmentIdentifier { get; set; }
        public string InvestorCollateralProgramIdentifier { get; set; }
        public decimal? GuarantyFeePercent { get; set; }
        public decimal? BaseGuarantyFeePercent { get; set; }
        public decimal? GuarantyFeeAfterAlternatePaymentMethodPercent { get; set; }
        public decimal? LoanAcquisitionScheduledUPBAmount { get; set; }
        public decimal? InvestorOwnershipPercent { get; set; }
        public string InvestorRemittanceType { get; set; }
        public int? InvestorRemittanceDay { get; set; }
        public string RelatedLoanInvestorType { get; set; }
        public string LoanDefaultLossPartyType { get; set; }
        public string REOMarketingPartyType { get; set; }
        public string MIPremiumSourceType { get; set; }
        public decimal? LenderPaidMIInterestRateAdjustmentPercent { get; set; }
        public string PrimaryMIAbsenceReasonType { get; set; }
        public string PrimaryMIAbsenceReasonTypeOtherDescription { get; set; }
        public DateTime? LastPaymentReceivedDate { get; set; }
        public DateTime? LastPaidInstallmentDueDate { get; set; }
        public int? PaymentBillingStatementLeadDaysCount { get; set; }
        public int? DelinquentPaymentsOverPastTwelveMonthsCount { get; set; }
        public decimal? PerChangePrincipalAndInterestPaymentAdjustmentPercent { get; set; }
        public DateTime? PerChangeRateAdjustmentEffectiveDate { get; set; }
        public int? PerChangeRateAdjustmentFrequencyMonthsCount { get; set; }
        public decimal? PerChangeMaximumDecreaseRatePercent { get; set; }
        public decimal? PerChangeMaximumIncreaseRatePercent { get; set; }
        public DateTime? NextRateAdjustmentEffectiveDate { get; set; }
        public string ConstructionToPermanentClosingFeatureType { get; set; }
        public string ConstructionToPermanentClosingType { get; set; }
        public string PoolIdentifier { get; set; }
        public string PoolAmortizationType { get; set; }
        public string PoolInvestorProductPlanIdentifier { get; set; }
        public DateTime? PoolIssueDate { get; set; }
        public string PoolMortgageType { get; set; }
        public string PoolStructureType { get; set; }
        public string PoolSuffixIdentifier { get; set; }
        public string PoolAccrualRateStructureType { get; set; }
        public decimal? PoolSecurityIssueDateInterestRatePercent { get; set; }
        public decimal? PoolMinimumAccrualRatePercent { get; set; }
        public decimal? PoolMaximumAccrualRatePercent { get; set; }
        public decimal? PoolMarginRatePercent { get; set; }
        public string PoolInterestRateRoundingType { get; set; }
        public decimal? PoolInterestRateRoundingPercent { get; set; }
        public bool? PoolInterestOnlyIndicator { get; set; }
        public int? PoolInterestAndPaymentAdjustmentIndexLeadDaysCount { get; set; }
        public int? PoolInterestAdjustmentIndexLeadDaysCount { get; set; }
        public bool? PoolAssumabilityIndicator { get; set; }
        public bool? PoolBalloonIndicator { get; set; }
        public decimal? PoolFixedServicingFeePercent { get; set; }
        public int? PoolScheduledRemittancePaymentDay { get; set; }
        public DateTime? SecurityTradeBookEntryDate { get; set; }
        public DateTime? LoanStateDate { get; set; }
        public string DownPaymentSourceType { get; set; }
        public string DownPaymentSourceTypeOtherDescription { get; set; }
        public string ConvertibleStatusType { get; set; }
        public DateTime? LatestConversionEffectiveDate { get; set; }
        public string ServicerLoanIdentifier { get; set; }
        public string FreddieInvestorCollateralProgramIdentifier { get; set; }
        public bool? GuaranteeFeeAddOnIndicator { get; set; }
        public string LoanBuyupBuydownType { get; set; }
        public int? LoanBuyupBuydownBasisPointNumber { get; set; }
        public string FreddieRelatedLoanInvestorType { get; set; }
        public bool? LoanDeliveredThroughServicingReleasedProcessIndicator { get; set; }
        public int? LoanLevelCreditScoreValue { get; set; }
        public string LoanLevelCreditScoreSelectionMethodType { get; set; }
        public bool? LoanLevelCreditScoreSelectionMethodSellerSpecificIndicator { get; set; }
        public string CreditScoreImpairmentType { get; set; }
        public decimal? ClosingCostContributionAmount { get; set; }
        public string ClosingCostFundsType { get; set; }
        public string ClosingCostFundsTypeOtherDescription { get; set; }
        public string ClosingCostSourceType { get; set; }
        public string ClosingCostSourceTypeOtherDescription { get; set; }
        public decimal? ClosingCost2ContributionAmount { get; set; }
        public string ClosingCost2FundsType { get; set; }
        public string ClosingCost2FundsTypeOtherDescription { get; set; }
        public string ClosingCost2SourceType { get; set; }
        public string ClosingCost2SourceTypeOtherDescription { get; set; }
        public decimal? ClosingCost3ContributionAmount { get; set; }
        public string ClosingCost3FundsType { get; set; }
        public string ClosingCost3FundsTypeOtherDescription { get; set; }
        public string ClosingCost3SourceType { get; set; }
        public string ClosingCost3SourceTypeOtherDescription { get; set; }
        public decimal? ClosingCost4ContributionAmount { get; set; }
        public string ClosingCost4FundsType { get; set; }
        public string ClosingCost4FundsTypeOtherDescription { get; set; }
        public string ClosingCost4SourceType { get; set; }
        public string ClosingCost4SourceTypeOtherDescription { get; set; }
        public decimal? OtherFundsCollectedAtClosingAmount { get; set; }
        public string OtherFundsCollectedAtClosingType { get; set; }
        public DateTime? RelatedLoanStateDateAtClosing { get; set; }
        public string DownPaymentOtherTypeDescription { get; set; }
        public string DocumentCustodianID { get; set; }
        public string InvestorFeatureIdPool { get; set; }
        public string ServicerID { get; set; }
        public string PayeeID { get; set; }
        public decimal? RelatedLoanUnpaidPrincipalBalanceAmount { get; set; }
        public string FreddieLegalEntityType { get; set; }
        public string FannieLegalEntityType { get; set; }
        public string FreddieLegalEntityTypeOther { get; set; }
        public string FannieLegalEntityTypeOther { get; set; }
        public string FreddieBorrowerAlienStatus { get; set; }
        public bool? MultipleConcurrentlyClosingLienOnSubjectPropertyIndicator { get; set; }
        public bool? SecondLienIsDeliveredIndicator { get; set; }
        public bool? RelatedLoanIndicator { get; set; }
        public string FreddieRelatedLoanType { get; set; }
        public string FannieRelatedLoanType { get; set; }
        public string FannieRefinanceType { get; set; }
        public string FreddieRefinanceType { get; set; }
        public string FannieRelatedLoanAmortizationType { get; set; }
        public bool? RelatedLoanHELOCIndicator { get; set; }
        public DateTime? LendersDeliveryDate { get; set; }
        public string MICompanyNameType { get; set; }
        public string FreddieMICompanyNameTypeOther { get; set; }
        public string FannieMICompanyNameTypeOther { get; set; }
        public string FannieBuydownContributer { get; set; }
        public int? NumberOfUnitsSold { get; set; }
        public int? FinancedUnitCount { get; set; }
        public string ProjectDesignType { get; set; }
        public string FreddieProjectClassificationType { get; set; }
        public string FannieProjectClassificationType { get; set; }
        public string ProjectAttachmentType { get; set; }
        public bool? SiteBuiltIndicator { get; set; }
        public string FreddieRelatedLoanLienPosition { get; set; }
        public string FannieRelatedLoanLienPosition { get; set; }
        public string FreddieCoBorrowerAlienStatus { get; set; }
        public string FreddieUnderwritingTypeOther { get; set; }
        public string BorrowerType { get; set; }
        public string CoBorrowerType { get; set; }
        public string CounselTypeOther { get; set; }
        public string FreddieLoanTypePublicAndIndianHousingIndicator { get; set; }
        public bool? CoBorrowerMailToAddressSameasPropertyIndicator { get; set; }
        public string CoBorrowerCountryCode { get; set; }
        public string PoolDocumentCustodianID { get; set; }
        public string PoolSellerID { get; set; }
        public string PoolServicerID { get; set; }
        public bool? BalloonResetIndicator { get; set; }
        public int? Unit2TotalBedrooms { get; set; }
        public decimal? Unit2SubjectPropertyGrossRentalIncome { get; set; }
        public int? Unit3TotalBedrooms { get; set; }
        public decimal? Unit3SubjectPropertyGrossRentalIncome { get; set; }
        public int? Unit4TotalBedrooms { get; set; }
        public decimal? Unit4SubjectPropertyGrossRentalIncome { get; set; }
        public DateTime? SubsequentPerChangeRateAdjustmentEffectiveDate { get; set; }
        public int? SubsequentPerChangeRateAdjustmentFrequencyMonthsCount { get; set; }
        public decimal? SubsequentPerChangeMaximumDecreaseRatePercent { get; set; }
        public decimal? SubsequentPerChangeMaximumIncreaseRatePercent { get; set; }
        public int? Unit1TotalBedrooms { get; set; }
        public decimal? Unit1SubjectPropertyGrossRentalIncome { get; set; }
        public int? FannieCLTV { get; set; }
        public int? FannieHCLTV { get; set; }
        public decimal? FannieRateSpread { get; set; }
        public int? FannieLTV { get; set; }
        public int? FannieTLTV { get; set; }
        public int? FannieInvestorOwnershipPercent { get; set; }
        public decimal? FannieLenderPaidMIInterestRateAdjustmentPercent { get; set; }
        public int? FannieMICoveragePercent { get; set; }
        public string FannieBorrowerFirstName { get; set; }
        public string FannieBorrowerMiddleName { get; set; }
        public string FannieCoBorrowerFirstName { get; set; }
        public string FannieCoBorrowerMiddleName { get; set; }
        public string FannieTrustName { get; set; }
        public int? FanniePoolOwnershipPercent { get; set; }
        public string FannieAutoUWDec { get; set; }
        public string FreddieAutoUWDec { get; set; }
        public string FannnieMortgageType { get; set; }
        public string FreddieMortgageType { get; set; }
        public string ConstructionMethodType { get; set; }
        public int? RelatedLoanMaturityPeriodCount { get; set; }
        public DateTime? RelatedLoanScheduledFirstPaymentDate { get; set; }
        public bool? RelatedLoanBalloonIndicator { get; set; }
        public int? ProjectUnitCount { get; set; }
        public string AttachmentType { get; set; }
        public bool? SpecialFloodHazardAreaIndicator { get; set; }
        public string FannieLoanProgramIdentifier { get; set; }
        public string FreddieLoanProgramIdentifier { get; set; }
        public string FreddieInvestorFeatureIdentifier { get; set; }
        public string FreddieRefinanceCashOutDeterminationType { get; set; }
        public bool? TemporaryBuydownIndicator { get; set; }
        public string GSEProjectType { get; set; }
        public DateTime? RelatedLoanNoteDate { get; set; }
        public string FreddieExplanationOfDownPayment { get; set; }
        public string FreddieRelatedInvestorLoanID { get; set; }
        public string FannieRelatedInvestorLoanID { get; set; }
        public string FreddieDownPaymentType { get; set; }
        public bool? FreddieRelatedClosedEndSecondIndicator { get; set; }
        public string FreddieDownPmt2SourceType { get; set; }
        public string FreddieDownPmt2SourceTypeExpl { get; set; }
        public string FreddieDownPmt2Type { get; set; }
        public string FreddieDownPmt2TypeExpl { get; set; }
        public decimal? FreddieDownPmt3Amt { get; set; }
        public string FreddieDownPmt3SourceType { get; set; }
        public string FreddieDownPmt3SourceTypeExpl { get; set; }
        public string FreddieDownPmt3Type { get; set; }
        public string FreddieDownPmt3TypeExpl { get; set; }
        public decimal? FreddieDownPmt4Amt { get; set; }
        public string FreddieDownPmt4SourceType { get; set; }
        public string FreddieDownPmt4SourceTypeExpl { get; set; }
        public string FreddieDownPmt4Type { get; set; }
        public string FreddieDownPmt4TypeExpl { get; set; }
        public string FannieARMIndexType { get; set; }
        public string FreddieARMIndexType { get; set; }
        public string FreddieAVMModelNameTypeExpl { get; set; }
        public string NotePayToName { get; set; }
        public DateTime? FirstRateChangePaymentEffectiveDate { get; set; }
        public int? FannieBLTV { get; set; }
        public string GinnieConstructionMethodType { get; set; }
        public string GinnieOtherConstructionMethodType { get; set; }
        public string FannieFloodSpecialFeatureCode { get; set; }
        public string ManufacturedHomeWidthType { get; set; }
        public string LoanIdentifierValueType { get; set; }
        public int? TotalMortgagedPropertiesCount { get; set; }
        public string FreddiePropertyFormType { get; set; }
        public string FanniePropertyFormType { get; set; }
        public string FannieCreditScoreProviderName { get; set; }
        public string FreddieCreditScoreProviderName { get; set; }
        public decimal? RefinanceCashOutAmount { get; set; }
        public string FannieSectionOfAct { get; set; }
        public string FreddieSectionOfAct { get; set; }
        public string GovernmentRefinanceType { get; set; }
        public decimal? GovernmentAnnualPremiumPercent { get; set; }
        public decimal? GovernmentUpfrontPremiumAmount { get; set; }
        public decimal? GovernmentUpfrontPremiumPercent { get; set; }
        public decimal? GuarantyPercent { get; set; }
        public string ConstructionMethodTypeOtherDescription { get; set; }
        public string ACHBankAccountPurposeType { get; set; }
        public string ACHABARoutingAndTransitNumber { get; set; }
        public string ACHABARoutingAndTransitIdentifier { get; set; }
        public string ACHBankAccountIdentifier { get; set; }
        public string ACHBankAccountPurposeTransitIdentifier { get; set; }
        public string ACHInstitutionTelegraphicAbbreviationName { get; set; }
        public string ACHReceiverSubaccountName { get; set; }
        public string ACHBankAccountDescription { get; set; }
        public string MortgageProgramType { get; set; }
        public string MERSOriginalMortgageeOfRecordIndicator { get; set; }
        public string MortgageOriginator { get; set; }
        public DateTime? MonetaryEventAppliedDate { get; set; }
        public decimal? MonetaryEventGrossPrincipalAmount { get; set; }
        public string MonetaryEventType { get; set; }
        public string IndexType { get; set; }
        public string DownPaymentFundsType { get; set; }
        public string OtherDownPaymentFundsType { get; set; }
        public string IssuerIdentifier { get; set; }
        public string PoolIssuerTransferee { get; set; }
        public DateTime? PoolCertificatePaymentDate { get; set; }
        public string BondFinancePool { get; set; }
        public string BondFinanceProgramType { get; set; }
        public string BondFinanceProgramName { get; set; }
        public string PoolClassType { get; set; }
        public string PoolConcurrentTransferIndicator { get; set; }
        public int? PoolCurrentLoanCount { get; set; }
        public decimal? PoolCurrentPrincipalBalanceAmount { get; set; }
        public string PoolingMethodType { get; set; }
        public DateTime? PoolInterestAdjustmentEffectiveDate { get; set; }
        public DateTime? PoolMaturityDate { get; set; }
        public int? PoolMaturityPeriodCount { get; set; }
        public string DocumentSubmissionIndicator { get; set; }
        public string DocumentRequiredIndicator { get; set; }
        public string CertificateType { get; set; }
        public string CertificateIdentifier { get; set; }
        public DateTime? CertificateMaturityDate { get; set; }
        public decimal? CertificatePrincipalBalanceAmount { get; set; }
        public decimal? SecurityOriginalSubscriptionAmount { get; set; }
        public decimal? GinnieGovernmentAnnualPremiumAmount { get; set; }
        public string GinnieMortgageType { get; set; }
        public string Id { get; set; }
        public string SellerID { get; set; }
    }
}