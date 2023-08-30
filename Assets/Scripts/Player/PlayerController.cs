using UnityEngine;

namespace Assets.Scripts.Player
{
    [RequireComponent(typeof(IMovable))]
    [RequireComponent(typeof(IJumpable))]
    public class PlayerController : MonoBehaviour
    {
        private IMovable _movable;
        private IJumpable _jumpable;
        private float _horizontalInput;

        private const string HorizontalInput = "Horizontal";

        private void Start()
        {
            _movable = GetComponent<IMovable>();
            _jumpable = GetComponent<IJumpable>();
        }

        private void Update()
        {
            MoveInput();
            Jump();
        }

        private void FixedUpdate()
        {
            Move();
        }

        private void MoveInput()
        {
            _horizontalInput = Input.GetAxisRaw(HorizontalInput);
        }

        private void Move()
        {
            _movable.Move(_horizontalInput);
        }

        private void Jump()
        {
            if (Input.GetKey(KeyCode.Space))
            {
                _jumpable.Jump();
            }
        }
    }
}