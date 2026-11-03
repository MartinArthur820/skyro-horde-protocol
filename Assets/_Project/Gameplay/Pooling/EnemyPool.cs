using System.Collections.Generic;
using UnityEngine;


namespace HordeProtocol.Gameplay
{
    public class EnemyPool : MonoBehaviour
    {
        [SerializeField] private GameObject enemyPrefab;
        [SerializeField] private Queue<GameObject> enemyPool = new Queue<GameObject>();
        public int poolSize;

        void Start()
        {
            for (int i = 0; i < poolSize; i++)
            {
                GameObject enemy = Instantiate(enemyPrefab);
                enemyPool.Enqueue(enemy);
                enemy.SetActive(false);
            }
        }
        public GameObject GetEnemy()
        {
            if (enemyPool.Count > 0)
            {
                GameObject enemy = enemyPool.Dequeue();
                enemy.SetActive(true);
                return enemy;
            }
            return null;
        }
        public void ReturnEnemy(GameObject enemy)
        {
            enemyPool.Enqueue(enemy);
            enemy.SetActive(false);
        }
    }
}
