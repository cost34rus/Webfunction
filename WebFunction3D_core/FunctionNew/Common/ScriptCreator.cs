using WebFunction3D_core.FunctionNew.API;

namespace WebFunction3D_core.FunctionNew.Common
{
    public class ScriptCreator : IScriptCreator
    {
        private readonly IScriptTemplate _template;
        private readonly IScript _script;

        public ScriptCreator(IScriptTemplate template)
        {
            _template = template;
            _script = new Script();
        }

        public IScript Create()
        {
            _script.Params = _template.GetParamsTemplate();
            return _script;
        }
    }
}