namespace CSharpTemplateGenerator
{
    public class VariableModel
    {
        public AccessModifier _AccessModifier;
        public object Type;
        public string VariableName;

        public override string ToString()
        {
            return $"{_AccessModifier} {Type} {VariableName}";
        }
    }
}