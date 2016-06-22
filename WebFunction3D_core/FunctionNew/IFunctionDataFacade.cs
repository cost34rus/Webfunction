using System;
using WebFunction3D_core.FunctionNew.API;

namespace WebFunction3D_core.FunctionNew
{
    public interface IFunctionDataFacade
    {
        IFunction GetFunction(IScriptTemplate template, Type creator);

        IFunction GetFunction(IScriptTemplate template);
    }
}