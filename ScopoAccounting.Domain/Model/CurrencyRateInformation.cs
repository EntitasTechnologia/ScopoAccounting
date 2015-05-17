using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScopoAccounting.Domain.Model
{
    public class CurrencyRateInformation : BaseEntity
    {
        public int SerialNo { get; set; }
        public string CurrencyCode { get; set; }
        public DateTime RateForDate { get; set; }
        public byte RateType { get; set; }
        public decimal BuyRate { get; set; }
        public decimal SaleRate { get; set; }
        public byte Status { get; set; } // Data Type: byte or bool
    }
}
