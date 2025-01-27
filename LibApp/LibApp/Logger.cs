using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace LibApp
{
    public static class Logger
    {
        private static readonly string LogFilePath = "log.json";
        private static List<LogEntry> logEntries = new List<LogEntry>();

        static Logger()
        {
            LoadLogs();
        }

        public static void Log(string action, string details)
        {
            var logEntry = new LogEntry(action, details);
            logEntries.Add(logEntry);
            SaveLogs();
        }

        private static void LoadLogs()
        {
            if (File.Exists(LogFilePath))
            {
                var json = File.ReadAllText(LogFilePath);
                logEntries = JsonConvert.DeserializeObject<List<LogEntry>>(json) ?? new List<LogEntry>();
            }
        }

        private static void SaveLogs()
        {
            var json = JsonConvert.SerializeObject(logEntries, Formatting.Indented, new CustomDateTimeConverter());
            File.WriteAllText(LogFilePath, json);
        }
    }
    public class LogEntry
    {
        public string Action { get; set; }
        public string Details { get; set; }

        [JsonConverter(typeof(CustomDateTimeConverter))]
        public DateTime Timestamp { get; set; }

        public LogEntry(string action, string details)
        {
            Action = action;
            Details = details;
            Timestamp = DateTime.Now;
        }
    }

    public class CustomDateTimeConverter : IsoDateTimeConverter
    {
        public CustomDateTimeConverter()
        {
            DateTimeFormat = "dd/MM/yyyy HH:mm:ss";
        }
    }
}
