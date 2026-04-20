using UnityEngine;

/// <summary>
/// SpriteRenderer의 Sorting Layer와 Order in Layer를 코드로 적용.
/// </summary>
public class SortingLayerApplier : MonoBehaviour
{
    [SerializeField] private string sortingLayerName = "Default";
    [SerializeField] private int orderInLayer = 0;
    [SerializeField] private SpriteRenderer spriteRenderer;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();

        ApplySortingValues();
    }

    // Inspector 창에서 설정한 Sorting Layer와 Order in Layer값을 SpriteRenderer에 적용.
    private void ApplySortingValues()
    {
        spriteRenderer.sortingLayerName = sortingLayerName;
        spriteRenderer.sortingOrder = orderInLayer;
    }
}
