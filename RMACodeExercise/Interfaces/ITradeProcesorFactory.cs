using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMACodeExercise
{
    public interface ITradeProcessorFactory
    {
        IFileReader GetFileReader();
        ITradeParser GetTradeParser();
        IDatabaseAccessor GetDatabaseAccessor();
    }
}
