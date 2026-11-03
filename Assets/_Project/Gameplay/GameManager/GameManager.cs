using UnityEngine;
using UnityEngine.UI;
using TMPro;


namespace HordeProtocol.Gameplay
{
    public class GameManager : MonoBehaviour
    {
        private int score = 0;
        public TMP_Text textScore;
        private void OnEnable()
        {
            ZombieFollow.enemyKilled += AddScore;
        }
        private void AddScore()
        {
            score += 20;
            textScore.text = score.ToString();
        }
    }
}
