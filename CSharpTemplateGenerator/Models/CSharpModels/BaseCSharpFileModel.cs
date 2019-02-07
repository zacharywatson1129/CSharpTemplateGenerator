using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTemplateGenerator
{
    public abstract class BaseCSharpFileModel
    {
        public List<MethodModel> Methods;
        public List<VariableModel> Variables;
        public string name;

        public abstract string GetSignature();
    }
}
