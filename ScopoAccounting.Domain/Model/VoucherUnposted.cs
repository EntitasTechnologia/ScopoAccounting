using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScopoAccounting.Domain.Model
{
    public class VoucherUnposted : BaseEntity
    {
        public int TransactionID { get; set; }
        public string TransactionNo { get; set; }
        public int BranchID { get; set; }
        public DateTime TransactionDate { get; set; }
        public DateTime ClearingDate { get; set; }
        public string GeneralParticular { get; set; }
        public bool IsCashVoucher { get; set; }
        public int ModuleCode { get; set; }
        public int TransactionCode { get; set; }
        public int? AdviceNoteKey { get; set; }
        public int BatchID { get; set; }
        public byte VoucherTypeID { get; set; }
    }
}
