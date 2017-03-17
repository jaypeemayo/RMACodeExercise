using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMACodeExercise
{
    public interface ITradeParser
    {
        IList<ITradeRecord> Parse(IList<string> lines);
    }
}
