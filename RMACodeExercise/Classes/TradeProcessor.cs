

using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMACodeExercise
{
   
    public class TradeProcessor:ITradeProcessor
    {
        IFileReader fileReader;
        ITradeParser tradeParser;
        IDatabaseAccessor databaseAccessor;


        public TradeProcessor(ITradeProcessorFactory tradeProcessorFactory)
        {
            this.fileReader = tradeProcessorFactory.GetFileReader();
            this.tradeParser = tradeProcessorFactory.GetTradeParser();
            this.databaseAccessor = tradeProcessorFactory.GetDatabaseAccessor();
        }
        public void ProcessTrades(Stream stream)
        {
            IList<string> lines = this.fileReader.Read(stream);
            IList<ITradeRecord> trades = this.tradeParser.Parse(lines);
            this.databaseAccessor.Save(trades);
        }
    }


   
  

   

    


  



 

    

 
}
