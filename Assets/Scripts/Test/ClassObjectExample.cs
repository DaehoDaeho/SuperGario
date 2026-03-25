using UnityEngine;

public class ClassObjectExample : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // PlayerInfo 클래스 설계도를 바탕으로 객체를 만든다.
        PlayerInfo hero = new PlayerInfo("Hero", 100, 0);
        PlayerInfo knight = new PlayerInfo("Knight", 150, 20);

        PrintPlayerInfo(hero);
        PrintPlayerInfo(knight);

        hero.TakeDamage(50);
        knight.AddScore(50);

        PrintPlayerInfo(hero);
        PrintPlayerInfo(knight);
    }

    private void PrintPlayerInfo(PlayerInfo playerInfo)
    {
        Debug.Log("이름: " + playerInfo.GetPlayerName());
        Debug.Log("체력: " + playerInfo.GetPlayerHp());
        Debug.Log("점수: " + playerInfo.GetPlayerScore());
        Debug.Log("사망 여부: " + playerInfo.IsDead());
    }
}
