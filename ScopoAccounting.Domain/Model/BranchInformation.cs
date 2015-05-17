using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScopoAccounting.Domain.Model
{
    public class BranchInformation : BaseEntity
    {
        public int BranchID { get; set; }
        public byte BranchTypeID { get; set; }
        public int? ParentBranchID { get; set; }
        public string BranchCode { get; set; }
        public string BranchName { get; set; }
    }
}
