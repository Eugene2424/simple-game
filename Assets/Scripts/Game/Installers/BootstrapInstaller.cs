using System.ComponentModel;
using UnityEngine;
using Zenject;
using Game.Application;
using Game.Infrastructure;
using Game.Presentation.UI;

namespace Game.Installers
{
    public class BootstrapInstaller : MonoInstaller
    {
        [SerializeField] private LoadingScreen loadingScreen;
        [SerializeField] private SceneLoader sceneLoader;
        
        public override void InstallBindings()
        {
            Container.Bind<GameStateManager>().AsSingle();
            Container.Bind<ILoadingScreen>().FromInstance(loadingScreen).AsSingle();
            Container.Bind<ISceneLoader>().FromInstance(sceneLoader).AsSingle();
        }
    }
}