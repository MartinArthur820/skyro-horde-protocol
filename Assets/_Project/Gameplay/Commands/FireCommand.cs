using System.Collections;
using UnityEngine;

namespace HordeProtocol.Gameplay
{
    public class FireCommand : MonoBehaviour , ICommand
    {
        float bulletCount;
        GameObject bulletPrefab;
        Transform entityTransform;
        public void Fire(Transform entityTransform)
        {
            this.entityTransform = entityTransform;
            Execute();
        }
        public void Execute()
        {
            for (int i = 0; i < bulletCount; i++)
            {
                GameObject shotPrefab = Instantiate(bulletPrefab, entityTransform.position, entityTransform.rotation);
            }
        }
    }
}
