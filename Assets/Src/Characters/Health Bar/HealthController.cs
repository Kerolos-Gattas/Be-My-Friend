using UnityEngine;

public class HealthController : MonoBehaviour
{
    public McAnimator mcAnimator;
    public int maxHealth = 5;
    public HealthBar healthBar;
    private int currentHealth;

    void Start()
    {
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
    }

    public void TakeDamage(int damage)
    {
        mcAnimator.AnimateHurt();
        currentHealth -= damage;
        healthBar.setHealth(currentHealth);

        if (currentHealth <= 0)
        {
            Die();
        }
    }

    private void Die()
    {
        mcAnimator.AnimateDeath();
    }
}
