using System;
using System.Collections.Generic;

namespace statuUpdateTool.Tms_Models
{
    public partial class LocationCarrierConfiguration
    {
        public LocationCarrierConfiguration()
        {
            AccountCarrierPlannedShipmentConfigurations = new HashSet<AccountCarrierPlannedShipmentConfiguration>();
        }

        public long LocationCarrierConfigurationId { get; set; }
        public long ClientId { get; set; }
        public long AccountId { get; set; }
        public long LocationId { get; set; }
        public long? CarrierId { get; set; }
        public int? Priority { get; set; }
        public int? SystemPriority { get; set; }
        public long? PaymentTypeId { get; set; }
        public string? UserName { get; set; }
        public string? Password { get; set; }
        public string? CustomerCode { get; set; }
        public string? ApiKey { get; set; }
        public string? CommonLabelUserName { get; set; }
        public string? CommonLabelUserPassword { get; set; }
        public string? SenderCustomerId { get; set; }
        public string? SenderCustomerAddressId { get; set; }
        public bool? PrintEdespatchOnLabel { get; set; }
        public bool? PutQrcodeOnLabelForEdespatch { get; set; }
        public bool? CheckIfPasswordIsMandatoryForQrcodeOnLabel { get; set; }
        public bool? CheckIfUsingStatusTracking { get; set; }
        public bool? SendToCarrierIfRmaAvailable { get; set; }
        public string? TextForLabel { get; set; }
        public long? MaxCarrierQuota { get; set; }
        public long? MaxCarrierLabelQuota { get; set; }
        public bool? IfControlMaxCarrierQuota { get; set; }
        public long? MinCarrierQuota { get; set; }
        public bool? IfControlMinCarrierQuota { get; set; }
        public bool? IsActive { get; set; }
        public bool? IfRmaCodeSend { get; set; }
        public string? RmaServiceUserName { get; set; }
        public string? RmaServicePassword { get; set; }
        public long? RmacodeUsageLimit { get; set; }
        public string? CustomerPrefix1 { get; set; }
        public string? CustomerPrefix2 { get; set; }
        public decimal? MinWidth { get; set; }
        public decimal? MaxWidth { get; set; }
        public decimal? MinLength { get; set; }
        public decimal? MaxLength { get; set; }
        public decimal? MinHeight { get; set; }
        public decimal? MaxHeight { get; set; }
        public decimal? MinWeight { get; set; }
        public decimal? MaxWeight { get; set; }
        public long? AccountLocationWorkingScheduleGroupId { get; set; }
        public bool? UseDefaultAccountLocationWorkingSchedule { get; set; }
        public bool? IfNotDecidable { get; set; }
        public DateTime CreatedDate { get; set; }
        public long CreateUserIdentityId { get; set; }
        public DateTime? ChangedDate { get; set; }
        public long? ChangeUserIdentityId { get; set; }
        public long RecordStatusId { get; set; }
        public byte[] RowVersion { get; set; } = null!;
        public long? CurrentCarrierLabelQuota { get; set; }
        public long? CurrentCarrierQuota { get; set; }
        public long? MinCarrierLabelQuota { get; set; }
        public bool IfTransferredToSecondary { get; set; }
        public string? MarketPlaceCustomerToCustomerServiceUserName { get; set; }
        public string? MarketPlaceCustomerToCustomerServicePassword { get; set; }
        public long? MarketPlaceCustomerToCustomerCodeUsegaLimit { get; set; }
        public bool? IfDiscountAllowed { get; set; }
        public bool? CheckCarrierIfPrintOnlyOfflineLabel { get; set; }
        public bool? AdditionalZplisActive { get; set; }
        public string? AdditionalZpltemplate { get; set; }
        public bool? AdditionalZplisUseAsDefault { get; set; }
        public string? EwaybillTemplateOnLabel { get; set; }
        public bool? EwaybillActiveOnLabel { get; set; }
        public bool? CalculatePriceFromPackageTotalDesi { get; set; }
        public bool? IsExtraSettingActive { get; set; }
        public string? ExtraSettingValue1 { get; set; }
        public string? ExtraSettingValue2 { get; set; }

        public virtual Account Account { get; set; } = null!;
        public virtual Client Client { get; set; } = null!;
        public virtual Location Location { get; set; } = null!;
        public virtual TypeLookup? PaymentType { get; set; }
        public virtual ICollection<AccountCarrierPlannedShipmentConfiguration> AccountCarrierPlannedShipmentConfigurations { get; set; }
    }
}
