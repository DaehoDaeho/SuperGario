using System.Collections;
using UnityEngine;

/// <summary>
/// 피격 시 스프라이트를 잠깐 사라졌다가 다시 나타나게 하는 역할. (깜박임 연출)
/// </summary>
public class HurtFlashReceiver : MonoBehaviour
{
    [SerializeField] private SpriteRenderer spriteRenderer;
    [SerializeField] private float flashTotalDuration = 0.5f;
    [SerializeField] private float flashDuration = 0.15f;

    private Coroutine currentFlashRoutine = null;

    public void PlayFlash(float duration)
    {
        flashTotalDuration = duration;

        if (currentFlashRoutine != null)
        {
            StopCoroutine(currentFlashRoutine);
        }

        currentFlashRoutine = StartCoroutine(PlayFlashRoutine());
    }

    IEnumerator PlayFlashRoutine()
    {
        float totalTimer = 0.0f;
        float flashTimer = 0.0f;

        while(totalTimer < flashTotalDuration)
        {
            totalTimer += Time.deltaTime;
            flashTimer += Time.deltaTime;

            // 깜박임 연출.
            if(flashTimer >= flashDuration)
            {
                spriteRenderer.enabled = !spriteRenderer.enabled;
                flashTimer = 0.0f;
            }

            yield return null;
        }

        spriteRenderer.enabled = true;
        currentFlashRoutine = null;
    }
}
