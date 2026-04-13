using UnityEngine;

/// <summary>
/// 함정 오브젝트에 붙어서 플레이어 캐릭터와 함정이 충돌했을 때 플레이어에게 데미지 적용.
/// </summary>
public class Trap : MonoBehaviour
{
    [SerializeField] private int damageAmount = 1;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Player") == false)
        {
            return;
        }

        PlayerHealth playerHealth = collision.GetComponent<PlayerHealth>();
        if(playerHealth != null)
        {
            playerHealth.TakeDamage(damageAmount);
        }
    }
}
