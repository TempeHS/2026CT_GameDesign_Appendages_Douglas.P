using UnityEngine;
using UnityEngine.InputSystem;


public class PlayerController : MonoBehaviour
{
    bool isFacingRight = false;

    public float speed = 5f;
    public float jumpForce = 7f;
    public float acceleration = 5f;

    private float MovementY;
    private float MovementX;

    public Rigidbody2D rb;
    public Animator animator;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float targetSpeed = MovementX * speed;
        float newX = Mathf.MoveTowards(
            rb.linearVelocity.x,
            targetSpeed,
            acceleration * Time.deltaTime
        );
        Vector2 newVelcoity = new Vector2(newX, rb.linearVelocity.y);
        rb.linearVelocity = newVelcoity;
        Flip();

        animator.SetFloat("Magnitude", rb.linearVelocity.magnitude);
        
    }

    private void Flip()
    {
        if (isFacingRight && MovementX < 0 || !isFacingRight && MovementX > 0)
        {
            isFacingRight = !isFacingRight;
            Vector3 ls = transform.localScale;
            ls.x *= -1f;
            transform.localScale = ls;
        }
    }

    public void OnMove(InputAction.CallbackContext context)
    {
        MovementX = context.ReadValue<Vector2>().x;
    }   

    public void onJump(InputAction.CallbackContext context)
    {
        if(context.performed)
        {
            rb.linearVelocity = new Vector2(rb.linearVelocity.x, jumpForce);
            animator.SetTrigger("jump");
        }
        else if (context.canceled && rb.linearVelocity.y > 0)
        {
            rb.linearVelocity = new Vector2(rb.linearVelocity.x, jumpForce * 0.5f);
            animator.SetTrigger("jump");
        }

    }
}
