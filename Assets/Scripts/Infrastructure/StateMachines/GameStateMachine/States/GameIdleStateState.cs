using Infrastructure.Factories.UI;
using Zenject;

namespace Infrastructure.StateMachines.GameStateMachine.States
{
    public class GameIdleStateState : IGameState
    {
        private IUIFactory _uiFactory;
        private IGameStateMachine _gameStateMachine;

        public GameIdleStateState(IUIFactory uiFactory, IGameStateMachine gameStateMachine)
        {
            _gameStateMachine = gameStateMachine;
            _uiFactory = uiFactory;
        }

        public void Enter()
        {

        }
        

        public void Exit()
        {
            
        }

        public class Factory : PlaceholderFactory<IGameStateMachine, GameIdleStateState>
        {
        }
    }
}