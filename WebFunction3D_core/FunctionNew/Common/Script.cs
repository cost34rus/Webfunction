using System.Collections.Generic;
using System.Linq;
using WebFunction3D_core.FunctionNew.API;

namespace WebFunction3D_core.FunctionNew.Common
{
    public class Script : IScript
    {
        public List<IScriptParam> Params { get; set; }
        public string[] GetLines()
        {
            return Params.Select(param => param.ToString()).ToArray();
        }
    }
}