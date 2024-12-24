using System;
using Game.Application;
using UnityEngine;
using UnityEngine.UI;
using Zenject;

namespace Game.Presentation.UI
{
    public class MainMenu : MonoBehaviour
    {
        [SerializeField] private Button playButton;
        private ICommandMediator _mediator;
        
        
        [Inject]
        public void Construct(ICommandMediator mediator)
        {
            _mediator = mediator;
        }
        private void Start()
        {
            playButton.onClick.AddListener(OnPlayButtonClicked);
        }

        private void OnPlayButtonClicked()
        {
            if (_mediator != null)
                _mediator.Execute<StartPlayCommand>();
        }
    }
}