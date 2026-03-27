using UnityEngine;

public class PlayerPhysicsInfo : MonoBehaviour
{
    public Rigidbody2D rigidbody2D;
    public Collider2D collider2D;
    public SpriteRenderer spriteRenderer;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // GetComponent<>() : 게임 오브젝트에 붙어있는 컴포넌트를 가져오는 Unity 함수.
        //rigidbody2D = GetComponent<Rigidbody2D>();
        Debug.Log("Gravity Scale = " + rigidbody2D.gravityScale);

        //collider2D = GetComponent<Collider2D>();
        Debug.Log("Is Trigger = " + collider2D.isTrigger);

        //spriteRenderer = GetComponent<SpriteRenderer>();
        Debug.Log("FlipX = " + spriteRenderer.flipX);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
