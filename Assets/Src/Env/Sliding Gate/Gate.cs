using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gate : MonoBehaviour
{
    public Collider2D gateCollider;
    public Animator animator;


    public void OpenGate()
    {
        animator.SetTrigger("Open");
        gateCollider.enabled = false;
    }

    public void CloseGate()
    {
        animator.SetTrigger("Close");
        gateCollider.enabled = true;
    }
}
