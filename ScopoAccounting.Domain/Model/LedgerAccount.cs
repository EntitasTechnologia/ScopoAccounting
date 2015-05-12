using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScopoAccounting.Domain.Model
{
    public class LedgerAccount
    {
        public int AccountKey { get; set; }
        public int ParentAccountKey { get; set; }
        public string AccountNo { get; set; }
        public string AccountName { get; set; }
        public byte AccountType { get; set; }
        public string CurrencyCode { get; set; }
        public bool IsGlobalAccount { get; set; }
        public bool AutoEntryOnly { get; set; }
        public Nullable<int> CashFlowID { get; set; }
        public byte CashTypeID { get; set; }
        public Nullable<System.DateTime> CreationDate { get; set; }
        public Nullable<System.DateTime> ClosedDate { get; set; }
        public byte Status { get; set; }
        public System.DateTime SetupDate { get; set; }
        public int UserID { get; set; }
    }
}
