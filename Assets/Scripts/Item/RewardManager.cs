using UnityEngine;

/// <summary>
/// 보상목록을 관리하고, 랜덤으로 보상을 반환하는 역할.
/// </summary>
public class RewardManager : MonoBehaviour
{
    // 싱글톤 패턴을 적용하기 위한 인스턴스.
    public static RewardManager instance;

    [SerializeField] private GameObject[] rewardPrefabs;

    private void Awake()
    {
        // 인스턴스 초기화.
        // this : 클래스 자신을 this라고 한다.
        instance = this;
    }

    public void CreateRandomReward(Vector3 newPosition)
    {
        int index = Random.Range(0, rewardPrefabs.Length);

        // 씬에 게임오브젝트를 생성하는 함수.
        // 첫번째 인자 : 프리팹 원본.
        // 두번째 인자 : 생성할 위치.
        // 세번째 인자 : 회전값.
        Instantiate(rewardPrefabs[index], newPosition, Quaternion.identity);
    }
}
