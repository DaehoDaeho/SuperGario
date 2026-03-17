using UnityEngine;

public class ProgramStartMessage : MonoBehaviour
{
    public string startMessage = "게임이 시작되었고, Start 함수가 한 번 실행되었습니다.";

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log(startMessage);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
