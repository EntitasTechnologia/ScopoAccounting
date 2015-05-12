using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScopoAccounting.Domain.Model
{
    public class VoucherDetailUnposted
    {
        public int TransactionKey { get; set; }
        public int SerialNo { get; set; }
        public int AccountKey { get; set; }
        public decimal DrCrAmount { get; set; }
        public Nullable<byte> CostCenterID { get; set; }
    }
}
