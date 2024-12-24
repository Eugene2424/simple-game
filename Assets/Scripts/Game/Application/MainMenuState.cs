namespace Game.Application
{
    public class MainMenuState : GameBaseState
    {
        protected override string SceneName => "MainMenu";
        public MainMenuState(ISceneLoader sceneLoader, ILoggerService logger) : base(sceneLoader, logger){}
        
    }
}