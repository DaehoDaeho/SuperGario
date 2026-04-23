using UnityEngine;

/// <summary>
/// 적이 일정 시간마다 방향을 바꾸며 좌우로 순찰하는 가장 기본적인 이동 구조를 제공.
/// </summary>
public class EnemyPatrol : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 2.0f;
    [SerializeField] private float directionChangeInterval = 2.0f;

    [SerializeField] private float moveDirection = 1.0f;    // 1.0 : 오른쪽, -1.0 : 왼쪽.
    [SerializeField] private Rigidbody2D rigidbody2DComponent;
    [SerializeField] private SpriteRenderer spriteRenderer;

    private float directionTimer = 0.0f;

    private void FixedUpdate()
    {
        if(rigidbody2DComponent == null)
        {
            return;
        }

        // 방향 체크.
        // 이동 처리.
        UpdateDirectionTimer();
        MoveEnemy();
    }

    /// <summary>
    /// 방향 전환 타이머를 누적하고, 일정 시간이 지나면 방향을 전환.
    /// </summary>
    void UpdateDirectionTimer()
    {
        directionTimer += Time.fixedDeltaTime;

        if(directionTimer >= directionChangeInterval)
        {
            moveDirection *= -1.0f;
            directionTimer = 0.0f;
        }

        spriteRenderer.flipX = moveDirection < 0.0f;
    }

    void MoveEnemy()
    {
        rigidbody2DComponent.linearVelocity = new Vector2(moveDirection * moveSpeed, rigidbody2DComponent.linearVelocity.y);
    }
}
