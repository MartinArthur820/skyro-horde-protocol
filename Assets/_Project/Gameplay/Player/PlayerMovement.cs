using UnityEngine;
using UnityEngine.InputSystem;

namespace HordeProtocol.Gameplay
{
    public class PlayerMovement : MonoBehaviour
    {
        public int movementSpeed;
        public GameObject playerRotator;

        MoveCommand moveCommand;
        Horde inputActions;
        Rigidbody2D rigidbody2D;
        Vector2 movementVector;
        Camera camera;
        Vector3 mouseVector;

        private void Awake()
        {
            rigidbody2D = GetComponent<Rigidbody2D>();
            inputActions = new Horde();
            moveCommand = new MoveCommand();
        }
        private void Start()
        {
            camera = Camera.main;

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
            mouseVector = camera.ScreenToWorldPoint(Mouse.current.position.ReadValue());
        }
        private void FixedUpdate()
        {
            Movement();
            LookAtMouse();
        }
        private void Movement()
        {
            moveCommand.Move(rigidbody2D, movementVector, movementSpeed);
        }
        private void LookAtMouse()
        {
            Vector2 dis = transform.position - mouseVector;
            playerRotator.transform.rotation = Quaternion.LookRotation(Vector3.forward, dis);
        }
    }
}

