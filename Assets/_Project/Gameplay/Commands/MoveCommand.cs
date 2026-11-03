using UnityEngine;

namespace HordeProtocol.Gameplay
{
    public class MoveCommand : ICommand
    {
        Rigidbody2D rb2D;
        float movementSpeed;
        Vector2 movementVector;

        public void Move(Rigidbody2D rb2D, Vector2 movementVector, float movementSpeed)
        {
            this.rb2D = rb2D;
            this.movementSpeed = movementSpeed;
            this.movementVector = movementVector;
            Execute();
        }
        public void Execute()
        {
            rb2D.linearVelocity = movementVector.normalized * movementSpeed;
        }
    }
}
