using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScopoAccounting.Domain.Model
{
    public class CostCenter : BaseEntity
    {
        public byte CostCenterID { get; set; }
        public string CostCenterName { get; set; }
        public bool Status { get; set; } // Data Type: byte or bool
    }
}
