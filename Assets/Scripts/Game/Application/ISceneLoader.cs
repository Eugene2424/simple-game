using System;

namespace Game.Application
{
    public interface ISceneLoader
    {
        void LoadSceneAsync(string sceneName, Action onComplete = null);
    }
}