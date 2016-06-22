using System;
using System.Collections.Generic;
using WebFunction3D_core.FunctionNew.API;
using WebFunction3D_core.FunctionNew.Common;

namespace WebFunction3D_core.FunctionNew.FunctionGnuplot.Templates
{
    public class TreeDScriptTemplate
    {
        public TreeDScriptTemplate()
        {
            SourceType = typeof (byte[]);
        }

        public List<IScriptParam> GetParamsTemplate()
        {
            List<IScriptParam> paramsTemplate = new List<IScriptParam>();
            paramsTemplate.Add(new ScriptParam
            {
                Prefix = "set",
                Name = "terminal",
                Value = "gif animate delay 0",
                Type = ParamType.Mandatory
            });
            paramsTemplate.Add(new ScriptParam
            {
                Prefix = "set",
                Name = "output",
                Value = "\"" + OutputFileName + "\"",
                Type = ParamType.Mandatory
            });
            paramsTemplate.Add(new ScriptParam
            {
                Prefix = "set",
                Name = "contour",
                Type = ParamType.Mandatory
            });
            paramsTemplate.Add(new ScriptParam
            {
                Prefix = "set",
                Name = "grid",
                Type = ParamType.Mandatory
            });
            paramsTemplate.Add(new ScriptParam
            {
                Prefix = "set",
                Name = "samples",
                Value = "40, 40",
                Type = ParamType.Mandatory
            });
            paramsTemplate.Add(new ScriptParam
            {
                Prefix = "set",
                Name = "isosamples",
                Value = "40, 40",
                Type = ParamType.Mandatory
            });
            paramsTemplate.Add(new ScriptParam
            {
                Prefix = "set",
                Name = "style",
                Value = "data lines",
                Type = ParamType.Mandatory
            });
            paramsTemplate.Add(new ScriptParam
            {
                Prefix = "do",
                Name = "for",
                Value = "[i=0:360]{",
                Type = ParamType.Mandatory
            });
            paramsTemplate.Add(new ScriptParam
            {
                Prefix = "set",
                Name = "view",
                Value = "60,i",
                Type = ParamType.Mandatory
            });
            paramsTemplate.Add(new ScriptParam
            {
                Prefix = "",
                Name = "splot",
                Value = Function,
                Type = ParamType.Mandatory
            });
            paramsTemplate.Add(new ScriptParam
            {
                Name = "}",
                Value = "",
                Type = ParamType.Mandatory
            });
            return paramsTemplate;
        }

        public string Function { get; set; }

        public string OutputFileName { get; set; }

        public Type SourceType { get; private set; }

        public Type CreatorType
        {
            get { throw new NotImplementedException(); }
        }

        public ICollection<IParam> Options
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    }
}