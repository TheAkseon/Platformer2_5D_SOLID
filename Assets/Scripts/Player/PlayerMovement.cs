using UnityEngine;

namespace Assets.Scripts.Player
{
    [RequireComponent(typeof(CharacterController))]
    public class PlayerMovement : MonoBehaviour, IMovable
    {
        [SerializeField] private float _speed = 5.0f;

        private CharacterController _characterController;

        private void Start()
        {
            _characterController = GetComponent<CharacterController>();
        }

        public void Move(float horizontalInput)
        {
            Vector3 direction = new Vector3(horizontalInput, 0, 0).normalized * _speed * Time.deltaTime;
            _characterController.Move(direction);
        }
    }
}
