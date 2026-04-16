using TMPro;
using UnityEngine;

/// <summary>
/// 플레이어의 현재 체크포인트 위치를 저장하는 역할.
/// </summary>
public class RespawnPointManager : MonoBehaviour
{
    [SerializeField] private Vector3 currentCheckPointPosition;
    [SerializeField] private TMP_Text textMessage;
    [SerializeField] private float hideMessageTime = 2.0f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        currentCheckPointPosition = transform.position;
        textMessage.gameObject.SetActive(false);
    }

    public void SetCheckPoint(Vector3 newCheckPointPosition)
    {
        currentCheckPointPosition = newCheckPointPosition;

        PrintCheckPointPosition();
        ShowMessage();
    }

    public Vector3 GetCheckPointPosition()
    {
        return currentCheckPointPosition;
    }

    public void PrintCheckPointPosition()
    {
        Debug.Log("현재 저장된 체크포인트 위치 : " + currentCheckPointPosition);
    }

    void ShowMessage()
    {
        textMessage.gameObject.SetActive(true);

        CancelInvoke();
        Invoke("HideMessage", hideMessageTime);
    }

    void HideMessage()
    {
        textMessage.gameObject.SetActive(false);
    }

    /// <summary>
    /// 체크포인트에서 게임을 다시 시작.
    /// </summary>
    public void RestartGame()
    {
        transform.position = currentCheckPointPosition;

        PlayerHealth playerHealth = GetComponent<PlayerHealth>();
        if(playerHealth != null)
        {
            playerHealth.ResetHealthForRespawn();
        }
    }
}
