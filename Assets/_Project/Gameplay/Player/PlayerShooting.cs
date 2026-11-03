using System.Collections;
using UnityEngine;
using UnityEngine.InputSystem;

namespace HordeProtocol.Gameplay
{
    public class PlayerShooting : MonoBehaviour
    {
        Horde inputActions;
        FireCommand fireCommand;
        bool isFiring;
        bool cooldown;

        public float firingSpeed;
        public float bulletCount;

        public GameObject bulletPrefab;
        private void Awake()
        {
            inputActions = new Horde();
            fireCommand = new FireCommand();
        }
        private void OnEnable()
        {
            inputActions.Enable();
        }
        private void OnDisable()
        {
            inputActions.Disable();
        }
        private void Update()
        {
            isFiring = (inputActions.Player.Fire.ReadValue<float>() >= 1);
            Shoot();
        }
        private IEnumerator Shoot()
        {
            if (isFiring && !cooldown)
            {
                cooldown = true;
                fireCommand.Fire(transform);
                yield return new WaitForSeconds(firingSpeed);
                cooldown = false;
            }
        }

    }
}
