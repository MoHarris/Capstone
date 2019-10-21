using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public float speed;
    public float jumpForce;
    public float moveInput;
    public float glideFactor;
    public float glideMeter;

    private Rigidbody2D rb;

    private bool forward = true;

    private bool isGrounded;
    public Transform groundCheck;
    public float checkRadius;
    public LayerMask whatIsGround;
    private float originalGravityScale;
    

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        originalGravityScale = rb.gravityScale;
        
    }
   
    // Update is called once per frame
    void FixedUpdate()
    {
        isGrounded = Physics2D.OverlapCircle(groundCheck.position, checkRadius, whatIsGround);
        moveInput = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(moveInput * speed, rb.velocity.y);

        if(forward == false && moveInput > 0)
        {
            Flip();
        }

        else if(forward == true && moveInput < 0)
        {
            Flip();
        }

    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow) && isGrounded == true)
        {
            rb.velocity = Vector2.up * jumpForce;
        }

        if (Input.GetKey(KeyCode.LeftShift) && !isGrounded && glideMeter > 0)
        {
            rb.gravityScale = glideFactor;

            if (glideMeter > 0)
            {
                glideMeter = glideMeter - 1;
            }


        }

        else
        {
            rb.gravityScale = originalGravityScale;

            if (glideMeter < 100)
            {
                glideMeter = glideMeter + 1;
            }
        }
    }

    void Flip()
    {
        forward = !forward;
        Vector3 Scaler = transform.localScale;
        Scaler.x = Scaler.x * -1;
        transform.localScale = Scaler;

    }


}
