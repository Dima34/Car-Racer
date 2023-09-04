using Infrastructure.Factories;
using Zenject;

namespace Infrastructure.StateMachines.GameStateMachine.States
{
    public class GameLoopState : IGameState
    {
        private IGameFactory _gameFactory;
        private IGameStateMachine _gameStateMachine;

        public GameLoopState(IGameFactory gameFactory, IGameStateMachine gameStateMachine)
        {
            _gameStateMachine = gameStateMachine;
            _gameFactory = gameFactory;
        }

        public void Enter() =>
            RunGame();

        private void RunGame()
        {
        }

        public void Exit() =>
            StopGame();

        private void StopGame()
        {
        }
        
        private void GoToEndgameState() =>
            _gameStateMachine.EnterState<EndGameState>();

        public class Factory : PlaceholderFactory<IGameStateMachine, GameLoopState>
        {
        }
    }
}