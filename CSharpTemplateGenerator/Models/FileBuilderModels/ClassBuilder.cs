using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTemplateGenerator
{
    public sealed class ClassBuilder : BaseFileBuilder
    {
        public BaseCSharpFileModel model;

        public ClassBuilder(ClassModel classModel)
        {
            model = classModel;
        }
        public override List<string> GetAsListOfStrings()
        {
            List<string> output = new List<string>();
            // Since this is a class...we need to get the signature of the class...
            output.Add(model.GetSignature());
            output.Add("{");
            foreach (MethodModel method in model.Methods)
            {
                output.Add(method.ToString());
                output.Add("{");
                output.Add("}");
            }
            output.Add(model.ToString());
            // Semicolon to indicate end of class
            output.Add("}");
            return output;
        }
    }
}
