using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScopoAccounting.Domain.Model
{
    public class VoucherDeleted
    {
        public int TransactionKey { get; set; }
        public string TransactionID { get; set; }
        public int BranchKey { get; set; }
        public System.DateTime TransactionDate { get; set; }
        public System.DateTime ClearingDate { get; set; }
        public string GeneralParticular { get; set; }
        public bool IsCashVoucher { get; set; }
        public int ModuleCode { get; set; }
        public int TransactionCode { get; set; }
        public Nullable<int> AdviceNoteKey { get; set; }
        public int BatchID { get; set; }
        public byte VoucherTypeID { get; set; }
        public System.DateTime SetupDate { get; set; }
        public int UserID { get; set; }
    }
}
