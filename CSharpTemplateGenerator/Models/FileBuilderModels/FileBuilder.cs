using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTemplateGenerator
{
    abstract class FileBuilder
    {
        public abstract List<string> GetAsListOfStrings(BaseCSharpFileModel model);       
    }
}
