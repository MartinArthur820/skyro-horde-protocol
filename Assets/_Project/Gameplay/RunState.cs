using Codice.Client.BaseCommands;
using UnityEditor.VersionControl;
using UnityEngine;
using UnityEngine.UI;

namespace HordeProtocol.Gameplay
{
    public class RunState : MonoBehaviour
    {
        Horde inputActions;
        GameState gameState;
        private void OnEnable()
        {
            inputActions = new Horde();
            inputActions.Enable();
            
        }
        private void Update()
        {
            if (inputActions.Player.Pause.ReadValue<float>() == 1)
            {
               gameState = ChangeGameState(GameState.Pause);
            }
            else
            {
                gameState = GameState.Run;
            }
            Debug.Log(inputActions.Player.Pause.ReadValue<float>());
            Submit();
        }
        private GameState ChangeGameState(GameState newState)
        {
            gameState = newState;
            return gameState;
        }
        enum GameState
        {
            Run, Pause, GameOver, Retry
        }

        void Submit()
        {
            if (gameState == GameState.Run)
            {
                
            }
            else if (gameState == GameState.Pause)
            {

            }
            else if (gameState == GameState.Retry)
            {
            }

        }
    }
}
