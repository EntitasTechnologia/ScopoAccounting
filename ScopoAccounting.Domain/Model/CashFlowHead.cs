using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScopoAccounting.Domain.Model
{
    public class CashFlowHead : BaseEntity
    {
        public int CashFlowID { get; set; }
        public string Description { get; set; }
        public byte? ParentCashFlowID { get; set; }
        public byte CFSParOrder { get; set; } // Not Clear
    }
}
