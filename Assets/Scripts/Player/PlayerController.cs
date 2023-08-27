using UnityEngine;

namespace Assets.Scripts.Player
{
    public class PlayerController : MonoBehaviour
    {
        [SerializeField] private IPlayerView _playerView;

        private IPlayerState _currentState;

        private void Start()
        {
            _currentState = new PlayerWalkingState(this);
            _playerView = GetComponent<PlayerView>();
        }

        private void Update()
        {
            _currentState.HandleInput();
            _currentState.Update();
        }

        public void ChangeState(IPlayerState newState)
        {
            _currentState = newState;
        }
    }
}