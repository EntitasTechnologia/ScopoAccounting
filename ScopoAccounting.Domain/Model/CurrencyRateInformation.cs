using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScopoAccounting.Domain.Model
{
    public class CurrencyRateInformation
    {
        public int SerialNo { get; set; }
        public string CurrencyCode { get; set; }
        public System.DateTime RateForDate { get; set; }
        public byte RateType { get; set; }
        public decimal BuyRate { get; set; }
        public decimal SaleRate { get; set; }
        public byte Status { get; set; }
        public System.DateTime SetupDate { get; set; }
        public int UserID { get; set; }
    }
}
