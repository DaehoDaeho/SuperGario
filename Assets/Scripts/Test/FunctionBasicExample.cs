using UnityEngine;

public class FunctionBasicExample : MonoBehaviour
{
    private int playerHp = 5;
    int playerScore = 0;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // 3개의 함수를 차례대로 호출해 보시오.
        //PrintLessonStartMessage();
        //PrintPlayerName();
        //PrintLessonEndMessage();
        //AddScore(100);
        TakeDamage(10);
        bool isDead = IsDead();
        if(isDead == true)
        {
            Debug.Log("플레이어가 사망했습니다.");
        }
        else
        {
            Debug.Log("아직 싸울 수 있다.");
        }
    }

    private void PrintLessonStartMessage()
    {
        Debug.Log("함수 수업 예제를 시작합니다.");
    }

    private void PrintPlayerName()
    {
        Debug.Log("플레이어의 이름은 Hero입니다.");
    }

    private void PrintLessonEndMessage()
    {
        Debug.Log("함수 수업 예제를 마칩니다.");
    }

    private void TakeDamage(int damage)
    {
        playerHp -= damage;
        Debug.Log("데미지를 입었습니다 : " + damage);
        Debug.Log("현재 체력 : " + playerHp);
    }

    // 점수를 매개변수로 받고, playerScore에 매개변수로 받은 점수를 합산하고, 현재 점수를 Debug.Log 출력하는 함수 선언.
    private void AddScore(int score)
    {
        playerScore += score;
        Debug.Log("현재 점수 : " + playerScore);
    }

    // playerHp가 0 이하인지 체크해서 결과를 반환하는 함수를 선언. 결과는 bool 값을 반환.
    // TakeDamage 함수 호출 playerHp 감소. 감소량은 각자 알아서.
    // playerHp가 0 이하인지 체크해서 결과를 반환하는 함수를 호출하고 결과를 bool 형 변수에 저장.
    // if 문으로 결과가 true인지 false인지 검사.
    // true면 "플레이어가 사망했습니다" 메시지 출력. false면 "아직 싸울 수 있다" 메시지 출력.
    private bool IsDead()
    {
        //if(playerHp <= 0)
        //{
        //    return true;
        //}
        //else
        //{
        //    return false;
        //}

        //if(playerHp <= 0)
        //{
        //    return true;
        //}

        //return false;

        //bool isDead = playerHp <= 0;
        //return isDead;

        return playerHp <= 0;
    }

    public int GetPlayerHp()
    {
        return playerHp;
    }
}
