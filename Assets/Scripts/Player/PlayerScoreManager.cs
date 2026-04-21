using TMPro;    // 네임스페이스 : 이름 공간.
using UnityEngine;  // 네임스페이스.

public class PlayerScoreManager : MonoBehaviour
{
    [SerializeField]
    private int score = 0;

    [SerializeField]
    private int coinCount = 0;

    [SerializeField]
    private TMP_Text textScore;

    [SerializeField]
    private TMP_Text textCoinCount;

    [SerializeField] private EffectSoundPlayer effectSoundPlayer;
    [SerializeField] private AudioClip coinClip;

    void Start()
    {
        UpdateScoreText();
        UpdateCoinCountText();
    }

    public void AddScore(int newScore)
    {
        score += newScore;
        Debug.Log("점수 획득 : " + newScore + ", 현재 점수 : " + score);

        UpdateScoreText();

        effectSoundPlayer.PlayEffectSound(coinClip);
    }

    void UpdateScoreText()
    {
        // null : 세팅되지 않은/아무것도 아닌 데이터/사용할 수 없는 데이터.
        if(textScore != null)
        {
            textScore.text = "현재 점수 : " + score;
        }
    }

    public void AddCount()
    {
        coinCount++;
        UpdateCoinCountText();
    }

    void UpdateCoinCountText()
    {
        if(textCoinCount != null)
        {
            textCoinCount.text = "코인 개수 : " + coinCount;
        }
    }
}

