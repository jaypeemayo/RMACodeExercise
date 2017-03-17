using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMACodeExercise
{
    public class TradeParser : ITradeParser
    {
        private static float LotSize = 100000f;
        private ILoggingService loggingSevice;
        public TradeParser(ILoggingService loggingSevice)
        {
            this.loggingSevice = loggingSevice;
        }
        public IList<ITradeRecord> Parse(IList<string> lines)
        {
            #region parser
            var trades = new List<ITradeRecord>();
            var lineCount = 1;
            foreach (var line in lines)
            {

                var fields = line.Split(new char[] { ',' });

                if (fields.Length != 3)
                {
                    loggingSevice.Log($"WARN: Line {lineCount} malformed. Only {fields.Length} field(s) found.");
                    continue;
                }

                if (fields[0].Length != 6)
                {               
                    loggingSevice.Log($"WARN: Trade currencies on line {0} malformed: [{fields[0]}]");
                    continue;
                }

                int tradeAmount;
                if (!int.TryParse(fields[1], out tradeAmount))
                {          
                    loggingSevice.Log($"WARN: Trade amount on line {0} is not a valid integer: [{fields[1]}]");
                    continue;
                }

                if (tradeAmount < 0) //<--requested enhancement
                {
                    loggingSevice.Log($"WARN: Trade amount on line {0} is less than zero: [{fields[1]}]");
                    continue;
                }

                decimal tradePrice;
                if (!decimal.TryParse(fields[2], out tradePrice))
                {                
                    loggingSevice.Log($"WARN: Trade price on line {0} is not a valid decimal: [{fields[1]}]");
                    continue;
                }

                var sourceCurrencyCode = fields[0].Substring(0, 3);
                var destinationCurrencyCode = fields[0].Substring(3, 3);

                // Calculate values
                var trade = new TradeRecord
                {
                    SourceCurrency = sourceCurrencyCode,
                    DestinationCurrency = destinationCurrencyCode,
                    Lots = tradeAmount / LotSize,
                    Price = tradePrice
                };

                trades.Add(trade);

                lineCount++;
            }

            return trades;
            #endregion
        }
    }
}
