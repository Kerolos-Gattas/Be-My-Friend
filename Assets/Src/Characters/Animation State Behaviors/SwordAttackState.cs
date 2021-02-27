using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwordAttackState : StateMachineBehaviour
{
    private CharacterController2D controller;

    // OnStateEnter is called when a transition starts and the state machine starts to evaluate this state
    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        controller = animator.GetComponent<CharacterController2D>();
        controller.performSwordAttack();
    }
}
