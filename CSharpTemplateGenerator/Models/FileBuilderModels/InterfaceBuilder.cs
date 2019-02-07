using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTemplateGenerator
{
    public sealed class InterfaceBuilder : BaseFileBuilder
    {
        public BaseCSharpFileModel model;

        public InterfaceBuilder(InterfaceModel model)
        {
            this.model = model;
        }

        public override List<string> GetAsListOfStrings()
        {
            List<string> output = new List<string>();
            // Since this is a interface, we simple add each method signature and a semicolon, on one line.
            output.Add(model.GetSignature());
            // Opening interface brace 
            output.Add("{");
            foreach (MethodModel method in model.Methods)
            {
                // Method signature and semicolon
                output.Add(method.ToString() + ";");
            }
            // Closing interface brace
            output.Add("}");
            return output;
        }
    }
}
