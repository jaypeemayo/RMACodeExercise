using Microsoft.Practices.Unity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMACodeExercise
{
    public class TradeProcessorFactory : ITradeProcessorFactory
    {
        IUnityContainer unityContainer;
        public TradeProcessorFactory(IUnityContainer unityContainer)
        {
            this.unityContainer = unityContainer;
        }
        public IFileReader GetFileReader()
        {
            return this.unityContainer.Resolve<IFileReader>();
        }

        public ITradeParser GetTradeParser()
        {
            return this.unityContainer.Resolve<ITradeParser>();
        }

        public IDatabaseAccessor GetDatabaseAccessor()
        {
            return this.unityContainer.Resolve<IDatabaseAccessor>();
        }
    }
}
