using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScopoAccounting.Domain.Model
{
    public class AccountingPolicy : BaseEntity
    {
        public byte CashFlowMethod { get; set; }
        public byte FinancialYearStartMonth { get; set; }
        public byte FinancialYearInMonth { get; set; }
        public int? YearClosingAccountKey { get; set; }
    }
}
