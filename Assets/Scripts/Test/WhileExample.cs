using UnityEngine;

public class WhileExample : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int count = 0;

        while(count < 5)
        {
            Debug.Log("반복 실행중");
            count++;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
