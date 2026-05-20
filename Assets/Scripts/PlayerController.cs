using UnityEngine;
using UnityEngine.InputSystem;


public class PlayerController : MonoBehaviour
{
    public float speed = 5f;
    public float jumpForce = 7f;
    public float acceleration = 5f;

    private float MovementY;
    private float MovementX;

    public Rigidbody2D rb;

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
        }

    }
}
