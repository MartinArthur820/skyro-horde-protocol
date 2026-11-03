using UnityEngine;

namespace HordeProtocol.Gameplay
{
    public class ZombieReturn : MonoBehaviour
    {
        public EnemyPool enemyPool;
        private void OnDisable()
        {
            if (enemyPool != null)
            {
                enemyPool.ReturnEnemy(gameObject);
            }
        }
    }
}
