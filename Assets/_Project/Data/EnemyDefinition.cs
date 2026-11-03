using UnityEngine;

namespace HordeProtocol.Data
{
    [CreateAssetMenu(fileName = "EnemyDefinition", menuName = "Scriptable Objects/EnemyDefinition")]
    public class EnemyDefinition : ScriptableObject
    {
        public string enemyName;
        public int health;
        public int speed;
    }
}
