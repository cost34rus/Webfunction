using WebFunction3D_core.FunctionNew.API;

namespace WebFunction3D_core.FunctionNew.Common
{
    public class Param : IParam
    {
        public string Name { get; set; }
        public object Value { get; set; }
    }
}