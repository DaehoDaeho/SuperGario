using UnityEngine;

public class PlayerScoreManager : MonoBehaviour
{
    [SerializeField]
    private int score = 0;

    public void AddScore(int newScore)
    {
        score += newScore;
        Debug.Log("점수 획득 : " + newScore + ", 현재 점수 : " + score);
    }
}
