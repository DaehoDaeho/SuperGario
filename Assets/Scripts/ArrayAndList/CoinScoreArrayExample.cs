using UnityEngine;

/// <summary>
/// 배열을 사용해서 여러 코인 점수룰 저장하고,
/// 반복문으로  각 점수를 출력.
/// </summary>
public class CoinScoreArrayExample : MonoBehaviour
{
    [SerializeField] private int[] coinScores = new int[] { 10, 20, 30, 40, 50 };

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        PrintCoinScore();

    }

    void PrintCoinScore()
    {
        for(int i=0; i<coinScores.Length; ++i)
        {
            Debug.Log("Index[" + i + "] = " + coinScores[i]);
        }
    }
}
