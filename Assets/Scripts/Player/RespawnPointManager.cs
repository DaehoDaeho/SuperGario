using UnityEngine;

/// <summary>
/// 플레이어의 현재 체크포인트 위치를 저장하는 역할.
/// </summary>
public class RespawnPointManager : MonoBehaviour
{
    [SerializeField] private Vector3 currentCheckPointPosition;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        currentCheckPointPosition = transform.position;
    }

    public void SetCheckPoint(Vector3 newCheckPointPosition)
    {
        currentCheckPointPosition = newCheckPointPosition;

        PrintCheckPointPosition();
    }

    public Vector3 GetCheckPointPosition()
    {
        return currentCheckPointPosition;
    }

    public void PrintCheckPointPosition()
    {
        Debug.Log("현재 저장된 체크포인트 위치 : " + currentCheckPointPosition);
    }
}
