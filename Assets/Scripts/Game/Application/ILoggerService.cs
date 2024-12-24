﻿using System;

namespace Game.Application
{
    public interface ILoggerService
    {
        public void Log(string message);
        public void LogWarning(string message);
        public void LogError(string message);
        public void LogException(Exception exception);
    }
}