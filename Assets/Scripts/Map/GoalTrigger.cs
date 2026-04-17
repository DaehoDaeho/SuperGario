using UnityEngine;

public class GoalTrigger : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Player") == false)
        {
            return;
        }

        // GameObject.FindAnyObjectByType
        // 지정된 타입의 컴포넌트가 씬에 있을 경우 찾아서 가져오는 함수.
        GameClearController gameClearController = GameObject.FindAnyObjectByType<GameClearController>();
        if(gameClearController != null)
        {
            gameClearController.ClearGame();
        }
    }
}
