namespace Serilog.Configuration
{
	/// <summary>
	/// Serilog.Sinks.File Configuration Extensions
	/// </summary>
	public static class LoggerSinkConfigurationExtensions
	{
		/// <summary>
		/// Serilog.Sinks.File Configuration Extensions
		/// </summary>
		/// <param name="sinkConfiguration"></param>
		/// <param name="logDir"></param>
		/// <param name="logFile"></param>
		/// <param name="restrictedToMinimumLevel"></param>
		/// <param name="outputTemplate"></param>
		/// <param name="formatProvider"></param>
		/// <param name="fileSizeLimitBytes"></param>
		/// <param name="levelSwitch"></param>
		/// <param name="buffered"></param>
		/// <param name="shared"></param>
		/// <param name="flushToDiskInterval"></param>
		/// <param name="rollingInterval"></param>
		/// <param name="rollOnFileSizeLimit"></param>
		/// <param name="retainedFileCountLimit"></param>
		/// <param name="encoding"></param>
		/// <param name="hooks"></param>
		/// <param name="retainedFileTimeLimit"></param>
		/// <returns></returns>
		public static LoggerConfiguration File(this LoggerSinkConfiguration sinkConfiguration, string logDir, string logFile, 
			Events.LogEventLevel restrictedToMinimumLevel = Events.LogEventLevel.Verbose,
			string outputTemplate = "{Timestamp:yyyy-MM-dd HH:mm:ss.fff zzz} [{Level:u3}] {Message:lj}{NewLine}{Exception}",
			IFormatProvider? formatProvider = null,
			long? fileSizeLimitBytes = 1073742824,
			Core.LoggingLevelSwitch? levelSwitch = null,
			bool buffered = false,
			bool shared = false,
			TimeSpan? flushToDiskInterval = null,
			RollingInterval rollingInterval = RollingInterval.Infinite,
			bool rollOnFileSizeLimit = false,
			int? retainedFileCountLimit = 31,
			System.Text.Encoding? encoding = null,
			Sinks.File.FileLifecycleHooks? hooks = null,
			TimeSpan? retainedFileTimeLimit = null)
		{
			ArgumentNullException.ThrowIfNull(sinkConfiguration);
			ArgumentException.ThrowIfNullOrWhiteSpace(logDir);
			ArgumentException.ThrowIfNullOrWhiteSpace(logFile);

			DirectoryInfo logDirInfo = new DirectoryInfo(logDir);
			if (!logDirInfo.Exists)
				logDirInfo.Create();

			FileInfo logFileInfo = logDirInfo.GetFileInfo(logFile);

			return sinkConfiguration.File(logFileInfo.FullName, restrictedToMinimumLevel, outputTemplate, formatProvider, fileSizeLimitBytes, 
				levelSwitch, buffered, shared, flushToDiskInterval, rollingInterval, rollOnFileSizeLimit, retainedFileCountLimit, encoding, hooks,
				retainedFileTimeLimit);
		}
	}
}
