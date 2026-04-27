using UnityEngine;

/// <summary>
/// 플레이어의 공격 판정 오브젝트에 붙어서 적과 닿았을 때 데미지를 전달하는 역할.
/// </summary>
public class PlayerAttackHitbox : MonoBehaviour
{
    [SerializeField] private int damageAmount = 1;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        EnemyHealth enemyHealth = collision.GetComponent<EnemyHealth>();

        if(enemyHealth != null)
        {
            enemyHealth.TakeDamage(damageAmount);
        }
    }
}
