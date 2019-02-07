using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTemplateGenerator
{
    public class InterfaceModel : BaseCSharpFileModel
    {
        string name;
        public InterfaceModel(string name)
        {
            this.name = name;
        }

        public override string GetSignature()
        {
            throw new NotImplementedException();
        }
    }
}
