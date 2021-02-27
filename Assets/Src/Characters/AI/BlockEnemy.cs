using UnityEngine;

public class BlockEnemy : MonoBehaviour
{

    public CharacterController2D controller;
    public Transform character;
    public EnemyBehavior enemyBehavior;

    private void FixedUpdate()
    {
        controller.AttemptBlock();
        if (enemyBehavior != null)
        {
            enemyBehavior.LookAtCharacter(character, controller);
        }
    }
}
