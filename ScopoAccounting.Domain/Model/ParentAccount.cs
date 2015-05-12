using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScopoAccounting.Domain.Model
{
    public class ParentAccount
    {
        public int AccountKey { get; set; }
        public int ParentAccountKey { get; set; }
        public string AccountNo { get; set; }
        public string AccountName { get; set; }
        public byte AccountType { get; set; }
        public System.DateTime CreationDate { get; set; }
        public byte Status { get; set; }
        public System.DateTime SetupDate { get; set; }
        public int UserID { get; set; }
    }
}
