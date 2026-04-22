using System.Collections;
using UnityEngine;

/// <summary>
/// SpriteRenderer의 색을 잠깐 바꿨다가 다시 원래 색으로 복구하는 역할.
/// </summary>
public class SimpleFlashEffect : MonoBehaviour
{
    [SerializeField] private SpriteRenderer spriteRenderer;

    private Color baseColor = Color.white;

    private Coroutine currentFlashCoroutine;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // 스프라이트의 원래 색상 정보 보관.
        baseColor = spriteRenderer.color;
    }

    /// <summary>
    /// 지정한 색으로 잠깐 바꿨다가 다시 원래 색으로 복구.
    /// </summary>
    /// <param name="flashColor">잠깐 적용할 색상</param>
    /// <param name="flashDuration">색상을 유지할 시간</param>
    public void PlayFlash(Color flashColor, float flashDuration)
    {
        // 기존에 이미 색상 변경 함수가 호출이 되는 중이면 그 함수 호출을 중단시키고, 새로 호출하기 위한 처리.
        if(currentFlashCoroutine != null)
        {
            // 기존 함수 호출 중단 처리.
            StopCoroutine(currentFlashCoroutine);
        }

        // 새로 호출하는 처리.
        currentFlashCoroutine = StartCoroutine(FlashRoutine(flashColor, flashDuration));
    }

    IEnumerator FlashRoutine(Color flashColor, float flashDuration)
    {
        spriteRenderer.color = flashColor;

        // 지정한 시간만큼 대기.
        yield return new WaitForSeconds(flashDuration);

        // 대기 시간이 지난 후 원래 색상으로 복구.
        spriteRenderer.color = baseColor;
        currentFlashCoroutine = null;
    }
}
