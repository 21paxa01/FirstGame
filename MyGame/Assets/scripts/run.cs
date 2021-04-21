using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class run : MonoBehaviour 
{
    
    public Rigidbody2D rb;
    public Animator anim;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        
        GroundCheckRadius = GroundCheck.GetComponent<CircleCollider2D>().radius;
    }
    
    void Update()
    {

        Walk();
        Reflect();
        Jump();
        CheckingGround();
    }
    
    public Vector2 moveVector;
    public int speed = 3;
    void Walk()
    {
        moveVector.x = Input.GetAxisRaw("Horizontal");
        if (transform.position.x > -30 && transform.position.x < 36)
        {
            rb.velocity = new Vector2(moveVector.x * speed, rb.velocity.y);
        }
        else if(transform.position.x <= -30&& Input.GetKey(KeyCode.D))
        {
            rb.velocity = new Vector2(moveVector.x * speed, rb.velocity.y);
        }
        else if (transform.position.x >= 36 && Input.GetKey(KeyCode.A))
        {
            rb.velocity = new Vector2(moveVector.x * speed, rb.velocity.y);
        }
        else
        {
            rb.velocity = new Vector2(0, rb.velocity.y);
        }
        anim.SetFloat("moveX", Mathf.Abs(moveVector.x));
    }
    
    public bool faceRight = true;
    void Reflect()
    {
        Vector3 difference = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
        if ((rb.velocity.x < difference.x && !faceRight) || (rb.velocity.x > difference.x && faceRight))
        {
            transform.Rotate(0f, 180f, 0f);
            faceRight = !faceRight;
        }
    }
    
    public int jumpForce = 10;
    void Jump()
    {
        if (onGround && Input.GetKeyDown(KeyCode.Space))
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpForce);
        }
    }

   
    public bool onGround;
    public LayerMask Ground;
    public Transform GroundCheck;
    private float GroundCheckRadius;
    void CheckingGround()
    {
        onGround = Physics2D.OverlapCircle(GroundCheck.position, GroundCheckRadius, Ground);
        anim.SetBool("onGround", onGround);
    }
    
}