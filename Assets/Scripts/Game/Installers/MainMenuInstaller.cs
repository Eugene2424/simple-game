using Game.Application;
using Game.Infrastructure;
using Zenject;

namespace Game.Installers
{
    public class MainMenuInstaller : MonoInstaller
    {
        public override void InstallBindings()
        {
            Container.Bind<ICommandMediator>().To<CommandMediator>().AsSingle();
            Container.Bind<StartPlayCommand>().AsTransient();
        }
    }
}