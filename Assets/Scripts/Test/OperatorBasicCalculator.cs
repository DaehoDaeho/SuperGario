using UnityEngine;

public class OperatorBasicCalculator : MonoBehaviour
{
    int firstIntValue = 20;
    int secondIntValue = 6;
    float moveSpeed = 5.0f;
    float speedMultiplier = 1.5f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int addResult = firstIntValue + secondIntValue;
        int subtractResult = firstIntValue - secondIntValue;
        int mulplyResult = firstIntValue * secondIntValue;
        int divideResult = firstIntValue / secondIntValue;
        int remainResult = firstIntValue % secondIntValue;
        float runSpeed = moveSpeed * speedMultiplier;
        float halfSpeed = moveSpeed / 2.0f;

        Debug.Log("더하기 결과: " + addResult);
        Debug.Log("빼기 결과: " + subtractResult);
        Debug.Log("곱하기 결과: " + mulplyResult);
        Debug.Log("나누기 결과: " + divideResult);
        Debug.Log("나머지 결과: " + remainResult);
        Debug.Log("달리기 속도 계산 결과: " + runSpeed);
        Debug.Log("절반 속도 계산 결과: " + halfSpeed);
    }
}
