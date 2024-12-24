using Game.Application;
using UnityEngine;
using Zenject;

namespace Game.Infrastructure
{
    public class Bootstrap : MonoBehaviour
    {
        private GameStateManager _stateManager;
        private MainMenuState _menuState;
        
        [Inject]
        public void Construct(GameStateManager stateManager, MainMenuState menuState)
        {
            _stateManager = stateManager;
            _menuState = menuState;
        }

        private void Start()
        {
            _stateManager.ChangeState(_menuState);
        }
    }
}