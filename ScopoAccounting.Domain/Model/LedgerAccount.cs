using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScopoAccounting.Domain.Model
{
    public class LedgerAccount : BaseEntity
    {
        public int AccountID { get; set; }
        public int ParentAccountID { get; set; }
        public string AccountNo { get; set; }
        public string AccountName { get; set; }
        public byte AccountType { get; set; }
        public string CurrencyCode { get; set; }
        public bool IsGlobalAccount { get; set; }
        public bool AutoEntryOnly { get; set; }
        public int? CashFlowID { get; set; }
        public byte CashTypeID { get; set; }
        public DateTime? CreationDate { get; set; } // Is it required because already have Setup Date
        public DateTime? ClosedDate { get; set; }
        public byte Status { get; set; } // Data Type: byte or bool
    }
}
