using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScopoAccounting.Domain.Model
{
    public class VoucherType
    {
        public byte VoucherTypeID { get; set; }
        public string TypeDescription { get; set; }
        public bool? IsManual { get; set; }
    }
}
