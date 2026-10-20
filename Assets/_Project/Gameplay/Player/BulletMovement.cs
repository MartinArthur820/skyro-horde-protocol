using UnityEditor.Experimental.GraphView;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UIElements;

namespace HordeProtocol.Gameplay
{
    public class BulletMovement : MonoBehaviour
    {
        Vector3 targetVector;
        Camera camera;
        Rigidbody2D rb;
        Vector3 direction;

        public float bulletSpeed;

        private void Awake()
        {
            rb = GetComponent<Rigidbody2D>();
            camera = Camera.main;
            targetVector = camera.ScreenToWorldPoint(Mouse.current.position.ReadValue());
            direction = (targetVector - transform.position).normalized;
            

        }
        void FixedUpdate()
        {
            rb.linearVelocity = new Vector2(direction.x, direction.y).normalized * bulletSpeed;
        }
    }
}
