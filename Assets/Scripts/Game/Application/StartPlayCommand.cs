namespace Game.Application
{
    public class StartPlayCommand : ICommand
    {
        private readonly GameStateManager _stateManager;
        private readonly GameplayState _gameplayState;
        
        public StartPlayCommand(GameStateManager stateManager, GameplayState gameplayState)
        {
            _stateManager = stateManager;
            _gameplayState = gameplayState;
        }
        
        public void Execute()
        {
            _stateManager.ChangeState(_gameplayState);
        }
    }
}