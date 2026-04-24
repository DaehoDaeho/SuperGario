using System.Collections;
using UnityEngine;

/// <summary>
/// 적이 피격되었을 때 Sprite 색을 잠깐 바꿨다가 다시 원래 색으로 복구하는 시각 효과를 제공.
/// </summary>
public class EnemyHitFlash : MonoBehaviour
{
    [SerializeField] private SpriteRenderer spriteRenderComponent;
    [SerializeField] private Color hitFlashColor = Color.red;
    [SerializeField] private float hitFlashDuration = 0.1f;

    private Color baseColor = Color.white;

    private Coroutine currentFlashCoroutine;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        baseColor = spriteRenderComponent.color;
    }

    /// <summary>
    /// 적 피격 Flash 효과를 시작.
    /// </summary>
    public void PlayHitFlash()
    {
        if(currentFlashCoroutine != null)
        {
            StopCoroutine(currentFlashCoroutine);
        }

        currentFlashCoroutine = StartCoroutine(HitFlashRoutine());
    }

    IEnumerator HitFlashRoutine()
    {
        spriteRenderComponent.color = hitFlashColor;

        yield return new WaitForSeconds(hitFlashDuration);

        spriteRenderComponent.color = baseColor;
        currentFlashCoroutine = null;
    }
}
