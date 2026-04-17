using UnityEngine;

public class GameClearController : MonoBehaviour
{
    [SerializeField] private GameObject gameClearPanel;

    private bool isClear = false;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        gameClearPanel.SetActive(false);
    }

    public void ClearGame()
    {
        isClear = true;
        gameClearPanel.SetActive(true);
        Time.timeScale = 0.0f;
    }

    public bool IsClear()
    {
        return isClear;
    }
}
