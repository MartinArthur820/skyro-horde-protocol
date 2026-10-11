using UnityEngine;

namespace HordeProtocol.Gameplay
{
    public class PlayerMovement : MonoBehaviour
    {
        public int movementSpeed;

        Horde inputActions;
        Rigidbody2D rigidbody2;
        Vector2 movementVector;

        private void Awake()
        {
            rigidbody2 = GetComponent<Rigidbody2D>();
            inputActions = new Horde();
        }
        private void OnEnable()
        {
            inputActions.Enable();
        }
        private void OnDisable()
        {
            inputActions.Disable();
        }
        void Update()
        {
            movementVector = inputActions.Player.Move.ReadValue<Vector2>();
        }
        private void FixedUpdate()
        {
            rigidbody2.linearVelocity = movementVector.normalized * movementSpeed;
        }
    }
}
