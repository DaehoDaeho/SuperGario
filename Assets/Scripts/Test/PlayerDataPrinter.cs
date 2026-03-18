using UnityEngine;

/// <summary>
/// PlayerBasicData에 저장된 값을 콘솔에 출력하는 역할을 하는 스크립트.
/// </summary>
public class PlayerDataPrinter : MonoBehaviour
{
    PlayerBasicData playerBasicData;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        playerBasicData = GetComponent<PlayerBasicData>();

        Debug.Log("플레이어 이름: " + playerBasicData.GetPlayerName());
        Debug.Log("플레이어 체력: " + playerBasicData.GetPlayerHp());
        Debug.Log("플레이어 점수: " + playerBasicData.GetPlayerScore());
        Debug.Log("플레이어 이동속도: " + playerBasicData.GetMoveSpeed());
        Debug.Log("플레이어 점프 가능 여부: " + playerBasicData.GetCanJump());
    }
}
