using System;
using System.Collections.Generic;
using WebFunction3D_core.FunctionNew.API;
using WebFunction3D_core.FunctionNew.Common;

namespace WebFunction3D_core.FunctionNew.FunctionGnuplot.Templates
{
    public class SplineScriptTemplate
    {
        public List<IScriptParam> GetParamsTemplate()
        {
            List<IScriptParam> paramsTemplate = new List<IScriptParam>
            {
                new ScriptParam
                {
                    Prefix = "set",
                    Name = "terminal",
                    Value = "gif animate delay 0"
                },
                new ScriptParam
                {
                    Prefix = "set",
                    Name = "output",
                    Value = "\"" + OutputFileName + "\"",
                    Type = ParamType.Mandatory
                },
                new ScriptParam
                {
                    Prefix = "set",
                    Name = "contour",
                    Type = ParamType.Mandatory
                },
                new ScriptParam
                {
                    Prefix = "set",
                    Name = "grid",
                    Type = ParamType.Mandatory
                },
                new ScriptParam
                {
                    Prefix = "set",
                    Name = "samples",
                    Value = "40, 40",
                    Type = ParamType.Mandatory
                },
                new ScriptParam
                {
                    Prefix = "set",
                    Name = "isosamples",
                    Value = "40, 40",
                    Type = ParamType.Mandatory
                },
                new ScriptParam
                {
                    Prefix = "set",
                    Name = "style",
                    Value = "data lines",
                    Type = ParamType.Mandatory
                },
                new ScriptParam
                {
                    Prefix = "do",
                    Name = "for",
                    Value = "[i=0:360]{",
                    Type = ParamType.Mandatory
                },
                new ScriptParam
                {
                    Prefix = "set",
                    Name = "view",
                    Value = "60,i",
                    Type = ParamType.Mandatory
                },
                new ScriptParam
                {
                    Prefix = "",
                    Name = "splot",
                    Value = Function,
                    Type = ParamType.Mandatory
                },
                new ScriptParam
                {
                    Name = "}",
                    Value = "",
                    Type = ParamType.Mandatory
                }
            };
            return paramsTemplate;
        }


        public string Function { get; set; }

        public string OutputFileName { get; set; }

        public Type SourceType
        {
            get { return typeof(string); }
        }

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