using UnityEngine;

public class ForExample : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // "반복 실행중" 메시지를 5번 출력하는 코드 작성.
        // 1. int i=0
        // 2. i<5
        // 3. Debug.Log("반복 실행중");
        // 4. i++
        // 5. i<5 -> 조건이 만족하지 않을때까지 반복.
        for (int i=0; i<5; i++)
        {
            Debug.Log("반복 실행중");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
