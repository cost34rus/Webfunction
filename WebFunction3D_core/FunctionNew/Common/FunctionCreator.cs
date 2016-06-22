using WebFunction3D_core.FunctionNew.API;

namespace WebFunction3D_core.FunctionNew.Common
{
    public abstract class FunctionCreator : IFunctionCreator
    {
        protected IScriptTemplate Template;
        protected readonly IFunction Function;

        protected FunctionCreator()
        {
            Function = new Function();
        }

        public virtual IFunction Create()
        {
            Function.Source = CreateData();
            return Function;
        }

        protected abstract object CreateData();

        public void SetTemplate(IScriptTemplate template)
        {
            Template = template;
        }

        protected abstract void FillParams();
    }
}