namespace CSharpTemplateGenerator
{
    public class MethodModel
    {
        public AccessModifier _AccessModifier;
        public object ReturnType;
        public string MethodName;

        public override string ToString()
        {
            return $"{_AccessModifier.ToString()} {ReturnType.ToString()} {MethodName}"; 
        }
    }
}