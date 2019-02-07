using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTemplateGenerator
{
    public sealed class InterfaceBuilder : BaseFileBuilder
    {
        public InterfaceModel model;

        public InterfaceBuilder(InterfaceModel model)
        {
            this.model = model;
        }

        public override List<string> GetAsListOfStrings()
        {
            return new List<string>();
        }
    }
}
