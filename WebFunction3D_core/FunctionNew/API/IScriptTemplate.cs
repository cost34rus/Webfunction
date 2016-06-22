using System;
using System.Collections.Generic;

namespace WebFunction3D_core.FunctionNew.API
{
    public interface IScriptTemplate
    {
        List<IScriptParam> GetParamsTemplate();
        string Function { get; set; }

        string XFrom { get; set; }
        string XDo { get; set; }
        string XStep { get; set; }
        string YFrom { get; set; }
        string YDo { get; set; }
        string YStep { get; set; } 
        string OutputFileName { get; set; }
        Type SourceType { get; }
        Type CreatorType { get; }
        ICollection<IParam> Options { get; set; }
    }
}