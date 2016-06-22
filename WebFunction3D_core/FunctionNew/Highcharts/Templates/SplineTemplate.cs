using System;
using System.Collections.Generic;
using WebFunction3D_core.FunctionNew.API;
using WebFunction3D_core.FunctionNew.Common;

namespace WebFunction3D_core.FunctionNew.Highcharts.Templates
{
    public class SplineTemplate : IScriptTemplate
    {
        private string _xStep;

        public SplineTemplate()
        {
            CreatorType = typeof (HighchartsFunctionCreator);
        }

        public List<IScriptParam> GetParamsTemplate()
        {
            throw new NotImplementedException();
        }

        public string Function { get; set; }

        public string XFrom { get; set; }

        public string XDo { get; set; }

        public string XStep
        {
            get { return _xStep ?? FunctionConstants.XStepDefault; }
            set { _xStep = value; }
        }

        public string YFrom { get; set; }

        public string YDo { get; set; }

        public string YStep { get; set; }

        public string OutputFileName { get; set; }

        public Type SourceType { get; private set; }

        public Type CreatorType { get; private set; }

        public ICollection<IParam> Options { get; set; }
    }
}