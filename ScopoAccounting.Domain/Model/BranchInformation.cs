using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScopoAccounting.Domain.Model
{
    public class BranchInformation
    {
        public int BranchKey { get; set; }
        public byte BranchTypeID { get; set; }
        public Nullable<int> ParentBranchKey { get; set; }
        public string BranchCode { get; set; }
        public string BranchName { get; set; }
        public System.DateTime SetupDate { get; set; }
        public int UserID { get; set; }
    }
}
