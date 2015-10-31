﻿using System;
using System.Threading;
using System.Configuration;

namespace ProofOfConcept
{
    public static class Settings
    {
        private static readonly ThreadLocal<TimeoutSettings> _timeoutSettings 
            = new ThreadLocal<TimeoutSettings>();
        public static ITimeoutSettings TimeoutSettings
        {
            get
            {
                if (!_timeoutSettings.IsValueCreated)
                {
                    var result = GetConfiguration<TimeoutSettings>();
                    _timeoutSettings.Value = result;
                }
                return _timeoutSettings.Value;
            }
        }


        private static T GetConfiguration<T>()
        {
            var configuration = ConfigurationManager.OpenMappedExeConfiguration(new ExeConfigurationFileMap()
            {
                ExeConfigFilename = AppDomain.CurrentDomain.SetupInformation.ConfigurationFile
            }, ConfigurationUserLevel.None);
            foreach (var section in configuration.Sections)
            {
                if (section is T)
                {
                    return (T)section;
                }
            }
            return default(T);
        }

    }

    public class SettingsException : Exception
    {
        public SettingsException(string message, Exception innerException)
            : base(message, innerException) {}
        public SettingsException(string message)
            : base(message) { }
    }
}