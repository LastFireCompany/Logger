using Microsoft.Extensions.Configuration;

namespace Logger
{
    public class Log
    {
         string logFilePath;

        public void Start()
        {
            var config = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("LoggerSettings.json", optional: false, reloadOnChange: true)
                .Build();
            
            var pathToFolder = config["PathToFolder:PathString"];
            
            logFilePath = $"{pathToFolder} |"+ $"{DateTime.Now:yyyy-MM-dd_HH-mm-ss}" + "|.log";
            
            

        }
        public void Info(string message)
        {
            using (StreamWriter logWriter = new StreamWriter(logFilePath, true))
            {
                logWriter.WriteLine($"{DateTime.Now} | INFO | {message}");
            }
        }
        public void Eror(string message)
        {
            using (StreamWriter logWriter = new StreamWriter(logFilePath, true))
            {
                logWriter.WriteLine($"{DateTime.Now} | ERROR | {message}");
            }
        }
        public void Debug(string message)
        {
            using (StreamWriter logWriter = new StreamWriter(logFilePath, true))
            {
                logWriter.WriteLine($"{DateTime.Now} | DEBUG | {message}");
            }
        }
    }
}
