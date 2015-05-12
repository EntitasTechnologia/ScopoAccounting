using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScopoAccounting.Domain.Model
{
    public class AccSysVoucherTypeID
    {
        public byte VoucherTypeID { get; set; }
        public string TypeDescription { get; set; }
        public Nullable<bool> IsManual { get; set; }
    }
}
