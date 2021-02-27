using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpEnemy : MonoBehaviour
{
    public CharacterController2D controller;
    public Transform character;
    public EnemyBehavior enemyBehavior;

    private void FixedUpdate()
    {
        controller.AttemptJump();
        if (enemyBehavior != null)
        {
            enemyBehavior.LookAtCharacter(character, controller);
        }
    }
}
