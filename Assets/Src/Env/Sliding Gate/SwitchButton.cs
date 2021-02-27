using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchButton : MonoBehaviour
{
    public Animator animator;
    public Gate gate;
    public bool triggerExit = true;

    private void OnTriggerEnter2D(Collider2D other)
    {
        animator.SetTrigger("Down");
        gate.OpenGate();
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (triggerExit)
        {
            animator.SetTrigger("Up");
            gate.CloseGate();
        }
    }
}
