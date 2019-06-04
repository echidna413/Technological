namespace Common
{
    public class ApplicationData
    {
        private ApplicationData()
        {
        }

        public static ApplicationData Instance { get; } = new ApplicationData();

        public string Login { get; set; }
        public string Role { get; set; }
    }
}
