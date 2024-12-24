using System.Collections;
using System.Collections.Generic;
using Game.Application;
using Game.Infrastructure;
using UnityEngine;
using Zenject;

namespace Game.Installers
{
    public class ProjectInstaller : MonoInstaller
    {
        public override void InstallBindings()
        {
            BindServices();
            BindGameStates();
        }

        private void BindServices()
        {
            Container.Bind<ILoggerService>().To<UnityLogger>().AsSingle();
        }
        
        private void BindGameStates()
        {
            Container.Bind<MainMenuState>().AsTransient();
            Container.Bind<GameplayState>().AsTransient();
        }

    }
}

