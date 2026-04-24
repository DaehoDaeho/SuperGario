using UnityEngine;

/// <summary>
/// 적의 체력을 관리하고, 데미지, 피격 반응, 사망 판정을 처리하는 역할.
/// </summary>
public class EnemyHealth : MonoBehaviour
{
    [SerializeField] private int maxHp = 3;
    [SerializeField] private int currentHp = 0;
    [SerializeField] private EnemyHitFlash enemyHitFlash;

    private bool isDead = false;    // 사망 여부.

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        currentHp = maxHp;
    }

    public void TakeDamage(int damageAmount)
    {
        // 이미 사망했으면 아무 처리도 하지 않는다.
        if(isDead == true)
        {
            return;
        }

        currentHp -= damageAmount;

        if(currentHp < 0)
        {
            currentHp = 0;
        }

        // 피격 시 Flash 연출.
        enemyHitFlash.PlayHitFlash();

        // 사망 판단.
        CheckDeath();
    }

    /// <summary>
    /// 현재 체력이 0 이하인지 검사하고, 죽었다면 사망 처리를 실행.
    /// </summary>
    void CheckDeath()
    {
        if(currentHp <= 0 && isDead == false)
        {
            // 사망 처리.
            Die();
        }
    }

    /// <summary>
    /// 적 사망 처리.
    /// </summary>
    void Die()
    {
        isDead = true;
        Destroy(gameObject);
    }

    public int GetCurrentHp()
    {
        return currentHp;
    }

    public int GetMaxHp()
    {
        return maxHp;
    }

    public bool IsDead()
    {
        return isDead;
    }
}
