using UnityEngine;
using UnityEngine.UI;
using TMPro;
using Microsoft.CodeAnalysis.CSharp.Syntax;


namespace HordeProtocol.Gameplay
{
    public class GameManager : MonoBehaviour
    {
        private float score = 0;
        [SerializeField]private float scoreMultiplier;

        public TMP_Text textScore;
        public float timeForScore;
        public float timeSinceScore;
        private void OnEnable()
        {
            ZombieFollow.enemyKilled += AddScore;
        }
        private void Update()
        {
            CheckMultiplier();
        }
        private void AddScore()
        {

            if (timeSinceScore < timeForScore)
            {
                scoreMultiplier += 0.1f;
            }
            else
            {
                scoreMultiplier = 0;
            }
            score += (20 + (20 * scoreMultiplier));
            textScore.text = score.ToString();
            timeSinceScore = 0;
        }
        private void CheckMultiplier()
        {
            timeSinceScore += Time.deltaTime;

        }
    }
}
