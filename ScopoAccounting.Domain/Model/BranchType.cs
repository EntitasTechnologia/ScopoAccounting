using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScopoAccounting.Domain.Model
{
    public class BranchType
    {
        public byte BranchTypeID { get; set; }
        public string BranchTypeName { get; set; }
        public byte? ParentBranchTypeID { get; set; }
    }
}
