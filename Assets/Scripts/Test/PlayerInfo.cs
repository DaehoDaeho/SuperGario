using UnityEngine;

public class PlayerInfo
{
    private string playerName;
    private int playerHp;
    private int playerScore;

    /// <summary>
    /// 객체를 만들때 시작 데이터를 전달받아서 초기화하는 생성자.
    /// 생성자의 규칙 1 : 반환타입을 기재하지 않는다.
    /// 생성자의 규칙 2 : 이름이 클래스 이름과 동일하다.
    /// </summary>
    /// <param name="newPlayerName"></param>
    /// <param name="newPlayerHp"></param>
    /// <param name="newPlayerScore"></param>
    public PlayerInfo(string newPlayerName, int newPlayerHp, int newPlayerScore)
    {
        playerName = newPlayerName;
        playerHp = newPlayerHp;
        playerScore = newPlayerScore;
    }

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

    public void TakeDamage(int damage)
    {
        playerHp -= damage;
    }

    public void AddScore(int scoreAmount)
    {
        playerScore += scoreAmount;
    }

    public bool IsDead()
    {
        return playerHp <= 0;
    }
}
