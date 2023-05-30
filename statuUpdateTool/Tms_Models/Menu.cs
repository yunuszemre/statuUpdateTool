using System;
using System.Collections.Generic;

namespace statuUpdateTool.Tms_Models
{
    public partial class Menu
    {
        public Menu()
        {
            InverseParentMenu = new HashSet<Menu>();
        }

        public long MenuId { get; set; }
        public long? ParentMenuId { get; set; }
        public string? Code { get; set; }
        public string Description { get; set; } = null!;
        public long? TypeLookupId { get; set; }
        public int? MenuViewOrder { get; set; }
        public string? Path { get; set; }
        public string? Icon { get; set; }
        public DateTime CreatedDate { get; set; }
        public long CreateUserIdentityId { get; set; }
        public DateTime? ChangedDate { get; set; }
        public long? ChangeUserIdentityId { get; set; }
        public long RecordStatusId { get; set; }
        public byte[] RowVersion { get; set; } = null!;
        public bool IfTransferredToSecondary { get; set; }

        public virtual Menu? ParentMenu { get; set; }
        public virtual ICollection<Menu> InverseParentMenu { get; set; }
    }
}
