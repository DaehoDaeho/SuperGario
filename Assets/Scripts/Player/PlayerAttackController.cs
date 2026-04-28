using System.Collections;
using UnityEngine;

/// <summary>
/// 플레이어 공격 입력 처리.
/// </summary>
public class PlayerAttackController : MonoBehaviour
{
    [SerializeField] private PlayerAttackActivator playerAttackActivator;
    [SerializeField] private float attackDuration = 0.15f;

    [SerializeField] private PlayerAttackHitbox playerAttackHitbox;
    [SerializeField] private PlayerFacingController playerFacingController;

    [SerializeField] private Vector3 rightAttackLocalPosition = new Vector3(0.8f, 0.0f, 0.0f);
    [SerializeField] private Vector3 leftAttackLocalPosition = new Vector3(-0.8f, 0.0f, 0.0f);

    // 공격 후 다음 공격이 가능해질 때까지의 시간.
    [SerializeField] private float attackCooldown = 0.35f;

    // 현재 플레이어가 공ㅇ격 중인지 여부를 저장.
    // 공격 중복 실행을 방지하기 위해 필요.
    private bool isAttacking = false;

    // 다음 공격이 가능한 시간을 저장.
    private float nextAttackAvailableTime = 0.0f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        playerAttackActivator.SetObjectActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        // 현재 시간이 공격 가능 시간인지 체크.
        if(Time.time < nextAttackAvailableTime)
        {
            return;
        }

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

        // 플레이어의 현재 방향을 가져온다.
        int facingDirection = playerFacingController.GetFacingDirection();
        UpdateAttackHitboxPosition(facingDirection);

        // 타겟 재설정.
        playerAttackHitbox.ResetTargets();

        playerAttackActivator.SetObjectActive(true);

        yield return new WaitForSeconds(attackDuration);

        playerAttackActivator.SetObjectActive(false);

        // 현재 시간에 쿨타임을 더해 다음 공격 가능 시간을 갱신.
        nextAttackAvailableTime = Time.time + attackCooldown;
        isAttacking = false;
    }

    /// <summary>
    /// 현재 바라보는 방향에 따라 공격 히트박스의 로컬 위치를 조정.
    /// </summary>
    /// <param name="facingDirection">현재 바라보는 방향.</param>
    void UpdateAttackHitboxPosition(int facingDirection)
    {
        if(facingDirection == -1)
        {
            playerAttackHitbox.transform.localPosition = leftAttackLocalPosition;
        }
        else if(facingDirection == 1)
        {
            playerAttackHitbox.transform.localPosition = rightAttackLocalPosition;
        }
    }
}
