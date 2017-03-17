using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMACodeExercise
{
    class Program
    {
        static void Main(string[] args)
        {

            ITradeProcessor tradeProcessor = new TradeProcessor(new TradeProcessorFactory()); //TODO: resolve dependecy using unity.
        }
    }
}
