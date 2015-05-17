using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScopoAccounting.Domain.Model
{
    public class CurrencyInformation : BaseEntity
    {
        public string CurrencyCode { get; set; }
        public string CurrencyName { get; set; }
        public string CurrencySymbol { get; set; }
        public byte? BaseCurrencyType { get; set; } // Data Type: byte or bool
        public byte Status { get; set; } // Data Type: byte or bool
    }
}
