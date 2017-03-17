using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMACodeExercise
{
    public interface IFileReader
    {
        IList<string> Read(Stream stream);
    }
}
