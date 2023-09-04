using Infrastructure.Factories;
using StaticData;
using UnityEngine;
using Zenject;

namespace Infrastructure.StateMachines.GameStateMachine.States
{
    public class InitializeState : IGameState
    {
        private IGameStateMachine _stateMachine;
        private IGameFactory _gameFactory;
        private LevelStaticData _levelData;

        public InitializeState(IGameStateMachine stateMachine, IGameFactory gameFactory)
        {
            _stateMachine = stateMachine;
            _gameFactory = gameFactory;
        }
        
        public void Enter()
        {
            BuildLevel();
            GoToGameIdleState();
        }

        private void BuildLevel()
        {
            GameObject player = _gameFactory.CreatePlayer();
            player.transform.position = _levelData.PlayerStartPosition;
        }

        private void GoToGameIdleState() =>
            _stateMachine.EnterState<GameIdleStateState>();

        public void Exit()
        {
        }

        public class Factory : PlaceholderFactory<IGameStateMachine, InitializeState>
        {
        }
    }
}