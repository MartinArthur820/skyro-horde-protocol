using System.Collections;
using UnityEngine;
using UnityEngine.InputSystem;

namespace HordeProtocol.Gameplay
{
    public class PlayerShooting : MonoBehaviour
    {
        Horde inputActions;
        bool isFiring;
        bool cooldown;

        public float firingSpeed;
        public float bulletCount;
        public float bulletSpread;

        public GameObject bulletPrefab;
        private void Awake()
        {
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
        private void Update()
        {
            isFiring = (inputActions.Player.Fire.ReadValue<float>() >= 1);
            Debug.Log(isFiring);
            StartCoroutine(Fire());
        }
        private IEnumerator Fire()
        {
            if (isFiring && !cooldown)
            {
                //float spread = Random.Range(transform.rotation.z + bulletSpread, transform.rotation.z - bulletSpread);
                cooldown = true;
                for (int i = 0; i < bulletCount; i++)
                {
                    GameObject shotPrefab = Instantiate(bulletPrefab, transform.position, transform.rotation);
                }
                yield return new WaitForSeconds(firingSpeed);
                cooldown = false;
            }
        }

    }
}
