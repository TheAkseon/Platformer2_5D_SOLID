using UnityEngine;

namespace Assets.Scripts.Player
{
    [RequireComponent(typeof(Rigidbody))]
    public class PlayerMovement : MonoBehaviour, IMovable
    {
        [SerializeField] private float _speed = 5.0f;

        private Rigidbody _rigidbody;

        private void Start()
        {
            _rigidbody = GetComponent<Rigidbody>();
        }

        public void Move(float horizontalInput)
        {
            Vector3 movementDirection = new Vector3(horizontalInput, 0, 0) * _speed * Time.deltaTime;
            _rigidbody.velocity = movementDirection * _speed * Time.deltaTime;
        }
    }
}
