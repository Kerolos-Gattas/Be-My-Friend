using UnityEngine;

public class McAnimator : MonoBehaviour
{
    public Animator animator;

    public void AnimateMove(float horizontalVelocity)
    {
        animator.SetFloat("Speed", horizontalVelocity);
    }

    public void AnimateJump()
    {
        animator.SetTrigger("Jump");
    }

    public void AnimateAttack()
    {
        animator.SetTrigger("Sword Attack");
    }

    public void AnimateHurt()
    {
        animator.SetTrigger("Hurt");
    }

    public void AnimateDeath()
    {
        animator.SetTrigger("Die");
    }

    public void AnimateBlock()
    {
        animator.SetTrigger("Block");
    }

    public void AnimateCast()
    {
        animator.SetTrigger("Cast");
    }
}
