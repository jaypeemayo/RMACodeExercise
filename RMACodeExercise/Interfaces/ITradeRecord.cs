using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMACodeExercise
{
    public interface ITradeRecord
    {
        string SourceCurrency { get; set; }
        string DestinationCurrency { get; set; }
        float Lots { get; set; }
        decimal Price { get; set; }
    }
}
