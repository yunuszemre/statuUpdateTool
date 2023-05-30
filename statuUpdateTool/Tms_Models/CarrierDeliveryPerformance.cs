using System;
using System.Collections.Generic;

namespace statuUpdateTool.Tms_Models
{
    public partial class CarrierDeliveryPerformance
    {
        public long CarrierDeliveryPerformanceId { get; set; }
        public long? ClientId { get; set; }
        public long? AccountId { get; set; }
        public long? CarrierId { get; set; }
        public long? RecipientCityId { get; set; }
        public long? RecipientTownId { get; set; }
        public long? RecipientDistrictId { get; set; }
        public string? RecipientCity { get; set; }
        public string? RecipientTown { get; set; }
        public string? RecipientDistrict { get; set; }
        public long? SenderCityId { get; set; }
        public long? SenderTownId { get; set; }
        public long? SenderDistrictId { get; set; }
        public string? SenderCity { get; set; }
        public string? SenderTown { get; set; }
        public string? SenderDistrict { get; set; }
        public decimal? AverageDeliveryDay { get; set; }
        public decimal? AverageDeliveryRate { get; set; }
        public long? TotalSentShipment { get; set; }
        public long? TotalDeliveredShipment { get; set; }
        public long? TotalShipment { get; set; }
        public DateTime CreatedDate { get; set; }
        public long CreateUserIdentityId { get; set; }
        public DateTime? ChangedDate { get; set; }
        public long? ChangeUserIdentityId { get; set; }
        public long RecordStatusId { get; set; }
        public byte[] RowVersion { get; set; } = null!;
        public bool IfTransferredToSecondary { get; set; }
    }
}
