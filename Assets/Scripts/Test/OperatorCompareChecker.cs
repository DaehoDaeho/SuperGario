using UnityEngine;

public class OperatorCompareChecker : MonoBehaviour
{
    int playerHp = 30;
    int playerScore = 120;
    int targetScore = 100;
    float remainTime = 15.0f;
    bool hasKey = true;
    bool isNearDoor = false;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        bool isDead = playerHp <= 0;
        bool isScoreEnough = playerScore >= targetScore;
        bool isTimeOver = remainTime <= 0.0f;
        bool canOpenDoor = hasKey == true && isNearDoor == true;
        bool isGameOver = isDead == true || isTimeOver == true;
        bool doesNotHaveKey = !hasKey;

        Debug.Log("플레이어 사망 여부: " + isDead);
        Debug.Log("목표 점수 이상인지 여부: " + isScoreEnough);
        Debug.Log("시간 종료 여부: " + isTimeOver);
        Debug.Log("문 열기 가능 여부: " + canOpenDoor);
        Debug.Log("게임 종료 여부: " + isGameOver);
        Debug.Log("열쇠가 없는지 여부: " + doesNotHaveKey);
    }
}
