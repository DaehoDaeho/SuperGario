using UnityEngine;

/// <summary>
/// 플레이어와 관련된 가장 기본적인 데이터를 변수로 저장하는 스크립트.
/// </summary>
public class PlayerBasicData : MonoBehaviour
{
    string playerName = "Hero";
    int playerHp = 100;
    int playerScore = 0;
    float moveSpeed = 5.0f;
    bool canJump = true;

    public string GetPlayerName()
    {
        return playerName;
    }

    public int GetPlayerHp()
    {
        return playerHp;
    }

    public int GetPlayerScore()
    {
        return playerScore;
    }

    public float GetMoveSpeed()
    {
        return moveSpeed;
    }

    public bool GetCanJump()
    {
        return canJump;
    }

    public void SetPlayerHp(int newHp)
    {
        playerHp = newHp;
    }

    public void SetPlayerScore(int newScore)
    {
        playerScore = newScore;
    }

    public void SetMoveSpeed(float newMoveSpeed)
    {
        moveSpeed = newMoveSpeed;
    }

    public void SetCanJump(bool newCanJump)
    {
        canJump = newCanJump;
    }
}
