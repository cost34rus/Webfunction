using System.Diagnostics;

namespace WebFunction3D_core
{
    public static class CMD
    {
        private static Process _cmd;
        public static void Run()
        {
            _cmd = new Process();//создаем новый объект класса
            _cmd.StartInfo = new ProcessStartInfo(@"cmd.exe");//задаем имя исполняемого файла
            //_cmd.StartInfo.CreateNoWindow = true;//не создавать окно
            _cmd.StartInfo.WindowStyle = ProcessWindowStyle.Normal;//спрятать окно
            _cmd.StartInfo.RedirectStandardInput = true;// перенаправить вход
            _cmd.StartInfo.RedirectStandardOutput = true;//перенаправить выход
            _cmd.StartInfo.UseShellExecute = false;//обязательный параметр, для работы предыдущих
            _cmd.StartInfo.WorkingDirectory = @"c:\";//устанавливаю рабочую директорию
            //_cmd.StartInfo.UserName = "test";//задаю имя пользователя
            //var str = new System.Security.SecureString();//nтут некоторые замуты с паролем
            //str.AppendChar('1');
            //str.AppendChar('2');
            //_cmd.StartInfo.Password = str;//присваиваю пароль 12
            _cmd.StartInfo.LoadUserProfile = true;//говорю, что необходимо загрузить профиль
            _cmd.Start();//запускаем командную строку
        }

        public static void Cd(string path)
        {
            _cmd.StandardInput.WriteLine("cd "+"\"" + path + "\"");
            Debug.WriteLine("Командная строка: выполнена команда cd на " + "cd " + "\"" + path + "\"");

        }

        public static void Exe(string command)
        {
            _cmd.StandardInput.WriteLine(command);
            Debug.WriteLine("Командная строка: выполнена команда" + command);
        }

        public static void Destroy()
        {
            _cmd.Close();
            _cmd.Dispose();
            Debug.WriteLine("Закрыта командная строка");
        }
    }
}