using UnityEngine;

public class LoopGameSimulation : MonoBehaviour
{
    int enemySpawnCount = 5;
    int coinCount = 3;
    int startWave = 3;
    int playerHp = 5;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //for(int i=0; i<enemySpawnCount; i++)
        //{
        //    int enemyNumber = i + 1;
        //    Debug.Log("적 생성 완료: " + enemyNumber + "번째 적");
        //}

        //Debug.Log("적 생성 처리 완료");

        //for(int i=0; i<coinCount; i++)
        //{
        //    int coinNumber = i + 1;
        //    Debug.Log("코인 확인 완료: " + coinNumber + "번째 코인");
        //}

        //Debug.Log("모든 코인 확인 완료");

        //while(startWave > 0)
        //{
        //    Debug.Log("현재 웨이브: " + startWave);
        //    startWave--;
        //}

        //Debug.Log("모든 웨이브 진행 완료");

        // 함수 호출.
        PrintHello();

        int damage = 10;
        TakeDamage(damage);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void PrintHello()
    {
        Debug.Log("안녕하세요.");
    }

    private void TakeDamage(int damage)
    {
        playerHp -= damage;
    }
}
