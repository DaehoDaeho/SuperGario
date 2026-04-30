using UnityEngine;
using System.Collections.Generic;

public class CoinScoreListExample : MonoBehaviour
{
    [SerializeField] List<int> coinScores = new List<int>();

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        SetListData();
    }

    void SetListData()
    {
        for(int i=0; i<5; ++i)
        {
            coinScores.Add(10 * (i + 1));
        }

        for(int i=0; i<coinScores.Count; ++i)
        {
            Debug.Log("Index[" + i + "] = " + coinScores[i]);
        }

        int sum = 0;
        for (int i = 0; i < coinScores.Count; ++i)
        {
            sum += coinScores[i];
        }

        Debug.Log("리스트 데이터의 합 = " + sum);

        coinScores.Insert(2, 25);

        for (int i = 0; i < coinScores.Count; ++i)
        {
            Debug.Log("Index[" + i + "] = " + coinScores[i]);
        }


        coinScores.Remove(25);

        for (int i = 0; i < coinScores.Count; ++i)
        {
            Debug.Log("Index[" + i + "] = " + coinScores[i]);
        }

        coinScores.RemoveAt(1);

        for (int i = 0; i < coinScores.Count; ++i)
        {
            Debug.Log("Index[" + i + "] = " + coinScores[i]);
        }


        coinScores.Clear();
        Debug.Log("List Count = " + coinScores.Count);
    }
}
