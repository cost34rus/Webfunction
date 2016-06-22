using System.IO;
using WebFunction3D_core.FunctionNew.API;
using WebFunction3D_core.FunctionNew.Common;

namespace WebFunction3D_core.FunctionNew.FunctionGnuplot
{
    public class GnupoltFunctionCreator : FunctionCreator
    {
        private IScript _script;
        private FileInfo _inputFileInfo;
        private FileInfo _outputFileInfo;
        private string _gnuplotPath = "";

        public override IFunction Create()
        {
            _script = new ScriptCreator(Template).Create();
            CreateInputFile();
            CreateOutputFile();
            Function.Source = CreateData();
            return Function;
        }

        protected override object CreateData()
        {
            if (Template.SourceType == typeof (byte[]))
            {
                return GetImageByte();
            }
            if (Template.SourceType == typeof(string))
            {
                return GetHtml();
            }
            return null;
        }

        protected override void FillParams()
        {
            throw new System.NotImplementedException();
        }

        private void CreateInputFile()
        {
            File.WriteAllLines(GetInputFilePath(), _script.GetLines());
            _inputFileInfo = new FileInfo(GetInputFilePath());
        }

        private void CreateOutputFile()
        {
            _outputFileInfo = new FileInfo(GetOutputFilePath());
            _outputFileInfo.Delete();
            CMD.Run();
            CMD.Cd(GnuplotPath);
            CMD.Exe("gnuplot " + _inputFileInfo.Name);
            CMD.Destroy();
        }


        private string GetInputFilePath()
        {
            return GnuplotPath + "\\" + "input.gnu";
        }

        private string GnuplotPath
        {
            get
            {
                if (_gnuplotPath == "" || !Directory.Exists(_gnuplotPath))
                {
                    return @"c:\gnuplot\";
                }
                return _gnuplotPath;
            }
        }

        private string GetOutputFilePath()
        {
            return GnuplotPath + "\\" + Template.OutputFileName;
        }

        private byte[] GetImageByte()
        {
            while (true)
            {
                byte[] text;
                try
                {
                    text = File.ReadAllBytes(_outputFileInfo.FullName);
                }
                catch
                {
                    continue;
                }
                return text;
            }
        }

        private string GetHtml()
        {
            int iteration = 0;
            while (!_outputFileInfo.Exists)
            {
                iteration++;
                if (iteration == int.MaxValue) return "<h1>Не удалось получить значение</h1>";
            }
            iteration = 0;
            while (true)
            {
                string text;
                try
                {
                    text = File.ReadAllText(_outputFileInfo.FullName);
                }
                catch
                {
                    iteration++;
                    if (iteration == int.MaxValue) return "<h1>Не удалось получить значение</h1>";
                    continue;
                }
                return text;
            }
        }
    }
}