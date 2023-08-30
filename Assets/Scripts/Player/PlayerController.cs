using UnityEngine;

namespace Assets.Scripts.Player
{
    [RequireComponent(typeof(IMovable))]
    public class PlayerController : MonoBehaviour
    {
        private IMovable _movable;
        private float _horizontalInput;

        private const string HorizontalInput = "Horizontal";

        private void Start()
        {
            _movable = GetComponent<IMovable>();
        }

        private void Update()
        {
            MoveInput();
        }

        private void FixedUpdate()
        {
            MovePlayer();
        }

        private void MoveInput()
        {
            _horizontalInput = Input.GetAxisRaw(HorizontalInput);
        }

        private void MovePlayer()
        {
            _movable.Move(_horizontalInput);
        }
    }
}