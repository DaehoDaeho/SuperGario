using System.Collections;
using UnityEngine;

public class CoinPickupVisualEffect : MonoBehaviour
{
    [SerializeField] private float effectDuration = 0.08f;

    private Vector3 baseScale = Vector3.one;

    private bool isPlaying = false;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // 코인의 원래 크기를 저장.
        baseScale = transform.localScale;
    }

    public void PlayPickupEffectAndHide()
    {
        if(isPlaying == true)
        {
            return;
        }

        StartCoroutine(PickupEffectRoutine());
    }

    IEnumerator PickupEffectRoutine()
    {
        isPlaying = true;
        float elapsedTime = 0.0f;   // 현재까지 진행된 시간을 저장하기 위한 변수. 타이머 체크 변수.

        while(elapsedTime < effectDuration)
        {
            // Time.deltaTime : 이전 프레임에서 현재 프레임까지 오는데 소요된 시간.
            elapsedTime += Time.deltaTime;

            // 전체 연출 시간 대비 현재 진행 비율 계산.
            float normalizedTimer = elapsedTime / effectDuration;

            // Mathf.Lerp : 시작값에서 부드럽게 목표값까지 변화시켜주는 함수.
            // 코인의 크기가 1에서 0까지 부드럽게 줄어드는 처리. (보간)
            float scaleMultiplier = Mathf.Lerp(1.0f, 0.0f, normalizedTimer);

            transform.localScale = new Vector3(baseScale.x * scaleMultiplier, baseScale.y * scaleMultiplier, baseScale.z);

            // 다음 프레임까지 대기.
            yield return null;
        }

        transform.localScale = baseScale;
        isPlaying = false;
        Destroy(gameObject);
    }
}
