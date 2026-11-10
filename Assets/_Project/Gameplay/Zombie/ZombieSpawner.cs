using UnityEngine;

namespace HordeProtocol.Gameplay
{
    public class ZombieSpawner : MonoBehaviour
    {
        public float timeToSpawn;
        private float timeSinceSpawn;
        public Transform player;

        [SerializeField]private EnemyPool enemyPool;
        private void Update()
        {
            timeSinceSpawn += Time.deltaTime;

            if (timeSinceSpawn >= timeToSpawn)
            {
                GameObject newEnemy = enemyPool.GetEnemy();
                if (newEnemy != null )
                {
                    newEnemy.transform.position = transform.position;
                    ZombieFollow zombieFollow = newEnemy.GetComponent<ZombieFollow>();
                    ZombieReturn zombieReturn = newEnemy.GetComponent<ZombieReturn>();
                    zombieFollow.target = player;
                    zombieReturn.enemyPool = this.enemyPool;
                    timeSinceSpawn = 0;
                }


            }
        }
    }
}
