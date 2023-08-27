using UnityEngine;

namespace Assets.Scripts.Player
{
    public class PlayerWalkingState : IPlayerState
    {
        private float _speed = 5.0f;
        private PlayerController _playerController;

        public PlayerWalkingState(PlayerController playerController)
        {
            _playerController = playerController;
        }

        public void HandleInput()
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                _playerController.ChangeState(new PlayerJumpingState());
            }
        }

        public void Update()
        {
            float horizontalInput = Input.GetAxis("Horizontal");

            Vector3 newPosition = _playerController.transform.position + 
                new Vector3(horizontalInput * _speed * Time.deltaTime, _playerController.transform.position.y, 
                _playerController.transform.position.z);

            _playerController.transform.position = newPosition;
        }
    }
}
