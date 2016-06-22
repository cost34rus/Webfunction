using System.Collections.Generic;
using ELW.Library.Math;
using ELW.Library.Math.Expressions;
using ELW.Library.Math.Tools;
using WebFunction3D_core.FunctionNew.Common;
using WebFunction3D_core.FunctionNew.Graph3D.Json;

namespace WebFunction3D_core.FunctionNew.Graph3D
{
    public class Graph3DFunctionCreator : FunctionCreator
    {
        const string XName = "x";
        const string YName = "y";
        private double _xFrom;
        private double _xDo;
        private double _xStep;
        private double _yFrom;
        private double _yDo;
        private double _yStep;

        protected override object CreateData()
        {
            var data = new Data();
            PreparedExpression preparedExpression = ToolsHelper.Parser.Parse(Template.Function);
            CompiledExpression compiledExpression = ToolsHelper.Compiler.Compile(preparedExpression);
            var rows = new List<Row>();
            FillParams();
            for (double x = _xFrom ; x < _xDo; x+= _xStep)
            {
                for (double y = _yFrom; y < _yDo; y += _yStep)
                {
                    var row = new Row();
                    List<VariableValue> variables = new List<VariableValue>
                    {
                        new VariableValue(x, XName),
                        new VariableValue(y, YName)
                    };
                    double z = ToolsHelper.Calculator.Calculate(compiledExpression, variables);
                    var values = new List<Value>
                    {
                        new Value
                        {
                            v = x
                        },
                        new Value
                        {
                            v = y
                        },
                        new Value
                        {
                            v = z
                        }
                    };
                    row.c = values;
                    rows.Add(row);
                }
            }
            data.rows = rows;
            return data;
        }

        protected override void FillParams()
        {
            try
            {
                _xFrom = double.Parse(Template.XFrom);
                _xDo = double.Parse(Template.XDo);
                _xStep = double.Parse(Template.XStep);
                _yFrom = double.Parse(Template.YFrom);
                _yDo = double.Parse(Template.YDo);
                _yStep = double.Parse(Template.YStep);
            }
            catch
            {
                //todo обработать ошибку
            }
        }
    }
}