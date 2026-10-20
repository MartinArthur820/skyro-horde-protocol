using UnityEngine;
using UnityEngine.InputSystem;

namespace HordeProtocol.Gameplay
{
    public class ZombieFollow : MonoBehaviour
    {
        Rigidbody2D rb;
        Vector3 direction;

        public float movementSpeed;
        public Transform target;

        private void Awake()
        {
            rb = GetComponent<Rigidbody2D>();
        }
        void FixedUpdate()
        { 
            direction = (target.position - transform.position).normalized;
            rb.linearVelocity = new Vector2(direction.x, direction.y).normalized * movementSpeed;
        }
    }
}
