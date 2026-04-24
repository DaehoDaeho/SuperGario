using UnityEngine;

/// <summary>
/// 공격 판정 오브젝트가 적에 닿았을 때 EnemyHealth에 데미지를 전달하는 역할
/// </summary>
public class EnemyDamageHitBox : MonoBehaviour
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
