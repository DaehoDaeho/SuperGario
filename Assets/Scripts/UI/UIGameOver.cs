using System;
using UnityEngine;
using UnityEngine.SceneManagement;  // SceneManager를 사용하기 위한 네임스페이스.

public class UIGameOver : MonoBehaviour
{
    [SerializeField] private GameObject panelGameOver;
    [SerializeField] private RespawnPointManager respawnPointManager;

    void Start()
    {
        ShowGameOverUI(false);
    }

    public void ShowGameOverUI(bool show)
    {
        panelGameOver.SetActive(show);
    }

    /// <summary>
    /// 재시작 버튼을 클릭했을 때 호출할 함수.
    /// </summary>
    public void OnClickRestartButton()
    {
        Time.timeScale = 1.0f;

        // 게임 씬을 다시 로딩.
        // SceneManager 클래스 사용.
        SceneManager.LoadScene("SampleScene");
    }

    public void OnClickRestartOnCheckPoint()
    {
        respawnPointManager.RestartGame();
        ShowGameOverUI(false);
    }
}
