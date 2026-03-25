using UnityEngine;

public class Enemy_Combat : MonoBehaviour
{
    public int damageRedWarrior = 1;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        collision.gameObject.GetComponent<Player_Health>().ChangeHealth(damageRedWarrior);
    }
}
