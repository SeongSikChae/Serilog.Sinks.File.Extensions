# Serilog.SinksFile Extensions

## Serilog.Configuration namespace Extensions

### LoggerSinConfiguration Extensions

* LoggerConfiguration File(string longDir, string logFile, Serilog.Events.LogEventLevel restrictedToMinimumLevel = Serilog.Events.LogEventLevel.Verbose, string outputTemplate = "{Timestamp:yyyy-MM-dd HH:mm:ss.fff zzz} [{Level:u3}] {Message:lj}{NewLine}{Exception}", System.IFormatProvider? formatProvider = null, long? fileSizeLimitBytes = 1073742824,
			Serilog.Core.LoggingLevelSwitch? levelSwitch = null,
			bool buffered = false,
			bool shared = false,
			TimeSpan? flushToDiskInterval = null,
			RollingInterval rollingInterval = RollingInterval.Infinite,
			bool rollOnFileSizeLimit = false,
			int? retainedFileCountLimit = 31,
			System.Text.Encoding? encoding = null,
			Serilog.Sinks.File.FileLifecycleHooks? hooks = null,
			TimeSpan? retainedFileTimeLimit = null)