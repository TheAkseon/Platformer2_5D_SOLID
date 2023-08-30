using UnityEngine;

namespace Assets.Scripts.Player
{
    [RequireComponent(typeof(CharacterController))]
    public class PlayerJump : MonoBehaviour, IJumpable
    {
        private CharacterController _characterController;
        private float _verticalVelocity;

        private float _gravity = -9.81f;
        private float _jumpForce = 5f;

        private void Start()
        {
            _characterController = GetComponent<CharacterController>();
        }

        private void Update()
        {
            ApplyGravity();
        }

        private void ApplyGravity()
        {
            _verticalVelocity += _gravity * Time.deltaTime;
            Vector3 verticalMovement = new Vector3(0, _verticalVelocity, 0) * Time.deltaTime;
            _characterController.Move(verticalMovement);
        }

        public void Jump()
        {
            if (_characterController.isGrounded)
            {
                _verticalVelocity = _jumpForce;
            }
        }
    }
}
