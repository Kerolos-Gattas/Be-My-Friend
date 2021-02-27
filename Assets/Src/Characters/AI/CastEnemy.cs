using UnityEngine;

public class CastEnemy : MonoBehaviour
{
    public CharacterController2D controller;
    public Transform character;
    public EnemyBehavior enemyBehavior;

    private void FixedUpdate()
    {
        controller.AttemptCast();
        if (enemyBehavior != null)
        {
            enemyBehavior.LookAtCharacter(character, controller);
        }
    }
}
