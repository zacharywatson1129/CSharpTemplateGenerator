using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTemplateGenerator
{
    public sealed class ClassModel : BaseCSharpFileModel
    {
        public List<VariableModel> Variables;
        public List<MethodModel> Methods;
        public string name;

        public ClassModel(string name, List<VariableModel> variables, List<MethodModel> methods)
        {
            this.name = name;
            this.Variables = variables;
            this.Methods = methods;
        }

        public override string GetSignature()
        {
            return $"public class {name}";
        }
    }
}
