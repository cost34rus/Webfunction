namespace WebFunction3D_core.FunctionNew.API
{
    public interface IFunctionCreator
    {
        IFunction Create();

        void SetTemplate(IScriptTemplate template);
    }
}