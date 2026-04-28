using UnityEngine;
using System.Collections.Generic;

/// <summary>
/// 플레이어의 공격 판정 오브젝트에 붙어서 적과 닿았을 때 데미지를 전달하는 역할.
/// </summary>
public class PlayerAttackHitbox : MonoBehaviour
{
    [SerializeField] private int damageAmount = 1;

    private List<EnemyHealth> hitTargets = new List<EnemyHealth>();

    /// <summary>
    /// 공격이 새로 시작될 때 이전 공격에서 맞았던 대상 기록을 비운다.
    /// </summary>
    public void ResetTargets()
    {
        hitTargets.Clear();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        EnemyHealth enemyHealth = collision.GetComponent<EnemyHealth>();

        // 이번 공격에서 피격 당한 적이 리스트에 포함되어 있는지 체크해서 함수를 빠져나간다.
        if(hitTargets.Contains(enemyHealth) == true)
        {
            return;
        }

        if(enemyHealth != null)
        {
            enemyHealth.TakeDamage(damageAmount);
            hitTargets.Add(enemyHealth);
        }
    }
}
