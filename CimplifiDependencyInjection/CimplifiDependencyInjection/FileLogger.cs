using System;
using System.IO;
using System.Text;

namespace CimplifiDependencyInjection
{
    public class FileLogger : ILogger
    {
        private string _filePath;

        public FileLogger(string filePath)
        {
            _filePath = filePath;
        }

        public void Log(string message)
        {
            if (string.IsNullOrEmpty(_filePath))
            {
                throw new InvalidOperationException("File path is not set.");
            }

            try
            {
               
                string directory = Path.GetDirectoryName(_filePath);
                if (!string.IsNullOrEmpty(directory) && !Directory.Exists(directory))
                {
                    Directory.CreateDirectory(directory);
                }

               
                using (StreamWriter sw = new StreamWriter(_filePath, true, Encoding.UTF8))
                {
                    sw.WriteLine($"{DateTime.Now:yyyy-MM-dd HH:mm:ss}: {message}");
                }
            }
            catch (Exception ex)
            {
                
                Console.Error.WriteLine($"Failed to write to log file: {ex.Message}");

            
            }
        }

    }
}
