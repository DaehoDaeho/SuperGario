using UnityEngine;

public class IfBasicExample : MonoBehaviour
{
    int playerScore = 120;
    int targetScore = 100;

    bool hasKey = false;

    int playerHp = 100;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if(playerScore >= targetScore)
        {
            Debug.Log("클리어 조건을 만족했습니다");
        }

        if(hasKey == true)
        {
            Debug.Log("열쇠가 있어서 문을 열 수 있습니다");
        }
        else
        {
            Debug.Log("열쇠가 없어서 문을 열 수 없습니다");
        }

        if(playerHp <= 0)
        {
            Debug.Log("너는 죽었다");
        }
        else if(playerHp <= 70)
        {
            Debug.Log("위험해!!!");
        }
        else
        {
            Debug.Log("너는 안전해");
        }
    }
}
