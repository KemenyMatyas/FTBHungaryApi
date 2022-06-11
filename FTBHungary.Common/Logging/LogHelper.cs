namespace Common.Logging;

using Microsoft.Extensions.Configuration;
using Serilog;
using Serilog.Core;


    public static class LogHelper
    {
        private static readonly Dictionary<string, Logger> Loggers = new();

        public static Logger Activity => Loggers["activityLogger"];
        public static Logger Business => Loggers["businessLogger"];

        public static Logger Diagnostic => Loggers["diagnosticLogger"];

        public static Logger Security => Loggers["securityLogger"];

        public static void Init(IConfiguration config)
        {
            var activityLogger = new LoggerConfiguration()
                .ReadFrom.Configuration(config, "ActivityLog").CreateLogger();
            Loggers.Add("activityLogger", activityLogger);

            var businessLogger = new LoggerConfiguration()
                .ReadFrom.Configuration(config, "BusinessLog").CreateLogger();
            Loggers.Add("businessLogger", businessLogger);

            var diagnosticLogger = new LoggerConfiguration()
                .ReadFrom.Configuration(config, "DiagnosticLog").CreateLogger();
            Loggers.Add("diagnosticLogger", diagnosticLogger);

            var securityLogger = new LoggerConfiguration()
                .ReadFrom.Configuration(config, "SecurityLog").CreateLogger();
            Loggers.Add("securityLogger", securityLogger);
        }
    }