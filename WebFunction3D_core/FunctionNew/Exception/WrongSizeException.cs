using System.Reflection;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace WebFunction3D_core.FunctionNew.Exception
{
    public class WrongSizeException : System.Exception
    {
        public override string Message
        {
            get { return "Неверный размер коллекции"; }
        }
    }
}