using UnityEngine;

public class FireBall : MonoBehaviour
{
    public float speed = 20f;
    public Rigidbody2D rb;
    public Animator animator;
    private LayerMask enemyLayers;
    private LayerMask friendlyLayers;
    private bool facingRight;

    public void setEnemyLayers(LayerMask enemyLayers)
    {
        this.enemyLayers = enemyLayers;
    }

    public void setFriendlyLayers(LayerMask friendlyLayers)
    {
        this.friendlyLayers = friendlyLayers;
    }

    public void setFacingRight(bool facingRight)
    {
        this.facingRight = facingRight;
    }

    void Start()
    {
        rb.velocity = transform.right * speed;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        CharacterController2D controller = other.GetComponent<CharacterController2D>();
        if (controller != null)
        {
            if (friendlyLayers == controller.enemyLayers)
            {
                FireBallHits();
                controller.PerformCastAttackDamage(this.enemyLayers, facingRight);
            }
        }
        else
        {
            FireBallHits();
        }
    }

    private void FireBallHits()
    {
        rb.velocity = Vector3.zero;
        rb.angularVelocity = 0f;
        animator.SetTrigger("Explosion");
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        rb.velocity = transform.right * speed;
    }
}
