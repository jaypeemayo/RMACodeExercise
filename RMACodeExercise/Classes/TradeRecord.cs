using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMACodeExercise
{
    public class TradeRecord : ITradeRecord
    {
        public string SourceCurrency { get; set; }
        public string DestinationCurrency { get; set; }
        public float Lots { get; set; }
        public decimal Price { get; set; }
    }
}
