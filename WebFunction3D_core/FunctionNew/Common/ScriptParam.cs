using WebFunction3D_core.FunctionNew.API;

namespace WebFunction3D_core.FunctionNew.Common
{
    public class ScriptParam : IScriptParam
    {
        public string Name { get; set; }
        public object Value { get; set; }
        public ParamType Type { get; set; }
        public string Prefix { get; set; }

        public override string ToString()
        {
            return Prefix + " " + Name + " " + Value;
        }
    }
}