using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScopoAccounting.Domain.Model
{
    public class VoucherDetailUnposted
    {
        public int TransactionID { get; set; }
        public int SerialNo { get; set; }
        public int AccountID { get; set; }
        public decimal DrCrAmount { get; set; }
        public byte? CostCenterID { get; set; }
    }
}
