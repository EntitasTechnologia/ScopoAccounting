using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScopoAccounting.Domain.Model
{
    public class CashFlowHead
    {
        public int CashFlowID { get; set; }
        public string Description { get; set; }
        public byte? ParentCashFlowID { get; set; }
        public byte CFSParOrder { get; set; }
        public DateTime SetupDate { get; set; }
        public int UserID { get; set; }
    }
}
