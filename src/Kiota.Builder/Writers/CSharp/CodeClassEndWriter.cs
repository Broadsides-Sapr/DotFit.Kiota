namespace Kiota.Builder.Writers.CSharp {
    public class CodeClassEndWriter : BaseCSharpElementWriter<CodeClass.End>
    {
        public CodeClassEndWriter(CSharpConventionService conventionService):base(conventionService){}
        public override void WriteCodeElement(CodeClass.End codeElement, LanguageWriter writer)
        {
            writer.DecreaseIndent();
            writer.WriteLine("}");
            if(codeElement?.Parent?.Parent is CodeNamespace) {
                writer.DecreaseIndent();
                writer.WriteLine("}");
            }
        }
    }
}
