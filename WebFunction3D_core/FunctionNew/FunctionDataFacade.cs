using System;
using WebFunction3D_core.FunctionNew.API;

namespace WebFunction3D_core.FunctionNew
{
    public class FunctionDataFacade : IFunctionDataFacade
    {
        public IFunction GetFunction(IScriptTemplate template, Type creator)
        {
            //todo обрабоать ошибку
            var functionCreator = (IFunctionCreator) Activator.CreateInstance(creator);
            functionCreator.SetTemplate(template);
            return functionCreator.Create();
        }

        public IFunction GetFunction(IScriptTemplate template)
        {
            //todo сделать асинхронной 
            //todo обрабоать ошибку
            var functionCreator = (IFunctionCreator)Activator.CreateInstance(template.CreatorType);
            functionCreator.SetTemplate(template);
            return functionCreator.Create();
        }
    }
}