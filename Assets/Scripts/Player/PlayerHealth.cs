using TMPro;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// 플레이어의 체력을 관리하는 역할.
/// </summary>
public class PlayerHealth : MonoBehaviour
{
    public static PlayerHealth instance;

    [SerializeField] private int maxHp = 5;
    [SerializeField] private int currentHp = 0;
    [SerializeField] private TMP_Text textHp;
    [SerializeField] private Image imageHp;
    [SerializeField] UIGameOver uiGameOver;
    [SerializeField] Animator animator;
    [SerializeField] private SimpleFlashEffect flashEffect;
    [SerializeField] private HurtFlashReceiver flashReceiver;
    [SerializeField] private BGMPlayer bgmPlayer;

    private bool isDead = false;

    private void Awake()
    {
        instance = this;
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        currentHp = maxHp;
        UpdateHPUI();
    }

    public void TakeDamage(int damageAmount)
    {
        if(isDead == true)
        {
            return;
        }

        currentHp -= damageAmount;

        if(currentHp < 0)
        {
            currentHp = 0;
        }        

        UpdateHPUI();

        if (currentHp == 0)
        {
            Die();
        }
        else
        {
            animator.SetTrigger("Hurt");
        }

        if(flashEffect != null)
        {
            flashEffect.PlayFlash(Color.red, 0.5f);
        }

        if(flashReceiver != null)
        {
            flashReceiver.PlayFlash(0.5f);
        }
    }

    void Die()
    {
        // 사망 처리.
        isDead = true;

        // 사망 애니메이션 재생.
        animator.SetTrigger("Dead");

        // 게임오버 UI 출력.
        // 지정한 시간이 지나고 난 후 함수를 호출하는 기능을 사용.
        Invoke("ShowGameOverUI", 3.0f);
    }

    /// <summary>
    /// 리스폰 시 플레이어 체력을 최대 체력으로 복구.
    /// </summary>
    public void ResetHealthForRespawn()
    {
        currentHp = maxHp;
        isDead = false;

        UpdateHPUI();

        animator.SetTrigger("Restart");
        Time.timeScale = 1.0f;
    }

    void ShowGameOverUI()
    {
        bgmPlayer.StopBGM();
        uiGameOver.ShowGameOverUI(true);
        Time.timeScale = 0.0f;
    }

    public void Heal(int healAmount)
    {
        currentHp += healAmount;

        if(currentHp > maxHp)
        {
            currentHp = maxHp;
        }

        UpdateHPUI();
    }

    void UpdateHPUI()
    {
        if(textHp != null)
        {
            textHp.text = "체력 : " + currentHp + "/" + maxHp;
        }

        if(imageHp != null)
        {
            imageHp.fillAmount = (float)currentHp / (float)maxHp; // 백분율로 환산.
        }
    }

    public int GetCurrentHp()
    {
        return currentHp;
    }

    public int GetMaxHp()
    {
        return maxHp;
    }

    public bool IsDead()
    {
        return isDead;
    }
}
