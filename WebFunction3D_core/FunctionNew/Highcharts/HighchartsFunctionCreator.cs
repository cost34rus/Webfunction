using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;
using SplineLibrary.Common;
using SplineLibrary.CubicSpline;
using WebFunction3D_core.FunctionNew.Common;
using WebFunction3D_core.FunctionNew.Exception;

namespace WebFunction3D_core.FunctionNew.Highcharts
{
    public class HighchartsFunctionCreator : FunctionCreator
    {
        private double _xStep;

        protected override object CreateData()
        {
            FillParams();
            var points = JsonConvert.DeserializeObject<List<Point>>(Template.Function);
            if (points.Count < 2)
            {
                throw new WrongSizeException();
            }
            CubicSpline cubicSpline = new CubicSpline();
            cubicSpline.BuildSpline(points);
            var data = new List<Point>();
            for (double x = points.First().x; x < points.Last().x; x += _xStep)
            {
                double y = cubicSpline.Interpolate(x);
                data.Add(new Point
                {
                    x = x,
                    y = y
                });
            }
            return data;
        }

        protected override void FillParams()
        {

            try
            {
                _xStep = Convert.ToDouble(Template.XStep);
            }
            catch 
            {
               //todo на azure конверт идет правильно в отличии от от IIS,поэтому тут при ошибки устанавливается стандартное значение
                _xStep = Convert.ToDouble(FunctionConstants.XStepDefault);
            }

        }
    }
}