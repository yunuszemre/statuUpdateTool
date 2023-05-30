using System;
using System.Collections.Generic;

namespace statuUpdateTool.Tms_Models
{
    public partial class AccountDecisionRule
    {
        public long AccountDecisionRuleId { get; set; }
        public long ClientId { get; set; }
        public long AccountId { get; set; }
        public long LocationId { get; set; }
        public long? CarrierId { get; set; }
        public long CountryId { get; set; }
        public long? CityId { get; set; }
        public long? TownId { get; set; }
        public long? DistrictId { get; set; }
        public string? ProductCode { get; set; }
        public long? PaymentTypeId { get; set; }
        public decimal? MinVolumetricWeight { get; set; }
        public decimal? MaxVolumetricWeight { get; set; }
        public string? ConsignmentSegment { get; set; }
        public bool? ConsignmentOversizeFlag { get; set; }
        public bool? ConsignmentSetupNeededFlag { get; set; }
        public long? CustomerId { get; set; }
        public string? CustomerSegment { get; set; }
        public long? Priority { get; set; }
        public long? CriteriaPriority { get; set; }
        public long? AddressDepth { get; set; }
        public long? CriteriaCount { get; set; }
        public DateTime CreatedDate { get; set; }
        public long CreateUserIdentityId { get; set; }
        public DateTime? ChangedDate { get; set; }
        public long? ChangeUserIdentityId { get; set; }
        public long RecordStatusId { get; set; }
        public byte[] RowVersion { get; set; } = null!;
        public bool IfTransferredToSecondary { get; set; }
        public bool? IfDiscountAllowed { get; set; }
        public decimal? MinTotalPrice { get; set; }
        public decimal? MaxTotalPrice { get; set; }
        public string? CustomerCode { get; set; }

        public virtual Account Account { get; set; } = null!;
        public virtual Carrier? Carrier { get; set; }
        public virtual City? City { get; set; }
        public virtual Client Client { get; set; } = null!;
        public virtual Country Country { get; set; } = null!;
        public virtual Customer? Customer { get; set; }
        public virtual District? District { get; set; }
        public virtual Location Location { get; set; } = null!;
        public virtual TypeLookup? PaymentType { get; set; }
        public virtual Town? Town { get; set; }
    }
}
