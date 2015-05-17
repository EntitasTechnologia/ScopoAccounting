using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScopoAccounting.Domain.Model
{
    public class ParentAccount : BaseEntity
    {
        public int AccountID { get; set; }
        public int ParentAccountID { get; set; }
        public string AccountNo { get; set; }
        public string AccountName { get; set; }
        public byte AccountType { get; set; }
        public DateTime CreationDate { get; set; }
        public byte Status { get; set; } // Data Type: byte or bool
    }
}
