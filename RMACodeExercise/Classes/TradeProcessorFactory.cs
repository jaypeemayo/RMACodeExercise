using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMACodeExercise
{
    public class TradeProcessorFactory : ITradeProcessorFactory
    {
        //TODO: unity container is injected in the constructor
        public TradeProcessorFactory()//<--container as parameter
        {
            //TODO: for improvement, Unity container can be used for dependency injection.
        }
        public IFileReader GetFileReader()
        {
            //TODO: resolve intance using unity container
            return new FileReader();
        }

        public ITradeParser GetTradeParser()
        {
            //TODO: resolve intance using unity container
            return new TradeParser(new LoggingService());
        }

        public IDatabaseAccessor GetDatabaseAccessor()
        {
            //TODO: resolve intance using unity container
            return new DatabaseAccessor(new LoggingService());
        }
    }
}
