using UnityEngine;

public class HealItem : MonoBehaviour
{
    [SerializeField] private int healAmount = 1;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player") == false)
        {
            return;
        }

        PlayerHealth playerHealth = collision.GetComponent<PlayerHealth>();
        if (playerHealth != null)
        {
            playerHealth.Heal(healAmount);
        }

        Destroy(gameObject);
    }
}
