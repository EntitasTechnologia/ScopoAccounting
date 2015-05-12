using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScopoAccounting.Domain.Model
{
    public class CostCenter
    {
        public byte CostCenterID { get; set; }
        public string CostCenterName { get; set; }
        public Nullable<bool> Status { get; set; }
        public System.DateTime SetupDate { get; set; }
        public int UserID { get; set; }
    }
}
