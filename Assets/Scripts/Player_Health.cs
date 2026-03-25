using UnityEngine;

public class Player_Health : MonoBehaviour
{
    public int currentHealth;
    public int maxHealth;

    public void ChangeHealth(int amount)
    {
        currentHealth += amount;
        currentHealth = Mathf.Clamp(currentHealth, 0, maxHealth);

        // if (currentHealth <= 0)
        // {
        //     GameObject.SetActive(false);
        // }
    }
}
