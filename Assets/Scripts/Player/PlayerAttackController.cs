using System.Collections;
using UnityEngine;

/// <summary>
/// 플레이어 공격 입력 처리.
/// </summary>
public class PlayerAttackController : MonoBehaviour
{
    [SerializeField] private PlayerAttackActivator playerAttackActivator;
    [SerializeField] private float attackDuration = 0.15f;

    // 현재 플레이어가 공ㅇ격 중인지 여부를 저장.
    // 공격 중복 실행을 방지하기 위해 필요.
    private bool isAttacking = false;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        playerAttackActivator.SetObjectActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.X) == true)
        {
            // 공격 시도.
            TryAttack();
        }
    }

    /// <summary>
    /// 현재 공격 가능 상태인지 검사하고, 가능하면 공격 코루틴을 실행.
    /// </summary>
    void TryAttack()
    {
        if(isAttacking == true)
        {
            return;
        }

        StartCoroutine(AttackRoutine());
    }

    /// <summary>
    /// 공격 판정 오브젝트를 짧은 시간동안 활성화했다가 다시 비활성화.
    /// </summary>
    /// <returns></returns>
    IEnumerator AttackRoutine()
    {
        isAttacking = true;

        playerAttackActivator.SetObjectActive(true);

        yield return new WaitForSeconds(attackDuration);

        playerAttackActivator.SetObjectActive(false);

        isAttacking = false;
    }
}
