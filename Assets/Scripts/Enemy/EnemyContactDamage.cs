using UnityEngine;

/// <summary>
/// 플레이어가 적과 접촉했을 때 플레이어에게 데미지를 전달하는 역할.
/// </summary>
public class EnemyContactDamage : MonoBehaviour
{
    [SerializeField] private int damageAmount = 1;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Player") == false)
        {
            return;
        }

        PlayerHealth playerHealth = collision.GetComponent<PlayerHealth>();
        if (playerHealth != null)
        {
            playerHealth.TakeDamage(damageAmount);
        }
    }
}
