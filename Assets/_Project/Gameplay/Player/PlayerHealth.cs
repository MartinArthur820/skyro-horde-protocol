using System;
using UnityEngine;

namespace HordeProtocol.Gameplay
{
    public class PlayerHealth : MonoBehaviour
    {
        public float health;
        public static event Action PlayerDied;

        private void OnCollisionEnter2D(Collision2D collision)
        {
            if (health > 0)
            {
                health = health - 1;
            }
            else
            {
                PlayerDied.Invoke();
            }
        }

    }
}
