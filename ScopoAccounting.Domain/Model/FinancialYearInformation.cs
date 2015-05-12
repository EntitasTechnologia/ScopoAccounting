using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScopoAccounting.Domain.Model
{
    public class FinancialYearInformation
    {
        public int SerialNo { get; set; }
        public System.DateTime FinancialYearStartDate { get; set; }
        public System.DateTime FinancialYearEndDate { get; set; }
    }
}
