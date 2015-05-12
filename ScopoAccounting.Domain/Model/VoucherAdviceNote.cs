using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScopoAccounting.Domain.Model
{
    public class VoucherAdviceNote
    {
        public int AdviceNoteKey { get; set; }
        public string AdviceNoteReferance { get; set; }
        public string AdviceNote { get; set; }
        public string ToBranchCode { get; set; }
    }
}
