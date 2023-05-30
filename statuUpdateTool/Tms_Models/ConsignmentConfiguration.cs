using System;
using System.Collections.Generic;

namespace statuUpdateTool.Tms_Models
{
    public partial class ConsignmentConfiguration
    {
        public long ConsignmentConfigurationId { get; set; }
        public long ClientId { get; set; }
        public long AccountId { get; set; }
        public bool? CheckIfPrintOnlyOfflineLabel { get; set; }
        public long? DefaultCarrierId { get; set; }
        public bool? CheckIfCommonLabelIsUsing { get; set; }
        public bool? AlwaysUseCarrierOnConsignment { get; set; }
        public bool? IfNotNullUseConsignmentCarrier { get; set; }
        public bool? AlwaysUseDefaultCarrier { get; set; }
        public bool? IfNotNullUseConsignmentCarrierElseDecide { get; set; }
        public bool? AlwaysDecideCarrier { get; set; }
        public long? PlannedConsignmentBusinessRuleId { get; set; }
        public long? DefaultLocationId { get; set; }
        public long? AddressMappingId { get; set; }
        public bool? IsCustomizedTrackingPageUsed { get; set; }
        public DateTime CreatedDate { get; set; }
        public long CreateUserIdentityId { get; set; }
        public DateTime? ChangedDate { get; set; }
        public long? ChangeUserIdentityId { get; set; }
        public long RecordStatusId { get; set; }
        public byte[] RowVersion { get; set; } = null!;
        public bool IfTransferredToSecondary { get; set; }
        public string? ReturnCodePrefix { get; set; }
        public long? ReturnCodeStartNumber { get; set; }
        public string? ReturnPageClientLogoUrl { get; set; }
        public long? ReturnDefaultCarrierId { get; set; }
        public string? OmsApiUsername { get; set; }
        public string? OmsApiPassword { get; set; }
        public decimal? PerformanceRatio { get; set; }
        public decimal? PriceRatio { get; set; }
        public bool? IsMeasuredByPriceAndPerformance { get; set; }
        public bool? IsOpenPerformanceJob { get; set; }
        public bool? IsOpenPatternJob { get; set; }
        public bool? IsRuleBasedRoutingMode { get; set; }
        public bool? IsSystemRecommendationMode { get; set; }
        public bool? IfNoRuleBasedRoutingModeRunSystemRecommendationMode { get; set; }
        public bool? ShouldApprovalBeObtainedForDelivery { get; set; }
        public string? DeliveryReceiptTemplate { get; set; }

        public virtual Account Account { get; set; } = null!;
        public virtual Client Client { get; set; } = null!;
        public virtual Carrier? DefaultCarrier { get; set; }
    }
}
