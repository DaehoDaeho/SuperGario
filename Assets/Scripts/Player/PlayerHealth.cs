using TMPro;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// 플레이어의 체력을 관리하는 역할.
/// </summary>
public class PlayerHealth : MonoBehaviour
{
    [SerializeField] private int maxHp = 5;
    [SerializeField] private int currentHp = 0;
    [SerializeField] private TMP_Text textHp;
    [SerializeField] private Image imageHp;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        currentHp = maxHp;
        UpdateHPUI();
    }

    public void TakeDamage(int damageAmount)
    {
        currentHp -= damageAmount;

        if(currentHp < 0)
        {
            currentHp = 0;
        }

        UpdateHPUI();
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
}
