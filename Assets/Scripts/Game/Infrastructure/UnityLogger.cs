using Game.Application;
using System;

namespace Game.Infrastructure
{
    public class UnityLogger : ILoggerService
    {
        public void Log(string message)
        {
            UnityEngine.Debug.Log(message);
        }

        public void LogWarning(string message)
        {
            UnityEngine.Debug.LogWarning(message);
        }

        public void LogError(string message)
        {
            UnityEngine.Debug.LogError(message);
        }

        public void LogException(Exception exception)
        {
            LogError(exception.Message);
        }
    }
}