using System;
using System.IO;
using AsyncOperations.LanguageExtensions;

namespace AsyncOperations.Classes
{

    public static class Exceptions
    {
        public static void Write(Exception exception)
        {
            var fileName = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "UnhandledException.txt");
            if (File.Exists(fileName))
            {
                var contents = File.ReadAllText(fileName);
                var current = exception.ToLogString(Environment.StackTrace);
                var data = $"{contents}{Environment.NewLine}{current}{Environment.NewLine}";
                File.WriteAllText(fileName, data);
            }
            else
            {
                File.WriteAllText(fileName, exception.ToLogString(Environment.StackTrace) + Environment.NewLine);
            }
        }
    }
}
