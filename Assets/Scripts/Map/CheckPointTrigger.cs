using UnityEngine;

/// <summary>
/// 체크포인트 오브젝트에 붙어서 플레이어가 닿았을 때 현재 위치를 체크포인트로 저장을 요청하는 역할.
/// </summary>
public class CheckPointTrigger : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Player") == false)
        {
            return;
        }

        RespawnPointManager respawnPointManager = collision.GetComponent<RespawnPointManager>();
        if(respawnPointManager != null)
        {
            respawnPointManager.SetCheckPoint(transform.position);
        }
    }
}
