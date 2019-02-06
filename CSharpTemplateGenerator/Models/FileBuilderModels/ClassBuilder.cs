using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTemplateGenerator
{
    public sealed class ClassBuilder : FileBuilder
    {
        public ClassModel model;

        public ClassBuilder(ClassModel model)
        {
            
        }
        public override List<string> GetAsListOfStrings()
        {
            List<string> output = new List<string>();
            
            output.Add(model.ToString());
            return output;
        }
    }
}
