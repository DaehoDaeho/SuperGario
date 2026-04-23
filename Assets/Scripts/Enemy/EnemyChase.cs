using UnityEngine;

/// <summary>
/// 플레이어가 일정 거리 안에 들어왔을 때 플레이어 방향으로 이동하는 역할.
/// </summary>
public class EnemyChase : MonoBehaviour
{
    [SerializeField] private Transform targetTransform;

    [SerializeField] private float chaseSpeed = 2.5f;

    [SerializeField] private float chaseDistance = 5.0f;
    [SerializeField] private Rigidbody2D rigidBody2DComponent;
    [SerializeField] private SpriteRenderer spriteRenderer;

    private void FixedUpdate()
    {
        if(rigidBody2DComponent == null)
        {
            return;
        }

        if(targetTransform == null)
        {
            return;
        }

        // 이동 처리.
        UpdateChaseMovement();
    }

    /// <summary>
    /// 플레이어와의 거리를 계산하고, 추적 거리 안에 있을 때만 좌우 추적 이동을 수행.
    /// </summary>
    void UpdateChaseMovement()
    {
        // Vector2.Distance : 두 지점 사이의 거리를 계산하는 함수.
        float distanceToTarget = Vector2.Distance(transform.position, targetTransform.position);

        if(distanceToTarget > chaseDistance)
        {
            rigidBody2DComponent.linearVelocity = new Vector2(0.0f, rigidBody2DComponent.linearVelocity.y);
            return;
        }

        float moveDirection = 0.0f;

        if(targetTransform.position.x < transform.position.x)
        {
            moveDirection = -1.0f;
        }
        else if(targetTransform.position.x > transform.position.x)
        {
            moveDirection = 1.0f;
        }

        spriteRenderer.flipX = moveDirection < 0.0f;

        rigidBody2DComponent.linearVelocity = new Vector2(chaseSpeed * moveDirection, rigidBody2DComponent.linearVelocity.y);
    }
}
