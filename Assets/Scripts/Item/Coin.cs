using UnityEngine;

public class Coin : MonoBehaviour
{
    [SerializeField]
    private int scoreAmount = 1;

    [SerializeField] private CoinPickupVisualEffect coinEffect;

    void OnTriggerEnter2D(Collider2D collider)
    {
        // 코인과 충돌한 대상의 태그가 플레이어인지 검사.
        if(collider.CompareTag("Player") == true)
        {
            // 충돌한 오브젝트로부터 PlayerScoreManager 컴포넌트를 가져온다.
            // GetComponent : <> 안에 지정된 컴포넌트를 가져오는 함수.
            PlayerScoreManager playerScoreManager = collider.GetComponent<PlayerScoreManager>();
            playerScoreManager.AddScore(scoreAmount);
            playerScoreManager.AddCount();

            if(coinEffect != null)
            {
                coinEffect.PlayPickupEffectAndHide();
            }
            else
            {
                Destroy(gameObject);
            }

            // Destroy : 게임 오브젝트를 파괴하는 함수.
            //Destroy(gameObject);
        }
    }
}
