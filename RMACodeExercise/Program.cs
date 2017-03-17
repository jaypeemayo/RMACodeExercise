using Microsoft.Practices.Unity;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMACodeExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            IUnityContainer unitycontainer = new UnityContainer();
            unitycontainer.RegisterType<ILoggingService, LoggingService>();
            unitycontainer.RegisterType<IFileReader, FileReader>();
            unitycontainer.RegisterType<ITradeParser, TradeParser>();
            unitycontainer.RegisterType<IDatabaseAccessor, DatabaseAccessor>();
            unitycontainer.RegisterType<ITradeProcessorFactory, TradeProcessorFactory>();

            ITradeProcessor tradeProcessor = unitycontainer.Resolve<TradeProcessor>();

            using (var test_Stream = new MemoryStream(Encoding.UTF8.GetBytes("PHPAUD,32,1 \nAUDPHP,1,32 \n"))) //<--dummy values for testing
            {
                tradeProcessor.ProcessTrades(test_Stream);
            }
        }
    }
}
