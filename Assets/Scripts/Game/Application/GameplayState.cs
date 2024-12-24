namespace Game.Application
{
    public class GameplayState : GameBaseState
    {
        protected override string SceneName => "Gameplay";
        public GameplayState(ISceneLoader sceneLoader, ILoggerService loggerService) : base(sceneLoader, loggerService){}
    }
}