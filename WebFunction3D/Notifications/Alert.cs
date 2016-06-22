using System.Runtime.Serialization;

namespace WebFunction3D.Notifications
{
    public class Alert
    {
        public string message { get; set; }

        public string type { get; set; }

        public Alert Success
        {
            get
            {
                return  new Alert
                {
                    message = "Успешно.",
                    type = AlertStyles.Success
                };
            }
        }

        public Alert Warning
        {
            get
            {
                return new Alert
                {
                    message = "Ошибка.",
                    type = AlertStyles.Danger
                };
            }
        }
    }
}