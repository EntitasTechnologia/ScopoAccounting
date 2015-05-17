using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScopoAccounting.Domain.Model
{
    public class BaseEntity
    {
        public DateTime SetupDate { get; set; }
        public int UserID { get; set; }
    }
}
