using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{

    public float speed;
    public float jumpForce;
    public float moveInput;
    public float glideFactor;
    public float glideMeter;

    private Rigidbody2D rb;

    private bool forward = true;

    protected bool isGrounded;
    public Transform groundCheck;
    public float checkRadius;
    public LayerMask whatIsGround;
    private float originalGravityScale;
    public bool isGliding;
    //Scene scene = SceneManager.GetActiveScene();

    private Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
        originalGravityScale = rb.gravityScale;
        isGliding = false;
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
                isGliding = true;
            }

        if (isGrounded == false)
        {
            anim.SetBool("isJumping", false);
        }
         else
        {
         anim.SetBool("isJumping", true);
         }
        }

        if (Input.GetKey(KeyCode.DownArrow) && !isGrounded)
        {
            //rb.velocity = Vector2.up * -jumpForce;
            rb.gravityScale = originalGravityScale * 2;


        }

        else
        {
            isGliding = false;
           

            rb.gravityScale = originalGravityScale;

            if (glideMeter < 100)
            {
                glideMeter = glideMeter + 1;
            }
        }

        if (Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
        if(moveInput == 0)
        {
            anim.SetBool("isWalking", false);
		}
        else 
        {
        anim.SetBool("isWalking", true);
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
