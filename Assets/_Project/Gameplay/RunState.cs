using UnityEditor.VersionControl;
using UnityEngine;

namespace HordeProtocol.Gameplay
{
    public class RunState : MonoBehaviour
    {
        string gameState;

        enum GameState
        {
            Run, Pause, GameOver, Retry
        }

        void Submit()
        {

        }
    }
}
