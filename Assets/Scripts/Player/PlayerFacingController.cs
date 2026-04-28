using UnityEngine;

/// <summary>
/// 플레이어가 바라보는 좌우 방향을 관리.
/// </summary>
public class PlayerFacingController : MonoBehaviour
{
    [SerializeField] private int facingDirection = 1;
    [SerializeField] private SpriteRenderer spriteRendererComponent;

    // Update is called once per frame
    void Update()
    {
        UpdateFacingDirection();
        UpdateSpriteFlip();
    }

    /// <summary>
    /// 좌우 이동 입력을 기준으로 플레이어가 바라보는 방향을 갱신.
    /// </summary>
    void UpdateFacingDirection()
    {
        float horizontalInput = Input.GetAxisRaw("Horizontal");

        if(horizontalInput > 0.0f)
        {
            facingDirection = 1;
        }
        else if(horizontalInput < 0.0f)
        {
            facingDirection = -1;
        }
    }

    /// <summary>
    /// 현재 바라보는 방향에 맞춰 SpriteRenderer의 좌우 반전을 갱신.
    /// </summary>
    void UpdateSpriteFlip()
    {
        if(facingDirection == -1)
        {
            spriteRendererComponent.flipX = true;
        }
        else if(facingDirection == 1)
        {
            spriteRendererComponent.flipX = false;
        }
    }

    /// <summary>
    /// 현재 플레이어가 바라보는 방향을 반환.
    /// </summary>
    /// <returns>오른쪽이면 1, 왼쪽이면 -1</returns>
    public int GetFacingDirection()
    {
        return facingDirection;
    }
}
