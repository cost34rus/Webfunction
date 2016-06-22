using WebFunction3D_core.FunctionNew.Common;

namespace WebFunction3D_core.FunctionNew.API
{
    public interface IParam
    {
        string Name { get; set; }
        object Value { get; set; } 
    }
}