namespace Game.Application
{
    public abstract class GameBaseState : IGameState
    {
        private readonly ISceneLoader _sceneLoader;
        private readonly ILoggerService _logger;
        
        protected abstract string SceneName { get; }

        public GameBaseState(ISceneLoader sceneLoader, ILoggerService logger)
        {
            _sceneLoader = sceneLoader;
            _logger = logger;
        }
        
        public virtual void Enter()
        {
            _sceneLoader.LoadSceneAsync(SceneName);
            _logger.Log("Enter " + SceneName + " state");
        }

        public virtual void Exit()
        {
            _logger.Log("Exit " + SceneName + " state");
        }
    }
}