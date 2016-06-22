using System.Collections.Generic;

namespace WebFunction3D_core.FunctionNew.API
{
    public interface IScript
    {
        List<IScriptParam> Params { get; set; }

        string[] GetLines();
    }
}