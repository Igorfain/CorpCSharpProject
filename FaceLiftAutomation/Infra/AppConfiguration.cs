using Microsoft.Extensions.Configuration;

namespace LsportsAutomation.Infra
{
    public class AppConfiguration
    {
    
        public void ReadConfigFile(out string URL,out string user,out string pass)
        {

            var Config = new ConfigurationBuilder().AddJsonFile("Config.json").Build();
            var baseURL = Config.GetValue<string>("AppSettings:BaseURL");
            var userEmail = Config.GetValue<string>("AppSettings:userName");
            var password = Config.GetValue<string>("AppSettings:password");

            URL = baseURL;
            user = userEmail;
            pass = password;


        }
    }
}
