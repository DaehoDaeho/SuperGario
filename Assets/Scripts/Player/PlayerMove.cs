using System.Security.Cryptography;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    // 이동속도.
    [SerializeField] private float moveSpeed = 5.0f;

    // 점프력.
    [SerializeField] private float jumpForce = 8.0f;

    [SerializeField] private Rigidbody2D rb;

    [SerializeField] private Animator animator;

    // 키 입력 방식은 동일.
    private float moveInput = 0.0f;

    [SerializeField] private bool canJump = true;

    private bool move = false;

    // Update is called once per frame
    void Update()
    {
        // 입력 받기.
        ReadInput();

        UpdateAnimator();
        PrintCurrentMoveState();
    }

    /// <summary>
    /// 물리 기반 처리를 하는데 적합한 함수.
    /// </summary>
    void FixedUpdate()
    {
        MovePlayer();
    }

    void ReadInput()
    {
        moveInput = Input.GetAxisRaw("Horizontal");

        if(moveInput != 0.0f)
        {
            move = true;
        }
        else
        {
            move = false;
        }

        // 스페이스 키를 눌렀는지 체크를 하고 눌렀으면 점프 처리.
        if(Input.GetKeyDown(KeyCode.Space) == true && canJump == true)
        {
            Jump();
        }
    }

    void Jump()
    {
        rb.linearVelocity = new Vector2(rb.linearVelocity.x, jumpForce);
    }

    void MovePlayer()
    {
        // 이동량 계산 = 키 입력 값 * 이동속도.
        // Time.deltaTime
        // 이전 프레임과 현재 프레임 사이의 시간 간격.
        // 이 값을 곱해주면 프레임 차이가 나도 이동 속도가 일정하게 보이도록 만들 수 있다.
        //float moveAmountX = moveInput * moveSpeed * Time.deltaTime;
        //transform.position += new Vector3(moveAmountX, 0.0f, 0.0f);

        // X방향 이동 속도를 계산한다.
        float moveVelocityX = moveInput * moveSpeed;
        rb.linearVelocity = new Vector2(moveVelocityX, rb.linearVelocity.y);
    }

    void PrintCurrentMoveState()
    {
        Debug.Log("현재 입력값 : " + moveInput);
        Debug.Log("현재 속도 : " + rb.linearVelocity);
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        // 충돌한 대상이 바닥인지 판단.
        // 태그 정보를 이용해서 처리.
        // GameObject.CompareTag() : 해당 게임 오브젝트의 태그를 비교하는 함수.
        if(collision.gameObject.CompareTag("Ground") == true)
        {
            canJump = true;
            animator.SetBool("IsGrounded", true);
        }
    }

    void OnCollisionExit2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("Ground") == true)
        {
            canJump = false;
            animator.SetBool("IsGrounded", false);
        }
    }

    void UpdateAnimator()
    {
        // 애니메이터에 bool 값을 전달해서 애니메이션을 전환해 주는 함수.
        animator.SetBool("Move", move);
    }
}
