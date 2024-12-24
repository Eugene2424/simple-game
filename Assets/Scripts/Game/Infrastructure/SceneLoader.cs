using Game.Application;
using System;
using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using Zenject;


namespace Game.Infrastructure
{
    public class SceneLoader : MonoBehaviour, ISceneLoader
    {
        private ILoadingScreen _loadingScreen;
        
        [Inject]
        public void Construct(ILoadingScreen loadingScreen)
        {
            _loadingScreen = loadingScreen;
        }

        public void LoadSceneAsync(string sceneName, Action onComplete = null)
        {
            _loadingScreen.Show();
            var asyncOperation = SceneManager.LoadSceneAsync(sceneName);
            asyncOperation.allowSceneActivation = false;

            _loadingScreen.UpdateProgress(asyncOperation.progress);
            StartCoroutine(UpdateProgress(asyncOperation, onComplete));
        }

        private IEnumerator UpdateProgress(AsyncOperation asyncOperation, Action onComplete)
        {
            while (!asyncOperation.isDone)
            {
                _loadingScreen.UpdateProgress(asyncOperation.progress);
                if (asyncOperation.progress >= 0.9f)
                {
                    asyncOperation.allowSceneActivation = true;
                }
                yield return null;
            }

            _loadingScreen.Hide();
            onComplete?.Invoke();
        }
    }
}