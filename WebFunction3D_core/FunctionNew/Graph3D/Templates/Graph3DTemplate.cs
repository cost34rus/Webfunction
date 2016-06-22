using System;
using System.Collections.Generic;
using WebFunction3D_core.FunctionNew.API;
using WebFunction3D_core.FunctionNew.Common;

namespace WebFunction3D_core.FunctionNew.Graph3D.Templates
{
    public class Graph3DTemplate : IScriptTemplate
    {
        private string _xFrom;
        private string _xDo;
        private string _xStep;
        private string _yFrom;
        private string _yDo;
        private string _yStep;

        public Graph3DTemplate()
        {
            CreatorType = typeof(Graph3DFunctionCreator);
            SourceType = typeof(object);
        }

        List<IScriptParam> IScriptTemplate.GetParamsTemplate()
        {
            throw new NotImplementedException();
        }

        public string Function { get; set; }

        public string XFrom
        {
            get { return _xFrom ?? FunctionConstants.XFromDefault; }
            set { _xFrom = value; }
        }

        public string XDo
        {
            get { return _xDo ?? FunctionConstants.XDoDefault; }
            set { _xDo = value; }
        }

        public string XStep
        {
            get { return _xStep ?? FunctionConstants.XStepDefault; }
            set { _xStep = value; }
        }

        public string YFrom
        {
            get { return _yFrom ?? FunctionConstants.YFromDefault; }
            set { _yFrom = value; }
        }

        public string YDo
        {
            get { return _yDo ?? FunctionConstants.YDoDefault; }
            set { _yDo = value; }
        }

        public string YStep
        {
            get { return _yStep ?? FunctionConstants.YStepDefault; }
            set { _yStep = value; }
        }

        public string OutputFileName { get; set; }
        public Type SourceType { get; private set; }
        public Type CreatorType { get; private set; }
        public ICollection<IParam> Options { get; set; }
    }
}